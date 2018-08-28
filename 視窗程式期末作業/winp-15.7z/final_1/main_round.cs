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
    public partial class main_round : Form
    {
        int right;
        int round;
        public main_round(int right,int round)
        {
            InitializeComponent();
            this.right = right;
            this.round = round;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            int choose=total_monster.choose;
            l1.Text = total_monster.teamn[choose, 0];
            l2.Text = total_monster.teamn[choose, 1];
            l3.Text = right + "/" + total_monster.roundaa;
            l4.Text = ""+round;
            

        }

        private void l4_Click(object sender, EventArgs e)
        {

        }
    }
}
