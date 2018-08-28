using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace final_1
{
    class monster
    {
       public String namem;
        public int blood;//真實血量
        public int blood_now;//現在這一回合被打的血量
        public int attack;
        public int attribute;//屬性
        public int pic;//頭像
        public int cd;
        public int cd_now;
        public int die;//生or死
        public int recover;//回復
        public int skilln;
        public String skillname;
        public String skillname2;
        public Image im;//頭像(更正)
        public int defead;//防禦(小怪)
        public int card;//掉卡
        public String leadern;
        public String leader;
        public double leadera;
        public monster(int pic,int attribute,int cd,int attack,int blood)
        {
            this.pic = pic;
            this.attribute = attribute;
            this.cd = cd;
            this.attack = attack;
            this.blood = blood;
            die = 1;
            blood_now = blood;
            cd_now = cd;
        }
        public monster(int pic, int attribute, int cd, int attack, int blood, int recover, int skilln, String skillname)
        {
            this.pic = pic;
            this.attribute = attribute;
            this.cd = cd;
            this.attack = attack;
            this.blood = blood;
            die = 1;
            blood_now = blood;
            cd_now = cd;
            this.recover = recover;
            this.skilln = skilln;
            this.skillname = skillname;

        }
        public monster( int n)
        {
        }
        // ///////////////正確版本//////////////////////
        public monster(String namem, int attribute, int cd, int attack, int blood, int recover, int skilln, String skillname, Image im, String skillname2, String leadern, int leadera, String leader)
        {
            this.pic = pic;
            this.attribute = attribute;
            this.cd = cd;
            this.attack = attack;
            this.blood = blood;
            die = 1;
            blood_now = blood;
            cd_now = cd;
            this.recover = recover;
            this.skilln = skilln;
            this.skillname = skillname;
            this.im = im;
            this.skillname2 = skillname2;
            this.namem = namem;
            this.leadern = leadern;
            this.leadera = leadera;
            this.leader = leader;
        }
        public monster(monster m)
        {
            this.pic = m.pic;
            this.attribute = m.attribute;
            this.cd = m.cd;
            this.attack = m.attack;
            this.blood = m.blood;
            die = 1;
            blood_now = m.blood;
            cd_now = m.cd;
            this.recover = m.recover;
            this.skilln = m.skilln;
            this.skillname = m.skillname;
            this.im = m.im;
            this.skillname2 = m.skillname2;
            this.namem = m.namem;
            this.defead =m.defead;
            this.card = m.card;
            this.leadern = m.leadern;
            this.leadera = m.leadera;
            this.leader = m.leader;
        }
        //小怪
        public monster(String namem, int attribute, int cd, int attack, int blood,int defead, Image im)
        {
            this.attribute = attribute;
            this.cd = cd;
            this.attack = attack;
            this.blood = blood;
            die = 1;
            blood_now = blood;
            cd_now = cd;
            this.im = im;
            this.namem = namem;
            this.defead = defead;
        }
        /// //////
        /// 
        public monster(int card,String namem, int attribute, int cd, int attack, int blood, int defead, Image im)//掉卡的建構子
        {
            this.attribute = attribute;
            this.cd = cd;
            this.attack = attack;
            this.blood = blood;
            die = 1;
            blood_now = blood;
            cd_now = cd;
            this.im = im;
            this.namem = namem;
            this.defead = defead;
            this.card=card;
        }

        // ///////////////////////////////////////

        public int user_attack(double[] attack, double comboadd)
        {
            int attr = this.attribute;
            int attack_a = this.attack;
            double bonus = attack[attr];
            int last_attack = Convert.ToInt32(attack_a *comboadd*bonus);
            return last_attack;
        }



    }
}
