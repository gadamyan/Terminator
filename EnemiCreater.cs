using System;
using System.Collections.Generic;
using System.Text;

namespace Terminator
{
    class EnemiCreater
    {
        List<Enemi> enemis;
        List<Wall> walls;
        internal List<Enemi> Enemis
        {
            get { return enemis; }
        }

        public EnemiCreater(int i,List<Wall> walls)
        {
            this.walls = walls;
            enemis = new List<Enemi>();
            switch (i)
            {
                case 1: CreateEnemis1(); break;
                case 2: CreateEnemis2(); break;
                case 3: CreateEnemis3(); break;
                case 4: CreateEnemis4(); break;
                case 5: CreateEnemis5(); break;
                default: break;
            }
        }

        private void CreateEnemis1()
        {
            #region CrieatingEnemis
            enemis.Add(new EnemiConfig(50, 49, walls, 1));
            enemis.Add(new EnemiConfig(59, 428, walls, 2));
            enemis.Add(new EnemiConfig(229, 45, walls, 3));
            enemis.Add(new EnemiConfig(578, 219, walls, 1));
            enemis.Add(new EnemiConfig(732, 234, walls, 1));
            enemis.Add(new EnemiConfig(956, 368, walls, 2));
            enemis.Add(new EnemiConfig(1195, 55, walls, 3));
            enemis.Add(new EnemiConfig(1235, 578, walls, 2));
            enemis.Add(new EnemiConfig(891, 906, walls, 1));
            enemis.Add(new EnemiConfig(896, 553, walls, 1));
            enemis.Add(new EnemiConfig(737, 872, walls, 3));
            enemis.Add(new EnemiConfig(498, 602, walls, 1));
            enemis.Add(new EnemiConfig(199, 688, walls, 3));
            enemis.Add(new EnemiConfig(164, 817, walls, 2));
            enemis.Add(new EnemiConfig(523, 901, walls, 1));
            enemis.Add(new EnemiConfig(219, 1071, walls, 2));
            enemis.Add(new EnemiConfig(179, 1226, walls, 3));
            enemis.Add(new EnemiConfig(563, 1210, walls, 1));
            enemis.Add(new EnemiConfig(752, 1096, walls, 2));
            enemis.Add(new EnemiConfig(926, 1021, walls, 1));
            enemis.Add(new EnemiConfig(986, 1395, walls, 1));
            enemis.Add(new EnemiConfig(1200, 1101, walls, 3));
            enemis.Add(new EnemiConfig(1355, 1220, walls, 1));
            enemis.Add(new EnemiConfig(1654, 1385, walls, 1));
            enemis.Add(new EnemiConfig(1644, 1245, walls, 2));
            enemis.Add(new EnemiConfig(1689, 1036, walls, 3));
            enemis.Add(new EnemiConfig(1654, 852, walls, 1));
            enemis.Add(new EnemiConfig(1788, 578, walls, 2));
            enemis.Add(new EnemiConfig(1649, 269, walls, 3));
            enemis.Add(new EnemiConfig(1585, 44, walls, 1));
            enemis.Add(new EnemiConfig(1534, 209, walls, 2));
            enemis.Add(new EnemiConfig(1360, 617, walls, 1));
            enemis.Add(new EnemiConfig(1539, 901, walls, 2));
            enemis.Add(new EnemiConfig(1490, 427, walls, 4));
            ///////////////////////////////
            enemis.Add(new EnemiConfig(271, 207, walls, 1));
            enemis.Add(new EnemiConfig(585, 49, walls, 2));
            enemis.Add(new EnemiConfig(906, 70, walls, 1));
            enemis.Add(new EnemiConfig(824, 435, walls, 2));
            enemis.Add(new EnemiConfig(1226, 216, walls, 2));
            enemis.Add(new EnemiConfig(1135, 641, walls, 1));
            enemis.Add(new EnemiConfig(1234, 910, walls, 3));
            enemis.Add(new EnemiConfig(698, 536, walls, 2));
            enemis.Add(new EnemiConfig(56, 544, walls, 1));
            enemis.Add(new EnemiConfig(382, 532, walls, 2));
            enemis.Add(new EnemiConfig(44, 913, walls, 1));
            enemis.Add(new EnemiConfig(597, 824, walls, 2));
            enemis.Add(new EnemiConfig(390, 1202, walls, 2));
            enemis.Add(new EnemiConfig(381, 1392, walls, 1));
            enemis.Add(new EnemiConfig(40, 1376, walls, 1));
            enemis.Add(new EnemiConfig(44, 1059, walls, 1));
            enemis.Add(new EnemiConfig(637, 1388, walls, 2));
            enemis.Add(new EnemiConfig(778, 1400, walls, 1));
            enemis.Add(new EnemiConfig(966, 1230, walls, 2));
            enemis.Add(new EnemiConfig(1372, 1015, walls, 2));
            enemis.Add(new EnemiConfig(1237, 1339, walls, 1));
            enemis.Add(new EnemiConfig(1498, 1381, walls, 3));
            enemis.Add(new EnemiConfig(1874, 1262, walls, 1));
            enemis.Add(new EnemiConfig(1517, 1197, walls, 1));
            enemis.Add(new EnemiConfig(1878, 1091, walls, 1));
            enemis.Add(new EnemiConfig(1770, 740, walls, 3));
            enemis.Add(new EnemiConfig(1870, 852, walls, 1));
            enemis.Add(new EnemiConfig(1781, 418, walls, 1));
            enemis.Add(new EnemiConfig(1871, 78, walls, 2));
            enemis.Add(new EnemiConfig(1437, 50, walls, 3));
            enemis.Add(new EnemiConfig(1338, 215, walls, 1));
            enemis.Add(new EnemiConfig(1356, 439, walls, 2));
            enemis.Add(new EnemiConfig(1546, 658, walls, 3));
            enemis.Add(new EnemiConfig(1493, 807, walls, 1));
            #endregion
        }

