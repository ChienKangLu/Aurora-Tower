using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_1
{
    public partial class main_team : Form
    {
        public main_team()
        {
            InitializeComponent();
        }
        PictureBox[] picture = new PictureBox[total_monster.total_card.Count];
        int[] picn = new int[total_monster.total_card.Count];
        int i = 0;
        int rigtnowteam = 0;
        private void Form7_Load(object sender, EventArgs e)
        {
            s1.Image = total_monster.monster[total_monster.team[0, 0]].im;
            s2.Image = total_monster.monster[total_monster.team[0, 1]].im;
            s3.Image = total_monster.monster[total_monster.team[0, 2]].im;
            s4.Image = total_monster.monster[total_monster.team[0, 3]].im;
            s5.Image = total_monster.monster[total_monster.team[0, 4]].im;
            b1.Enabled = false;
            //b2.Enabled = false;
            int location1 = 10;//垂直
            int location2 = 10;//水平
            int n = 0;
            for (int i = 0; i < total_monster.total_card.Count; i++)
            {
                picture[i] = new PictureBox();
                picture[i].Height = 50;
                picture[i].Width = 60;
                picture[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picture[i].Image = total_monster.monster[total_monster.total_card[i]].im;
                picture[i].BackColor = Color.Transparent;
                picture[i].Location = new Point(location2, location1);
                picture[i].Name = "" + i;
                picn[i] = total_monster.total_card[i];
                location2 += 70;//60
                n++;
                if (n == 4)
                {
                    n = 0;
                    location2 = 10;
                    location1 += 60;//50
                }
                card_panel.Controls.Add(picture[i]);

                picture[i].Click += new System.EventHandler(pic_click);
            }
        }
        Label []r = new Label[5];//位置是編號，int 是卡片
        int[] lo = new int[5];
        private void pic_click(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            if (choose)
            {
                

                if (i <= 4)
                {
                    r[i] = new Label();
                    if (a.BackColor == Color.Transparent)
                    {
                        a.BackColor = Color.Aqua;
                        r[i].BackColor = Color.White;
                        r[i].Left = a.Left;
                        r[i].Top = a.Top;
                        r[i].Size = new Size(10, 10);
                        r[i].Text += "" + (i + 1);
                        card_panel.Controls.Add(r[i]);
                        r[i].BringToFront();
                        total_monster.team[rigtnowteam, i] =picn[Convert.ToInt32(a.Name)];
                        lo[i] = Convert.ToInt32(a.Name);
                        i++;
                    }
                }
            }
            else
            {
                Image q = total_monster.monster[picn[Convert.ToInt32(a.Name)]].im;
                int b = total_monster.monster[picn[Convert.ToInt32(a.Name)]].blood;
                int c = total_monster.monster[picn[Convert.ToInt32(a.Name)]].attack;
                int d = total_monster.monster[picn[Convert.ToInt32(a.Name)]].recover;
                String f = total_monster.monster[picn[Convert.ToInt32(a.Name)]].skillname2;
                String g = total_monster.monster[picn[Convert.ToInt32(a.Name)]].skillname;
                int h = total_monster.monster[picn[Convert.ToInt32(a.Name)]].cd;
                String w = total_monster.monster[picn[Convert.ToInt32(a.Name)]].namem;
                int t = total_monster.monster[picn[Convert.ToInt32(a.Name)]].attribute;
                String qq = total_monster.monster[picn[Convert.ToInt32(a.Name)]].leadern;
                String ll = total_monster.monster[picn[Convert.ToInt32(a.Name)]].leader;
                main_card A = new main_card(q, b, c, d, f, g, h, w,t,qq,ll);
                A.ShowDialog();
            }

            if (i == 5)
            {
                b1.Enabled = true;
            }
        }
        /*
        int whichmonster(int a,int b)
        {
            return (a/50)*4+b/60;
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {

            //顯示該隊伍
            s1.Image = total_monster.monster[total_monster.team[rigtnowteam, 0]].im;
            s2.Image = total_monster.monster[total_monster.team[rigtnowteam, 1]].im;
            s3.Image = total_monster.monster[total_monster.team[rigtnowteam, 2]].im;
            s4.Image = total_monster.monster[total_monster.team[rigtnowteam, 3]].im;
            s5.Image = total_monster.monster[total_monster.team[rigtnowteam, 4]].im;
            for (int k = 0; k < 5; k++)
            {
                picture[lo[k]].BackColor = Color.Transparent;//SystemColors.Control
                r[k].Dispose();
            }
            i = 0;
            b1.Enabled = false;
            b2.Enabled = true;
            choose = false;

        }

        private void t2_Click(object sender, EventArgs e)
        {
            //改變選擇的顏色
            t1.BackColor = Color.FromArgb(255, 224, 192);
            t2.BackColor = Color.FromArgb(255, 224, 192);
            t3.BackColor = Color.FromArgb(255, 224, 192);
            t4.BackColor = Color.FromArgb(255, 224, 192);
            t5.BackColor = Color.FromArgb(255, 224, 192);
            t6.BackColor = Color.FromArgb(255, 224, 192);
            Label a = (Label)sender;
            a.BackColor = Color.FromArgb(255, 128, 128);
            int teamn=Convert.ToInt32(a.Name.Substring(1,1))-1;
            rigtnowteam = teamn;
            s1.Image = total_monster.monster[total_monster.team[teamn, 0]].im;
            s2.Image = total_monster.monster[total_monster.team[teamn, 1]].im;
            s3.Image = total_monster.monster[total_monster.team[teamn, 2]].im;
            s4.Image = total_monster.monster[total_monster.team[teamn, 3]].im;
            s5.Image = total_monster.monster[total_monster.team[teamn, 4]].im;
            
        }

        private void b4_Click(object sender, EventArgs e)
        {
            total_monster.f.Show();
            this.Dispose();
        }
        Boolean choose = false;
        private void b2_Click(object sender, EventArgs e)
        {
            choose = true;
            b2.Enabled = false;
        }

        private void s1_Click(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            Image q = total_monster.monster[total_monster.team[rigtnowteam,(a.Left-26)/53]].im;
            int b = total_monster.monster[total_monster.team[rigtnowteam, (a.Left - 26) / 53]].blood;
            int c = total_monster.monster[total_monster.team[rigtnowteam, (a.Left - 26) / 53]].attack;
            int d = total_monster.monster[total_monster.team[rigtnowteam, (a.Left - 26) / 53]].recover;
            String f = total_monster.monster[total_monster.team[rigtnowteam, (a.Left - 26) / 53]].skillname2;
            String g = total_monster.monster[total_monster.team[rigtnowteam, (a.Left - 26) / 53]].skillname;
            int h = total_monster.monster[total_monster.team[rigtnowteam, (a.Left - 26) / 53]].cd;
            String w = total_monster.monster[total_monster.team[rigtnowteam, (a.Left - 26) / 53]].namem;
            int t = total_monster.monster[total_monster.team[rigtnowteam, (a.Left - 26) / 53]].attribute;
            String qq = total_monster.monster[total_monster.team[rigtnowteam, (a.Left - 26) / 53]].leadern;
            String ll = total_monster.monster[total_monster.team[rigtnowteam, (a.Left - 26) / 53]].leader;
            main_card A = new main_card(q, b, c, d, f, g, h, w,t,qq,ll);
            A.ShowDialog();
        }


    }

}
