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
    public partial class main_victory : Form
    {
        public main_victory(int winorlose)
        {
            InitializeComponent();
            this.winorlose = winorlose;
        }
        int winorlose = 0;
        PictureBox[] drop = new PictureBox[total_monster.drop.Count];
        private void Form10_Load(object sender, EventArgs e)
        {

            total_monster.dd.Ctlcontrols.play();
            j1.Text = "" + total_monster.max_attack;
            j2.Text = "" + total_monster.max_recoer;
            j3.Text = "" + total_monster.round;
            j4.Text=""+total_monster.max_combo;
            title.Text = "" +total_monster.teamn[total_monster.choose,0];
            if (winorlose == 0)
            {
                v.Image = Image.FromFile("lose.png");
                l5.Text = "失敗";
            }
            else
            {
                v.Image = Image.FromFile("victory3.png");
                l5.Text = "完成";
            }

            int location=0;
            int location2=13;
            int n = 0;
            int q = total_monster.drop.Count;
            if (winorlose == 1)
            {
                for (int i = 0; i < q; i++)
                {
                    drop[i] = new PictureBox();
                    drop[i].BackColor = Color.Transparent;
                    drop[i].Location = new Point(location2, location);
                    drop[i].Width = 50;
                    drop[i].Height = 50;
                    total_monster.total_card.Add(total_monster.drop.Peek());
                    drop[i].Image = total_monster.monster[total_monster.drop.Pop()].im;
                    drop[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    b.Controls.Add(drop[i]);
                    n++;
                    location2 += 60;
                    if (n % 4 == 0)
                    {
                        location += 50;
                        location2 = 13;
                        n = 0;
                    }
                }
            }
            total_monster.drop.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            total_monster.f.Show();
            this.Dispose();
        }
    }
}
