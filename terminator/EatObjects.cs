using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Terminator
{
    class EatObject
    {
        int x, y;
        Image img;
        int eat_x, eat_y;
        EatObjectStatus status;

        internal EatObjectStatus Status
        {
            get { return status; }
        }
        public int Eat_y
        {
            get { return eat_y; }
        } 
        public int Eat_x
        {
            get { return eat_x; }
        } 
        public Image Img
        {
            get { return img; }
        }
        public int Y
        {
            get { return y; }
        }
        public int X
        {
            get { return x; }
        }

        public EatObject(EatObjectStatus status, int x, int y)
        {
            eat_x = eat_y = 30;
            this.x = x;
            this.y = y;
            this.status = status;
            switch(status)
            {
                case EatObjectStatus.Life: img = Properties.Resources.Life; break;
                case EatObjectStatus.Weppon: img = Properties.Resources.Weppon; break;
                case EatObjectStatus.Flag: img = Properties.Resources.Flag; break;
                case EatObjectStatus.GoodWeppon: img = Properties.Resources.GoodWeppon; break;
                default: break;
            }
        }
    }
}
