using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Terminator
{
    class Termin
    {
        #region TerminVariables
        TerminImg terminImg;
        Image currentImg;
        Image[] images;
        List<Wall> walls;
        int x, y;
        int direct_x, direct_y;
        int real_x, real_y;
        int mouse_x, mouse_y;
        int life;
        int targets;
        int stopTarget;
        int targetStopTime;
        int hurtTermin;
        int maxTargets;
        int maxLife;
        int flags;
        int flagsCount;
        int fits,currentFit;
        List<EatObject> eatObjects;
        int termin_x, termin_y,hurtTerminTime;

        public int FlagsCount
        {
            get { return flagsCount; }
        }
        public int Flags
        {
            get { return flags; }
        }
        public int HurtTermin
        {
            get { return hurtTermin; }
            set { if (value>=0)hurtTermin = value; }
        }
        public int HurtTerminTime
        {
            get { return hurtTerminTime; }
        } 
        public int TargetStopTime
        {
            get { return targetStopTime; }
            set { if (targetStopTime>=10) targetStopTime = value; }
        }
        public int StopTarget
        {
            get { return stopTarget; }
            set { if (value>=0)
                stopTarget = value; }
        }
        public int Targets
        {
            get { return targets; }
            set { if (value >=0 )targets = value; }
        }
        public int Termin_y
        {
            get { return termin_y; }
        } 
        public int Termin_x
        {
            get { return termin_x; }
        } 
        internal List<EatObject> EatObjects
        {
            get { return eatObjects; }
        }
        public int Life
        {
            get { return life; }
            set { life = value; }
        }
        public int Mouse_x
        {
            get { return mouse_x; }
            set { mouse_x = value; }
        }
        public int Mouse_y
        {
            get { return mouse_y; }
            set { mouse_y = value; }
        }
        public int Real_y
        {
            get { return real_y; }
            set { real_y = value; }
        }
        public int Real_x
        {
            get { return real_x; }
            set { real_x = value; }
        }
        public int Direct_y
        {
            get { return direct_y; }
            set { direct_y = value; }
        }
        public int Direct_x
        {
            get { return direct_x; }
            set { direct_x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public Image CurrentImg
        {
            get { return currentImg; }
        }
        #endregion

        public Termin(int real_x,int real_y,int x,int y,List<Wall> walls,List<EatObject> eatObjects)
        {
            termin_x = termin_y = 50; hurtTerminTime = 20;
            flagsCount = eatObjects.FindAll(r => r.Status == EatObjectStatus.Flag).Count;
            targetStopTime = 15;
            maxTargets = 100;
            maxLife = 50;
            targets = maxTargets;
            this.eatObjects=eatObjects;
            this.Life = maxLife;
            this.walls = walls;
            this.real_x = real_x;
            this.real_y = real_y;
            this.x = x;
            this.y = y;
            terminImg = new TerminImg();
            images = terminImg.ImgUp;
        }

        public void Run(IEnumerable<Enemi> enemis)
        {
            this.StopTarget--;
            this.HurtTermin--;
            CheckToHurt(enemis);
            ChangeCurrentImg();
            if (direct_x!=0 || direct_y!=0)
                fits++;
            x += direct_x;
            y += direct_y;
            CheckEatObjects();
        }

        private void CheckToHurt(IEnumerable<Enemi> enemis)
        {
            foreach (Enemi i in enemis)
            {
                bool hurt=false;
                if (i.X + i.Enemi_x > real_x && i.X < real_x+termin_x && i.Y < real_y + termin_y && i.Y + i.Enemi_y > real_y)
                {
                    real_x += -1 * direct_x;
                    direct_x = 0; hurt = true;
                    i.X += -3 * i.Direct_x;
                }
                if (i.Y + i.Enemi_y > real_y && i.Y < real_y + termin_y && i.X < real_x + termin_x && i.X + i.Enemi_x > real_x)
                {
                    real_y += -1 * direct_y;
                    direct_y = 0; hurt = true;
                    i.Y += -3 * i.Direct_y;
                }
                if (hurt && hurtTermin==0)
                {
                    life--;
                    this.HurtTermin = hurtTerminTime;
                }
            }
        }

        private void CheckEatObjects()
        {
            EatObject j=null;
            foreach(EatObject i in eatObjects)
                if (i.X > real_x && i.X < real_x + termin_x &&
                    i.Y > real_y && i.Y < real_y + termin_y)
                {
                    j = i; break;
                }
            if (j != null)
            {
                switch (j.Status)
                {
                    case EatObjectStatus.Life: 
                        {
                            if (life + 20 > maxLife)
                                life=maxLife;
                            else
                                life+=20;
                            eatObjects.Remove(j); 
                        } break;
                    case EatObjectStatus.Weppon: 
                        {
                            if (targets + 50 > maxTargets)
                                targets = maxTargets;
                            else
                                targets += 50;
                            eatObjects.Remove(j);
                        } break;
                    case EatObjectStatus.GoodWeppon: { TargetStopTime -= 5; eatObjects.Remove(j); } break;
                    case EatObjectStatus.Flag: { flags++; eatObjects.Remove(j); } break;
                }
            }
        }

        private void ChangeCurrentImg()
        {
            if (mouse_x == -1 && mouse_y==0)
                images = terminImg.ImgLeft;
            if (mouse_x == 1 && mouse_y == 0)
                images = terminImg.ImgRight;
            if (mouse_y == -1 && mouse_x == 0)
                images = terminImg.ImgUp;
            if (mouse_y == 1 && mouse_x == 0)
                images = terminImg.ImgDown;


            if (mouse_x == -1 && mouse_y == -1)
                images = terminImg.ImgUpLeft;
            if (mouse_x == 1 && mouse_y == -1)
                images = terminImg.ImgUpRight;
            if (mouse_y == 1 && mouse_x == 1)
                images = terminImg.ImgDownRight;
            if (mouse_y == 1 && mouse_x == -1)
                images = terminImg.ImgDownLeft;

            if (fits == 4)
            {
                fits = 0;
                if (currentFit == 2)
                    currentFit = 0;
                else
                    currentFit++;
            }
            if (direct_x == 0 && direct_y == 0)
                currentFit = 0;
            currentImg = images[currentFit];
        }

        internal void CheckWalls()
        {
            Rectangle r=new Rectangle(real_x+direct_x,real_y+direct_y,termin_x,termin_y);
            foreach (Wall i in walls)
            {
                if (r.IntersectsWith(new Rectangle(i.X1, i.Y1, i.X2 - i.X1, i.Y2 - i.Y1)))
                {
                    if (direct_x == -2 && i.X2+1 >= real_x && real_y + termin_y > i.Y1 && real_y < i.Y2)
                    {
                        x+=2;
                        real_x+=2;
                    }
                    if (direct_y == -2 && i.Y2+1 >= real_y && real_x + termin_x > i.X1 && real_x < i.X2)
                    {
                        y+=2;
                        real_y+=2;
                    }
                    if (direct_x == 2 && i.X1-1 <= real_x + termin_x && real_y + termin_y > i.Y1 && real_y < i.Y2)
                    {
                        x-=2;
                        real_x-=2;
                    }
                    if (direct_y == 2 && i.Y1-1 <= real_y + termin_y && real_x + termin_x > i.X1 && real_x < i.X2)
                    {
                        y-=2;
                        real_y-=2;
                    }
                }
            }
        }
    }
}
