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
    public partial class bag : Form
    {
        public bag()
        {
            InitializeComponent();
        }
        PictureBox[] picture = new PictureBox[total_monster.total_card.Count];
        
        private void Form3_Load(object sender, EventArgs e)
        {
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
                picture[i].Name = "" + total_monster.total_card[i];
                picture[i].Click += new System.EventHandler(c);
                location2 += 70;//60
                n++;
                if (n == 4)
                {
                    n = 0;
                    location2 = 10;
                    location1 += 60;//50
                }
                card_panel.Controls.Add(picture[i]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            
            a.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total_monster.f.Show();
            this.Dispose();
        }
        private void c(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            Image q = total_monster.monster[Convert.ToInt32(a.Name)].im;
            int b = total_monster.monster[Convert.ToInt32(a.Name)].blood;
            int c = total_monster.monster[Convert.ToInt32(a.Name)].attack;
            int d = total_monster.monster[Convert.ToInt32(a.Name)].recover;
            String f = total_monster.monster[Convert.ToInt32(a.Name)].skillname2;
            String g = total_monster.monster[Convert.ToInt32(a.Name)].skillname;
            int h = total_monster.monster[Convert.ToInt32(a.Name)].cd;
            String w = total_monster.monster[Convert.ToInt32(a.Name)].namem;
            int t = total_monster.monster[Convert.ToInt32(a.Name)].attribute;
            String qq = total_monster.monster[Convert.ToInt32(a.Name)].leadern;
            String ll = total_monster.monster[Convert.ToInt32(a.Name)].leader;
            main_card A = new main_card(q, b, c, d, f, g, h, w, t,qq,ll);
            A.ShowDialog();
        }
    }
}
