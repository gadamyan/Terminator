using System;
using System.Collections.Generic;
using System.Text;

namespace Terminator
{
    class EnemiConfig:Enemi
    {
        EnemiImg enemiImg;
        public EnemiConfig(int x,int y,List<Wall> walls,int i)
        {
            switch(i)
            {
                case 1: EnemiStyle(24, 24, 2); break;
                case 2: EnemiStyle(26, 26, 4); break;
                case 3: EnemiStyle(30, 30, 6); break;
                case 4: EnemiStyle(34, 34, 8); break;
                case 5: EnemiStyle(36, 36, 10); break;
                case 6: EnemiStyle(40, 40, 12); break;
            }
            enemiImg = new EnemiImg(i);
            CurrentImg = enemiImg.ImgUp;
            this.EnemiImg = enemiImg;
            this.X = x-this.Enemi_x/2;
            this.Y = y-this.Enemi_y/2;
            this.Walls = walls;
        }

        private void EnemiStyle(int enemi_x, int enemi_y, int life)
        {
            this.Enemi_x = enemi_x;
            this.Enemi_y = enemi_y;
            this.Life = life;
        }
    }
}