        private void CreateEnemis2()
        {
            #region CrieatingEnemis
            enemis.Add(new EnemiConfig(1112, 1175, walls, 1));
            enemis.Add(new EnemiConfig(917, 1375, walls, 1));
            enemis.Add(new EnemiConfig(693, 1031, walls, 2));
            enemis.Add(new EnemiConfig(340, 1155, walls, 3));
            enemis.Add(new EnemiConfig(614, 1390, walls, 1));
            enemis.Add(new EnemiConfig(544, 1155, walls, 2));
            enemis.Add(new EnemiConfig(325, 1390, walls, 2));
            enemis.Add(new EnemiConfig(61, 1200, walls, 1));
            enemis.Add(new EnemiConfig(345, 1041, walls, 3));
            enemis.Add(new EnemiConfig(409, 886, walls, 4));
            enemis.Add(new EnemiConfig(71, 871, walls, 1));
            enemis.Add(new EnemiConfig(265, 712, walls, 2));
            enemis.Add(new EnemiConfig(529, 667, walls, 3));
            enemis.Add(new EnemiConfig(698, 558, walls, 1));
            enemis.Add(new EnemiConfig(937, 782, walls, 4));
            enemis.Add(new EnemiConfig(878, 896, walls, 1));
            enemis.Add(new EnemiConfig(1221, 737, walls, 2));
            enemis.Add(new EnemiConfig(1206, 602, walls, 1));
            enemis.Add(new EnemiConfig(1221, 264, walls, 2));
            enemis.Add(new EnemiConfig(793, 209, walls, 1));
            enemis.Add(new EnemiConfig(609, 403, walls, 2));
            enemis.Add(new EnemiConfig(972, 423, walls, 3));
            enemis.Add(new EnemiConfig(180, 229, walls, 3));
            enemis.Add(new EnemiConfig(46, 209, walls, 1));
            enemis.Add(new EnemiConfig(494, 79, walls, 2));
            enemis.Add(new EnemiConfig(1022, 89, walls, 1));
            enemis.Add(new EnemiConfig(1421, 274, walls, 3));
            enemis.Add(new EnemiConfig(1769, 408, walls, 2));
            enemis.Add(new EnemiConfig(1869, 244, walls, 1));
            enemis.Add(new EnemiConfig(1650, 279, walls, 4));
            enemis.Add(new EnemiConfig(1341, 577, walls, 1));
            enemis.Add(new EnemiConfig(1839, 543, walls, 3));
            enemis.Add(new EnemiConfig(1660, 722, walls, 2));
            enemis.Add(new EnemiConfig(1495, 727, walls, 3));
            enemis.Add(new EnemiConfig(1484, 1027, walls, 3));
            enemis.Add(new EnemiConfig(1832, 1020, walls, 1));
            enemis.Add(new EnemiConfig(1854, 1294, walls, 2));
            enemis.Add(new EnemiConfig(1596, 1394, walls, 3));
            enemis.Add(new EnemiConfig(1670, 1175, walls, 4));
            /////////////////////////
            enemis.Add(new EnemiConfig(738, 1234, walls, 3));
            enemis.Add(new EnemiConfig(1228, 1011, walls, 2));
            enemis.Add(new EnemiConfig(908, 1010, walls, 1));
            enemis.Add(new EnemiConfig(439, 1319, walls, 4));
            enemis.Add(new EnemiConfig(166, 1250, walls, 1));
            enemis.Add(new EnemiConfig(59, 1385, walls, 2));
            enemis.Add(new EnemiConfig(159, 1022, walls, 4));
            enemis.Add(new EnemiConfig(592, 970, walls, 2));
            enemis.Add(new EnemiConfig(267, 836, walls, 3));
            enemis.Add(new EnemiConfig(52, 706, walls, 3));
            enemis.Add(new EnemiConfig(289, 568, walls, 4));
            enemis.Add(new EnemiConfig(59, 549, walls, 2));
            enemis.Add(new EnemiConfig(584, 532, walls, 1));
            enemis.Add(new EnemiConfig(717, 723, walls, 2));
            enemis.Add(new EnemiConfig(841, 592, walls, 4));
            enemis.Add(new EnemiConfig(795, 889, walls, 3));
            enemis.Add(new EnemiConfig(1158, 905, walls, 4));
            enemis.Add(new EnemiConfig(1051, 596, walls, 3));
            enemis.Add(new EnemiConfig(1010, 199, walls, 3));
            enemis.Add(new EnemiConfig(1155, 411, walls, 2));
            enemis.Add(new EnemiConfig(836, 349, walls, 2));
            enemis.Add(new EnemiConfig(663, 199, walls, 4));
            enemis.Add(new EnemiConfig(385, 199, walls, 2));
            enemis.Add(new EnemiConfig(42, 385, walls, 4));
            enemis.Add(new EnemiConfig(296, 361, walls, 1));
            enemis.Add(new EnemiConfig(85, 57, walls, 3));
            enemis.Add(new EnemiConfig(320, 61, walls, 2));
            enemis.Add(new EnemiConfig(890, 73, walls, 4));
            enemis.Add(new EnemiConfig(1302, 57, walls, 3));
            enemis.Add(new EnemiConfig(1563, 418, walls, 4));
            enemis.Add(new EnemiConfig(1874, 49, walls, 3));
            enemis.Add(new EnemiConfig(1609, 49, walls, 2));
            enemis.Add(new EnemiConfig(1584, 577, walls, 2));
            enemis.Add(new EnemiConfig(1856, 901, walls, 4));
            enemis.Add(new EnemiConfig(1655, 893, walls, 3));
            enemis.Add(new EnemiConfig(1335, 726, walls, 2));
            enemis.Add(new EnemiConfig(1424, 885, walls, 2));
            enemis.Add(new EnemiConfig(1645, 1018, walls, 4));
            enemis.Add(new EnemiConfig(1360, 1392, walls, 4));
            enemis.Add(new EnemiConfig(1850, 1165, walls, 2));
            enemis.Add(new EnemiConfig(1728, 1286, walls, 3));
            enemis.Add(new EnemiConfig(1339, 1254, walls, 2));
            #endregion
        }

