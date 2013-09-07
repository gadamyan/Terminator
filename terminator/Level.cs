using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Terminator
{
    class Level
    {
        #region LevelVariables
        WallCreater wallCreater;
        EatObjectsCreater eatObjectsCreater;
        EnemiCreater enemiCreater;
        Floor floor;
        List<Wall> walls;
        List<Enemi> enemis;
        Termin termin;
        Finish finish;
        string audioString;

        internal string AudioString
        {
            get { return audioString; }
        }
        internal Finish Finish
        {
            get { return finish; }
        }
        internal Termin Termin
        {
            get { return termin; }
        }
        internal List<Enemi> Enemis
        {
            get { return enemis; }
        }
        internal List<Wall> Walls
        {
            get { return walls; }
        }
        internal Floor Floor
        {
            get { return floor; }
        }
        #endregion

        public Level(int i)
        {
            wallCreater = new WallCreater(i);
            walls = wallCreater.Walls;
            enemiCreater = new EnemiCreater(i, walls);
            enemis = enemiCreater.Enemis;
            finish = new Finish(i);
            eatObjectsCreater = new EatObjectsCreater(i);
            audioString = string.Format(System.Globalization.CultureInfo.CurrentCulture, @"Source\Level{0}.Wav", i);
            switch (i)
            {
                case 1: Level1(); break;
                case 2: Level2(); break;
                case 3: Level3(); break;
                case 4: Level4(); break;
                case 5: Level5(); break;
                default: break;
            }
        }

        private void Level1()
        {
            Image img = Properties.Resources.FloorI;
            floor = new Floor(img, 0, 0);
            termin = new Termin(200, 400, 200, 400, walls, eatObjectsCreater.EatObjects);
        }

        private void Level2()
        {
            Image img = Properties.Resources.FloorII;
            floor = new Floor(img, -640, -960);
            termin = new Termin(1080, 1320, 440, 360, walls, eatObjectsCreater.EatObjects);
        }

        private void Level3()
        {
            Image img = Properties.Resources.FloorIII;
            floor = new Floor(img, -640, 0);
            termin = new Termin(740, 100, 100, 100, walls, eatObjectsCreater.EatObjects);
        }

        private void Level4()
        {
            Image img = Properties.Resources.FloorIV;
            floor = new Floor(img, -1280, 0);
            termin = new Termin(1600, 400, 320, 400, walls, eatObjectsCreater.EatObjects);
        }

        private void Level5()
        {
            Image img = Properties.Resources.FloorV;
            floor = new Floor(img, 0, -960);
            termin = new Termin(480, 1360, 480, 400, walls, eatObjectsCreater.EatObjects);
        }
    }
}
