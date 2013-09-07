using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Terminator
{
    class EnemiImg
    {
        #region EnemiImgVariables
        Image imgUp;
        Image imgRight;
        Image imgDown;
        Image imgLeft;

        Image imgUpRight;
        Image imgUpLeft;
        Image imgDownRight;
        Image imgDownLeft;
        Image imgDeath;

        public Image ImgDeath
        {
            get { return imgDeath; }
        }
        public Image ImgUpRight
        {
            get { return imgUpRight; }
        }
        public Image ImgUpLeft
        {
            get { return imgUpLeft; }
        }
        public Image ImgDownRight
        {
            get { return imgDownRight; }
        }
        public Image ImgDownLeft
        {
            get { return imgDownLeft; }
        }

        public Image ImgLeft
        {
            get { return imgLeft; }
        }
        public Image ImgDown
        {
            get { return imgDown; }
        }
        public Image ImgRight
        {
            get { return imgRight; }
        }
        public Image ImgUp
        {
            get { return imgUp; }
        }
        #endregion

        public EnemiImg(int i)
        {
            switch (i)
            {
                case 1: EnemiImage1(); break;
                case 2: EnemiImage2(); break;
                case 3: EnemiImage3(); break;
                case 4: EnemiImage4(); break;
                case 5: EnemiImage5(); break;
                case 6: EnemiImage6(); break;
                default: break;
            }
        }
        
        private void EnemiImage1()
        {
            imgUp = Properties.Resources.OvalUp;
            imgRight = Properties.Resources.OvalRight;
            imgDown = Properties.Resources.OvalDown;
            imgLeft = Properties.Resources.OvalLeft;
            imgUpLeft = Properties.Resources.OvalUpLeft;
            imgUpRight = Properties.Resources.OvalUpRight;
            imgDownLeft = Properties.Resources.OvalDownLeft;
            imgDownRight = Properties.Resources.OvalDownRight;
            imgDeath = Properties.Resources.DeathEnemi;
        }
        
        private void EnemiImage2()
        {
            imgUp = Properties.Resources.PixotUp;
            imgRight = Properties.Resources.PixotRight;
            imgDown = Properties.Resources.PixotDown;
            imgLeft = Properties.Resources.PixotLeft;
            imgUpLeft = Properties.Resources.PixotUpLeft;
            imgUpRight = Properties.Resources.PixotUpRight;
            imgDownLeft = Properties.Resources.PixotDownLeft;
            imgDownRight = Properties.Resources.PixotDownRight;
            imgDeath = Properties.Resources.DeathEnemi;
        }
        
        private void EnemiImage3()
        {
            imgUp = Properties.Resources.MotoUp;
            imgRight = Properties.Resources.MotoRight;
            imgDown = Properties.Resources.MotoDown;
            imgLeft = Properties.Resources.MotoLeft;
            imgUpLeft = Properties.Resources.MotoUpLeft;
            imgUpRight = Properties.Resources.MotoUpRight;
            imgDownLeft = Properties.Resources.MotoDownLeft;
            imgDownRight = Properties.Resources.MotoDownRight;
            imgDeath = Properties.Resources.DeathEnemi;
        }
        
        private void EnemiImage4()
        {
            imgUp = Properties.Resources.BugUp;
            imgRight = Properties.Resources.BugRight;
            imgDown = Properties.Resources.BugDown;
            imgLeft = Properties.Resources.BugLeft;
            imgUpLeft = Properties.Resources.BugUpLeft;
            imgUpRight = Properties.Resources.BugUpRight;
            imgDownLeft = Properties.Resources.BugDownLeft;
            imgDownRight = Properties.Resources.BugDownRight;
            imgDeath = Properties.Resources.DeathEnemi;
        }
        
        private void EnemiImage5()
        {
            imgUp = Properties.Resources.TankUp;
            imgRight = Properties.Resources.TankRight;
            imgDown = Properties.Resources.TankDown;
            imgLeft = Properties.Resources.TankLeft;
            imgUpLeft = Properties.Resources.TankUpLeft;
            imgUpRight = Properties.Resources.TankUpRight;
            imgDownLeft = Properties.Resources.TankDownLeft;
            imgDownRight = Properties.Resources.TankDownRight;
            imgDeath = Properties.Resources.DeathEnemi;
        }
        
        private void EnemiImage6()
        {
            imgUp = Properties.Resources.PlaneUp;
            imgRight = Properties.Resources.PlaneRight;
            imgDown = Properties.Resources.PlaneDown;
            imgLeft = Properties.Resources.PlaneLeft;
            imgUpLeft = Properties.Resources.PlaneUpLeft;
            imgUpRight = Properties.Resources.PlaneUpRight;
            imgDownLeft = Properties.Resources.PlaneDownLeft;
            imgDownRight = Properties.Resources.PlaneDownRight;
            imgDeath = Properties.Resources.DeathEnemi;
        }
    }
}
