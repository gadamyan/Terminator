using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace Terminator
{
    class View
    {
        Model model;

        internal Model Model
        {
            set { model = value; }
        }

        public void Paint(PaintEventArgs e)
        {
            try
            {
                switch (model.Status)
                {
                    case GameStatus.Stoping:
                    case GameStatus.Playing: PaintObjects(e); break;
                    case GameStatus.Looz: e.Graphics.DrawImage(Properties.Resources.Lose, 0, 0, 640, 480); break;
                    case GameStatus.Ween: e.Graphics.DrawImage(Properties.Resources.Win, 0, 0, 640, 480); break;
                    case GameStatus.EndGame: e.Graphics.DrawImage(Properties.Resources.Winner, 0, 0, 640, 480); break;
                    case GameStatus.Level: PaintLevel(e); break;
                    default: break;
                }
            }
            catch (NullReferenceException) { }
            catch (InvalidOperationException) { }
            catch (ArgumentNullException) { }
        }

        private void PaintLevel(PaintEventArgs e)
        {
            Image i = Properties.Resources.Level1;
            switch (model.Game)
            {
                case 1: i = Properties.Resources.Level1; break;
                case 2: i = Properties.Resources.Level2; break;
                case 3: i = Properties.Resources.Level3; break;
                case 4: i = Properties.Resources.Level4; break;
                case 5: i = Properties.Resources.Level5; break;
            }
            e.Graphics.DrawImage(i, 0, 0, 640, 480);
        }

        private void PaintObjects(PaintEventArgs e)
        {
            PaintFloors(e);
            PaintDeathEnemis(e);
            PaintEatObjects(e);
            PaintEnemis(e);
            PaintTermin(e);
            PaintTarget(e);
            PaintEnemiTargets(e);
            PaintPlane(e);
            PaintStatus(e);
        }

        private void PaintDeathEnemis(PaintEventArgs e)
        {
            foreach (Enemi i in model.Enemis.FindAll(r => r.Status == EnemiStatus.Death))
                e.Graphics.DrawImage(i.CurrentImg, new Rectangle(i.X - model.Real_x, i.Y - model.Real_y, i.Enemi_x, i.Enemi_y));
        }

        private void PaintPlane(PaintEventArgs e)
        {
            if (model.Plane.Entered)
                e.Graphics.DrawImage(model.Plane.CurrentImage, model.Plane.X - model.Real_x, model.Plane.Y - model.Real_y, model.Plane.Plane_x, model.Plane.Plane_y);
        }

        private void PaintStatus(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, new Rectangle(520, 460, 2*model.Termin.Life, 10));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(520, 460, 100, 10));
            e.Graphics.DrawString(model.Termin.Targets.ToString(System.Globalization.CultureInfo.CurrentCulture), new Font(FontFamily.GenericMonospace, 15, FontStyle.Bold), Brushes.Black, new PointF(20, 455));
        }

        private void PaintEatObjects(PaintEventArgs e)
        {
            foreach (EatObject i in model.Termin.EatObjects)
                e.Graphics.DrawImage(i.Img, i.X - i.Eat_x / 2 - model.Real_x, i.Y - i.Eat_y / 2 - model.Real_y, i.Eat_x, i.Eat_y);
        }

        private void PaintTarget(PaintEventArgs e)
        {
            Target t = model.Target;
            if (t.Flag)
            {
                e.Graphics.DrawLine(Pens.Yellow, new Point(t.Start_x - model.Real_x, t.Start_y - model.Real_y), new Point(t.End_x - model.Real_x, t.End_y - model.Real_y));
                e.Graphics.FillEllipse(Brushes.Yellow, new Rectangle(t.End_x - model.Real_x - 3, t.End_y - model.Real_y - 3, 6, 6));
                model.Target.Flag = false;
            }
        }

        private void PaintEnemiTargets(PaintEventArgs e)
        {
            foreach (Target t in model.EnemiTargets)
            {
                e.Graphics.DrawLine(Pens.Yellow, new Point(t.Start_x - model.Real_x, t.Start_y - model.Real_y), new Point(t.End_x - model.Real_x, t.End_y - model.Real_y));
                e.Graphics.FillEllipse(Brushes.Yellow, new Rectangle(t.End_x - model.Real_x - 2, t.End_y - model.Real_y - 2, 4, 4));
            }
        }

        private void PaintEnemis(PaintEventArgs e)
        {
            foreach (Enemi i in model.Enemis.FindAll(r => r.Status == EnemiStatus.Playing))
                e.Graphics.DrawImage(i.CurrentImg, new Rectangle(i.X - model.Real_x, i.Y - model.Real_y, i.Enemi_x, i.Enemi_y));
        }

        private void PaintTermin(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.Termin.CurrentImg, new Rectangle(model.Termin.X, model.Termin.Y, model.Termin.Termin_x, model.Termin.Termin_y));
        }

        private void PaintFloors(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.Floor.Img, model.Floor.X, model.Floor.Y, 1920, 1440);
        }
    }
}