        private void CreateEnemis3()
        {
            #region CrieatingEnemis
            enemis.Add(new EnemiConfig(986, 137, walls, 3));
            enemis.Add(new EnemiConfig(1230, 251, walls, 1));
            enemis.Add(new EnemiConfig(731, 407, walls, 4));
            enemis.Add(new EnemiConfig(738, 277, walls, 2));
            enemis.Add(new EnemiConfig(571, 411, walls, 4));
            enemis.Add(new EnemiConfig(268, 423, walls, 2));
            enemis.Add(new EnemiConfig(430, 155, walls, 3));
            enemis.Add(new EnemiConfig(422, 39, walls, 1));
            enemis.Add(new EnemiConfig(119, 39, walls, 1));
            enemis.Add(new EnemiConfig(126, 301, walls, 4));
            enemis.Add(new EnemiConfig(101, 579, walls, 2));
            enemis.Add(new EnemiConfig(89, 835, walls, 3));
            enemis.Add(new EnemiConfig(528, 884, walls, 4));
            enemis.Add(new EnemiConfig(976, 878, walls, 2));
            enemis.Add(new EnemiConfig(1218, 900, walls, 1));
            enemis.Add(new EnemiConfig(1138, 650, walls, 2));
            enemis.Add(new EnemiConfig(1014, 745, walls, 3));
            enemis.Add(new EnemiConfig(682, 624, walls, 3));
            enemis.Add(new EnemiConfig(314, 610, walls, 4));
            enemis.Add(new EnemiConfig(1392, 671, walls, 1));
            enemis.Add(new EnemiConfig(1524, 513, walls, 2));
            enemis.Add(new EnemiConfig(1452, 162, walls, 4));
            enemis.Add(new EnemiConfig(1134, 427, walls, 1));
            enemis.Add(new EnemiConfig(1488, 53, walls, 1));
            enemis.Add(new EnemiConfig(1853, 230, walls, 3));
            enemis.Add(new EnemiConfig(1855, 631, walls, 4));
            enemis.Add(new EnemiConfig(1711, 235, walls, 2));
            enemis.Add(new EnemiConfig(1708, 588, walls, 1));
            enemis.Add(new EnemiConfig(1772, 892, walls, 4));
            enemis.Add(new EnemiConfig(1500, 844, walls, 3));
            enemis.Add(new EnemiConfig(1351, 1078, walls, 1));
            enemis.Add(new EnemiConfig(1536, 1064, walls, 3));
            enemis.Add(new EnemiConfig(1873, 1190, walls, 2));
            enemis.Add(new EnemiConfig(1585, 1316, walls, 4));
            enemis.Add(new EnemiConfig(1218, 1384, walls, 3));
            enemis.Add(new EnemiConfig(1142, 1044, walls, 2));
            enemis.Add(new EnemiConfig(933, 1212, walls, 4));
            enemis.Add(new EnemiConfig(765, 1386, walls, 1));
            enemis.Add(new EnemiConfig(702, 1103, walls, 2));
            enemis.Add(new EnemiConfig(516, 1068, walls, 3));
            enemis.Add(new EnemiConfig(256, 1083, walls, 4));
            enemis.Add(new EnemiConfig(60, 1228, walls, 1));
            enemis.Add(new EnemiConfig(383, 1398, walls, 1));
            enemis.Add(new EnemiConfig(325, 1246, walls, 5));
            /////////////////////////
            enemis.Add(new EnemiConfig(1147, 56, walls, 4));
            enemis.Add(new EnemiConfig(1066, 409, walls, 2));
            enemis.Add(new EnemiConfig(944, 288, walls, 3));
            enemis.Add(new EnemiConfig(400, 291, walls, 3));
            enemis.Add(new EnemiConfig(579, 154, walls, 2));
            enemis.Add(new EnemiConfig(277, 38, walls, 4));
            enemis.Add(new EnemiConfig(50, 190, walls, 3));
            enemis.Add(new EnemiConfig(311, 885, walls, 2));
            enemis.Add(new EnemiConfig(776, 884, walls, 3));
            enemis.Add(new EnemiConfig(845, 542, walls, 4));
            enemis.Add(new EnemiConfig(443, 720, walls, 4));
            enemis.Add(new EnemiConfig(778, 755, walls, 2));
            enemis.Add(new EnemiConfig(1559, 306, walls, 4));
            enemis.Add(new EnemiConfig(1340, 85, walls, 3));
            enemis.Add(new EnemiConfig(1338, 296, walls, 2));
            enemis.Add(new EnemiConfig(1701, 436, walls, 4));
            enemis.Add(new EnemiConfig(1849, 410, walls, 2));
            enemis.Add(new EnemiConfig(1868, 762, walls, 3));
            enemis.Add(new EnemiConfig(1638, 901, walls, 2));
            enemis.Add(new EnemiConfig(1653, 1159, walls, 4));
            enemis.Add(new EnemiConfig(1872, 1046, walls, 3));
            enemis.Add(new EnemiConfig(1811, 1391, walls, 3));
            enemis.Add(new EnemiConfig(1434, 1382, walls, 4));
            enemis.Add(new EnemiConfig(1148, 1203, walls, 4));
            enemis.Add(new EnemiConfig(920, 1392, walls, 2));
            enemis.Add(new EnemiConfig(922, 1059, walls, 3));
            enemis.Add(new EnemiConfig(723, 1237, walls, 3));
            enemis.Add(new EnemiConfig(634, 1018, walls, 3));
            enemis.Add(new EnemiConfig(52, 1051, walls, 2));
            enemis.Add(new EnemiConfig(66, 1386, walls, 4));
            enemis.Add(new EnemiConfig(561, 1394, walls, 4));
            enemis.Add(new EnemiConfig(484, 1276, walls, 4));
            enemis.Add(new EnemiConfig(244, 1395, walls, 3));
            
            #endregion
        }

