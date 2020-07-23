using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCalc
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }


        public void CalcForm_Load(object sender, EventArgs e)
        {
            // By #NEKO
            // http://www.NEKOnsole.com
            // Ver2.0.0-R
        }

        public void Button_Click(object sender, EventArgs e)
        {
            // 教科ごとの点数
            int Ja_Me, En_Me, Ma_Me, Sc_Me, So_Me;
            int Ja_Aver, En_Aver, Ma_Aver, Sc_Aver, So_Aver;

            // 結果
            int Total_Me, Total_Aver;

            // 点数の変数化
            Ja_Me               = Convert.ToInt32(Ja_MeBox.Text);
            En_Me               = Convert.ToInt32(En_MeBox.Text);
            Ma_Me               = Convert.ToInt32(Ma_MeBox.Text);
            Sc_Me               = Convert.ToInt32(Sc_MeBox.Text);
            So_Me               = Convert.ToInt32(So_MeBox.Text);

            // 平均の変数化
            Ja_Aver             = Convert.ToInt32(Ja_AverBox.Text);
            En_Aver             = Convert.ToInt32(En_AverBox.Text);
            Ma_Aver             = Convert.ToInt32(Ma_AverBox.Text);
            Sc_Aver             = Convert.ToInt32(Sc_AverBox.Text);
            So_Aver             = Convert.ToInt32(So_AverBox.Text);

            // 結果の変数化と計算
            Total_Me            = Ja_Me + En_Me + Ma_Me + Sc_Me + So_Me;
            Total_Aver          = Ja_Aver + En_Aver + Ma_Aver + Sc_Aver + So_Aver;

            // 結果を出力
            Ja_PRText.Text      = Convert.ToString(50 + (Ja_Me - Ja_Aver) / 2);
            En_PRText.Text      = Convert.ToString(50 + (En_Me - En_Aver) / 2);
            Ma_PRText.Text      = Convert.ToString(50 + (Ma_Me - Ma_Aver) / 2);
            Sc_PRText.Text      = Convert.ToString(50 + (Sc_Me - Sc_Aver) / 2);
            So_PRText.Text      = Convert.ToString(50 + (So_Me - So_Aver) / 2);

            Total_MeText.Text   = Convert.ToString(Total_Me);
            Total_AverText.Text = Convert.ToString(Total_Aver);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
