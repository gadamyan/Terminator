using System;
using System.Collections.Generic;
using System.Text;

namespace Terminator
{
    class WallCreater
    {
        List<Wall> walls;

        internal List<Wall> Walls
        {
            get { return walls; }
        }

        public WallCreater(int i)
        {
            walls = new List<Wall>();

            walls.Add(new Wall(true,0, 0, 10, 1440));
            walls.Add(new Wall(true,1910, 0, 1920, 1440));
            walls.Add(new Wall(true,10, 0, 1910, 10));
            walls.Add(new Wall(true,10, 1430, 1910, 1440));

            switch (i)
            {
                case 1: CreateWalls1(); break;
                case 2: CreateWalls2(); break;
                case 3: CreateWalls3(); break;
                case 4: CreateWalls4(); break;
                case 5: CreateWalls5(); break;
                default: break;
            }
        }

        private void CreateWalls1()
        {
            #region WallsCreatingI
            walls.Add(new Wall(103, 77, 30, 134));
            walls.Add(new Wall(307, 129, 380, 30));
            walls.Add(new Wall(164, 368, 30, 196));
            walls.Add(new Wall(287, 285, 215, 30));
            walls.Add(new Wall(474, 368, 30, 196));
            walls.Add(new Wall(640, 206, 30, 392));
            walls.Add(new Wall(716, 387, 123, 30));
            walls.Add(new Wall(556, 481, 1091, 30));
            walls.Add(new Wall(640, 573, 30, 155));
            walls.Add(new Wall(371, 659, 30, 158));
            walls.Add(new Wall(371, 753, 509, 30));
            walls.Add(new Wall(813, 770, 30, 350));
            walls.Add(new Wall(640, 1028, 30, 581));
            walls.Add(new Wall(284, 960, 549, 30));
            walls.Add(new Wall(1219, 960, 1127, 30));
            walls.Add(new Wall(828, 1253, 30, 354));
            walls.Add(new Wall(443, 1268, 30, 324));
            walls.Add(new Wall(265, 1121, 325, 30));
            walls.Add(new Wall(118, 1234, 30, 196));
            walls.Add(new Wall(216, 1317, 166, 30));
            walls.Add(new Wall(876, 368, 30, 196));
            walls.Add(new Wall(1013, 285, 245, 30));
            walls.Add(new Wall(1142, 115, 245, 30));
            walls.Add(new Wall(1280, 478, 30, 935));
            walls.Add(new Wall(1217, 480, 97, 30));
            walls.Add(new Wall(1280, 478, 30, 935));
            walls.Add(new Wall(1183, 630, 30, 270));
            walls.Add(new Wall(1087, 678, 30, 365));
            walls.Add(new Wall(1018, 846, 108, 30));
            walls.Add(new Wall(1061, 1151, 30, 353));
            walls.Add(new Wall(1280, 1244, 30, 371));
            walls.Add(new Wall(1422, 1157, 30, 364));
            walls.Add(new Wall(1616, 1324, 359, 30));
            walls.Add(new Wall(1731, 1152, 358, 30));
            walls.Add(new Wall(1880, 960, 59, 30));
            walls.Add(new Wall(1473, 853, 221, 30));
            walls.Add(new Wall(1808, 790, 204, 30));
            walls.Add(new Wall(1426, 514, 30, 437));
            walls.Add(new Wall(1598, 556, 30, 778));
            walls.Add(new Wall(1723, 480, 219, 30));
            walls.Add(new Wall(1497, 280, 173, 30));
            walls.Add(new Wall(1598, 152, 414, 30));
            #endregion
        }

