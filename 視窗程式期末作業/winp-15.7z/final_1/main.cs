using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
namespace final_1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        Computer sound = new Computer();
        private void b2_Click(object sender, EventArgs e)
        {
            main_choose a = new main_choose();
            a.Show();
            this.Dispose() ;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            main_team a = new main_team();
            a.Show();
            this.Hide(); ;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            door.Image = Image.FromFile("final_door_2.png");
            b2.Visible = true;
        }

        private void door_MouseLeave(object sender, EventArgs e)
        {
            door.Image = null;

            b2.Visible = false;
        }

        private void door_Click(object sender, EventArgs e)
        {
            sound.Audio.Play("1111.wav");
            main_choose a = new main_choose();
            a.Show();
            this.Hide();
        }

        private void LL_MouseHover(object sender, EventArgs e)
        {
            LL.Image = Image.FromFile("qw4.png");
            b4.Visible = true;
        }

        private void LL_MouseLeave(object sender, EventArgs e)
        {
            LL.Image = null;
            b4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            total_monster.dd = back2;
            total_monster.dd.Ctlcontrols.play();
            total_monster.f = this;
        }

        private void p8_MouseHover(object sender, EventArgs e)
        {
           p8.Image = Image.FromFile("right2.png");
            be.Visible = true;
        }

        private void p8_MouseLeave(object sender, EventArgs e)
        {
           p8.Image = null;
           be.Visible = false;
        }

        private void p8_Click(object sender, EventArgs e)
        {
            bag A=new bag();
            A.Show();
            this.Hide();
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
