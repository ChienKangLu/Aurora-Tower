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
    public partial class main_partner : Form
    {
        String t;
        public main_partner(string a)
        {
            InitializeComponent();
            t = a;
        }
        Color which(int a)
        {
            if (a == 0)
            {
                return Color.FromArgb(60,0,255,0);
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
                return Color.FromArgb(60, 255,0,0); 
            }
            else if (a == 4)
            {
                return Color.FromArgb(60, 0 ,0,255); 
            }
            else
            {
                return Color.FromArgb(60, 0, 0, 0); ;
            }
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            title.Text = t;
            int lo = 0;

            for (int i = 0; i < 53; i++)
            {
                PictureBox a = new PictureBox();
                a.Height = 50;
                a.Width = 60;
                a.SizeMode = PictureBoxSizeMode.StretchImage;

                a.BackColor = which(total_monster.monster[i].attribute);
                a.Image = total_monster.monster[i].im;
               // a.BackColor = Color.White;
                a.Location = new Point(20, lo+80);
                a.Click += new System.EventHandler(p_Click);
                a.Name = "" + i;
                ////////////////////////////////
                Label b = new Label();
                b.BackColor = Color.FromArgb(120,122,197,255);
                b.Font = new Font("新細明體",10);
                b.TextAlign = ContentAlignment.MiddleCenter;
                b.Text += "" + total_monster.monster[i].namem;
                b.Height = 45;
                b.Width = 150;
                b.Location = new Point(80, lo+80);
                b.Name = "" + i;
                b.Click += new System.EventHandler(b_Click);
                ////////////////////////////////
                /*
                Button c = new Button();
                c.Text += "選" + "\n" + "擇";
                c.Name = "" + (a.Top / 60);
                c.Height = 50;
                c.Width = 30;
                c.Location = new Point(210, lo+50);
                c.Click += new System.EventHandler(b_Click);
                 */ 
                ////////////////////////////////
                lo+=60;
                this.Controls.Add(a);
                this.Controls.Add(b);
                //this.Controls.Add(c);
               // c.BringToFront();

            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            Label c = (Label)sender;
            int b = Convert.ToInt32(c.Name);
            DialogResult result = MessageBox.Show(total_monster.monster[Convert.ToInt32(c.Name)].namem, "確認選擇隊友", MessageBoxButtons.OKCancel);
            total_monster.six = b;
            if (result == DialogResult.OK)
            {
                main_enter A = new main_enter();
                A.Show();
                this.Hide();
            }
        }
        private void p_Click(object sender, EventArgs e)
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
            int y = total_monster.monster[Convert.ToInt32(a.Name)].attribute;
            String qq = total_monster.monster[Convert.ToInt32(a.Name)].leadern;
            String ll = total_monster.monster[Convert.ToInt32(a.Name)].leader;
            main_card A = new main_card(q, b, c, d, f, g, h, w,y,qq,ll);
            A.ShowDialog();
        }

        private void 返回主畫面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            total_monster.f.Show();
            total_monster.dd.Ctlcontrols.play();
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