        private void CreateWalls2()
        {
            #region WallsCreatingII
            walls.Add(new Wall(119, 278, 30, 238));
            walls.Add(new Wall(684, 144, 1161, 30));
            walls.Add(new Wall(787, 294, 454, 30));
            walls.Add(new Wall(479, 372, 30, 186));
            walls.Add(new Wall(1028, 372, 30, 186));
            walls.Add(new Wall(585, 480, 1151, 30));
            walls.Add(new Wall(119, 659, 30, 210));
            walls.Add(new Wall(407, 675, 30, 180));
            walls.Add(new Wall(640, 585, 30, 180));
            walls.Add(new Wall(786, 694, 30, 257));
            walls.Add(new Wall(996, 674, 30, 358));
            walls.Add(new Wall(876, 838, 210, 30));
            walls.Add(new Wall(364, 780, 521, 30));
            walls.Add(new Wall(960, 960, 610, 30));
            walls.Add(new Wall(285, 960, 550, 30));
            walls.Add(new Wall(640, 1053, 30, 576));
            walls.Add(new Wall(114, 1234, 30, 240));
            walls.Add(new Wall(362, 1099, 526, 30));
            walls.Add(new Wall(380, 1311, 30, 238));
            walls.Add(new Wall(975, 1325, 30, 210));
            walls.Add(new Wall(1095, 1235, 210, 30));
            walls.Add(new Wall(1280, 779, 30, 1301));
            walls.Add(new Wall(1567, 1337, 395, 30));
            walls.Add(new Wall(1779, 1243, 30, 218));
            walls.Add(new Wall(1545, 1119, 499, 30));
            walls.Add(new Wall(1649, 960, 523, 30));
            walls.Add(new Wall(1560, 762, 30, 174));
            walls.Add(new Wall(1174, 673, 181, 30));
            walls.Add(new Wall(1560, 660, 531, 30));
            walls.Add(new Wall(1637, 480, 547, 30));
            walls.Add(new Wall(1707, 339, 261, 30));
            walls.Add(new Wall(1561, 182, 30, 344));
            walls.Add(new Wall(1822, 221, 30, 207));
            #endregion
        }

        private void CreateWalls3()
        {
            #region WallsCreatingIII
            walls.Add(new Wall(299, 84, 455, 30));
            walls.Add(new Wall(640, 110, 30, 199));
            walls.Add(new Wall(925, 142, 30, 134));
            walls.Add(new Wall(747, 224, 895, 30));
            walls.Add(new Wall(923, 342, 535, 30));
            walls.Add(new Wall(640, 396, 30, 138));
            walls.Add(new Wall(211, 459, 30, 722));
            walls.Add(new Wall(1280, 321, 30, 621));
            walls.Add(new Wall(1469, 386, 121, 30));
            walls.Add(new Wall(1394, 371, 30, 515));
            walls.Add(new Wall(1493, 98, 229, 30));
            walls.Add(new Wall(1623, 399, 30, 631));
            walls.Add(new Wall(1776, 399, 30, 629));
            walls.Add(new Wall(1850, 699, 119, 30));
            walls.Add(new Wall(1467, 729, 343, 30));
            walls.Add(new Wall(1777, 829, 121, 30));
            walls.Add(new Wall(1701, 879, 30, 131));
            walls.Add(new Wall(1280, 1035, 30, 643));
            walls.Add(new Wall(1080, 681, 30, 219));
            walls.Add(new Wall(678, 805, 903, 30));
            walls.Add(new Wall(770, 606, 30, 222));
            walls.Add(new Wall(529, 676, 30, 230));
            walls.Add(new Wall(746, 480, 1039, 30));
            walls.Add(new Wall(67, 480, 115, 30));
            walls.Add(new Wall(138, 724, 117, 30));
            walls.Add(new Wall(637, 960, 1255, 30));
            walls.Add(new Wall(1418, 1062, 30, 174));
            walls.Add(new Wall(1656, 960, 507, 30));
            walls.Add(new Wall(1806, 1194, 30, 280));
            walls.Add(new Wall(1543, 1233, 496, 30));
            walls.Add(new Wall(1033, 1246, 30, 367));
            walls.Add(new Wall(839, 1166, 30, 382));
            walls.Add(new Wall(640, 1242, 30, 376));
            walls.Add(new Wall(379, 1025, 30, 99));
            walls.Add(new Wall(144, 1203, 30, 314));
            walls.Add(new Wall(392, 1158, 466, 30));
            walls.Add(new Wall(351, 1345, 383, 30));
            #endregion
        }

