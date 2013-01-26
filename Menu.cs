using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Terminator
{
    public partial class Menu : UserControl
    {
        SoundPlayer menuSound;
        public event EventHandler EndMenu;
        PictureBox descriptionpan;
        Config config;
        bool re;

        public bool RE
        {
            get { return re; }
            set { re = value; }
        }

        public Menu(Config config)
        {
            re = true;
            this.config = config;
            menuSound = new SoundPlayer();
            menuSound.SoundLocation = @"Source\Termin_Sound.Wav";
            InitializeComponent();
            this.Visible = false;
        }

        public void ShowMenu()
        {
            this.Visible = true;
            this.Focus();
        }

        private void Menu_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true && config.Sound)
                menuSound.PlayLooping();
        }

        private void ev()
        {
            menuSound.Stop();
            this.Visible = false;
            EndMenu(this,new EventArgs());
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "menu1": menu1.Image = Properties.Resources.Menu1On; break;
                case "menu2": menu2.Image = Properties.Resources.Menu2On; break;
                case "menu3": menu3.Image = Properties.Resources.Menu3On; break;
                case "menu4": menu4.Image = Properties.Resources.Menu4On; break;
                case "menu5": menu5.Image = Properties.Resources.Menu5On; break;
            }
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "menu1": menu1.Image = Properties.Resources.Menu1Off; break;
                case "menu2": menu2.Image = Properties.Resources.Menu2Off; break;
                case "menu3": menu3.Image = Properties.Resources.Menu3Off; break;
                case "menu4": menu4.Image = Properties.Resources.Menu4Off; break;
                case "menu5": menu5.Image = Properties.Resources.Menu5Off; break;
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            switch (((PictureBox)sender).Name)
            {
                case "menu1": ev(); break;
                case "menu2": LevelsChange(); break;
                case "menu3": About(); break;
                case "menu4": ShowConfig(); break;
                case "menu5": Application.Exit(); break;
            }
        }

        private void Menu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 27)
            {
                ev();
            }
        }

        private void MenuVisiable(bool v)
        {
            menu1.Visible = menu2.Visible = menu3.Visible = menu4.Visible = menu5.Visible = v;
        }

        #region About
        private void About()
        {
            MenuVisiable(false);
            Label DLab = new Label();
            DLab.AutoSize = true;
            DLab.Font = new Font("Microsoft Sans Serif", 15.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(204)));
            DLab.ForeColor = Color.Lime;
            DLab.Location = new Point(20, 50);
            FileStream strim = new FileStream(@"Source\Description.desc", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(strim);
            DLab.Text = sr.ReadToEnd();
            sr.Close();
            strim.Close();
            descriptionpan = new PictureBox();
            descriptionpan.BackColor = Color.Transparent;
            descriptionpan.Image = Properties.Resources.Description;
            descriptionpan.SizeMode = PictureBoxSizeMode.StretchImage;
            descriptionpan.Location = new Point(30, 30);
            descriptionpan.Size = new Size(580, 420);
            descriptionpan.Controls.Add(DLab);
            descriptionpan.PreviewKeyDown += new PreviewKeyDownEventHandler(DescKeyPress);
            this.Controls.Add(descriptionpan);
            descriptionpan.Focus();
        }

        void DescKeyPress(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13 || e.KeyValue == 27)
            {
                this.Controls.Remove(descriptionpan);
                MenuVisiable(true);
                this.Focus();
            }
        }
        #endregion

        #region Config
        private void ShowConfig()
        {
            MenuVisiable(false);
            ConfigPanel.Visible = true;
            ConfigPanel.Focus();
            soundOn.Checked = config.Sound;
            speed.Value = config.Speed;
            if (config.Mos)
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
        }

        private void soundOn_CheckedChanged(object sender, EventArgs e)
        {
            if (soundOn.Checked)
                menuSound.PlayLooping();
            else
                menuSound.Stop();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                config.Mos = true;
            else
                config.Mos = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Name == "save")
            {
                config.Sound = soundOn.Checked;
                config.Speed = speed.Value;
                if (radioButton1.Checked)
                    config.Mos = true;
                else
                    config.Mos = false;
                config.Write();
            }
            else
            {
                if (config.Sound)
                    menuSound.PlayLooping();
                else
                    menuSound.Stop();
            }
            ConfigPanel.Visible = false;
            MenuVisiable(true);
            this.Focus();
        }

        private void save_MouseEnter(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Name == "save")
                save.Image = Properties.Resources.save2;
            else
                back.Image = Properties.Resources.back2;
        }

        private void save_MouseLeave(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Name == "save")
                save.Image = Properties.Resources.save1;
            else
                back.Image = Properties.Resources.back1;
        }
        #endregion

        #region Level
        private void LevelsChange()
        {
            MenuVisiable(false);
            levelPanel.Visible = true;
            levelPanel.Focus();
            for (int i = 1; i < 6; i++)
            {
                if (config.AccessLevel < i)
                    levelPanel.Controls.Find("level" + i, false)[0].Enabled = false;
                else
                    levelPanel.Controls.Find("level" + i, false)[0].Enabled = true;
            }
        }

        private void levelPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
                LevelBack();
        }

        private void level_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name)
            {
                case "restart": { re = true; LevelBack(); ev(); } break;
                case "backLable": LevelBack(); break;
                case "newGame": { config.AccessLevel = 1; config.CurrentLevel = 1; re = true; LevelBack(); ev(); } break;
                default: LevelByName(((Label)sender).Name); break;
            }
            config.Write();
        }

        private void LevelByName(string lev)
        {
            int i = Convert.ToInt32(lev.Substring(lev.Length - 1, 1), System.Globalization.CultureInfo.CurrentCulture);
            config.CurrentLevel = i;
            re = true;
            LevelBack();
            ev();
        }

        private void LevelBack()
        {
            levelPanel.Visible = false;
            MenuVisiable(true);
            this.Focus();
        }

        private void level_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Green;
        }

        private void level_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Yellow;
        }
        #endregion
    }
}
