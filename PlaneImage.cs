using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Terminator
{
    class PlaneImage
    {
        List<Image[]> imgs;
        public List<Image[]> Imgs
        {
            get { return imgs; }
        }
        public PlaneImage()
        {
            imgs = new List<Image[]>();
            imgs.Add(new Image[]{Properties.Resources.AirPlane1_Right,Properties.Resources.AirPlane1_Left,
                Properties.Resources.AirPlane1_Up,Properties.Resources.AirPlane1_Down});
            imgs.Add(new Image[]{Properties.Resources.AirPlane2_Right,Properties.Resources.AirPlane2_Left,
                Properties.Resources.AirPlane2_Up,Properties.Resources.AirPlane2_Down});
            imgs.Add(new Image[]{Properties.Resources.AirPlane3_Right,Properties.Resources.AirPlane3_Left,
                Properties.Resources.AirPlane3_Up,Properties.Resources.AirPlane3_Down});
        }
    }
}
