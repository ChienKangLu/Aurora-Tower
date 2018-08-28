using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace final_1
{
    public partial class main_play : Form
    {
        double second = 0.05;
        int width = 50;
        int height = 50;
        P_A[,] A = new P_A[5, 6];
        int[,] T = new int[5, 6];//
        int[] B = new int[6];
        int[] C = new int[5];
        Computer sound = new Computer();
        Label[] FRE = new Label[30];
        Image[] picture = new Image[8];
        Image[] picture2 = new Image[6];
        ///////////////////////
        P_A now1 = new P_A();
        int cx1;
        int dx1;
        int road1 = 0;//移動距離
        int total = 0;//總距離
        int y;
        // ///  ///  //  ///////////////
        int cx2;
        int dx2;
        int road2 = 0;//移動距離
        int total2 = 0;//總距離
        int x;
        bool jkey = false;
        /// ///////////////////////////////////
        List<point> T_x_y_3 = new List<point>();
        List<point> T_x_y_4 = new List<point>();
        List<point> T_x_y_5 = new List<point>();
        List<point> T_x_y_6 = new List<point>();
        bool[,] yes_no = new bool[5, 4];//6,5,4,3
        /// ///////////////////////////////////////////
        List<point> T_x_y_3_2 = new List<point>();
        List<point> T_x_y_4_2 = new List<point>();
        List<point> T_x_y_5_2 = new List<point>();
        bool[,] yes_no2 = new bool[6, 4];//6,5,4,3
        List<point> combo_start = new List<point>();
        List<point> combo_total = new List<point>();
        // /////////////////////////////////////////
        public int rr = 0;//計算總combo數
        //////////////////////////////////////
        int number = 1;//計算combo數
        // ///////////////////////////////////
        List<point> color_R = new List<point>();
        List<point> color_D = new List<point>();
        List<point> color_F = new List<point>();
        List<point> color_G = new List<point>();
        List<point> color_Y = new List<point>();
        List<point> color_B = new List<point>();//補血
        int total_Combo = 0;
        Queue<int> top = new Queue<int>();
        Random r = new Random();
        /// /////////////////
        monster[] smallM = new monster[5];//小怪資料庫
        int stage = 10;
        int rightnow = 1;
        int monster_number = 0;//單次產生的怪物
        int monster_alive = 0;//單次產生還存在的怪物,用此判斷是否要在產生新的怪物進入下一關
        PictureBox []Mpicture = new PictureBox[5];//場上小怪輸出
        monster[] smallM_true = new monster[5];//真實小怪使用
        Label[] blood = new Label[5];
        Label[] blood2 = new Label[5];
        Label name = new Label();//!!!!!!!!!!!!!!!!11
        // ///////////////////////////////
        monster[] user = new monster[6];
        int total_blood=0;
        int total_blood_now = 0;
        /// ////////////////////
        double[] attack = new double[6];//補血
        bool[] bigattack = new bool[6];//補血
        /// //////////////////////
        Label[] ud = new Label[6];
        PictureBox[] user_UI = new PictureBox[6];
        // ///////////////////////
        int Round = 1;//very important!!!!!
        // ////////////////////////////
        double[] extra_attack = new double[6];//使用技能的各種加成(屬性區別每一個)，初始直為1
        int[] skill_round = new int[6];//計算技能能夠使用的回合數(屬性區別每一個)
        // ////////////////////////////
        public main_play(int x)//選擇的隊伍
        {
            InitializeComponent();
            //////////////////////////////////
            A[0, 0] = new P_A(pictureBox1); A[0, 1] = new P_A(pictureBox2); A[0, 2] = new P_A(pictureBox3); A[0, 3] = new P_A(pictureBox4); A[0, 4] = new P_A(pictureBox5);
            A[0, 5] = new P_A(pictureBox6); A[1, 0] = new P_A(pictureBox7); A[1, 1] = new P_A(pictureBox8); A[1, 2] = new P_A(pictureBox9); A[1, 3] = new P_A(pictureBox10);
            A[1, 4] = new P_A(pictureBox11); A[1, 5] = new P_A(pictureBox12); A[2, 0] = new P_A(pictureBox13); A[2, 1] = new P_A(pictureBox14); A[2, 2] = new P_A(pictureBox15);
            A[2, 3] = new P_A(pictureBox16); A[2, 4] = new P_A(pictureBox17); A[2, 5] = new P_A(pictureBox18);

            A[3, 0] = new P_A(pictureBox19); A[3, 1] = new P_A(pictureBox20); A[3, 2] = new P_A(pictureBox21);
            A[3, 3] = new P_A(pictureBox22); A[3, 4] = new P_A(pictureBox23); A[3, 5] = new P_A(pictureBox24);

            A[4, 0] = new P_A(pictureBox25); A[4, 1] = new P_A(pictureBox26); A[4, 2] = new P_A(pictureBox27);
            A[4, 3] = new P_A(pictureBox28); A[4, 4] = new P_A(pictureBox29); A[4, 5] = new P_A(pictureBox30);
            picture[0] = Image.FromFile("7ML900k.png");
            picture[1] = Image.FromFile("8Gm7rGo.png");
            picture[2] = Image.FromFile("GjKxv9s.png");
            picture[3] = Image.FromFile("J1w2vTy.png");
            picture[4] = Image.FromFile("TuAF8ZM.png");
            picture[5] = Image.FromFile("a4.png");
            picture[6] = Image.FromFile("back4.png");
            picture[7] = Image.FromFile("back5.png");
            picture2[0] = Image.FromFile("7ML900k2.png");
            picture2[1] = Image.FromFile("8Gm7rGo2.png");
            picture2[2] = Image.FromFile("GjKxv9s2.png");
            picture2[3] = Image.FromFile("J1w2vTy2.png");
            picture2[4] = Image.FromFile("TuAF8ZM2.png");
            picture2[5] = Image.FromFile("a1.png");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int number2 = r.Next(0, 6);
                    A[i, j].P.SizeMode = PictureBoxSizeMode.StretchImage;
                    A[i, j].P.Image = picture[number2];
                    A[i, j].A = number2;
                    A[i, j].P.BackColor = Color.Transparent;
                    /*
                    A[i, j].P.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (A[i, j].P.BackColor == Color.Red)
                    {

                        A[i, j].P.Image = picture[3];
                        A[i, j].A = 3;
                        A[i, j].P.BackColor = Color.Transparent;

                    }
                    else if (A[i, j].P.BackColor == Color.DodgerBlue)
                    {
                        A[i, j].P.Image = picture[4];
                        A[i, j].A = 4;
                        A[i, j].P.BackColor = Color.Transparent;
                    }
                    else if (A[i, j].P.BackColor == Color.Fuchsia)
                    {
                        A[i, j].P.Image = picture[2];
                        A[i, j].A = 2;
                        A[i, j].P.BackColor = Color.Transparent;
                    }
                    else if (A[i, j].P.BackColor == Color.Green)
                    {
                        A[i, j].P.Image = picture[0];
                        A[i, j].A = 0;
                        A[i, j].P.BackColor = Color.Transparent;
                    }
                    else if (A[i, j].P.BackColor == Color.Yellow)
                    {
                        A[i, j].P.Image = picture[1];
                        A[i, j].A = 1;
                        A[i, j].P.BackColor = Color.Transparent;
                    }
                    else if (A[i, j].P.BackColor == Color.Coral)
                    {
                        A[i, j].P.Image = picture[5];
                        A[i, j].A = 5;
                        A[i, j].P.BackColor = Color.Transparent;
                    }
                     */ 
                    //A[i, j].P.BringToFront();
                }
            }
            int g = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    T[i, j] = g;
                    //label36.Text += "" + T[i, j];
                    g++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    yes_no[i, j] = false;
                }
                bigattack[i] = false;
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    yes_no2[i, j] = false;
                }
            }
            ///////////本關的基本小怪///////////////
            smallM[0] = new monster(11,0,3,1000,72000);
            smallM[1] = new monster(10, 1, 2, 2000, 1000);
            smallM[2] = new monster(8, 2, 1, 5000,2000);
            smallM[3] = new monster(9, 3, 3, 3000, 1000);
            ////////////使用者的隊伍///////////////
            user[0] =new monster(total_monster.monster[total_monster.team[x, 0]]);
            user1.Image = user[0].im;
            leader = user[0].leadera;
            user1.SizeMode = PictureBoxSizeMode.StretchImage;
            user[1] = new monster(total_monster.monster[total_monster.team[x, 1]]);
            user2.Image = user[1].im;
            user2.SizeMode = PictureBoxSizeMode.StretchImage;
            user[2] = new monster(total_monster.monster[total_monster.team[x, 2]]);
            user3.Image = user[2].im;
            user3.SizeMode = PictureBoxSizeMode.StretchImage;
            user[3] = new monster(total_monster.monster[total_monster.team[x, 3]]);
            user4.Image = user[3].im;
            user4.SizeMode = PictureBoxSizeMode.StretchImage;
            user[4] = new monster(total_monster.monster[total_monster.team[x, 4]]);
            user5.Image = user[4].im;
            user5.SizeMode = PictureBoxSizeMode.StretchImage;
            user[5] = new monster(total_monster.monster[total_monster.six]);
            leader2 = user[5].leadera;
            user6.Image = user[5].im;
            user6.SizeMode = PictureBoxSizeMode.StretchImage;

            user_UI[0] = user1;
            user_UI[0].BackColor = which2(user[0].attribute);
            user_UI[1] = user2;
            user_UI[1].BackColor = which2(user[1].attribute);
            user_UI[2] = user3;
            user_UI[2].BackColor = which2(user[2].attribute);
            user_UI[3] = user4;
            user_UI[3].BackColor = which2(user[3].attribute);
            user_UI[4] = user5;
            user_UI[4].BackColor = which2(user[4].attribute);
            user_UI[5] = user6;
            user_UI[5].BackColor = which2(user[5].attribute);
            ///////////////////血量///////////////
            for (int i = 0; i < 6; i++)
            {
                total_blood += user[5].blood;
                
            }
            total_blood_now = total_blood;
            user_blood_1.Text = "" + total_blood_now;
            ud[0] = user_blood1;
            ud[1] = user_blood2;
            ud[2] = user_blood3;
            ud[3] = user_blood4;
            ud[4] = user_blood5;
            ud[5] = user_blood6;
            // //////////////////////初始技能加成
            for (int i = 9; i < 5; i++)
            {
                extra_attack[i] = 1;
            }
            
        }
        Color which2(int a)
        {
            if (a == 0)
            {
                return Color.FromArgb(60, 0, 255, 0);
            }
            else if (a == 1)
            {
                return Color.FromArgb(60, 255, 255, 0);

            }
            else if (a == 2)
            {
                return Color.FromArgb(60, 139, 101, 8);
            }
            else if (a == 3)
            {
                return Color.FromArgb(60, 255, 0, 0);
            }
            else if (a == 4)
            {
                return Color.FromArgb(60, 0, 0, 255);
            }
            else
            {
                return Color.FromArgb(60, 0, 0, 0); ;
            }
        }
        void round_show()
        {
            rightnow_round++;
            battle.Text = "Battle" + rightnow_round + "/" + final_round;
            battle.BringToFront();
            battle.Visible = true;
            delay(1);
            battle.Visible = false;
        }
        Computer sound2 = new Computer();
        
        private void Form2_Load(object sender, EventArgs e)
        {

            label44.Visible = false;
            //round_text.Text = "" + Round;
            p1.Controls.Add(name);
            pa3.BackgroundImage = total_monster.back[total_monster.choose];
            pa3.BackgroundImageLayout = ImageLayout.Stretch;
            //sound2.Audio.Play("music//1tree.wav", AudioPlayMode.BackgroundLoop);
            
            axWindowsMediaPlayer1.Visible = false;
            String a = "music//"+(total_monster.choose+1)+".wav";          
            axWindowsMediaPlayer1.URL =a;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
             
             
         }
                DateTime a;
        private void label1_Click(object sender, EventArgs e)
        {
            if (jkey)
            {

            }
            else
            {
                a = DateTime.Now;
                user_blood_1.Visible = false;
                count_down.Visible = true;
                timer_limit_2.Interval = 20;
                timer_limit_2.Enabled = true;

                //time_count();
                rr = 0;
                total_Combo = 0;
                t1.Enabled = false;
                t1.Clear();
                jkey = true;
                now1.P = (PictureBox)sender;
                now1.P.BringToFront();

                now1.A = A[find(now1.P.Name)[0], find(now1.P.Name)[1]].A;
                ///////////////////
                now1.P.Image = picture2[now1.A];



                ////////////////////
                dx1 = now1.P.Left / width;//B編號
                total = dx1 * width;
                cx1 = now1.P.Left;//目前位置
                y = now1.P.Top / height;
                for (int i = 0; i < 6; i++)
                {
                    B[i] = i;
                }
                dx2 = now1.P.Top / height;//B編號
                total2 = dx2 * height;
                cx2 = now1.P.Top;
                x = now1.P.Left / width;
                for (int i = 0; i < 5; i++)
                {
                    C[i] = i;
                }
                label31.Text = "dx1:" + dx1;
                label32.Text = "total:" + total;
                label33.Text = "cx1:" + cx1;
                label34.Text = "y:" + y;
                label35.Text = "dx2:" + dx2;
                label36.Text = "total2:" + total2;
                label37.Text = "cx2:" + cx2;
                label38.Text = "x:" + x;
            }
        }
        int Max_recover;
        void core()
        {
            Round++;
            round_text.Text = "" + Round;
            if (jkey == true)
                now1.P.Image = picture[now1.A];
            jkey = false;
            //combo(5);
            int c;
            do
            {
                combo(6);
                combo(5);
                combo(4);
                combo(3);
                /*
                 t1.Text += "3";
                 for (int i = 0; i < T_x_y_3.Count; i++)
                     t1.Text += "(" + T_x_y_3[i].x + "," + T_x_y_3[i].y + "," + T_x_y_3[i].z + ")" + "/";
                 t1.Text += Environment.NewLine + "4";
                 for (int i = 0; i < T_x_y_4.Count; i++)
                     t1.Text += "(" + T_x_y_4[i].x + "," + T_x_y_4[i].y + "," + T_x_y_4[i].z + ")" + "/";
                 t1.Text += Environment.NewLine + "5";
                 for (int i = 0; i < T_x_y_5.Count; i++)
                     t1.Text += "(" + T_x_y_5[i].x + "," + T_x_y_5[i].y + "," + T_x_y_5[i].z + ")" + "/";
                 t1.Text += Environment.NewLine + "6";
                 for (int i = 0; i < T_x_y_6.Count; i++)
                     t1.Text += "(" + T_x_y_6[i].x + "," + T_x_y_6[i].y + "," + T_x_y_6[i].z + ")" + "/";
                 */
                combo2(5);
                combo2(4);
                combo2(3);

                c = color_R.Count + color_Y.Count + color_D.Count + color_F.Count + color_G.Count + color_B.Count;
                /*
                 t1.Text += Environment.NewLine + "-------------------------" + Environment.NewLine + "3";
                 for (int i = 0; i < T_x_y_3_2.Count; i++)
                     t1.Text += "(" + T_x_y_3_2[i].x + "," + T_x_y_3_2[i].y + "," + T_x_y_3_2[i].z + ")" + "/";
                 t1.Text += Environment.NewLine + "4";
                 for (int i = 0; i < T_x_y_4_2.Count; i++)
                     t1.Text += "(" + T_x_y_4_2[i].x + "," + T_x_y_4_2[i].y + "," + T_x_y_4_2[i].z + ")" + "/";
                 t1.Text += Environment.NewLine + "5";
                 for (int i = 0; i < T_x_y_5_2.Count; i++)
                     t1.Text += "(" + T_x_y_5_2[i].x + "," + T_x_y_5_2[i].y + "," + T_x_y_5_2[i].z + ")" + "/";
                */
                // combination();


                print(color_R, "R");
                print(color_D, "D");
                print(color_F, "F");
                print(color_G, "G");
                print(color_Y, "Y");
                t1.Text += Environment.NewLine + "kkkk";
                /*
                 for (int i = 0; i < 5; i++)
                 {
                     t1.Text += i;
                     for (int j = 0; j < 4; j++)
                     {
                         t1.Text += "" + yes_no[i, j];
                     }
                     t1.Text += Environment.NewLine;
                 }
                 for (int i = 0; i < 6; i++)
                 {
                     t1.Text += i;
                     for (int j = 0; j < 4; j++)
                     {
                         t1.Text += "" + yes_no2[i, j];
                     }
                     t1.Text += Environment.NewLine;
                 }
                 */
                t1.Enabled = true;
                final_compute(color_R);
                final_compute(color_D);
                final_compute(color_F);
                final_compute(color_G);
                final_compute(color_Y);
                final_compute(color_B);

                sort(color_R);
                sort(color_D);
                sort(color_F);
                sort(color_G);
                sort(color_Y);
                sort(color_B);

                print(color_R, "R");
                print(color_D, "D");
                print(color_F, "F");
                print(color_G, "G");
                print(color_Y, "Y");
                print(color_B, "B");
                t1.Text += Environment.NewLine;
                t1.Text += number - 1;
                /*
                count_combo(color_R);
                count_combo(color_D);
                count_combo(color_F);
                count_combo(color_G);
                count_combo(color_Y);
                 */
                t1.Text += total_Combo;
                count(color_R, 3);//紅
                count(color_D, 4);//藍
                count(color_F, 2);//紫
                count(color_G, 0);//綠
                count(color_Y, 1);//黃
                count(color_B, 5);
                delet_coombo();
                delay(0.11);
                //!!!!!!!!!!!!!!!//
                new_combo();
                clear();
            } while (c > 0);
            // //////////////計算技能加成
            t1.Enabled = false;
            for (int i = 0; i < 5; i++)
            {
                if (skill_round[i] > 0)
                {
                    attack[i] *= extra_attack[i];
                    skill_round[i]--;
                }
            }
            // //////////////
            play();
            // //////////////回復
            int total_recover = 0;
            for (int i = 0; i < 6; i++)
            {
                total_recover += user[i].recover;
            }
            int after = Convert.ToInt32(attack[5] * total_recover * (1 + (rr - 1) * 0.25));
            if (after > Max_recover)
            {
                Max_recover = after;
            }
            user_blood.Visible = true;
            user_blood.Text = "+" + after;
            delay(1);
            user_blood.Visible = false;
            user_blood.Text = "";
            if (after + total_blood_now <= total_blood)
            {
                total_blood_now = after + total_blood_now;
            }
            else
            {
                total_blood_now = total_blood;
            }
            user_blood_1.Width = 300 * total_blood_now / total_blood;
            user_blood_1.Text = "" + total_blood_now;
            // //////////////
            rr = 0;
            for (int i = 0; i < 6; i++)
            {
                attack[i] = 0;
                bigattack[i] = false;
            }
            //delay(0.5);
            for (int i = 0; i < 6; i++)
            {
                ud[i].Visible = false;
                ud[i].Text = "";
                delay(0.1);
            }
            //計算怪物cd///////////////////////////////////
            for (int i = 0; i < monster_number; i++)
            {
                if (smallM_true[i].blood_now != 0)
                {
                    if (smallM_true[i].cd_now == 1)
                    {
                        smallM_true[i].cd_now = smallM_true[i].cd;//攻擊
                        total_blood_now -= smallM_true[i].attack;
                        user_blood_1.BackColor = whichColor(smallM_true[i].attribute);
                        delay(0.1);
                        user_blood_1.BackColor = Color.Pink;
                        user_blood_1.Width = 300 * total_blood_now / total_blood;
                        user_blood_1.Text = "" + total_blood_now;
                    }
                    else
                    {
                        smallM_true[i].cd_now--;
                    }
                    /*
                    name[i].Text = "";
                    name[i].Text += "攻擊" + smallM_true[i].attack + "\n";
                    name[i].Text += "血量" + smallM_true[i].blood_now + "\n";
                    name[i].Text += "cd" + smallM_true[i].cd_now;
                     */ 
                }
            }
            // //////////遊戲結束判斷////////////////死亡
            label31.Text = "" + total_blood_now;
            if (total_blood_now <= 0)
            {
                DialogResult result = MessageBox.Show("game over", "任務失敗", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    total_monster.round = Round;
                    total_monster.max_attack = maxattack_one;
                    total_monster.max_combo = max_combo;
                    total_monster.max_recoer = Max_recover;
                    this.Dispose();
                    main_victory A = new main_victory(0);
                    A.Show();
                }
            }
            // ////////////遊戲結束判斷////////////////勝利
            /*
            if (final_round == rightnow_round)
            {

                if (monster_alive == 0)
                {
                    DialogResult result = MessageBox.Show("勝利", "勝利", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        this.Dispose();
                        Form10 A = new Form10();
                        A.Show();
                        //Form1 A = new Form1();
                        //A.Show();
                    }
                }
            }
             */ 
            // ///////////////////////////////////
            // //////////////////////////////////
            if (monster_alive == 0)
            {
                Mpicture[drop].Image = total_monster.pic[smallM_true[drop].attribute + 58];//掉卡
                //Mpicture[drop].Width = 100;
                //Mpicture[drop].Height = 100;
                total_monster.drop.Push(smallM_true[drop].card);//加入掉的資料庫中
                delay(2);
                if (final_round == rightnow_round)
                {


                    DialogResult result = MessageBox.Show("恭喜你獲得了勝利", "完成任務", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        total_monster.round = Round;
                        total_monster.max_attack = maxattack_one;
                        total_monster.max_combo = max_combo;
                        total_monster.max_recoer = Max_recover;
                        this.Dispose();
                        main_victory A = new main_victory(1);
                        A.Show();
                        //Form1 A = new Form1();
                        //A.Show();
                    }

                }
                for (int i = 0; i < monster_number; i++)
                {
                    smallM_true[i].blood_now = smallM_true[i].blood;
                    pa3.Controls.Remove(Mpicture[i]);
                   // pa3.Controls.Remove(name[i]);
                    pa3.Controls.Remove(blood[i]);
                    pa3.Controls.Remove(blood2[i]);
                    Mpicture[i].Dispose();
                    //name[i].Dispose();
                    blood[i].Dispose();
                    blood2[i].Dispose();
                    Mpicture[i] = null;
                    //name[i] = null;
                    blood[i] = null;
                }
                addnewmonster();
            }

            for (int t = 0; t < 6; t++)
            {
                user[t].cd_now--;
                if (user[t].cd_now == -1)
                {
                    user[t].cd_now = user[t].cd;
                }
                if (user[t].cd_now == 0&&user_UI[t].Top!=143)
                    user_UI[t].Top -= 3;
            }
               
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 49 && e.KeyValue <= 54)
            {
                Image a = user[e.KeyValue - 48 - 1].im;
                int b = user[e.KeyValue - 48 - 1].blood;
                int c = user[e.KeyValue - 48 - 1].attack;
                int d = user[e.KeyValue - 48 - 1].recover;
                String f = user[e.KeyValue - 48 - 1].skillname2;
                String g= user[e.KeyValue - 48 - 1].skillname;
                int h = user[e.KeyValue - 48 - 1].cd;
                String i = user[e.KeyValue - 48 - 1].namem;
                int j = user[e.KeyValue - 48 - 1].attribute;
                String qq = user[e.KeyValue - 48 - 1].leadern;
                String ll = user[e.KeyValue - 48 - 1].leader;
                main_card A = new main_card(a, b, c, d, f,g,h,i,j,qq,ll);
                A.ShowDialog();
            }
            if (e.KeyCode == Keys.Space)
            {
                user_blood_1.Visible = true;
                count_down.Visible = false;
                count_down.Width = 300;
                timer_limit_2.Enabled = false;
                core();
            }
            if (jkey == true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    sound.Audio.Play("mobile_phone_O (1) (1) (1) (1).wav");
                    // x = now1.Left / width;
                    if (total2 - height >= 0)
                    {
                        now1.P.Top -= height;//移動
                        road2 -= height;//距離
                        total2 -= height;
                    }
                }

                if (e.KeyCode == Keys.Down)
                {
                    sound.Audio.Play("mobile_phone_O (1) (1) (1) (1).wav");
                    //x = now1.Left / width;
                    if (total2 + height <= height*4)
                    {
                        now1.P.Top += height;//移動
                        road2 += height;//距離
                        total2 += height;
                    }
                }
                if (e.KeyCode == Keys.Right)
                {
                    sound.Audio.Play("mobile_phone_O (1) (1) (1) (1).wav");
                    // y = now1.Top / height;
                    if (total + width <= width*5)
                    {
                        now1.P.Left += width;//移動
                        road1 += width;//距離
                        total += width;
                    }

                }
                if (e.KeyCode == Keys.Left)
                {
                    sound.Audio.Play("mobile_phone_O (1) (1) (1) (1).wav");
                    //y = now1.Top / height;
                    if (total - width >= 0)
                    {
                        now1.P.Left -= width;//移動
                        road1 -= width;//距離
                        total -= width;
                    }
                }
                if (Math.Abs(road1) == width)
                {
                    int s = Math.Abs(total) / width;
                    /*
                    int temp = cx1;
                    cx1 = A[y, T[y,s]%6].Left;//當前移動
                    A[y, T[y, s] % 6].Left = temp;//交換的位置
                     */
                    String dd = "pictureBox" + (T[y, s] + 1);
                    label39.Text = dd;
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (dd.Equals(A[i, j].P.Name))
                            {

                                int temp = cx1;
                                cx1 = A[i, j].P.Left;//當前移動
                                A[i, j].P.Left = temp;//交換的位置
                                // label39.Text = "" + cx1;
                                label40.Text = "" + A[i, j].P.Left;
                                break;
                            }
                        }
                    }

                    int temp2 = T[y, s];
                    T[y, s] = T[y, dx1];//當前移動
                    T[y, dx1] = temp2;//交換的位置
                    dx1 = now1.P.Left / width;
                    road1 = 0;
                    x = now1.P.Left / width;//

                    /*
                    int s = Math.Abs(total) / width;
                    ////////
                
                    int temp = cx1;
                    cx1 = A[y,B[s]].Left;//當前移動
                    A[y,B[s]].Left = temp;//交換的位置
                    ////////
                    int temp2 = B[s];
                    B[s] = B[dx1];//當前移動
                    B[dx1] = temp2;//交換的位置
                    dx1 = now1.Left/width; 
                    ///////
                    road1 = 0;
                     */
                }


                if (Math.Abs(road2) == height)
                {
                    int s = Math.Abs(total2) / height;
                    //label34.Text = "" + y;
                    //label35.Text = "" + now1.Top;
                    /*
                    int temp = cx2;
                    cx2 = A[(T[s, x]-x) / 6, x].Top;//當前移動//
                    A[(T[s, x]-x) / 6, x].Top = temp;//交換的位置
                     */

                    String dd = "pictureBox" + (T[s, now1.P.Left / width] + 1);
                    label39.Text = dd;
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (dd.Equals(A[i, j].P.Name))
                            {

                                int temp = cx2;
                                cx2 = A[i, j].P.Top;//當前移動
                                A[i, j].P.Top = temp;//交換的位置
                                // label39.Text = "" + cx1;
                                //label40.Text = "" + A[i, j].Left;
                                break;
                            }
                        }
                    }

                    int temp2 = T[s, now1.P.Left / width];
                    T[s, now1.P.Left / width] = T[dx2, now1.P.Left / width];//當前移動
                    T[dx2, now1.P.Left / width] = temp2;//交換的位置
                    dx2 = now1.P.Top / height;
                    road2 = 0;
                    y = now1.P.Top / height;//

                    /*
                    int s = Math.Abs(total2) / height;
                    ////////
                    int temp = cx2;
                    cx2 = A[C[s],x].Top;//當前移動//
                    A[C[s], x].Top = temp;//交換的位置
                    ////////
                    int temp2 = C[s];
                    C[s] = C[dx2];//當前移動
                    C[dx2] = temp2;//交換的位置
                    dx2 = now1.Top / height;
                    ///////
                    road2 = 0;
                     */

                }
                String rr = "\n";
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {

                        rr += "" + T[i, j] + "  ";

                    }
                    rr += "\n";
                }
                f2.Text = rr;
                label31.Text = "dx1:" + dx1;
                label32.Text = "total:" + total;
                label33.Text = "cx1:" + cx1;
                label34.Text = "y:" + y;
                label35.Text = "dx2:" + dx2;
                label36.Text = "total2:" + total2;
                label37.Text = "cx2:" + cx2;
                label38.Text = "x:" + x;
            }
        }
        private int[] find(int a)
        {
            int[] b = new int[2];
            String dd = "pictureBox" + (a + 1);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (dd.Equals(A[i, j].P.Name))
                    {
                        b[0] = i;
                        b[1] = j;
                        break;
                    }
                }
            }
            return b;
        }
        private int[] find(String a)
        {
            int[] b = new int[2];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (a.Equals(A[i, j].P.Name))
                    {
                        b[0] = i;
                        b[1] = j;
                        break;
                    }
                }
            }
            return b;
        }
        /// ///////////////////////
        private void combo(int combo)
        {
            int count3 = 0;//計算是否有連續3個一樣
            label41.Text += "\n";
            P_A stamp = new P_A();

            for (int i = 0; i < 5; i++)
            {
                if (combo == 6)
                {
                    int rn = 0;
                    //012345
                    for (int j = 0; j < (6 - combo) + 1; j++)//找到3個1消每列最多找4次  4
                    {
                        stamp = A[find(T[i, rn])[0], find(T[i, rn])[1]];
                        count3 = 0;//計算是否有連續3個一樣
                        ////////////////////////////////////
                        for (int k = 0; k < combo; k++)
                        {
                            P_A stamp2 = A[find(T[i, rn + k])[0], find(T[i, rn + k])[1]];
                            //label40.Text += stamp2.Name;
                            if (stamp2.A == stamp.A)
                            {
                                count3++;
                            }
                        }

                    }
                    if (count3 == combo) // 3
                    {
                        //count_combo_i.Push(i);
                        //count_combo_cn.Push(rn);
                        yes_no[i, 3] = true;
                        color(stamp.A, i, rn, stamp, combo, 0);
                        combo_start.Add(new point(i, rn, stamp));
                        T_x_y_6.Add(new point(i, rn));


                    }
                    label41.Text += count3 + "/";
                }
                else if (combo == 5 && yes_no[i, 3] == false || combo == 4 && yes_no[i, 3] == false && yes_no[i, 2] == false || combo == 3 && yes_no[i, 3] == false && yes_no[i, 2] == false && yes_no[i, 1] == false)
                {
                    int rn = 0;
                    //012345
                    for (int j = 0; j < (6 - combo) + 1; j++)//找到3個1消每列最多找4次  4
                    {
                        stamp = A[find(T[i, rn])[0], find(T[i, rn])[1]];
                        count3 = 0;//計算是否有連續3個一樣
                        ////////////////////////////////////
                        for (int k = 0; k < combo; k++)
                        {

                            P_A stamp2 = A[find(T[i, rn + k])[0], find(T[i, rn + k])[1]];
                            //label40.Text += stamp2.Name;
                            if (stamp2.A == stamp.A)
                            {
                                count3++;
                            }
                            // textBox1.Text += "" + count3 + "/";
                        }
                        if (count3 == combo) // 3
                        {
                            color(stamp.A, i, rn, stamp, combo, 0);
                            combo_start.Add(new point(i, rn, stamp));
                            if (combo == 3)
                                T_x_y_3.Add(new point(i, rn, stamp));
                            else if (combo == 4)
                                T_x_y_4.Add(new point(i, rn, stamp));
                            else if (combo == 5)
                                T_x_y_5.Add(new point(i, rn, stamp));
                            //count_combo_i.Push(i);
                            //count_combo_cn.Push(rn);
                            yes_no[i, combo - 3] = true;
                            //label42.Text += count_combo_i.Peek() + "," + count_combo_cn.Peek() + "\n";
                            rn += combo; //3 
                            //label40.Text += stamp.Name + "/";
                        }
                        else if (count3 < combo)//3
                        {
                            rn++;
                        }
                        label41.Text += count3 + "/";//012345
                        if (rn > 6 - combo)//3
                        {
                            break;
                        }
                    }
                }
                else
                {
                    label41.Text += "$" + "/";
                }

                label41.Text += "\n";
            }

        }
        private void combo2(int combo)
        {
            int count3 = 0;//計算是否有連續3個一樣
            label41.Text += "\n";
            for (int i = 0; i < 6; i++)
            {
                if (combo == 5 || combo == 4 && yes_no2[i, 3] == false && yes_no2[i, 2] == false || combo == 3 && yes_no2[i, 3] == false && yes_no2[i, 2] == false && yes_no2[i, 1] == false)
                {
                    int rn = 0;
                    //012345
                    for (int j = 0; j < (6 - combo); j++)//找到3個1消每列最多找3次  3
                    {
                        P_A stamp = A[find(T[rn, i])[0], find(T[rn, i])[1]];
                        count3 = 0;//計算是否有連續3個一樣
                        ////////////////////////////////////
                        for (int k = 0; k < combo; k++)
                        {

                            P_A stamp2 = A[find(T[rn + k, i])[0], find(T[rn + k, i])[1]];
                            //label40.Text += stamp2.Name;
                            if (stamp2.A== stamp.A)
                            {
                                count3++;
                            }
                            // textBox1.Text += "" + count3 + "/";
                        }
                        if (count3 == combo) // 3
                        {
                            color(stamp.A, rn, i, stamp, combo, 1);
                            combo_start.Add(new point(rn, i, stamp));
                            if (combo == 3)
                                T_x_y_3_2.Add(new point(rn, i, stamp));
                            else if (combo == 4)
                                T_x_y_4_2.Add(new point(rn, i, stamp));
                            else if (combo == 5)
                                T_x_y_5_2.Add(new point(rn, i, stamp));
                            //count_combo_i.Push(i);
                            //count_combo_cn.Push(rn);
                            yes_no2[i, combo - 3] = true;
                            //label42.Text += count_combo_i.Peek() + "," + count_combo_cn.Peek() + "\n";
                            rn += combo; //3 
                            //label40.Text += stamp.Name + "/";
                        }
                        else if (count3 < combo)//3
                        {
                            rn++;
                        }
                        label41.Text += count3 + "/";//012345
                        if (rn > 5 - combo)//3
                        {
                            break;
                        }
                    }
                }
                else
                {
                    label41.Text += "$" + "/";
                }

                label41.Text += "\n";
            }

        }

        //////////////////////////把每個點都加入combo_total
        void combination()
        {
            t1.Text += Environment.NewLine + "total";
            for (int i = 0; i < combo_start.Count; i++)
                t1.Text += "(" + combo_start[i].x + "," + combo_start[i].y + ")" + "/";
            addtocombototal(T_x_y_3, 3);
            addtocombototal(T_x_y_4, 4);
            addtocombototal(T_x_y_5, 5);
            addtocombototal(T_x_y_6, 6);
            addtocombototal(T_x_y_3_2, 3, "");
            addtocombototal(T_x_y_4_2, 4, "");
            addtocombototal(T_x_y_5_2, 5, "");
            t1.Text += Environment.NewLine + "-------------------------";
            t1.Text += Environment.NewLine + "combo_total" + Environment.NewLine;
            for (int i = 0; i < combo_total.Count; i++)
            {
                t1.Text += "(" + combo_total[i].x + "," + combo_total[i].y + "," + combo_total[i].z + ")" + "/";
            }

        }
        void addtocombototal(List<point> a, int b)
        {
            for (int i = 0; i < a.Count(); i++)
            {
                for (int j = 0; j < b; j++)
                {
                    combo_total.Add(new point(a[i].x, a[i].y + j, a[i].z));
                }
            }
        }
        void addtocombototal(List<point> a, int b, String c)//c無意義
        {
            for (int i = 0; i < a.Count(); i++)
            {
                for (int j = 0; j < b; j++)
                {
                    combo_total.Add(new point(a[i].x + j, a[i].y, a[i].z));
                }
            }
        }
        ///////////////////////////
        void color(int a, int x, int y, P_A z, int w, int s)
        {
            /////////////////////////////////////////////////////////
            if (a == 3)
            {
                color_R.Add(new point(x, y, z, w, s));
            }
            else if (a == 4)
            {
                color_D.Add(new point(x, y, z, w, s));
            }
            else if (a == 2)
            {
                color_F.Add(new point(x, y, z, w, s));
            }
            else if (a == 0)
            {
                color_G.Add(new point(x, y, z, w, s));
            }
            else if (a == 1)
            {
                color_Y.Add(new point(x, y, z, w, s));
            }
            else if(a==5){//補血
                color_B.Add(new point(x, y, z, w, s));
            }
            ///////////////////////////////////////////////////////////
        }
        void print(List<point> a, String b)
        {
            t1.Text += Environment.NewLine + b;
            for (int i = 0; i < a.Count; i++)
                t1.Text += "(" + a[i].x + "," + a[i].y + "," + a[i].z.A + "," + a[i].w + "," + a[i].s + "," + a[i].q + ")" + "/";
        }
        ///////////////////////////////////////////////

        void final_compute(List<point> color)
        {
            //int number = 1;
            if (color.Count == 1)
            {
                color[0].q = number;
                number++;
            }
            
            for (int i = 0; i < color.Count ; i++)
            {

                    //if (color_R[i].s == 0)//只判斷row
                    //{
                    if (color[i].q == 0)
                    {
                        color[i].q = number;
                        number++;
                    }
                for (int j = 0; j < color.Count; j++)
                {
                    //if (color_R[j].s == 0)//只判斷row
                    //{
                    if (color[i].s == 0 && color[j].s == 0)//兩者皆為row
                    {
                        if (method1(color[i], color[j]))
                        {
                            int temp = color[j].q;
                            if (color[j].q != 0)
                            {
                                for (int k = 0; k < color.Count; k++)
                                {
                                    if (color[k].q == temp)
                                    {
                                        color[k].q = color[i].q;
                                    }
                                }
                            } else
                            color[j].q = color[i].q;
                        }
                        else if (color[j].q == 0)
                        {
                            color[j].q = number;
                            number++;
                        }
                    }
                    else if (color[i].s == 0 && color[j].s == 1 || color[i].s == 1 && color[j].s == 0)
                    {
                        if (method3(color[i], color[j]))
                        {
                            int temp = color[j].q;
                            if (color[j].q != 0)
                            {
                                for (int k = 0; k < color.Count; k++)
                                {

                                    if (color[k].q == temp)
                                    {
                                        color[k].q = color[i].q;
                                    }
                                }
                            }
                            else
                                color[j].q = color[i].q;
                        }
                        else if (color[j].q == 0)
                        {
                            color[j].q = number;
                            number++;
                        }
                    }
                    else if (color[i].s == 1 && color[j].s == 1)
                    {
                        if (method2(color[i], color[j]))
                        {
                            int temp = color[j].q;
                            if (color[j].q != 0)
                            {
                                for (int k = 0; k < color.Count; k++)
                                {
                                    if (color[k].q == temp)
                                    {
                                        color[k].q = color[i].q;
                                    }
                                }
                            }
                            else
                                color[j].q = color[i].q;
                        }
                        else if (color[j].q == 0)
                        {
                            color[j].q = number;
                            number++;
                        }
                    }
                    //}
                }
                //}
                for (int u = 0; u < color.Count; u++)
                {
                    label1.Text += "" + color[u].q + " ";
                }
                label1.Text += "\n";
            }
            label1.Text += "$$";
        }
        bool method1(point a, point b)
        {
            if (Math.Abs(a.x - b.x) == 1)
            {
                if (a.w == 3 && b.w == 3)
                {
                    double d = Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2);
                    if (d <= 5)
                    {
                        return true;
                    }
                }
                else if (a.w > 3 || b.w > 3)
                {
                    return true;
                }
            }
            return false;
        }
        bool method2(point a, point b)
        {
            if (Math.Abs(a.y - b.y) == 1)
            {
                return true;
            }
            return false;
        }
        bool method3(point a, point b)
        {
            point c, d;
            if (a.s == 0 && b.s == 1)
            {
                c = a;//橫的
                d = b;//直的
            }
            else
            {
                c = b;
                d = a;
            }
            if (d.y >= c.y && d.y <= c.y + c.w - 1)
            {
                if (d.x + d.w - 1 >= c.x)
                {
                    return true;
                }
            }
            return false;

        }
        ///////////////////////////////////////////////
        void delet_coombo()
        {

            change_combo(color_R,3);
            change_combo(color_D,4);
            change_combo(color_F,2);
            change_combo(color_G,0);
            change_combo(color_Y,1);
            change_combo(color_B,5);
            for (int j = 0; j < 6; j++)
            {
                for (int i = 4; i >= 0; i--)
                {
                    bool flag2 = false;
                    bool flag = true;
                    int r = 1;
                    while (flag)
                    {
                        if (i + r <= 4 && A[find(T[i + r, j])[0], find(T[i + r, j])[1]].A >=6 && A[find(T[i, j])[0], find(T[i, j])[1]].A <6)
                        {
                            flag2 = true;
                            r++;
                        }
                        else
                        {
                            r = r - 1;
                            flag = false;
                        }
                    }
                    if (flag2)
                    {

                        int original = A[find(T[i, j])[0], find(T[i, j])[1]].P.Top;
                        
                        int temp2 = A[find(T[i + r, j])[0], find(T[i + r, j])[1]].P.Top;
                        A[find(T[i + r, j])[0], find(T[i + r, j])[1]].P.Top = original;
                        original = temp2;//6 + ((color[i].y+j) % 2 + color[i].x) % 2
                        //A[find(T[i + r, j])[0], find(T[i + r, j])[1]].P.Image = picture[6 + (i % 2 + j) % 2];

                        A[find(T[i, j])[0], find(T[i, j])[1]].P.BringToFront();
                        int yy = r;
                        while (yy != 0)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Top += height;
                            yy--;
                            delay(second);//
                        }
                       // sound.Audio.Play("short_punch1.wav");
                        A[find(T[i, j])[0], find(T[i, j])[1]].P.Top = temp2;

                        /*
                        int temp2 = A[find(T[i + r, j])[0], find(T[i + r, j])[1]].Top;
                        A[find(T[i + r, j])[0], find(T[i + r, j])[1]].Top = A[find(T[i, j])[0], find(T[i, j])[1]].Top;
                        A[find(T[i, j])[0], find(T[i, j])[1]].Top = temp2;
                         */
                        int temp = T[i + r, j];
                        T[i + r, j] = T[i, j];
                        T[i, j] = temp;
                    }
                }
            }
        }
        void sort(List<point> color)
        {
            for (int i = 0; i < color.Count() - 1; i++)
            {
                for (int j = i + 1; j < color.Count(); j++)
                {
                    if (color[i].q > color[j].q)
                    {
                        point temp = color[i];
                        color[i] = color[j];
                        color[j] = temp;
                    }
                }
            }

        }
        int max_combo = 0;
        void change_combo(List<point> color,int attr)
        {
            /*
            for (int i = 0; i < color.Count()-1; i++)
            {
                for (int j = i+1; j < color.Count(); j++)
                {
                    if (color[i].q > color[j].q)
                    {
                        point temp = color[i];
                        color[i] = color[j];
                        color[j] = temp;
                    }
                }
            }
             */
          
                label44.Visible = true;
            label44.BringToFront();
                for (int i = 0; i < color.Count; i++)
                {
                    int lastA = color[i].z.A;
                    if (color[i].s == 0)
                    {
                        for (int j = 0; j < color[i].w; j++)
                        {
                            A[find(T[color[i].x, color[i].y + j])[0], find(T[color[i].x, color[i].y + j])[1]].P.Image = null;
                            A[find(T[color[i].x, color[i].y + j])[0], find(T[color[i].x, color[i].y + j])[1]].A = 10;//6 + ((color[i].y + j) % 2 + color[i].x) % 2
                        }
                    }
                    else if (color[i].s == 1)
                    {
                        for (int j = 0; j < color[i].w; j++)
                        {
                            A[find(T[color[i].x + j, color[i].y])[0], find(T[color[i].x + j, color[i].y])[1]].P.Image = null;
                            A[find(T[color[i].x + j, color[i].y])[0], find(T[color[i].x + j, color[i].y])[1]].A = 10;//6 + ((color[i].y + j) % 2 + color[i].x) % 2
                        }
                    }
                    if (i != color.Count - 1 && color[i].q == color[i + 1].q)
                    {
                        // delay(1);
                    }
                    else
                    {
                        rr++;
                        label44.Text = ""+ rr ;
                        if (rr > max_combo)
                        {
                            max_combo = rr;
                        }
                        sound.Audio.Play("CA.wav");
                        double comboadd = (1 + (rr - 1) * 0.25);
                        for (int h = 0; h < 6; h++)//每一隻
                        {
                            if (user[h].attribute == attr || ud[h].Visible == true)
                            {
                                int last_attack = user[h].user_attack(attack, comboadd);
                                if (last_attack != 0)
                                {
                                    //ud[h].BackColor = which2(user[h].attribute);
                                    ud[h].Text = "" + last_attack;
                                    ud[h].Visible = true;
                                }
                            }
                        }
                        int[] shootsq = new int[6];
                        int shootn = 0;
                        for (int t = 0; t < 6; t++)
                        {
                            if (user[t].attribute == lastA)
                            {
                                shootsq[shootn] = t;
                                shootn++;
                            }

                        }
                        for (int t = 0; t < shootn; t++)
                        {
                            user_UI[shootsq[t]].BackColor = whichColor(lastA);
                            delay(0.2);
                            user_UI[shootsq[t]].BackColor = which2(user[shootsq[t]].attribute);
                        }
                        delay(0.4);
                    }
                  
                }
        }
        Color whichColor(int a)
        {
            Color color = new Color();
            if (a == 3){
                color = Color.Red;
            }else if(a==4){
                color = Color.DodgerBlue;
            }
            else if (a == 2)
            {
                color = Color.Fuchsia;
            }
            else if (a == 0)
            {
                color = Color.Green;
            }
            else if (a == 1)
            {
                color = Color.Yellow;
            }
            return color;
        }
        /*
        void count_combo(List<point> color)
        {

            Stack<int> count = new Stack<int>();
            for (int i = 0; i < color.Count; i++)
            {
                if (count.Count() != 0)
                {
                    if (color[i].q != count.Peek())
                    {
                        count.Push(color[i].q);
                    }
                }
                else
                    count.Push(color[i].q);
            }
            total_Combo += count.Count;
        }
         */
        void delay(double i)
        {
            DateTime now = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while ((DateTime.Now - now).TotalSeconds <= i);
        }
        void new_combo()
        {
            for (int j = 0; j < 6; j++)
            {
                for (int i = 4; i >= 0; i--)
                {
                    P_A temp = A[find(T[i, j])[0], find(T[i, j])[1]];
                    
                    if (temp.A>= 6)
                    {
                        top.Enqueue(temp.P.Top);
                        temp.P.Top = -height;
                        int dd = random_color();//隨機產生圖片
                        temp.P.Image = picture[dd];
                        temp.A = dd;
                        

                    }
                }
            }
            for (int j = 0; j < 6; j++)
            {
                for (int i = 4; i >= 0; i--)
                {
                    P_A temp = A[find(T[i, j])[0], find(T[i, j])[1]];
                    if (temp.P.Top == -height)
                    {
                        while (temp.P.Top != top.Peek())
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Top += height;
                            delay(second);
                        }
                        //sound.Audio.Play("short_punch1.wav");
                        top.Dequeue();
                    }

                }
            }

        }
        int random_color()
        {

            int a = r.Next(1, 7);//1,2,3,4,5,6(補血)
            int b =0;
            switch (a)
            {
                case 1:
                    b = 3;
                    break;
                case 2:
                    b = 4;
                    break;
                case 3:
                    b = 2;
                    break;
                case 4:
                    b = 0;
                    break;
                case 5:
                    b = 1;
                    break;
                case 6:
                    b = 5;
                    break;
            }
            return b;
        }
        void clear()
        {
            T_x_y_3.Clear();
            T_x_y_4.Clear();
            T_x_y_5.Clear();
            T_x_y_6.Clear();
            //  bool[,] yes_no = new bool[5, 4];//6,5,4,3
            T_x_y_3_2.Clear();
            T_x_y_4_2.Clear();
            T_x_y_5_2.Clear();
            // bool[,] yes_no2 = new bool[6, 4];//6,5,4,3
            combo_start.Clear();
            combo_total.Clear();
            color_R.Clear();
            color_D.Clear();
            color_F.Clear();
            color_G.Clear();
            color_Y.Clear();
            color_B.Clear();
            number = 1;
            label44.Visible = false;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    yes_no[i, j] = false;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    yes_no2[i, j] = false;
                }
            }
        }
        class point
        {
            public int x;
            public int y;
            public P_A z;//顏色
            public int w = 0;//多少連線
            public int s = 0;//row0 or column1
            public int q = 0;//是否有相連的編號，編號依樣代表相連
            public int space;//空的point,分隔
            public point(int x, int y, P_A z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                q = 0;
            }
            public point(int x, int y)
            {
                this.x = x;
                this.y = y;
                q = 0;
            }
            public point(int x, int y, P_A z, int w, int s)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.w = w;
                this.s = s;
                q = 0;
            }
            public point()
            {
                space = 0;
            }
        }
        class P_A
        {
            public PictureBox P;
            public int A;
            public P_A()
            {
            }
            public P_A(PictureBox P)
            {
                this.P = P;
            }
            public P_A(PictureBox P, int A)
            {
                this.P = P;
                this.A = A;
            }
        }
        //List<int> combo_number = new List<int>();
        void count(List<point>color,int c)//
        {  
            Stack<int> count = new Stack<int>();
            for (int i = 0; i < color.Count(); i++)
            {
                if (i != 0 && color[i].q == color[i-1].q)
                {
                    int y = count.Pop();
                    count.Push(y + color[i].w-1);
                }
                else
                {
                    count.Push(color[i].w);
                }
            }
            t1.Text+= Environment.NewLine;
            while (count.Count()!=0)
            {
                int x = count.Pop();//6
                if (x >= 5)//判斷全體攻擊
                {
                    bigattack[c] = true;
                }
                if(x==3)
                    attack[c] +=1;
                else
                {
                    attack[c] += 1 + (x - 3) * 0.25;
                }
                
                t1.Text += "" + x + "!!"; 
            }
            t1.Text +="~"+ attack[c];
            
            t1.Text += Environment.NewLine;
        }

        int maxattack_one = 0;
        double leader;
        double leader2;
        void play(){
            
            double comboadd = (1 + (rr - 1) * 0.25);
            
            for (int i = 0; i < 6; i++)//每一隻
            {
            int last_attack = user[i].user_attack(attack, comboadd);
            

                if (bigattack[user[i].attribute])
                {
                    if (last_attack != 0)
                    {
                        for (int j = 0; j < monster_number; j++)
                        {
                            if (smallM_true[j].blood_now > 0)
                            {

                                last_attack = (int)Math.Round(last_attack * res(user[i].attribute, smallM_true[j].attribute));
                                last_attack *=Convert.ToInt32( Math.Round( leader * leader2));//隊長技
                                if (last_attack >= smallM_true[j].defead)
                                {
                                    last_attack = last_attack - smallM_true[j].defead;
                                }
                                else
                                {
                                    last_attack = 1;
                                }
                                smallM_true[j].blood_now -= last_attack;
                                if (smallM_true[j].blood_now <= 0)
                                {
                                    smallM_true[j].blood_now = 0;
                                }
                                /*
                                name[j].Text = "";
                                name[j].Text += "攻擊" + smallM_true[j].attack + "\n";
                                name[j].Text += "血量" + smallM_true[j].blood_now+"\n";
                                name[j].Text += "cd" + smallM_true[j].cd_now;
                                 */
                                Mpicture[j].BackColor = whichColor(user[i].attribute);
                                blood[j].Width = (blood_length * smallM_true[j].blood_now) / smallM_true[j].blood;
                                delay(0.2);
                                Mpicture[j].BackColor = Color.Transparent;
                            }
                        }
                    }
                }
                else
                {
                   
                  //先攻擊血量最少的
                    int[] f = new int[monster_number];
                    for (int j = 0; j < monster_number; j++)
                    {
                        f[j] = j;
                    }
                    for (int j = 0; j < monster_number-1; j++)
                    {
                        for (int k = j+1; k < monster_number; k++)
                        {
                            if (smallM_true[j].blood_now > smallM_true[k].blood_now)
                            {
                                int temp = f[j];
                                f[j] = f[k];
                                f[k] = temp;
                            }
                        }
                    }
                    for (int j = 0; j < monster_number; j++)
                    {
                        if (smallM_true[f[j]].blood_now > 0)
                        {

                            if (last_attack != 0)
                            {
                                last_attack = (int)Math.Round(last_attack * res(user[i].attribute, smallM_true[j].attribute));
                                last_attack *= Convert.ToInt32(Math.Round(leader * leader2));//隊長技
                                if (last_attack >= smallM_true[j].defead)
                                {
                                    last_attack = last_attack - smallM_true[j].defead;
                                }
                                else
                                {
                                    last_attack = 1;
                                }
                                smallM_true[f[j]].blood_now -= last_attack;

                                if (smallM_true[f[j]].blood_now <= 0)
                                {
                                    smallM_true[f[j]].blood_now = 0;
                                }
                                /*
                                name[f[j]].Text = "";
                                name[f[j]].Text += "攻擊" + smallM_true[f[j]].attack + "\n";
                                name[f[j]].Text += "血量" + smallM_true[f[j]].blood_now + "\n"; ;
                                name[f[j]].Text += "cd" + smallM_true[f[j]].cd_now;
                                 */ 
                                blood[f[j]].Width = (blood_length * smallM_true[f[j]].blood_now) / smallM_true[f[j]].blood;
                                Mpicture[f[j]].BackColor = whichColor(user[i].attribute);
                                delay(0.2);
                                Mpicture[f[j]].BackColor = Color.Transparent;
                                break;
                            }
                        }
                    }

                }

                if (last_attack != 0)
                {
                    ud[i].Text = "" + last_attack;
                    ud[i].Visible = true;
                }

               // 紀錄攻擊
            if (last_attack > maxattack_one)
            {
                maxattack_one = last_attack;
            }
                  

            }
            int count = 0;
            for (int i = 0; i < monster_number; i++)
            {
                if (smallM_true[i].blood_now == 0)
                {
                    count++;
                }
            }
            monster_alive = monster_number - count;//如果monster_alive等於0，代表可以進入下一關
            label40.Text = "" + monster_alive+"\n"+monster_number;
        }
        double res(int a,int b)//a:使用者，b電腦
        {
            if (a == 3 && b == 0||a==4&&b==3||a==0&&b==4)
            {
                return 1.5;
            }else if(a==2&&b==1||a==1&&b==2){
                return 1;
            }else
            {
                return 0.6;
            }



        }

        int blood_length=0;
        int drop;//掉卡
        int final_round = total_monster.roundaa;//總共幾關
        int rightnow_round = 0;//!!!!傳值!!!!! //傳入關卡隊伍編號

        void addnewmonster()
        {
            round_show();
            monster_number = r.Next(2, 4);//產生幾隻
            int width = 300 / monster_number;
            blood_length = (300 - (monster_number + 1) * 1) / monster_number;
            if (rightnow_round == final_round || rightnow_round == final_round-1)
            {
                monster_number = 1;
            }
            if (monster_number == 1)
            {
                blood_length = 165;
            }
            drop = r.Next(0, monster_number);//掉卡
            for (int i = 0; i < monster_number; i++)
            {
                int number2 = r.Next(0, 4);//每隻是甚麼怪物
               // label43.Text = "" + number2;
                if (rightnow_round == final_round)
                {
                    //monster_number = 1;
                    smallM_true[i] = new monster(total_monster.monsterR[total_monster.round_monster[total_monster.choose, 5]]);//魔王
                }else if (rightnow_round == final_round-1)
                {
                    smallM_true[i] = new monster(total_monster.monsterR[total_monster.round_monster[total_monster.choose, 4]]);//魔王
                }else
                    smallM_true[i] = new monster(total_monster.monsterR[total_monster.round_monster[total_monster.choose, number2]]);//smallM[number2].pic, smallM[number2].attribute, smallM[number2].cd, smallM[number2].attack, smallM[number2].blood
                

                Mpicture[i] = new PictureBox();
                Mpicture[i].BackColor = Color.Transparent;
                Mpicture[i].Image = smallM_true[i].im;//錯誤
                Mpicture[i].Left = width * i +  blood_length *2/9;//13 + width * i//((300 - Convert.ToInt32(Math.Round(blood_length * 0.6)) * monster_number) / (monster_number + 1))*(i+1) + Convert.ToInt32(Math.Round(blood_length * 0.6))*i
                Mpicture[i].Top = 122 - Convert.ToInt32(Math.Round(blood_length * 0.6));//40
                Mpicture[i].Width =Convert.ToInt32(Math.Round(blood_length*0.6));//70
                Mpicture[i].Height = Convert.ToInt32(Math.Round(blood_length *0.6));//80
                Mpicture[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Mpicture[i].Name = "" + i//嘗試
;                /////
                blood2[i] = new Label();
                blood2[i].Left =  width * i;
                blood2[i].Top = 133-1;//133-1
                blood2[i].Width = blood_length;//91
                blood2[i].Height = 5;
                blood2[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                blood[i] = new Label();
                blood[i].Image = Image.FromFile("red.png");
                blood[i].Width = blood_length;//90
                blood[i].Height = 3;
                blood[i].Left = 0 + width * i;
                blood[i].Top = 133;
                blood[i].BackColor = Color.Teal;
                if (monster_number == 1)
                {
                    Mpicture[i].Left += 70;
                    blood2[i].Left += 70;
                    blood[i].Left += 70;

                }
                /*
                /////
                name[i] = new Label();
                name[i].Image = Image.FromFile("w2.png"); 
                name[i].BackColor = Color.Transparent;
                name[i].Width = 135;//60
                name[i].Height = 100;//30
                name[i].Left = 85;// 10 + width * i
                name[i].Top = 50;//5
                name[i].BackColor = Color.White;
                name[i].Font = new Font("新細明體", 10);
                name[i].ForeColor = Color.White;
                name[i].TextAlign = ContentAlignment.MiddleCenter;
                //////
                name[i].Text += "名稱" + smallM_true[i].namem+ "\n";
                name[i].Text += "防禦" + smallM_true[i].defead + "\n";
                name[i].Text += "攻擊" + smallM_true[i].attack+"\n";
                name[i].Text += "血量" + smallM_true[i].blood_now+"\n";
                name[i].Text += "cd" + smallM_true[i].cd_now;
                p1.Controls.Add(name[i]);
                name[i].Hide();//嘗試
                 */ 
                pa3.Controls.Add(blood[i]);
                pa3.Controls.Add(blood2[i]);
                pa3.Controls.Add(Mpicture[i]);
                Mpicture[i].BringToFront();
                Mpicture[i].MouseHover += new System.EventHandler(MouseHover1);
                Mpicture[i].MouseLeave += new System.EventHandler(MouseLeave1);
            }

             
        }


        private void user1_Click(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            if (temp.Top == 143)
            {
                int num = temp.Left / 50;
                DialogResult result = MessageBox.Show(user[num].skillname, "使用技能", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ///label31.Text += "" + num;
                    skill(user[num].skilln);
                    temp.Top += 3;
                }
            }

        }
        public void skill(int a){

            if (a == 0)
            {//光轉心
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 1)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 5;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[5];
                        }
                        //A[find(T[i, j])[0], find(T[i, j])[1]].A
                    }
                }
            }
            else if (a == 1)
            {//木轉心
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 0)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 5;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[5];
                        }
                        //A[find(T[i, j])[0], find(T[i, j])[1]].A
                    }
                }
            }
            else if (a == 2)
            {//心轉木，水轉心
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 5)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 0;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[0];
                        }
                        else if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 4)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 5;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[5];
                        }
                        //A[find(T[i, j])[0], find(T[i, j])[1]].A
                    }
                }
            }
            else if (a == 3)
            {//心轉火
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 5)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 3;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[3];
                        }
                    }
                }
            }
            else if (a == 4)
            {//2回合內，火屬性攻擊10倍
                 skill_round[3] = 2;
                for (int i = 0; i < 6; i++)
                {
                    if(i==3)
                    extra_attack[i] = 10;
                }
            }
            else if (a == 5)//暗光轉木
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 1||A[find(T[i, j])[0], find(T[i, j])[1]].A == 2)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 0;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[0];
                        }
                    }
                }
            }
            else if (a == 6)//水轉心
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 4 )
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 5;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[5];
                        }
                    }
                }
            }
            else if (a == 7)//2回合內木屬性攻擊10倍
            {
                skill_round[0] = 2;
                for (int i = 0; i < 6; i++)
                {
                    if (i == 0)
                        extra_attack[i] = 10;
                }
            }
            else if (a == 8)//心轉水
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 5)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 4;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[4];
                        }
                    }
                }
            }
            else if (a == 9)//暗光轉水
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 1 || A[find(T[i, j])[0], find(T[i, j])[1]].A == 2)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 4;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[4];
                        }
                    }
                }
            }
            else if (a == 10)//2回合內水屬性攻擊10倍
            {
                skill_round[4] = 2;
                for (int i = 0; i < 6; i++)
                {
                    if (i == 4)
                        extra_attack[i] = 10;
                }
            }
            else if (a == 11)//暗轉心
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 2)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 5;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[5];
                        }
                    }
                }
            }
            else if (a == 12)//心轉光  
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 5)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 1;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[1];
                        }
                    }
                }
            }
            else if (a == 13)//水‧木轉光
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (A[find(T[i, j])[0], find(T[i, j])[1]].A == 4||A[find(T[i, j])[0], find(T[i, j])[1]].A == 0)
                        {
                            A[find(T[i, j])[0], find(T[i, j])[1]].A = 1;
                            A[find(T[i, j])[0], find(T[i, j])[1]].P.Image = picture[1];
                        }
                    }
                }
            }
            else if (a == 14)//2回合內光屬性攻擊10倍
            {
                skill_round[1] = 2;
                for (int i = 0; i < 6; i++)
                {
                    if (i == 1)
                        extra_attack[i] = 10;
                }
            } 
        }
        
        private void timer_limit_2_Tick(object sender, EventArgs e)
        {
            
            count_down.Width -= 1;
            if (count_down.Width == 0)
            {
                label31.Text = "fofofofof";
                user_blood_1.Visible = true;
                count_down.Visible = false;
                count_down.Width = 300;
                timer_limit_2.Enabled = false;
                core();
            }
        }

        private void MouseHover1(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int n =Convert.ToInt32(p.Name);
            // /////////////////////

            //name[i] = new Label();
            name.Image = Image.FromFile("w2.png");
            name.BackColor = Color.Transparent;
            name.Width = 135;//60
            name.Height = 100;//30
            name.Left = 85;// 10 + width * i
            name.Top = 50;//5
            name.BackColor = Color.White;
            name.Font = new Font("新細明體", 10);
            name.ForeColor = Color.White;
            name.TextAlign = ContentAlignment.MiddleCenter;
            //////
            name.Text += "名稱:" + smallM_true[n].namem + "("+which(smallM_true[n].attribute) +")"+ "\n";
            name.Text += "防禦:" + smallM_true[n].defead + "\n";
            name.Text += "攻擊:" + smallM_true[n].attack + "\n";
            name.Text += "血量:" + smallM_true[n].blood_now + "\n";
            name.Text += "cd:" + smallM_true[n].cd_now;
            //p1.Controls.Add(name[n]);
            //name.Hide();//嘗試
            // /////////////////////
            name.BringToFront();
            name.Show();
        }
        String which(int a)
        {
            if (a == 0)
            {
                return "木";
            }
            else if (a == 1)
            {
                return "光";

            }
            else if (a == 2)
            {
                return "暗";
            }
            else if (a == 3)
            {
                return "火";
            }
            else if (a == 4)
            {
                return "水";
            }
            else
            {
                return "";
            }
        }
        private void MouseLeave1(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int n = Convert.ToInt32(p.Name);
            name.Text = "";
            name.Hide();
        }

        private void 返回主畫面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            total_monster.f.Show();
            total_monster.dd.Ctlcontrols.play();

        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            // ///////顯示第幾關//////////
            addnewmonster();
            // ///////////////////
        }

        private void 關卡資訊ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 關卡資訊ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            main_round A = new main_round(rightnow_round, Round);
            A.ShowDialog();
        }

        private void 作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_writer A = new main_writer();
            A.ShowDialog();

        }

        private void 玩法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_c A = new main_c();
            A.ShowDialog();
        }

        private void 簡介ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_d A = new main_d();
            A.ShowDialog();
        }








    
    }
}
