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
    public partial class main_c : Form
    {
        public main_c()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            t1.Text = "回合按下一顆符石移動，不論有沒有符石被消除亦作一回合計算。敵人距離攻擊的回合根據此規則計算，而召喚獸技能的冷卻時間只會在符石被消除的回合減少。時間系統有限制移動符石的時間，在每次玩家開始移動符石時，限制時間會開始倒數，此時玩家的血條部分會暫時變成倒數器顯示剩餘時間，在此段時間玩家可以隨意移動符石到不同位置。在沒有開始移動符石的情況下，遊戲不會限制玩家的思考時間。移動符石時，符石會與位於移動方向的符石交換位置，在限制時間內玩家不會被限制交換位置的次數，意思就是說玩家可以在一回合內以完美的移動路線交換各符石的位置達成多次符石消除。符石移動方向符石可以向八個方向移動，玩家可以先掌握上下左右四個方向的基本技巧，再挑戰斜線移動符石（俗稱斜轉）。符石消除規則當三個或以上相同顏色的符石形成一線就會消除。消除的符石越多傷害或回復力越高。每回合中多次消除符石會生成Combo，Combo的增加會加強該回合的傷害或回復力效果。如果達成兩次或更多消除的條件以及顏色相同的符石有連接的時候，只作一次消除計算消除一種顏色符石時，該符石所屬屬性的召喚獸會發動攻擊，單次消除符石數量越多，傷害加成越多。基本情況下3顆符石被消除效果為100%，每消除多一顆符石，效果提升25%單次消除5個或以上相同顏色符石時，召喚獸會對敵人造成全體傷害。消除心符石時，玩家生命力會回復一定數量，回復生命數值的計算方式與傷害值相同，隨著被消除的符石數量增加而增加回復生命數值。多次消除符石計算（Combo）每回合多次消除符石會生成Combo，Combo的增加會加強該回合消除符石造成的傷害及回復力效果。Combo加成倍率與Combo字樣會在界面右下方跳出顯示。每個Combo會增加25%該回合最終造成的所有傷害和回復生命數值。";
        }
    }
}
