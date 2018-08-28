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
    public partial class main_card : Form
    {

        public main_card(Image a,int b,int c, int d,String e,String f,int g,String namex,int race1,String leadern,String leader)
        {
            InitializeComponent();
            pic.Image = a;
            life.Text += "" + b;
            attackt.Text += "" + c;
            recovert.Text += "" + d;
            name2.Text += e;
            skillt.Text += f;
            cd.Text += "" + g;
            name_x.Text += "" + namex;
            race.Text = which(race1);
            name4.Text = leadern;
            leadert.Text = leader;

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
        public main_card() { }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Dispose();
            }
        }

        private void name_x_Click(object sender, EventArgs e)
        {

        }
    }
}