        private void CreateWalls4()
        {
            #region WallsCreatingIV
            walls.Add(new Wall(152, 298, 30, 393));
            walls.Add(new Wall(73, 480, 127, 30));
            walls.Add(new Wall(301, 438, 30, 668));
            walls.Add(new Wall(434, 229, 237, 30));
            walls.Add(new Wall(529, 495, 193, 30));
            walls.Add(new Wall(447, 595, 30, 170));
            walls.Add(new Wall(356, 787, 538, 30));
            walls.Add(new Wall(321, 960, 473, 30));
            walls.Add(new Wall(314, 1202, 30, 455));
            walls.Add(new Wall(93, 1133, 166, 30));
            walls.Add(new Wall(191, 1233, 30, 229));
            walls.Add(new Wall(447, 1155, 30, 199));
            walls.Add(new Wall(529, 1270, 193, 30));
            walls.Add(new Wall(640, 682, 30, 1344));
            walls.Add(new Wall(1797, 272, 30, 387));
            walls.Add(new Wall(1606, 285, 205, 30));
            walls.Add(new Wall(1519, 382, 30, 165));
            walls.Add(new Wall(1497, 128, 404, 30));
            walls.Add(new Wall(1280, 204, 30, 387));
            walls.Add(new Wall(1137, 222, 144, 30));
            walls.Add(new Wall(1050, 269, 30, 391));
            walls.Add(new Wall(876, 89, 318, 30));
            walls.Add(new Wall(772, 203, 234, 30));
            walls.Add(new Wall(904, 276, 30, 177));
            walls.Add(new Wall(804, 350, 170, 30));
            walls.Add(new Wall(1314, 480, 1191, 30));
            walls.Add(new Wall(736, 671, 30, 223));
            walls.Add(new Wall(818, 798, 193, 30));
            walls.Add(new Wall(929, 654, 30, 318));
            walls.Add(new Wall(1163, 766, 30, 358));
            walls.Add(new Wall(1390, 602, 424, 30));
            walls.Add(new Wall(1431, 823, 344, 30));
            walls.Add(new Wall(1617, 712, 30, 251));
            walls.Add(new Wall(1795, 681, 30, 222));
            walls.Add(new Wall(1845, 807, 130, 30));
            walls.Add(new Wall(1244, 960, 1179, 30));
            walls.Add(new Wall(1567, 1098, 30, 246));
            walls.Add(new Wall(1244, 1058, 30, 165));
            walls.Add(new Wall(927, 1139, 30, 165));
            walls.Add(new Wall(1272, 1236, 1066, 30));
            #endregion
        }

        private void CreateWalls5()
        {
            #region WallsCreatingV
            walls.Add(new Wall(107, 251, 30, 259));
            walls.Add(new Wall(190, 366, 137, 30));
            walls.Add(new Wall(274, 195, 30, 371));
            walls.Add(new Wall(456, 182, 154, 30));
            walls.Add(new Wall(548, 234, 30, 299));
            walls.Add(new Wall(658, 99, 189, 30));
            walls.Add(new Wall(640, 290, 30, 351));
            walls.Add(new Wall(869, 245, 30, 232));
            walls.Add(new Wall(863, 376, 252, 30));
            walls.Add(new Wall(1004, 200, 30, 381));
            walls.Add(new Wall(1153, 282, 30, 366));
            walls.Add(new Wall(678, 480, 1173, 30));
            walls.Add(new Wall(165, 706, 30, 275));
            walls.Add(new Wall(290, 858, 281, 30));
            walls.Add(new Wall(445, 684, 30, 378));
            walls.Add(new Wall(569, 786, 217, 30));
            walls.Add(new Wall(777, 755, 30, 381));
            walls.Add(new Wall(987, 705, 390, 30));
            walls.Add(new Wall(1022, 796, 30, 153));
            walls.Add(new Wall(1280, 732, 30, 1266));
            walls.Add(new Wall(1548, 64, 30, 108));
            walls.Add(new Wall(1560, 210, 531, 30));
            walls.Add(new Wall(1660, 502, 30, 555));
            walls.Add(new Wall(1539, 554, 30, 496));
            walls.Add(new Wall(1410, 421, 229, 30));
            walls.Add(new Wall(1372, 705, 154, 30));
            walls.Add(new Wall(1737, 794, 184, 30));
            walls.Add(new Wall(1641, 960, 538, 30));
            walls.Add(new Wall(1359, 1181, 127, 30));
            walls.Add(new Wall(1638, 1085, 192, 30));
            walls.Add(new Wall(1749, 1201, 30, 262));
            walls.Add(new Wall(1528, 1250, 30, 360));
            walls.Add(new Wall(638, 960, 1255, 30));
            walls.Add(new Wall(1143, 1350, 243, 30));
            walls.Add(new Wall(975, 1132, 374, 30));
            walls.Add(new Wall(922, 1288, 30, 283));
            walls.Add(new Wall(773, 1242, 30, 250));
            walls.Add(new Wall(640, 1245, 30, 370));
            walls.Add(new Wall(388, 1051, 30, 152));
            walls.Add(new Wall(97, 1222, 30, 285));
            walls.Add(new Wall(369, 1206, 513, 30));
            walls.Add(new Wall(434, 1363, 30, 134));
            walls.Add(new Wall(503, 1311, 109, 30));
            #endregion
        }
    }
}