        private void CreateEnemis4()
        {
            #region CrieatingEnemis
            enemis.Add(new EnemiConfig(1855, 420, walls, 4));
            enemis.Add(new EnemiConfig(1337, 63, walls, 5));
            enemis.Add(new EnemiConfig(1541, 198, walls, 1));
            enemis.Add(new EnemiConfig(1406, 352, walls, 3));
            enemis.Add(new EnemiConfig(1112, 282, walls, 2));
            enemis.Add(new EnemiConfig(897, 42, walls, 1));
            enemis.Add(new EnemiConfig(968, 146, walls, 3));
            enemis.Add(new EnemiConfig(691, 420, walls, 2));
            enemis.Add(new EnemiConfig(848, 256, walls, 5));
            enemis.Add(new EnemiConfig(689, 736, walls, 1));
            enemis.Add(new EnemiConfig(815, 712, walls, 5));
            enemis.Add(new EnemiConfig(807, 860, walls, 2));
            enemis.Add(new EnemiConfig(1073, 736, walls, 4));
            enemis.Add(new EnemiConfig(1346, 541, walls, 3));
            enemis.Add(new EnemiConfig(1717, 683, walls, 4));
            enemis.Add(new EnemiConfig(1857, 754, walls, 5));
            enemis.Add(new EnemiConfig(1330, 898, walls, 2));
            enemis.Add(new EnemiConfig(1554, 658, walls, 5));
            enemis.Add(new EnemiConfig(1675, 1077, walls, 4));
            enemis.Add(new EnemiConfig(1857, 1246, walls, 2));
            enemis.Add(new EnemiConfig(1566, 1379, walls, 3));
            enemis.Add(new EnemiConfig(1225, 1317, walls, 1));
            enemis.Add(new EnemiConfig(853, 1375, walls, 2));
            enemis.Add(new EnemiConfig(839, 1151, walls, 3));
            enemis.Add(new EnemiConfig(1119, 1148, walls, 4));
            enemis.Add(new EnemiConfig(1413, 1020, walls, 5));
            enemis.Add(new EnemiConfig(510, 1354, walls, 1));
            enemis.Add(new EnemiConfig(565, 1201, walls, 3));
            enemis.Add(new EnemiConfig(475, 902, walls, 2));
            enemis.Add(new EnemiConfig(154, 902, walls, 3));
            enemis.Add(new EnemiConfig(257, 1076, walls, 1));
            enemis.Add(new EnemiConfig(72, 1219, walls, 5));
            enemis.Add(new EnemiConfig(243, 562, walls, 4));
            enemis.Add(new EnemiConfig(64, 347, walls, 5));
            enemis.Add(new EnemiConfig(588, 168, walls, 3));
            enemis.Add(new EnemiConfig(487, 345, walls, 2));
            enemis.Add(new EnemiConfig(378, 565, walls, 1));
            enemis.Add(new EnemiConfig(384, 551, walls, 6));
            ///////////////////////////
            enemis.Add(new EnemiConfig(1332, 192, walls, 4));
            enemis.Add(new EnemiConfig(1870, 87, walls, 2));
            enemis.Add(new EnemiConfig(1199, 423, walls, 3));
            enemis.Add(new EnemiConfig(1116, 143, walls, 4));
            enemis.Add(new EnemiConfig(1207, 45, walls, 3));
            enemis.Add(new EnemiConfig(972, 376, walls, 5));
            enemis.Add(new EnemiConfig(731, 146, walls, 2));
            enemis.Add(new EnemiConfig(869, 544, walls, 2));
            enemis.Add(new EnemiConfig(712, 906, walls, 3));
            enemis.Add(new EnemiConfig(999, 882, walls, 4));
            enemis.Add(new EnemiConfig(1046, 550, walls, 5));
            enemis.Add(new EnemiConfig(1620, 552, walls, 2));
            enemis.Add(new EnemiConfig(1848, 536, walls, 3));
            enemis.Add(new EnemiConfig(1344, 663, walls, 4));
            enemis.Add(new EnemiConfig(1500, 894, walls, 4));
            enemis.Add(new EnemiConfig(1759, 889, walls, 3));
            enemis.Add(new EnemiConfig(1856, 1064, walls, 3));
            enemis.Add(new EnemiConfig(1401, 1316, walls, 4));
            enemis.Add(new EnemiConfig(1029, 1366, walls, 5));
            enemis.Add(new EnemiConfig(1454, 1158, walls, 4));
            enemis.Add(new EnemiConfig(1052, 1035, walls, 2));
            enemis.Add(new EnemiConfig(700, 1133, walls, 3));
            enemis.Add(new EnemiConfig(375, 1089, walls, 4));
            enemis.Add(new EnemiConfig(386, 1331, walls, 2));
            enemis.Add(new EnemiConfig(569, 1060, walls, 2));
            enemis.Add(new EnemiConfig(319, 871, walls, 5));
            enemis.Add(new EnemiConfig(257, 1300, walls, 4));
            enemis.Add(new EnemiConfig(59, 1376, walls, 3));
            enemis.Add(new EnemiConfig(66, 1047, walls, 2));
            enemis.Add(new EnemiConfig(54, 561, walls, 3));
            enemis.Add(new EnemiConfig(152, 713, walls, 5));
            enemis.Add(new EnemiConfig(58, 156, walls, 4));
            enemis.Add(new EnemiConfig(217, 410, walls, 3));
            enemis.Add(new EnemiConfig(387, 172, walls, 4));
            enemis.Add(new EnemiConfig(516, 61, walls, 2));
            enemis.Add(new EnemiConfig(358, 290, walls, 4));
            enemis.Add(new EnemiConfig(380, 433, walls, 5));
            enemis.Add(new EnemiConfig(566, 688, walls, 5));
            enemis.Add(new EnemiConfig(383, 728, walls, 4));
            #endregion
        }

