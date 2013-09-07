using System;
using System.Collections.Generic;
using System.Text;

namespace Terminator
{
    class Finish
    {
        int x, y;

        public int Y
        {
            get { return y; }
        }
        public int X
        {
            get { return x; }
        }

        public Finish(int i)
        {
            switch (i)
            {
                case 1: Finish1(); break;
                case 2: Finish2(); break;
                case 3: Finish3(); break;
                case 4: Finish4(); break;
                case 5: Finish5(); break;
                default: break;
            }
        }

        private void Finish1()
        {
            x = 1507;
            y = 322;
        }

        private void Finish2()
        {
            x = 1734;
            y = 1168;
        }

        private void Finish3()
        {
            x = 189;
            y = 1203;
        }

        private void Finish4()
        {
            x = 550;
            y = 537;
        }

        private void Finish5()
        {
            x = 875;
            y = 762;
        }
    }
}
