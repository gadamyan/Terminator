using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Terminator
{
    static class Crosser
    {
        public static List<Point> LineToRect(Rectangle r, Point p1, Point p2)
        {
            return LineToRectFunct(r.X, r.Y, r.X + r.Width, r.Y + r.Height, p1.X, p1.Y, p2.X, p2.Y);
        }

        private static List<Point> LineToRectFunct(int x1, int y1, int x2, int y2, int xs, int ys, int xe, int ye)
        {
            List<Point> points = new List<Point>();
            if (ys == ye)
            {
                if (ys >= y1 && ys <= y2)
                {
                    if (Math.Max(xs, xe) >= x1 && Math.Min(xs, xe) <= x1)
                        points.Add(new Point(x1, ys));
                    if (Math.Max(xs, xe) >= x2 && Math.Min(xs, xe) <= x2)
                        points.Add(new Point(x2, ys));
                }
            }
            else
                if (xs == xe)
                {
                    if (xs >= x1 && xs <= x2)
                    {
                        if (Math.Max(ys, ye) >= y1 && Math.Min(ys, ye) <= y1)
                            points.Add(new Point(xs, y1));
                        if (Math.Max(ys, ye) >= y2 && Math.Min(ys, ye) <= y2)
                            points.Add(new Point(xs, y2));
                    }
                }
                else
                {
                    int temp_x, temp_y;
                    temp_y = y1;
                    temp_x = (y1 * (xe - xs) - xe * ys + ye * xs) / (ye - ys);
                    if (temp_x >= x1 && temp_x <= x2)
                        points.Add(new Point(temp_x, temp_y));

                    temp_y = y2;
                    temp_x = (y2 * (xe - xs) - xe * ys + ye * xs) / (ye - ys);
                    if (temp_x >= x1 && temp_x <= x2)
                        points.Add(new Point(temp_x, temp_y));
                    
                    temp_x = x1;
                    temp_y = (x1 * (ye - ys) + xe * ys - ye * xs) / (xe - xs);
                    if (temp_y >= y1 && temp_y <= y2)
                        points.Add(new Point(temp_x, temp_y));

                    temp_x = x2;
                    temp_y = (x2 * (ye - ys) + xe * ys - ye * xs) / (xe - xs);
                    if (temp_y >= y1 && temp_y <= y2)
                        points.Add(new Point(temp_x, temp_y));
                }
            return points;
        }

        public static Point SmallLine(int xs, int ys, Termin termin)
        {
            Point p = new Point();
            Random rand = new Random();
            int len = rand.Next(50, 200);
            int xe, ye;
            xe = termin.Real_x-15 + rand.Next(termin.Termin_x+30);
            ye = termin.Real_y-15 + rand.Next(termin.Termin_y+30);

            if (Math.Pow((xe - xs), 2) + Math.Pow((ye - ys), 2) > len * len)
            {
                if (xe == xs)
                {
                    if (ye > ys)
                        ye = ys + len;
                    else
                        ye = ys - len;
                }
                else
                {
                    int len1 = (int)Math.Sqrt(Math.Pow((xe - xs), 2) + Math.Pow((ys - ye), 2));
                    xe = xs + len * (xe - xs) / len1;
                    ye = ys - len * (ys - ye) / len1;
                }
            }
            p.X = xe;
            p.Y = ye;
            return p;
        }

        public static bool Iscross(Enemi i, Termin termin, List<Wall> walls)
        {
            int i2x,i2y,i1x,i1y;
            i1x = Math.Min(i.X + i.Enemi_x / 2, termin.Real_x + termin.Termin_x / 2);
            i1y = Math.Min(i.Y + i.Enemi_y / 2, termin.Real_y + termin.Termin_y / 2);
            i2x = Math.Abs(i.X + i.Enemi_x / 2 - termin.Real_x - termin.Termin_x / 2);
            i2y = Math.Abs(i.Y + i.Enemi_y / 2 - termin.Real_y - termin.Termin_y / 2);
            Rectangle tr = new Rectangle(i1x, i1y, i2x, i2y);
            bool bol = true;
            foreach (Wall j in walls)
            {
                Rectangle t1 = new Rectangle(j.X1, j.Y1, j.X2 - j.X1, j.Y2 - j.Y1);
                if (tr.IntersectsWith(t1))
                {
                    if (LineToRectFunct(j.X1, j.Y1, j.X2, j.Y2, i1x, i1y, i1x + i2x, i1y + i2y).Count > 0)
                        bol = false;
                }
            }
            return bol;
        }
    }
}
