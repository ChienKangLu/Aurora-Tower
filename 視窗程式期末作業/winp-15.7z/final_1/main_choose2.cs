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
    public partial class main_choose2 : Form
    {
        public main_choose2()
        {
            InitializeComponent();
        }

        private void l1_Click(object sender, EventArgs e)
        {
            Label b = (Label)sender;
            if (b.Name.Equals("l1"))
            {
                total_monster.roundaa=5;
            }
            else if (b.Name.Equals("l2"))
            {
                total_monster.roundaa = 8;
            }
            else if (b.Name.Equals("l11"))
            {
                total_monster.roundaa = 10;
            }
            main_partner A = new main_partner(total_monster.teamn[total_monster.choose, 0]);
            A.Show();
            this.Dispose();
        }

        private void l3_Load(object sender, EventArgs e)
        {
            l1.Text = (total_monster.teamn[total_monster.choose, 1])+"初級";
            l2.Text = total_monster.teamn[total_monster.choose, 1]+"中級";
            l11.Text = total_monster.teamn[total_monster.choose, 1]+"高級";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            main_choose a = new main_choose();
            a.Show();
            this.Dispose();
        }
    }
}
