using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Terminator
{
    class Enemi
    {
        #region EnemiVariables
        EnemiStatus status;
        int x, y;
        int direct_x, direct_y;
        Image currentImg;
        List<Wall> walls;
        int enemi_x, enemi_y;
        Random r=new Random();
        int life;
        int targetDelay;
        EnemiImg enemiImg;
        bool search;

        public bool Search
        {
            get { return search; }
            set { search = value; }
        }
        public int TargetDelay
        {
            get { return targetDelay; }
            set { if (value >= 0) targetDelay = value; }
        }
        internal EnemiImg EnemiImg
        {
            set { enemiImg = value; }
        }
        public int Life
        {
            get { return life; }
            set 
            {
                if (value <= 0)
                {
                    life = 0;
                    status = EnemiStatus.Death;
                    currentImg = enemiImg.ImgDeath;
                }
                else
                    life = value;
            }
        }
        public int Enemi_y
        {
            get { return enemi_y; }
            set { enemi_y = value; }
        }
        public int Enemi_x
        {
            get { return enemi_x; }
            set { enemi_x = value; }
        }
        internal List<Wall> Walls
        {
            set { walls = value; }
        }
        public Image CurrentImg
        {
            get { return currentImg; }
            set { currentImg = value; }
        }
        public int Direct_y
        {
            get { return direct_y; }
        }
        public int Direct_x
        {
            get { return direct_x; }
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

        internal EnemiStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion

        public void Run()
        {
            ChangeCurrentImg();
            CheckWalls();
            x += direct_x;
            y += direct_y;
            this.TargetDelay--;
        }

        private void CheckWalls()
        {
            foreach (Wall i in walls)
            {
                Rectangle rect = new Rectangle(x+direct_x, y+direct_y, enemi_x, enemi_y);
                if (rect.IntersectsWith(new Rectangle(i.X1, i.Y1, i.X2 - i.X1, i.Y2 - i.Y1)))
                {
                    if (i.X2 >= x && i.X1 <= x + enemi_x && y + enemi_y > i.Y1 && y < i.Y2)
                        direct_x = -1 * direct_x;
                    if (i.Y2 >= y && i.Y1 <= y + enemi_y && x + enemi_x > i.X1 && x < i.X2)
                        direct_y = -1 * direct_y;
                }
            }
        }
        public void RunRandom()
        {
            if (r.Next(500) > 490)
            {
                direct_x = r.Next(-1, 2);
                direct_y = r.Next(-1, 2);
            }
        }
        public void RunToTermin(int x,int y)
        {
            if (x>this.x+enemi_x/2)
                direct_x=1;
            else
                direct_x=-1;
            if (x == this.x+enemi_x/2)
                direct_x = 0;

            if (y > this.y+enemi_y/2)
                direct_y = 1;
            else
                direct_y = -1;
            if (y == this.y+enemi_y/2)
                direct_y = 0;
        }

        internal void TurnAround(IEnumerable<Enemi> enemis)
        {
            foreach (Enemi i in enemis)
            {
                if ((direct_x == -1 && x < i.X + i.Enemi_x && x > i.X ||
                        direct_x == 1 && x + enemi_x > i.X && x < i.X)
                        && y + enemi_y > i.Y && y < i.Y + i.Enemi_y)
                    direct_x = 0;

                if ((direct_y == -1 && y < i.Y + i.Enemi_y && y > i.Y ||
                    direct_y == 1 && y + enemi_y > i.Y && y < i.Y)
                    && x + enemi_x > i.X && x < i.X + i.Enemi_x)
                    direct_y = 0;
            }
        }
        private void ChangeCurrentImg()
        {
            if (direct_x == -1 && direct_y == 0)
                currentImg = enemiImg.ImgLeft;
            if (direct_x == 1 && direct_y == 0)
                currentImg = enemiImg.ImgRight;
            if (direct_y == -1 && direct_x == 0)
                currentImg = enemiImg.ImgUp;
            if (direct_y == 1 && direct_x == 0)
                currentImg = enemiImg.ImgDown;


            if (direct_x == -1 && direct_y == -1)
                currentImg = enemiImg.ImgUpLeft;
            if (direct_x == 1 && direct_y == -1)
                currentImg = enemiImg.ImgUpRight;
            if (direct_y == 1 && direct_x == 1)
                currentImg = enemiImg.ImgDownRight;
            if (direct_y == 1 && direct_x == -1)
                currentImg = enemiImg.ImgDownLeft;
        }
    }
}
