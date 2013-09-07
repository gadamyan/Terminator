using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Terminator
{
    class Floor
    {
        Image img;
        int x, y;
        
        public Image Img
        {
            get { return img; }
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
        public Floor( Image img,int x,int y )
        {
            this.img = img;
            this.x = x;
            this.y = y;
        }
    }
}
