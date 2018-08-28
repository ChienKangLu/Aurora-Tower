using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace final_1
{
    static class total_monster
    {
        // //////使用者//////////
        public static AxWMPLib.AxWindowsMediaPlayer dd;
        public static Form f;
        
        public static int choose;//選擇關卡
        public static monster []monster = new monster[100];//使用者可以用的怪物
        public static monster[] monsterR = new monster[100];//關卡中的怪物
        public static Image[] pic = new Image[100];
        public static int [,]team=new int [10,5];
        public static String[,] teamn = new String[10, 2];//關卡名稱,關卡名稱
        public static Image[] back = new Image[8];
        public static int round;//總回合數
        public static int max_combo;//最多的comboo
        public static int max_attack;//最大攻擊
        public static int max_recoer;
        public static int roundaa; 
        // ///////////////////

        // ///////關卡/////////
        public static int[,] round_monster = new int[10, 6];
        // //////////////////////
        public static int six=0;
        public static Stack<int> drop = new Stack<int>();//first int last out
        public static List<int> total_card=new List<int>();
        static total_monster()
        {
            total_card.Add(0);
            total_card.Add(1);
            total_card.Add(2);
            total_card.Add(3);
            total_card.Add(4);
            total_card.Add(5);
            pic[0] = Image.FromFile("p1.png");
            pic[1] = Image.FromFile("p2.png");
            pic[2] = Image.FromFile("p3.png");
            pic[3] = Image.FromFile("p4.png");
            pic[4] = Image.FromFile("p5.png");
            pic[5] = Image.FromFile("p6.png");
            // ///////////小怪(測試)///////////
            pic[6] = Image.FromFile("p10.gif");
            pic[7] = Image.FromFile("p7.png");
            pic[8] = Image.FromFile("p8.png");
            pic[9] = Image.FromFile("p9.gif");
                      ///第一關///
            pic[10] = Image.FromFile("final\\team1\\a1.png");
            pic[11] = Image.FromFile("final\\team1\\a2.png");
            pic[12] = Image.FromFile("final\\team1\\a3.png");
            pic[13] = Image.FromFile("final\\team1\\a4.png");
            pic[14] = Image.FromFile("final\\team1\\a5.png");
            pic[15] = Image.FromFile("final\\team1\\a6.png");
            back[0] = Image.FromFile("final\\team1\\a_back.jpg");

                      ///第二關///
            pic[16] = Image.FromFile("final\\team2\\b1.png");
            pic[17] = Image.FromFile("final\\team2\\b2.png");
            pic[18] = Image.FromFile("final\\team2\\b3.png");
            pic[19] = Image.FromFile("final\\team2\\b4.png");
            pic[20] = Image.FromFile("final\\team2\\b5.png");
            pic[21] = Image.FromFile("final\\team2\\b6.png");
            back[1] = Image.FromFile("final\\team2\\b_back.jpg");
                      ///第三關///
            pic[22] = Image.FromFile("final\\team3\\c1.png");
            pic[23] = Image.FromFile("final\\team3\\c2.png");
            pic[24] = Image.FromFile("final\\team3\\c3.gif");
            pic[25] = Image.FromFile("final\\team3\\c4.png");
            pic[26] = Image.FromFile("final\\team3\\c5.png");
            pic[27] = Image.FromFile("final\\team3\\c6.png");
            back[2] = Image.FromFile("final\\team3\\c_back.jpg");
                     ///第四關///
            pic[28] = Image.FromFile("final\\team4\\d1.png");
            pic[29] = Image.FromFile("final\\team4\\d2.png");
            pic[30] = Image.FromFile("final\\team4\\d3.png");
            pic[31] = Image.FromFile("final\\team4\\d4.png");
            pic[32] = Image.FromFile("final\\team4\\d5.png");
            pic[33] = Image.FromFile("final\\team4\\d6.png");
            back[3] = Image.FromFile("final\\team4\\d_back.jpg");
                    ///第五關///
            pic[34] = Image.FromFile("final\\team5\\e1.png");
            pic[35] = Image.FromFile("final\\team5\\e2.png");
            pic[36] = Image.FromFile("final\\team5\\e3.png");
            pic[37] = Image.FromFile("final\\team5\\e4.png");
            pic[38] = Image.FromFile("final\\team5\\e5.png");
            pic[39] = Image.FromFile("final\\team5\\e6.gif");
            back[4] = Image.FromFile("final\\team5\\e_back.jpg");
                    ///第六關///
            pic[40] = Image.FromFile("final\\team6\\f1.png");
            pic[41] = Image.FromFile("final\\team6\\f2.png");
            pic[42] = Image.FromFile("final\\team6\\f3.png");
            pic[43] = Image.FromFile("final\\team6\\f4.png");
            pic[44] = Image.FromFile("final\\team6\\f5.png");
            pic[45] = Image.FromFile("final\\team6\\f6.png");
            back[5] = Image.FromFile("final\\team6\\f_back.jpg");
                    ///第七關///
            pic[46] = Image.FromFile("final\\team7\\g1.png");
            pic[47] = Image.FromFile("final\\team7\\g2.png");
            pic[48] = Image.FromFile("final\\team7\\g3.png");
            pic[49] = Image.FromFile("final\\team7\\g4.png");
            pic[50] = Image.FromFile("final\\team7\\g5.png");
            pic[51] = Image.FromFile("final\\team7\\g6.png");
            back[6] = Image.FromFile("final\\team7\\g_back.jpg");
                   ///第八關///
            pic[52] = Image.FromFile("final\\team8\\h1.png");
            pic[53] = Image.FromFile("final\\team8\\h2.png");
            pic[54] = Image.FromFile("final\\team8\\h3.png");
            pic[55] = Image.FromFile("final\\team8\\h4.png");
            pic[56] = Image.FromFile("final\\team8\\h5.png");
            pic[57] = Image.FromFile("final\\team8\\h6.png");
            back[7] = Image.FromFile("final\\team8\\h_back.jpg");
            // ///////////////////////////
            ////////////////////掉卡
            pic[58] = Image.FromFile("Bag\\wood.png");
            pic[59] = Image.FromFile("Bag\\light.png");
            pic[60] = Image.FromFile("Bag\\dark.png");
            pic[61] = Image.FromFile("Bag\\fire.png");
            pic[62] = Image.FromFile("Bag\\water.png");

            ///////////////////

            ////////////使用者可以用的怪物///////
            monster[0] = new monster("牛魔王", 0, 1, 2500, 2000, 150, 0, "光轉心",pic[0],"防禦姿勢‧光","超強攻擊",3,"全體攻擊力3倍");
            monster[1] = new monster("大石怪", 1, 2, 2504, 1400, 100, 1, "木轉心", pic[1], "防禦姿勢‧木", "超強攻擊", 3, "全體攻擊力3倍");
            monster[2] = new monster("大象", 4, 3, 1304, 2435, 50, 2, "心轉木，水轉心", pic[2], "木水轉化攻擊", "超強攻擊", 3, "全體攻擊力3倍");
            monster[3] = new monster("火焰怪牛", 3, 1, 986, 1700, 300, 3, "心轉火", pic[3], "攻擊姿勢‧火",  "超強攻擊", 3, "全體攻擊力3倍");
            monster[4] = new monster("大樹幹", 3, 2, 2210, 1878, 189, 4, "2回合內，火屬性攻擊10倍", pic[4], "神火焚城", "超強攻擊", 3, "全體攻擊力3倍");
            monster[5] = new monster("肥樹幹", 4, 4, 1408, 1800, 150, 5, "未有", pic[5],"未有","超強攻擊",3,"全體攻擊力3倍");

            monster[6] = new monster("巨刺蜈蚣", 0, 3, 100, 110, 200, 1, "木轉心", pic[10], "防禦姿勢‧木", "超強攻擊", 3, "全體攻擊力3倍");
            monster[7] = new monster("迷幻貓頭鷹", 0, 3, 100, 100, 200, 1, "木轉心", pic[11], "防禦姿勢‧木", "超強攻擊", 3, "全體攻擊力3倍");
            monster[8] = new monster("食人花", 0, 3, 100, 100, 200, 5, "暗、光轉木", pic[12], "全面啟動‧木", "超強攻擊", 3, "全體攻擊力3倍");
            monster[9] = new monster("毒菇菇", 0, 3, 100, 100, 200, 6, "水轉心", pic[13], "防禦姿勢‧水", "超強攻擊", 3, "全體攻擊力3倍");
            monster[10] = new monster("草石像", 0, 3, 100, 100, 200, 7, "2回合內，木屬性攻擊10倍", pic[14], "自然咆嘯", "超強攻擊", 3, "全體攻擊力3倍");
            monster[11] = new monster("巨石魔像", 0, 3, 100, 100, 200, 6, "水轉心", pic[15], "防禦姿勢‧水", "超強攻擊", 3, "全體攻擊力3倍");

            monster[12] = new monster("冷凍菇", 4, 3, 100, 110, 200, 1, "木轉心", pic[16], "防禦姿勢‧木", "超強攻擊", 3, "全體攻擊力3倍");
            monster[13] = new monster("冰巨人", 4, 3, 100, 100, 200, 1, "木轉心", pic[17], "防禦姿勢‧木", "超強攻擊", 3, "全體攻擊力3倍");
            monster[14] = new monster("大力龜", 4, 3, 100, 100, 200, 1, "木轉心", pic[18], "防禦姿勢‧木", "超強攻擊", 3, "全體攻擊力3倍");
            monster[15] = new monster("蝸牛戰士", 4, 3, 100, 100, 200, 8, "心轉水", pic[19], "攻擊姿勢‧水", "超強攻擊", 3, "全體攻擊力3倍");
            monster[16] = new monster("冰錐毒蠍", 4, 3, 100, 100, 200, 9, "暗、光轉水", pic[20], "全面啟動‧水", "超強攻擊", 3, "全體攻擊力3倍");
            monster[17] = new monster("巨鯨", 0, 4, 100, 100, 200, 10, "2回合內，水屬性攻擊10倍", pic[21], "海嘯爆發", "超強攻擊", 3, "全體攻擊力3倍");

            monster[18] = new monster("火肥肥", 3, 3, 100, 110, 200, 0, "未有", pic[22], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[19] = new monster("火燒豬", 3, 3, 100, 100, 200, 0, "未有", pic[23], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[20] = new monster("火鎧甲", 3, 3, 100, 100, 200, 0, "未有", pic[24], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[21] = new monster("熔岩巨人", 3, 3, 100, 100, 200, 0, "未有", pic[25], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[22] = new monster("噴火龍", 3, 3, 100, 100, 200, 0, "未有", pic[26], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[23] = new monster("死靈騎士", 3, 3, 100, 100, 200, 0, "未有", pic[27], "未有", "超強攻擊", 3, "全體攻擊力3倍");

            monster[24] = new monster("閃光龍", 1, 3, 2000, 1000, 200, 300, "暗轉心", pic[28], "防禦姿勢‧光", "超強攻擊", 3, "全體攻擊力3倍");
            monster[25] = new monster("光巨人", 1, 3, 1900, 1450, 200, 200, "心轉光", pic[29], "攻擊姿勢‧光", "超強攻擊", 3, "全體攻擊力3倍");
            monster[26] = new monster("金毛象", 1, 3, 1600, 2942, 200, 140, "水‧木轉光", pic[30], "萬丈光芒", "超強攻擊", 3, "全體攻擊力3倍");
            monster[27] = new monster("狼假面", 1, 3, 1700, 2243, 200, 284, "暗轉心", pic[31], "防禦姿勢‧光", "超強攻擊", 3, "全體攻擊力3倍");
            monster[28] = new monster("萬尾狐", 1, 3,2200, 1230, 200,305, "水‧木轉光", pic[32], "萬丈光芒", "超強攻擊", 3, "全體攻擊力3倍");
            monster[29] = new monster("千手觀音", 1, 3, 2502, 2123, 200, 90, "2回合內，光屬性攻擊10倍", pic[33], "光芒四射", "超強攻擊", 3, "全體攻擊力3倍");

            monster[30] = new monster("雙刀蜥蜴", 2, 3, 100, 110, 200, 0, "未有", pic[34], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[31] = new monster("灰肥肥", 2, 3, 100, 100, 200, 0, "未有", pic[35], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[32] = new monster("黯龍", 2, 3, 100, 100, 200, 0, "未有", pic[36], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[33] = new monster("灰狼戰士", 2, 3, 100, 100, 200, 0, "未有", pic[37], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[34] = new monster("闇巨象", 2, 3, 100, 100, 200, 0, "未有", pic[38], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[35] = new monster("戒靈", 2, 3, 100, 100, 200, 0, "未有", pic[39], "未有", "超強攻擊", 3, "全體攻擊力3倍");

            monster[36] = new monster("石矮人", 0, 3, 100, 110, 200, 0, "未有", pic[40], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[37] = new monster("亞歷斯坦", 3, 3, 100, 100, 200, 0, "未有", pic[41], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[38] = new monster("機器女巫", 2, 3, 100, 100, 200, 0, "未有", pic[42], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[39] = new monster("冰火巨人", 3, 3, 100, 100, 200, 0, "未有", pic[43], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[40] = new monster("光之死靈", 1, 3, 100, 100, 200, 0, "未有", pic[44], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[41] = new monster("急凍獨角獸", 4, 3, 100, 100, 200, 0, "未有", pic[45], "未有", "超強攻擊", 3, "全體攻擊力3倍");

            monster[42] = new monster("藍光劍士", 2, 3, 100, 110, 200, 0, "未有", pic[46], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[43] = new monster("機器巨象", 4, 3, 100, 100, 200, 0, "未有", pic[47], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[44] = new monster("圖騰鸚鵡", 0, 3, 100, 100, 200, 0, "未有", pic[48], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[45] = new monster("石磚象", 3, 3, 100, 100, 200, 0, "未有", pic[49], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[46] = new monster("鷹馬", 2, 3, 100, 100, 200, 0, "未有", pic[50], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[47] = new monster("侏儒巨角羊", 1, 3, 100, 100, 200, 0, "未有", pic[51], "未有", "超強攻擊", 3, "全體攻擊力3倍");

            monster[48] = new monster("惡靈劍士", 1, 3, 100, 110, 200, 0, "未有", pic[52], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[49] = new monster("虛無假面", 0, 3, 100, 100, 200, 0, "未有", pic[53], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[50] = new monster("機器砲兵", 4, 3, 100, 100, 200, 0, "未有", pic[54], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[51] = new monster("雙面娃娃", 2, 3, 100, 100, 200, 0, "未有", pic[55], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[52] = new monster("冥鏡幽靈", 1, 3, 100, 100, 200, 0, "未有", pic[56], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            monster[53] = new monster("蛇龍巫師", 3, 3, 100, 100, 200, 0, "未有", pic[57], "未有", "超強攻擊", 3, "全體攻擊力3倍");
            // /////////////////////////////


            // ///////////小怪(測試)///////////
            /*
            round_monster[0, 0] = 0; round_monster[0, 1] = 1; round_monster[0, 2] = 2; round_monster[0, 3] = 3;
            monsterR[0] = new monster("小怪1",3, 3, 100, 1000,150, pic[9]); 
            monsterR[1] = new monster("小怪2",1, 2, 200, 1000 ,160, pic[7]);
            monsterR[2] = new monster("小怪3", 2, 1, 500, 2000, 110, pic[8]);
            monsterR[3] = new monster("魔王", 0, 3, 100, 72000,200, pic[6]);
             */ 
            // ///////////////////////////////
            teamn[0, 0] = "通往叢林之路"; teamn[0, 1] = "萬惡的魔像詛咒";
            round_monster[0, 0] = 0; round_monster[0, 1] = 1; round_monster[0, 2] = 2; round_monster[0, 3] = 3; round_monster[0, 4] = 4; round_monster[0, 5] = 5;
            monsterR[0] = new monster(6,"巨刺蜈蚣", 0, 2, 2068, 10000, 200, pic[10]);
            monsterR[1] = new monster(7,"迷幻貓頭鷹", 0, 1, 1500, 2345, 44, pic[11]);
            monsterR[2] = new monster(8,"食人花", 0, 4, 7000, 10, 100000, pic[12]);
            monsterR[3] = new monster(9,"毒菇菇", 0, 2, 1000, 20000, 102, pic[13]);
            monsterR[4] = new monster(10,"草石像", 0, 4, 6000, 500000, 26, pic[14]);
            monsterR[5] = new monster(11,"巨石魔像", 0, 5, 10000, 100, 700, pic[15]);
            teamn[1, 0] = "海底洞窟的探險"; teamn[1, 1] = "隱藏深淵裡的巨獸";
            round_monster[1, 0] = 6; round_monster[1, 1] = 7; round_monster[1, 2] = 8; round_monster[1, 3] = 9; round_monster[1, 4] = 10; round_monster[1, 5] = 11;
            monsterR[6] = new monster(12,"冷凍菇", 4, 3, 100, 110, 200, pic[16]);
            monsterR[7] = new monster(13,"冰巨人", 4, 3, 100, 100, 200, pic[17]);
            monsterR[8] = new monster(14,"大力龜", 4, 3, 100, 100, 200, pic[18]);
            monsterR[9] = new monster(15,"蝸牛戰士", 4, 3, 100, 100, 200, pic[19]);
            monsterR[10] = new monster(16,"冰錐毒蠍", 4, 3, 100, 100, 200, pic[20]);
            monsterR[11] = new monster(17,"巨鯨", 4, 3, 100, 100, 200, pic[21]);
            teamn[2, 0] = "活火山的歷險"; teamn[2, 1] = "炙熱岩漿的逆襲";
            round_monster[2, 0] = 12; round_monster[2, 1] = 13; round_monster[2, 2] = 14; round_monster[2, 3] = 15; round_monster[2, 4] = 16; round_monster[2, 5] = 17;
            monsterR[12] = new monster(18,"火肥肥", 3, 3, 100, 110, 200, pic[22]);
            monsterR[13] = new monster(19,"火燒豬", 3, 3, 100, 100, 200, pic[23]);
            monsterR[14] = new monster(20,"火鎧甲", 3, 3, 100, 100, 200, pic[24]);
            monsterR[15] = new monster(21,"熔岩巨人", 3, 3, 100, 100, 200, pic[25]);
            monsterR[16] = new monster(22,"噴火龍", 3, 3, 100, 100, 200, pic[26]);
            monsterR[17] = new monster(23,"死靈騎士", 3, 3, 100, 100, 200, pic[27]);
            teamn[3, 0] = "潛入天空之塔"; teamn[3, 1] = "萬惡佛像的遷怒";
            round_monster[3, 0] = 18; round_monster[3, 1] = 19; round_monster[3, 2] = 20; round_monster[3, 3] = 21; round_monster[3, 4] = 22; round_monster[3, 5] = 23;
            monsterR[18] = new monster(24,"閃光龍", 1, 3, 100, 110, 200, pic[28]);
            monsterR[19] = new monster(25,"光巨人", 1, 3, 100, 100, 200, pic[29]);
            monsterR[20] = new monster(26,"金毛象", 1, 3, 100, 100, 200, pic[30]);
            monsterR[21] = new monster(27,"狼假面", 1, 3, 100, 100, 200, pic[31]);
            monsterR[22] = new monster(28,"萬尾狐", 1, 3, 100, 100, 200, pic[32]);
            monsterR[23] = new monster(29,"千手觀音", 1, 3, 100, 100, 200, pic[33]);
            teamn[4, 0] = "掉入地獄的深淵"; teamn[4, 1] = "黑洞裡的死靈幽魂";
            round_monster[4, 0] = 24; round_monster[4, 1] = 25; round_monster[4, 2] = 26; round_monster[4, 3] = 27; round_monster[4, 4] = 28; round_monster[4, 5] = 29;
            monsterR[24] = new monster(30,"雙刀蜥蜴", 2, 3, 100, 110, 200, pic[34]);
            monsterR[25] = new monster(31,"灰肥肥", 2, 3, 100, 100, 200, pic[35]);
            monsterR[26] = new monster(32,"黯龍", 2, 3, 100, 100, 200, pic[36]);
            monsterR[27] = new monster(33,"灰狼戰士", 2, 3, 100, 100, 200, pic[37]);
            monsterR[28] = new monster(34,"闇巨象", 2, 3, 100, 100, 200, pic[38]);
            monsterR[29] = new monster(35,"戒靈", 2, 3, 100, 100, 200, pic[39]);
            teamn[5, 0] = "窺探迷茫洞窟"; teamn[5, 1] = "奇異的古老魔物";
            round_monster[5, 0] = 30; round_monster[5, 1] = 31; round_monster[5, 2] = 32; round_monster[5, 3] = 33; round_monster[5, 4] = 34; round_monster[5, 5] = 35;
            monsterR[30] = new monster(36,"石矮人", 0, 3, 100, 110, 200, pic[40]);
            monsterR[31] = new monster(37,"亞歷斯坦", 3, 3, 100, 100, 200, pic[41]);
            monsterR[32] = new monster(38,"機器女巫", 2, 3, 100, 100, 200, pic[42]);
            monsterR[33] = new monster(39,"冰火巨人", 3, 3, 100, 100, 200, pic[43]);
            monsterR[34] = new monster(40,"光之死靈", 1, 3, 100, 100, 200, pic[44]);
            monsterR[35] = new monster(41,"急凍獨角獸", 4, 3, 100, 100, 200, pic[45]);
            teamn[6, 0] = "傳奇金字塔"; teamn[6, 1] = "守衛者的復仇";
            round_monster[6, 0] = 36; round_monster[6, 1] = 37; round_monster[6, 2] = 38; round_monster[6, 3] = 39; round_monster[6, 4] = 40; round_monster[6, 5] = 41;
            monsterR[36] = new monster(42,"藍光劍士", 2, 3, 100, 110, 200, pic[46]);
            monsterR[37] = new monster(43,"機器巨象", 4, 3, 100, 100, 200, pic[47]);
            monsterR[38] = new monster(44,"圖騰鸚鵡", 0, 3, 100, 100, 200, pic[48]);
            monsterR[39] = new monster(45,"石磚象", 3, 3, 100, 100, 200, pic[49]);
            monsterR[40] = new monster(46,"鷹馬", 2, 3, 100, 100, 200, pic[50]);
            monsterR[41] = new monster(47,"侏儒巨角羊", 1, 3, 100, 100, 200, pic[51]);
            teamn[7, 0] = "山間靈異旅社"; teamn[7, 1] = "幽冥幻術大法師";
            round_monster[7, 0] = 42; round_monster[7, 1] = 43; round_monster[7, 2] = 44; round_monster[7, 3] = 45; round_monster[7, 4] = 46; round_monster[7, 5] = 47;
            monsterR[42] = new monster(48,"惡靈劍士", 1, 3, 100, 110, 200, pic[52]);
            monsterR[43] = new monster(49,"虛無假面", 0, 3, 100, 100, 200, pic[53]);
            monsterR[44] = new monster(50,"機器砲兵", 3, 3, 100, 100, 200, pic[54]);
            monsterR[45] = new monster(51,"雙面娃娃", 2, 3, 100, 100, 200, pic[55]);
            monsterR[46] = new monster(52,"冥鏡幽靈", 1, 3, 100, 100, 200, pic[56]);
            monsterR[47] = new monster(53,"蛇龍巫師", 3, 3, 100, 100, 200, pic[57]);
        }
    }
}
