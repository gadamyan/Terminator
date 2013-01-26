using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Terminator
{
    public delegate void SoundDL();
    class Model
    {
        #region ModelVariables
        public event SoundDL SoundChange; 
        Level level;
        string audioString;
        Floor floor;
        Termin termin;
        Plane plane;
        GameStatus status;
        int real_x, real_y;
        int game;
        Target target;
        List<Target> enemiTargets;
        List<Wall> walls;
        List< Enemi> enemis;
        List<Enemi> tempEn;
        Finish finish;
        const int desc_Size_x = 640, desc_Size_y = 480;

        public int Game
        {
            get { return game; }
        }
        internal List<Target> EnemiTargets
        {
            get { return enemiTargets; }
        }
        public string AudioString
        {
            get { return audioString; }
        }
        internal Target Target
        {
            get { return target; }
        }
        public int Real_y
        {
            get { return real_y; }
        }
        public int Real_x
        {
            get { return real_x; }
        }
        internal List<Enemi> Enemis
        {
            get { return enemis; }
        }
        internal GameStatus Status
        {
            get { return status; }
            set { status = value; SoundChange(); }
        }
        internal Termin Termin
        {
            get { return termin; }
        }
        public Floor Floor
        {
            get { return floor; }
        }
        internal Plane Plane
        {
            get { return plane; }
        }
        #endregion

        public Model(int game)
        {
            this.game = game;
            status = GameStatus.Playing;
            level = new Level(game);

            floor = level.Floor;
            walls = level.Walls;
            termin = level.Termin;
            enemis = level.Enemis;
            finish = level.Finish;
            audioString = level.AudioString;

            target = new Target();
            plane = new Plane();
            enemiTargets = new List<Target>();
            tempEn = new List<Enemi>();
            real_x = termin.Real_x - termin.X;
            real_y = termin.Real_y - termin.Y;
        }

        public void KeyChange(bool hight, int value)
        {
            if (hight)
                termin.Direct_y = value;
            else
                termin.Direct_x = value;
        }

        internal void Play()
        {
            CheckTerminToWall();
            TerminTransform();
            RunEnemis();
            termin.Run(enemis.FindAll(r=> Math.Abs(r.X-termin.Real_x)<100 && (r.Y-termin.Real_y)<100 && r.Status==EnemiStatus.Playing ));
            real_x = -1 * floor.X;
            real_y=-1*floor.Y;
            termin.Real_x = real_x + termin.X;
            termin.Real_y = real_y + termin.Y;
            plane.move(real_x, real_y);
            CheckFinish();
        }

        private void CheckFinish()
        {
            if (termin.Real_x < finish.X && termin.Real_x + termin.Termin_x > finish.X &&
                termin.Real_y < finish.Y && termin.Real_y + termin.Termin_y > finish.Y && termin.Flags == termin.FlagsCount)
            {
                if (game == 5)
                    this.Status = GameStatus.EndGame;
                else
                    this.Status = GameStatus.Ween;
            }
            if (termin.Life <= 0)
                this.Status = GameStatus.Looz;
        }

        private void RunEnemis()
        {
            enemiTargets.Clear();
            tempEn.Clear();
            foreach (Enemi i in enemis)
                if (i.X + i.Enemi_x > real_x && i.X < real_x + desc_Size_x
                    && i.Y + i.Enemi_y > real_y && i.Y < real_y + desc_Size_y)
                {
                    if (i.Status != EnemiStatus.Death)
                        i.Status = EnemiStatus.Playing;
                }
                else
                {
                    if (i.Status != EnemiStatus.Death)
                    {
                        i.Status = EnemiStatus.NotView;
                        i.Search = false;
                    }
                    else
                        tempEn.Add(i);
                }
            foreach (Enemi i in tempEn)
                enemis.Remove(i);
            
            foreach (Enemi i in enemis.FindAll(r=> r.Status==EnemiStatus.Playing ))
            {
                //if (Math.Abs(termin.Real_x - i.X) < 300 && Math.Abs(termin.Real_y - i.Y) < 300)
                //{
                    if (i.Search || Crosser.Iscross(i, termin, walls))
                    {
                        i.Search = true;
                        i.RunToTermin(termin.Real_x + termin.Termin_x / 2, termin.Real_y + termin.Termin_y / 2);
                        if (i.TargetDelay == 0)
                            EnemiFire(i);
                    }
                    else
                        i.RunRandom();
                //}
                //else
                //    i.RunRandom();
                i.TurnAround(enemis.FindAll(r => r != i && r.Status==EnemiStatus.Playing && Math.Abs(r.X - i.X) < 100 && Math.Abs(r.Y - i.Y) < 100));
                
                i.Run();
            }
        }

        private void EnemiFire(Enemi e)
        {
            Target tempTarget = new Target();
            tempTarget.Start_x = e.X + e.Enemi_x / 2 + e.Direct_x * e.Enemi_x / 2;
            tempTarget.Start_y = e.Y + e.Enemi_y / 2 + e.Direct_y * e.Enemi_y / 2;

            Point tempPoint = Crosser.SmallLine(tempTarget.Start_x,tempTarget.Start_y,termin);
            tempTarget.End_x = tempPoint.X;
            tempTarget.End_y = tempPoint.Y;

            int tx1 = Math.Min(tempTarget.Start_x, tempTarget.End_x);
            int tx2 = Math.Max(tempTarget.Start_x, tempTarget.End_x);
            int ty1 = Math.Min(tempTarget.Start_y, tempTarget.End_y);
            int ty2 = Math.Max(tempTarget.Start_y, tempTarget.End_y);

            Rectangle trect = new Rectangle(tx1, ty1, tx2 - tx1, ty2 - ty1);
            List<Rectangle> rects = new List<Rectangle>();
            foreach (Wall i in walls.FindAll(r => trect.IntersectsWith(new Rectangle(r.X1, r.Y1, r.X2 - r.X1, r.Y2 - r.Y1))))
            {
                rects.Add(new Rectangle(i.X1, i.Y1, i.X2 - i.X1, i.Y2 - i.Y1));
            }
            foreach (Enemi i in enemis.FindAll(r => r!=e && r.Status == EnemiStatus.Playing &&
                trect.IntersectsWith(new Rectangle(r.X, r.Y, r.Enemi_x, r.Enemi_y))))
            {
                rects.Add(new Rectangle(i.X, i.Y, i.Enemi_x, i.Enemi_y));
            }
            rects.Add(new Rectangle(termin.Real_x, termin.Real_y, termin.Termin_x, termin.Termin_y));
            if (rects.Count != 0)
                tempTarget.InitLine(rects);
            enemiTargets.Add(tempTarget);
            e.TargetDelay = 5;
            if (tempTarget.End_x >= termin.Real_x && tempTarget.End_x <= termin.Real_x + termin.Termin_x
                && tempTarget.End_y >= termin.Real_y && tempTarget.End_y <= termin.Real_y + termin.Termin_y
                && termin.HurtTermin==0)
            {
                termin.Life--;
                termin.HurtTermin = termin.HurtTerminTime;
            }
        }

        private void CheckTerminToWall()
        {
            termin.CheckWalls();
        }

        private void TerminTransform()
        {
            if (termin.Y < 100 && termin.Direct_y == -2 && real_y != 0)
            {
                ChangeFloors(0, 2);
                termin.Y+=2;
            }
            if (termin.Y > 330 && termin.Direct_y == 2 && real_y != desc_Size_y*2)
            {
                ChangeFloors(0, -2);
                termin.Y-=2;
            }
            if (termin.X > 490 && termin.Direct_x == 2 && real_x != desc_Size_x*2)
            {
                ChangeFloors(-2, 0);
                termin.X-=2;
            }
            if (termin.X < 100 && termin.Direct_x == -2 && real_x !=0 )
            {
                ChangeFloors(2, 0);
                termin.X+=2;
            }
        }

        private void ChangeFloors(int x, int y)
        {
            floor.X += x;
            floor.Y += y;
        }

        internal void TargetRun(int end_x, int end_y)
        {
            target.Flag = true;
            target.End_x = end_x + real_x;
            target.End_y = end_y + real_y;
            target.Start_x = termin.Real_x + termin.Termin_x / 2 + termin.Mouse_x * termin.Termin_x / 2;
            target.Start_y = termin.Real_y + termin.Termin_y / 2 + termin.Mouse_y * termin.Termin_y / 2;

            int tx1 = Math.Min(target.Start_x, target.End_x);
            int tx2 = Math.Max(target.Start_x, target.End_x);
            int ty1 = Math.Min(target.Start_y, target.End_y);
            int ty2 = Math.Max(target.Start_y, target.End_y);
            Rectangle trect = new Rectangle(tx1, ty1, tx2 - tx1, ty2 - ty1);
            List<Rectangle> rects = new List<Rectangle>();
            foreach (Wall i in walls.FindAll(r => trect.IntersectsWith(new Rectangle(r.X1,r.Y1,r.X2-r.X1,r.Y2-r.Y1))))
            {
                rects.Add(new Rectangle(i.X1, i.Y1, i.X2 - i.X1, i.Y2 - i.Y1));
            }
            foreach (Enemi i in enemis.FindAll(r => r.Status==EnemiStatus.Playing && trect.IntersectsWith(new Rectangle(r.X, r.Y, r.Enemi_x, r.Enemi_y))))
            {
                rects.Add(new Rectangle(i.X, i.Y, i.Enemi_x, i.Enemi_y));
            }
            if (rects.Count!=0)
                target.InitLine(rects);

            foreach (Enemi i in enemis.FindAll(r => r.Status == EnemiStatus.Playing))
                if (i.X <= target.End_x && i.X + i.Enemi_x >= target.End_x &&
                    i.Y <= target.End_y && i.Y + i.Enemi_y >= target.End_y)
                    i.Life--;
            termin.Targets--;
        }
    }
}
