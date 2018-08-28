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
    public partial class main_enter : Form
    {
        public main_enter()
        {
            InitializeComponent();
        }
        int rigtnowteam = 0;
        private void Form6_Load(object sender, EventArgs e)
        {
            s1.Image = total_monster.monster[total_monster.team[rigtnowteam, 0]].im;
            s2.Image = total_monster.monster[total_monster.team[rigtnowteam, 1]].im;
            s3.Image = total_monster.monster[total_monster.team[rigtnowteam, 2]].im;
            s4.Image = total_monster.monster[total_monster.team[rigtnowteam, 3]].im;
            s5.Image = total_monster.monster[total_monster.team[rigtnowteam, 4]].im;
            s6.Image = total_monster.monster[total_monster.six].im;
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
            int teamn = Convert.ToInt32(a.Name.Substring(1, 1)) - 1;
            rigtnowteam = teamn;
            s1.Image = total_monster.monster[total_monster.team[teamn, 0]].im;
            s2.Image = total_monster.monster[total_monster.team[teamn, 1]].im;
            s3.Image = total_monster.monster[total_monster.team[teamn, 2]].im;
            s4.Image = total_monster.monster[total_monster.team[teamn, 3]].im;
            s5.Image = total_monster.monster[total_monster.team[teamn, 4]].im;
            s6.Image = total_monster.monster[total_monster.six].im;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_play A = new main_play(rigtnowteam);
            total_monster.dd.Ctlcontrols.stop();
            A.Show();
            this.Hide();
        }

        private void s1_Click(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            int dqw = (a.Left - 6) / 53;
            int rr = 0;
            if ((a.Left - 6) / 53 == 5)
            {
                rr = total_monster.six;
            }
            else
            {
                rr = total_monster.team[rigtnowteam, dqw];
            }
                Image q = total_monster.monster[rr].im;
                int b = total_monster.monster[rr].blood;
                int c = total_monster.monster[rr].attack;
                int d = total_monster.monster[rr].recover;
                String f = total_monster.monster[rr].skillname2;
                String g = total_monster.monster[rr].skillname;
                int h = total_monster.monster[rr].cd;
                String w = total_monster.monster[rr].namem;
                int t = total_monster.monster[rr].attribute;
                String qq= total_monster.monster[rr].leadern;
                String ll = total_monster.monster[rr].leader;
                main_card A = new main_card(q, b, c, d, f, g, h, w,t,qq,ll);
                A.ShowDialog();
            
        }
    }
}
