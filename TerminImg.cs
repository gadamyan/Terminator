using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Terminator
{
    class TerminImg
    {
        Image[] imgUp;
        Image[] imgRight;
        Image[] imgDown;
        Image[] imgLeft;

        Image[] imgUpRight;
        Image[] imgUpLeft;
        Image[] imgDownRight;
        Image[] imgDownLeft;
        
        public Image[] ImgUpRight
        {
            get { return imgUpRight; }
        }
        public Image[] ImgUpLeft
        {
            get { return imgUpLeft; }
        }
        public Image[] ImgDownRight
        {
            get { return imgDownRight; }
        }
        public Image[] ImgDownLeft
        {
            get { return imgDownLeft; }
        }

        public Image[] ImgLeft
        {
            get { return imgLeft; }
        }
        public Image[] ImgDown
        {
            get { return imgDown; }
        }
        public Image[] ImgRight
        {
            get { return imgRight; }
        }
        public Image[] ImgUp
        {
            get { return imgUp; }
        }

        public TerminImg()
        {
            imgUp = new Image[] { Properties.Resources.TermUp0, Properties.Resources.TermUp1, Properties.Resources.TermUp2 };
            imgRight = new Image[] { Properties.Resources.TermRight0, Properties.Resources.TermRight1, Properties.Resources.TermRight2 };
            imgDown = new Image[] { Properties.Resources.TermDown0, Properties.Resources.TermDown1, Properties.Resources.TermDown2 };
            imgLeft = new Image[] { Properties.Resources.TermLeft0, Properties.Resources.TermLeft1, Properties.Resources.TermLeft2 };
            imgUpLeft = new Image[] { Properties.Resources.TermUpLeft0, Properties.Resources.TermUpLeft1, Properties.Resources.TermUpLeft2 };
            imgUpRight = new Image[] { Properties.Resources.TermUpRight0, Properties.Resources.TermUpRight1, Properties.Resources.TermUpRight2 };
            imgDownLeft = new Image[] { Properties.Resources.TermDownLeft0, Properties.Resources.TermDownLeft1, Properties.Resources.TermDownLeft2 };
            imgDownRight = new Image[] { Properties.Resources.TermDownRight0, Properties.Resources.TermDownRight1, Properties.Resources.TermDownRight2 };
        }
    }
}
