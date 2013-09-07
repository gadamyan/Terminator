using System;
using System.Collections.Generic;
using System.Text;

namespace Terminator
{
    class EatObjectsCreater
    {
        List<EatObject> eatObjects;

        internal List<EatObject> EatObjects
        {
            get { return eatObjects; }
        }
        public EatObjectsCreater(int i)
        {
            eatObjects = new List<EatObject>();
            switch (i)
            {
                case 1: CreateObjects1(); break;
                case 2: CreateObjects2(); break;
                case 3: CreateObjects3(); break;
                case 4: CreateObjects4(); break;
                case 5: CreateObjects5(); break;
                default: break;
            }
        }

        private void CreateObjects1()
        {
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 144, 37));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 71, 445));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1232, 39));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 922, 326));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1556, 190));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 333, 716));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 756, 923));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1236, 517));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1561, 907));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 160, 1158));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1240, 1403));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1886, 1110));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1025, 231));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1233, 563));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 692, 531));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 39, 908));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 591, 803));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 400, 1168));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 502, 1387));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1187, 1014));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1622, 1391));
            eatObjects.Add(new EatObject(EatObjectStatus.GoodWeppon, 1476, 1010));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1873, 713));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1658, 267));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1577, 44));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1455, 904));
        }

        private void CreateObjects2()
        {
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 155, 179));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 992, 442));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1602, 305));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 373, 742));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 959, 799));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1245, 910));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1526, 695));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1885, 926));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 604, 1135));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 679, 997));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1240, 995));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1323, 1160));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 325, 1384));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 365, 1035));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 175, 723));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 852, 727));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 690, 914));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1088, 410));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 503, 638));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1218, 621));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 921, 362));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 455, 191));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 57, 260));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 329, 45));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 913, 90));
            eatObjects.Add(new EatObject(EatObjectStatus.GoodWeppon, 1201, 49));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1506, 41));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1871, 171));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1693, 293));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1619, 727));

        }

        private void CreateObjects3()
        {
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 178, 119));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 673, 428));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1507, 132));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 245, 445));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1874, 665));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1736, 913));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1045, 768));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 247, 770));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 343, 995));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1246, 995));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1452, 1003));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1771, 1268));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 706, 292));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 251, 349));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 150, 36));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 166, 673));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1132, 1026));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1026, 909));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1452, 162));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 819, 527));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 600, 755));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1335, 223));
            eatObjects.Add(new EatObject(EatObjectStatus.GoodWeppon, 1716, 52));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1858, 572));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1688, 450));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1562, 1026));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 957, 1388));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1351, 1290));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 194, 1116));
        }

        private void CreateObjects4()
        {
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1883, 445));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1313, 45));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1086, 258));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 868, 239));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 605, 30));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 49, 444));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 887, 764));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1583, 638));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1871, 772));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1533, 996));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 674, 998));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 586, 1236));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 51, 1169));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1100, 431));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1096, 167));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 800, 253));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 873, 435));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 788, 752));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1104, 902));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1197, 549));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1843, 699));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1567, 748));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1713, 829));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1644, 1166));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 824, 1352));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1295, 1056));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 873, 1190));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 390, 1389));
            eatObjects.Add(new EatObject(EatObjectStatus.GoodWeppon, 361, 1093));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 264, 1020));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 146, 1243));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 43, 52));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 195, 324));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 357, 176));
        }

        private void CreateObjects5()
        {
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 232, 330));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 596, 133));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 955, 342));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1208, 445));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1315, 325));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1344, 455));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1890, 32));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1599, 1131));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 1058, 740));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 399, 823));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 135, 1244));
            eatObjects.Add(new EatObject(EatObjectStatus.Flag, 867, 1169));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 296, 1147));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 824, 1208));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1213, 1009));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 450, 1029));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 836, 1013));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1204, 1301));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1631, 1025));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1396, 1382));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1700, 1131));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1323, 652));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1717, 721));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1493, 530));
            eatObjects.Add(new EatObject(EatObjectStatus.GoodWeppon, 1713, 266));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 450, 1029));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1867, 1021));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1704, 575));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1859, 311));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1385, 43));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 1084, 420));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1879, 907));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 1473, 153));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 690, 148));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 381, 424));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 110, 627));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 820, 311));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 487, 120));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 227, 802));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 868, 648));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 69, 907));
            eatObjects.Add(new EatObject(EatObjectStatus.Weppon, 528, 725));
            eatObjects.Add(new EatObject(EatObjectStatus.Life, 491, 591));
        }
    }
}
