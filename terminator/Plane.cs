using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Terminator
{
    class Plane
    {
        int x, y, direct_x, direct_y;
        int plane_x, plane_y;
        long lTime;
        Random r;
        Image currentImage;
        bool entered;
        PlaneImage planeImage;

        public int Plane_x
        {
            get { return plane_x; }
        }
        public int Plane_y
        {
            get { return plane_y; }
        } 
        public bool Entered
        {
            get { return entered; }
        }
        public Image CurrentImage
        {
            get { return currentImage; }
        }
        public int Y
        {
            get { return y; }
        }
        public int X
        {
            get { return x; }
        }

        public Plane()
        {
            plane_x = plane_y = 200;
            planeImage = new PlaneImage();
            r = new Random();
            lTime = r.Next(1000, 2000);
        }
        public void move(int p_x,int p_y)
        {
            if (entered)
            {
                x += direct_x;
                y += direct_y;
                if (x < p_x - plane_x-4 || x > p_x + 644 || y < p_y - plane_y-4 || y > p_y + 484)
                {
                    entered = false;
                    direct_x = direct_y = 0;
                    lTime = r.Next(500, 1000);
                }
            }
            else
            {
                lTime--;
                if (lTime == 0)
                {
                    entered = true;
                    CreatePlane(r.Next(0, 4),p_x,p_y);
                }
            }
        }

        private void CreatePlane(int p,int p_x,int p_y)
        {
            currentImage = planeImage.Imgs[r.Next(0,planeImage.Imgs.Count)][p];
            switch (p)
            {
                case 0: { x = p_x - plane_x; y = r.Next(p_y, p_y + 280); direct_x = 4; }; break;
                case 1: { x = p_x + 640; y = r.Next(p_y, p_y + 280); direct_x = -4; }; break;
                case 2: { x = r.Next(p_x, p_x + 440); y = p_y + 480; direct_y = -4; }; break;
                case 3: { x = r.Next(p_x, p_x + 440); y = p_y - plane_y; direct_y = 4; }; break;
            }
        }
    }
}
