using System;
using System.Collections.Generic;
using System.Text;

namespace Terminator
{
    class Wall
    {
        int x1, y1, x2, y2;

        public int Y2
        {
            get { return y2; }
        }
        public int X2
        {
            get { return x2; }
        }
        public int Y1
        {
            get { return y1; }
        }
        public int X1
        {
            get { return x1; }
        }

        public Wall(bool b,int x1, int y1, int x2, int y2)
        {
            if (b)
            {
                this.x1 = x1;
                this.x2 = x2;
                this.y1 = y1;
                this.y2 = y2;
            }
        }
        public Wall(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1 - x2 / 2;
            this.y1 = y1 - y2 / 2;
            this.x2 = this.x1 + x2;
            this.y2 = this.y1 + y2;
        }
    }
}
