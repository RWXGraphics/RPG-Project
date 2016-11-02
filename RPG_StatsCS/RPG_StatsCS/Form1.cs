using System;
using System.Windows.Forms;
using RPG_StatsCS;

namespace RPG_StatsCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //int start = 520;
        private void btn_GenStats_Click(object sender, EventArgs e)
        {
            //Stats aStat = new Stats();
            //aStat.randomStats();

            Random rand = new Random();
            if (lbl_StartPoints.Text == "520")
            {
                txtBox_AGIStat.Text = rand.Next(0, 150).ToString();

                double f1, f2, s;
                double.TryParse(lbl_StartPoints.Text, out f1);
                double.TryParse(txtBox_AGIStat.Text, out f2);
                s = f1 - f2;
                if (s <= 520)
                    lbl_FPoints.Text = s.ToString("c").Remove(0, 1);
                lbl_StartPoints.Text = lbl_FPoints.Text;
            }


            if (lbl_StartPoints.Text == lbl_FPoints.Text)
            {
                txtBox_CONStat.Text = rand.Next(0, 75).ToString();
                double f3, f4, s1;
                double.TryParse(lbl_StartPoints.Text, out f3);
                double.TryParse(txtBox_CONStat.Text, out f4);
                s1 = f3 - f4;
                if (s1 <= 520)
                    lbl_FPoints.Text = s1.ToString("c").Remove(0, 1);
                lbl_StartPoints.Text = lbl_FPoints.Text;
            }

            if (lbl_StartPoints.Text == lbl_FPoints.Text)
            {
                txtBox_DEXStat.Text = rand.Next(0, 50).ToString();
                double f5, f6, s2;
                double.TryParse(lbl_StartPoints.Text, out f5);
                double.TryParse(txtBox_DEXStat.Text, out f6);
                s2 = f5 - f6;
                if (s2 <= 520)
                    lbl_FPoints.Text = s2.ToString("c").Remove(0, 1);
                lbl_StartPoints.Text = lbl_FPoints.Text;                
            }
            if (lbl_StartPoints.Text == lbl_FPoints.Text)
            {
                txtBox_STRStat.Text = rand.Next(0, 50).ToString();
                double f7, f8, s3;
                double.TryParse(lbl_StartPoints.Text, out f7);
                double.TryParse(txtBox_STRStat.Text, out f8);
                s3 = f7 - f8;
                if (s3 <= 520)
                    lbl_FPoints.Text = s3.ToString("c").Remove(0, 1);
                lbl_StartPoints.Text = lbl_FPoints.Text;                
            }
            if (lbl_StartPoints.Text == lbl_FPoints.Text)
            {
                txtBox_CHARStat.Text = rand.Next(0, 50).ToString();
                double f9, f10, s4;
                double.TryParse(lbl_StartPoints.Text, out f9);
                double.TryParse(txtBox_CHARStat.Text, out f10);
                s4 = f9 - f10;
                if (s4 <= 520)
                    lbl_FPoints.Text = s4.ToString("c").Remove(0, 1);
                lbl_StartPoints.Text = lbl_FPoints.Text;                
            }
            if (lbl_StartPoints.Text == lbl_FPoints.Text)
            {
                txtBox_FACStat.Text = rand.Next(0, 50).ToString();
                double f11, f12, s5;
                double.TryParse(lbl_StartPoints.Text, out f11);
                double.TryParse(txtBox_FACStat.Text, out f12);
                s5 = f11 - f12;
                if (s5 <= 520)
                    lbl_FPoints.Text = s5.ToString("c").Remove(0, 1);
                lbl_StartPoints.Text = lbl_FPoints.Text;
                btn_GenStats.Enabled = false;
            }
            if (lbl_StartPoints.Text == lbl_FPoints.Text)
            {
                txtBox_INTLStat.Text = rand.Next(0, 50).ToString();
                double f13, f14, s6;
                double.TryParse(lbl_StartPoints.Text, out f13);
                double.TryParse(txtBox_FACStat.Text, out f14);
                s6 = f13 - f14;
                if (s6 <= 520)
                    lbl_FPoints.Text = s6.ToString("c").Remove(0, 1);
                lbl_StartPoints.Text = lbl_FPoints.Text;
                btn_GenStats.Enabled = false;
            }
            if (lbl_StartPoints.Text == lbl_FPoints.Text)
            {
                txtBox_INTUStat.Text = rand.Next(0, 50).ToString();
                double f15, f16, s7;
                double.TryParse(lbl_StartPoints.Text, out f15);
                double.TryParse(txtBox_INTUStat.Text, out f16);
                s7 = f15 - f16;
                if (s7 <= 520)
                    lbl_FPoints.Text = s7.ToString("c").Remove(0, 1);
                lbl_StartPoints.Text = lbl_FPoints.Text;
                btn_GenStats.Enabled = false;
            }
        }


    private void button2_Click(object sender, EventArgs e)
        {
            lbl_FPoints.Text = "";
            lbl_StartPoints.Text = "520";
            btn_GenStats.Enabled = true;
            txtBox_AGIStat.Text = "000";
            txtBox_CONStat.Text = "000";
            txtBox_DEXStat.Text = "000";
            txtBox_STRStat.Text = "000";
            txtBox_CHARStat.Text = "000";
            txtBox_FACStat.Text = "000";
            txtBox_INTLStat.Text = "000";
            txtBox_INTUStat.Text = "000";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBox_Name.Focus();
        }
    }
}
