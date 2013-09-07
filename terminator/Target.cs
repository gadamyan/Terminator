using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Terminator
{
    class Target
    {
        int start_x, start_y, end_x, end_y ;
        bool flag;

        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        public int End_y
        {
            get { return end_y; }
            set { end_y = value; }
        }
        public int End_x
        {
            get { return end_x; }
            set { end_x = value; }
        }
        public int Start_y
        {
            get { return start_y; }
            set { start_y = value; }
        }
        public int Start_x
        {
            get { return start_x; }
            set { start_x = value; }
        }

        internal void InitLine(List<Rectangle> rects)
        {
            List<Point> tempPoints = new List<Point>();
            foreach (Rectangle r in rects)
                tempPoints.AddRange(Crosser.LineToRect(r, new Point(start_x, start_y), new Point(end_x, end_y)));
            foreach (Point i in tempPoints)
                if( Math.Abs(i.X - start_x) <= Math.Abs(end_x - start_x) && Math.Abs(i.Y - start_y) <= Math.Abs(end_y - start_y))
                {
                    end_x = (int)i.X;
                    end_y = (int)i.Y;
                }
        }
    }
}
