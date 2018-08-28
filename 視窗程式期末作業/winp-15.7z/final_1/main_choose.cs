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
    public partial class main_choose : Form
    {
        public main_choose()
        {
            InitializeComponent();
        }

        private void b2_Click(object sender, EventArgs e)//關卡資訊選擇
        {
            Label b=(Label)sender;
            total_monster.choose = Convert.ToInt32(b.Name);
            //main_partner A = new main_partner(total_monster.teamn[total_monster.choose, 0]);
            main_choose2 A=new main_choose2();
            A.Show();
            this.Dispose();
        }
        int y = 0;
        private void Form5_Load(object sender, EventArgs e)
        {
            Panel QQ = new Panel();
            QQ.Size = new Size(260, 290);
            QQ.BackColor = Color.Transparent;
            QQ.Location = new Point(80, 125);
            QQ.AutoScroll = true;
            for (int i = 0; i < 8; i++)
            {
                
                Label a = new Label();
                //if ((i + 1) % 2 == 0)
                    a.BackColor = Color.Yellow;
                //else
                   // a.BackColor = Color.Blue;
                a.Name = "" + i;
                a.Width = 240;
                a.Font = new Font("新細明體", 15);
                a.TextAlign = ContentAlignment.MiddleCenter;
                a.Height = 38;
                a.Location = new Point(0, y);
                a.Text += total_monster.teamn[i, 0];
                a.Click += new System.EventHandler(b2_Click);
                y += 50;
                QQ.Controls.Add(a);
            }
            this.Controls.Add(QQ);
        }

        private void 返回主畫面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            total_monster.f.Show();

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
