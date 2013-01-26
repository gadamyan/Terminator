using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Terminator
{
    delegate void Invoker();
    public partial class Controller : UserControl
    {
        Model model;
        Thread gameThread;
        int mouse_x, mouse_y;
        bool mouseEnterFlag;
        bool fire;
        SoundPlayer gameSound;
        Menu gameMenu;
        Invoker invoker;
        View painter;
        Config config;

        public Thread GameThread
        {
            get { return gameThread; }
            set { gameThread = value; }
        }

        public Controller()
        {
            InitializeComponent();
            CreateMenuAudio();
            ShowMenu();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            painter.Paint(e);
        }

        private void CreateMenuAudio()
        {
            fire = false;
            painter = new View();
            config = new Config();
            invoker = ShowMenu;
            gameMenu = new Menu(config);
            this.Controls.Add(gameMenu);
            gameMenu.EndMenu += new EventHandler(RestartGame);
            gameSound = new SoundPlayer();
        }

        private void ShowMenu()
        {
            try { gameThread.Abort(); }
            catch (NullReferenceException) { }
            gameMenu.ShowMenu();
        }

        private void RestartGame(object sender,EventArgs e)
        {
            if (gameMenu.RE)
            {
                model = new Model(config.CurrentLevel);
                painter.Model = model;
                model.SoundChange += new SoundDL(model_SoundChange);
                gameSound.SoundLocation = model.AudioString;
                gameMenu.RE = false;
                model.Status = GameStatus.Level;
                this.Refresh();
                Thread.Sleep(5000);
            }
            this.Focus();
            model.Status = GameStatus.Playing;
            gameThread = new Thread(new ThreadStart(Play));
            gameThread.Priority = ThreadPriority.Highest;
            gameThread.Start();
        }

        private void Play()
        {
            while (model.Status == GameStatus.Playing)
            {
                model.Play();
                if (fire)
                    TerminFire();
                Invalidate();
                Thread.Sleep(150/config.Speed);
            }
        }

        private void model_SoundChange()
        {
            if (config.Sound)
            {
                if (model.Status == GameStatus.Playing)
                    gameSound.PlayLooping();
                else
                    gameSound.Stop();
            }
        }

        private void View_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W: model.KeyChange(true,-2); break;
                case Keys.S: model.KeyChange(true, 2); break;
                case Keys.A: model.KeyChange(false, -2); break;
                case Keys.D: model.KeyChange(false, 2); break;
                default: break;
            }
        }

        private void View_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W: model.KeyChange(true, 0); break;
                case Keys.S: model.KeyChange(true, 0); break;
                case Keys.A: model.KeyChange(false, 0); break;
                case Keys.D: model.KeyChange(false, 0); break;
                default: break;
            }
        }

        private void View_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case 102: { config.Sound = !config.Sound; gameSound.Stop(); model_SoundChange(); }; break;
                case 32: Pause(); break;
                case 27: PressEsc(); break;
                case 13: DoRestart(); break;
                default: break;
            }
        }

        private void DoRestart()
        {
            if (model.Status != GameStatus.Playing && model.Status != GameStatus.Stoping)
            {
                if (model.Status == GameStatus.Ween)
                {
                    config.CurrentLevel++;
                    if (config.AccessLevel < config.CurrentLevel)
                        config.AccessLevel = config.CurrentLevel;
                    config.Write();
                }
                if (model.Status == GameStatus.EndGame)
                     config.CurrentLevel = 1;
                new Thread(new ThreadStart(InvokeFunction)).Start();
            }
        }
        private void InvokeFunction()
        {
            gameMenu.RE = true;
            Invoke(invoker);
        }

        public void PressEsc()
        {
            if (model.Status == GameStatus.Playing || model.Status == GameStatus.Stoping)
            {
                gameSound.Stop();
                ShowMenu();
                model.Status = GameStatus.Stoping;
            }
        }

        private void Pause()
        {
            if (model.Status == GameStatus.Playing || model.Status == GameStatus.Stoping)
            {
                if (gameThread != null)
                {
                    gameThread.Abort();
                    model.Status = GameStatus.Stoping;
                    gameThread = null;
                }
                else
                {
                    model.Status = GameStatus.Playing;
                    gameThread = new Thread(new ThreadStart(Play));
                    gameThread.Start();
                }
            }
        }

        private void View_MouseEnter(object sender, EventArgs e)
        {
            mouseEnterFlag = true;
        }

        private void View_MouseLeave(object sender, EventArgs e)
        {
            mouseEnterFlag = false;
        }

        private void View_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_x = e.X; mouse_y = e.Y;
            if (mouseEnterFlag && model.Status==GameStatus.Playing)
            {
                if (e.X == model.Termin.X+model.Termin.Termin_x)
                    return;
                if (e.Y < model.Termin.Y + model.Termin.Termin_y/2 && Math.Atan(Math.Abs((double)(model.Termin.Y + model.Termin.Termin_y/2 - e.Y) / (model.Termin.X + model.Termin.Termin_x/2 - e.X))) > 0.9)
                {
                    model.Termin.Mouse_x = 0;
                    model.Termin.Mouse_y = -1;
                }else
                        if (e.Y > model.Termin.Y + model.Termin.Termin_y/2 && Math.Atan(Math.Abs((double)(model.Termin.Y + model.Termin.Termin_y/2 - e.Y) / (model.Termin.X + model.Termin.Termin_x/2 - e.X))) > 0.9)
                {
                    model.Termin.Mouse_x = 0;
                    model.Termin.Mouse_y = 1;
                }else
                        if (e.X > model.Termin.X + model.Termin.Termin_x/2 && Math.Atan(Math.Abs((double)(model.Termin.Y + model.Termin.Termin_y/2 - e.Y) / (model.Termin.X + model.Termin.Termin_x/2 - e.X))) < 0.5)
                {
                    model.Termin.Mouse_x = 1;
                    model.Termin.Mouse_y = 0;
                }else
                        if (e.X < model.Termin.X + model.Termin.Termin_x/2 && Math.Atan(Math.Abs((double)(model.Termin.Y + model.Termin.Termin_y/2 - e.Y) / (model.Termin.X + model.Termin.Termin_x/2 - e.X))) < 0.5)
                {
                    model.Termin.Mouse_x = -1;
                    model.Termin.Mouse_y = 0;
                }else
                {
                    if (e.X < model.Termin.X + model.Termin.Termin_x/2 && e.Y < model.Termin.Y + model.Termin.Termin_y/2)
                    {
                        model.Termin.Mouse_x = -1;
                        model.Termin.Mouse_y = -1;
                    }
                    if (e.X > model.Termin.X + model.Termin.Termin_x/2 && e.Y < model.Termin.Y + model.Termin.Termin_y/2)
                    {
                        model.Termin.Mouse_x = 1;
                        model.Termin.Mouse_y = -1;
                    }
                    if (e.X < model.Termin.X + model.Termin.Termin_x/2 && e.Y > model.Termin.Y + model.Termin.Termin_y/2)
                    {
                        model.Termin.Mouse_x = -1;
                        model.Termin.Mouse_y = 1;
                    }
                    if (e.X > model.Termin.X + model.Termin.Termin_x/2 && e.Y > model.Termin.Y + model.Termin.Termin_y/2)
                    {
                        model.Termin.Mouse_x = 1;
                        model.Termin.Mouse_y = 1;
                    }
                }
            }
        }

        private void TerminFire()
        {
            if (model.Status == GameStatus.Playing && mouseEnterFlag && model.Termin.StopTarget == 0 && model.Termin.Targets != 0 && (
                    mouse_x < model.Termin.X || mouse_x > model.Termin.X + model.Termin.Termin_x ||
                    mouse_y < model.Termin.Y || mouse_y > model.Termin.Y + model.Termin.Termin_y))
            {
                model.Termin.StopTarget = model.Termin.TargetStopTime;
                model.TargetRun(mouse_x, mouse_y);
            }
        }

        private void View_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && config.Mos || e.Button == MouseButtons.Right && !config.Mos)
                fire = true;
        }

        private void View_MouseUp(object sender, MouseEventArgs e)
        {
            DoRestart();
            if (e.Button == MouseButtons.Left && config.Mos || e.Button == MouseButtons.Right && !config.Mos)
                fire = false;
        }
    }
}