        private void CreateEnemis5()
        {
            #region CrieatingEnemis
            enemis.Add(new EnemiConfig(300, 1343, walls, 4));
            enemis.Add(new EnemiConfig(46, 1164, walls, 1));
            enemis.Add(new EnemiConfig(260, 1109, walls, 5));
            enemis.Add(new EnemiConfig(504, 1020, walls, 2));
            enemis.Add(new EnemiConfig(703, 1149, walls, 2));
            enemis.Add(new EnemiConfig(848, 1189, walls, 6));
            enemis.Add(new EnemiConfig(1107, 1030, walls, 3));
            enemis.Add(new EnemiConfig(1112, 1254, walls, 4));
            enemis.Add(new EnemiConfig(1166, 1400, walls, 1));
            enemis.Add(new EnemiConfig(1408, 1246, walls, 3));
            enemis.Add(new EnemiConfig(1332, 1068, walls, 2));
            enemis.Add(new EnemiConfig(1872, 1168, walls, 4));
            enemis.Add(new EnemiConfig(1584, 1141, walls, 6));
            enemis.Add(new EnemiConfig(1401, 852, walls, 5));
            enemis.Add(new EnemiConfig(1346, 497, walls, 6));
            enemis.Add(new EnemiConfig(1599, 599, walls, 2));
            enemis.Add(new EnemiConfig(1349, 272, walls, 6));
            enemis.Add(new EnemiConfig(1733, 708, walls, 5));
            enemis.Add(new EnemiConfig(1738, 350, walls, 4));
            enemis.Add(new EnemiConfig(1695, 127, walls, 5));
            enemis.Add(new EnemiConfig(1420, 56, walls, 3));
            enemis.Add(new EnemiConfig(1210, 426, walls, 5));
            enemis.Add(new EnemiConfig(1080, 424, walls, 2));
            enemis.Add(new EnemiConfig(872, 434, walls, 1));
            enemis.Add(new EnemiConfig(766, 238, walls, 4));
            enemis.Add(new EnemiConfig(934, 289, walls, 6));
            enemis.Add(new EnemiConfig(643, 49, walls, 3));
            enemis.Add(new EnemiConfig(444, 317, walls, 3));
            enemis.Add(new EnemiConfig(595, 177, walls, 5));
            enemis.Add(new EnemiConfig(220, 256, walls, 6));
            enemis.Add(new EnemiConfig(51, 262, walls, 2));
            enemis.Add(new EnemiConfig(83, 629, walls, 3));
            enemis.Add(new EnemiConfig(264, 541, walls, 4));
            enemis.Add(new EnemiConfig(386, 787, walls, 6));
            enemis.Add(new EnemiConfig(249, 908, walls, 1));
            enemis.Add(new EnemiConfig(565, 844, walls, 2));
            enemis.Add(new EnemiConfig(537, 683, walls, 5));
            enemis.Add(new EnemiConfig(853, 617, walls, 5));
            enemis.Add(new EnemiConfig(1224, 546, walls, 6));
            enemis.Add(new EnemiConfig(1087, 787, walls, 6));
            enemis.Add(new EnemiConfig(859, 766, walls, 6));
            /////////////////////////////
            enemis.Add(new EnemiConfig(160, 1269, walls, 5));
            enemis.Add(new EnemiConfig(53, 1394, walls, 3));
            enemis.Add(new EnemiConfig(525, 1127, walls, 6));
            enemis.Add(new EnemiConfig(167, 1025, walls, 4));
            enemis.Add(new EnemiConfig(861, 1341, walls, 4));
            enemis.Add(new EnemiConfig(700, 1346, walls, 5));
            enemis.Add(new EnemiConfig(915, 1018, walls, 5));
            enemis.Add(new EnemiConfig(992, 1200, walls, 6));
            enemis.Add(new EnemiConfig(1217, 1142, walls, 3));
            enemis.Add(new EnemiConfig(1000, 1399, walls, 5));
            enemis.Add(new EnemiConfig(1437, 1370, walls, 4));
            enemis.Add(new EnemiConfig(1836, 1018, walls, 5));
            enemis.Add(new EnemiConfig(1691, 1019, walls, 2));
            enemis.Add(new EnemiConfig(1509, 1021, walls, 3));
            enemis.Add(new EnemiConfig(1684, 1220, walls, 4));
            enemis.Add(new EnemiConfig(1665, 1383, walls, 5));
            enemis.Add(new EnemiConfig(1859, 1386, walls, 6));
            enemis.Add(new EnemiConfig(1473, 611, walls, 4));
            enemis.Add(new EnemiConfig(1595, 858, walls, 4));
            enemis.Add(new EnemiConfig(1859, 903, walls, 3));
            enemis.Add(new EnemiConfig(1802, 549, walls, 6));
            enemis.Add(new EnemiConfig(1503, 263, walls, 5));
            enemis.Add(new EnemiConfig(1599, 406, walls, 3));
            enemis.Add(new EnemiConfig(1867, 59, walls, 4));
            enemis.Add(new EnemiConfig(1460, 155, walls, 2));
            enemis.Add(new EnemiConfig(1210, 209, walls, 4));
            enemis.Add(new EnemiConfig(1151, 54, walls, 2));
            enemis.Add(new EnemiConfig(1085, 230, walls, 5));
            enemis.Add(new EnemiConfig(695, 429, walls, 5));
            enemis.Add(new EnemiConfig(759, 160, walls, 4));
            enemis.Add(new EnemiConfig(943, 64, walls, 5));
            enemis.Add(new EnemiConfig(416, 86, walls, 6));
            enemis.Add(new EnemiConfig(520, 420, walls, 4));
            enemis.Add(new EnemiConfig(333, 424, walls, 4));
            enemis.Add(new EnemiConfig(208, 76, walls, 5));
            enemis.Add(new EnemiConfig(85, 424, walls, 3));
            enemis.Add(new EnemiConfig(245, 681, walls, 6));
            enemis.Add(new EnemiConfig(57, 759, walls, 4));
            enemis.Add(new EnemiConfig(71, 896, walls, 5));
            enemis.Add(new EnemiConfig(816, 888, walls, 5));
            enemis.Add(new EnemiConfig(720, 684, walls, 4));
            enemis.Add(new EnemiConfig(568, 534, walls, 4));
            enemis.Add(new EnemiConfig(931, 884, walls, 6));
            enemis.Add(new EnemiConfig(1174, 880, walls, 6));
            enemis.Add(new EnemiConfig(1097, 636, walls, 5));
            enemis.Add(new EnemiConfig(970, 542, walls, 4));
            #endregion
        }
    }
}
