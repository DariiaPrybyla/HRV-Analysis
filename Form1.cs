using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                string phrase = HR(value);

                label65.Text = phrase;
            }
        }
        private string HR(double value)
        {
            if (value < 55)
                return "Тахікардія";
            else if (value >= 60 && value <= 80)
                return "Показник в нормі";
            else if (value > 80)
                return "Брадикардія";
            else
                return "Не відомо";
        }
       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double value))
            {
                string phrase = SDNN(value);

                label66.Text = phrase;
            }
        }
        private string SDNN(double value)
        {
            if (value < 30)
                return "Інфаркт міокарда, діабет, гіпертонія";
            else if (value >= 30 && value <= 99)
                return "Показник в нормі";
            else
                return "Ішемічна хвороба серця";
        }
                
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double value))
            {
                string phrase = RMSSD(value);

                label67.Text = phrase;
            }
        }
        private string RMSSD(double value)
        {          
            if (value >= 25 && value <= 50)
                return "Показник в нормі";
            else if (value >= 18 && value < 25)
                return "Інфаркт міокарда, діабет, гіпертонія";
            else if (value < 18)
                return "Ішемічна хвороба серця";
            else
                return "Не відомо";
        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox4.Text, out double value))
            {
                string phrase = NN50(value);

                label68.Text = phrase;
            }
        }
        private string NN50(double value)
        {
            if (value >= 9 && value <= 11)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox5.Text, out double value))
            {
                string phrase = PNN50(value);

                label69.Text = phrase;
            }
        }
        private string PNN50(double value)
        {
            if (value >= 10 && value <= 30)
                return "Показник в нормі";
            else if (value >= 3 && value <= 8)
                return "Діабет, гіпертонія";
            else if (value < 3)
                return "Ішемічна хвороба серця";
            else
                return "Не відомо";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox6.Text, out double value))
            {
                string phrase = CV(value);

                label70.Text = phrase;
            }
        }
        private string CV(double value)
        {
            if (value >= 3 && value <= 12)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox7.Text, out double value))
            {
                string phrase = VI(value);

                label71.Text = phrase;
            }
        }
        private string VI(double value)
        {
            if (value < 2)
                return "Поточний функціон. стан значно знижено";
            else if (value >= 2 && value < 6)
                return "Поточний функціон. стан знижено";
            else if (value >= 6 && value < 11)
                return "Поточний функціон. стан задовільний";
            else
                return "Поточний функціон. стан добрий";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox8.Text, out double value))
            {
                string phrase = Mode(value);

                label72.Text = phrase;
            }
        }
        private string Mode(double value)
        {
            if (value >= 700 && value <= 900)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox9.Text, out double value))
            {
                string phrase = AMode(value);

                label73.Text = phrase;
            }
        }
        private string AMode(double value)
        {
            if (value >= 30 && value <= 50)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox10.Text, out double value))
            {
                string phrase = MxDMn(value);

                label74.Text = phrase;
            }
        }
        private string MxDMn(double value)
        {
            if (value >= 150 && value <= 450)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox11.Text, out double value))
            {
                string phrase = HRV(value);

                label75.Text = phrase;
            }
        }
        private string HRV(double value)
        {
            if (value >= 22 && value <= 52)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox12.Text, out double value))
            {
                string phrase = IVR(value);

                label76.Text = phrase;
            }
        }
        private string IVR(double value)
        {
            if (value >= 35 && value <= 145)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox13.Text, out double value))
            {
                string phrase = VPR(value);

                label77.Text = phrase;
            }
        }
        private string VPR(double value)
        {
            if (value >= 0.24 && value <= 0.7)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox14.Text, out double value))
            {
                string phrase = SI(value);

                label78.Text = phrase;
            }
        }
        private string SI(double value)
        {
            if (value >= 50 && value <= 150)
                return "Показник в нормі";
            else if (value >= 300 && value <= 500)
                return "Емоційний стрес, фізична робота";
            else if (value >= 600 && value <= 700)
                return "Стенокардія";
            else if (value >= 900 && value <= 1100)
                return "Передінфарктний стан";
            else
                return "Не відомо";
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox15.Text, out double value))
            {
                string phrase = L(value);

                label79.Text = phrase;
            }
        }
        
        private string L(double value)
        {
            int sex = comboBox1.SelectedIndex;
            if (sex == 0)
            {
                if (value >= 0.31 && value <= 0.45)
                    return "Показник в нормі для Ч (до 25 років)";
                else
                    return "Показник не в нормі";
            }
            else
            {
                if (value >= 0.27 && value <= 0.31)
                    return "Показник в нормі для Ж (до 25 років)";
                else
                    return "Показник не в нормі";
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox16.Text, out double value))
            {
                string phrase = HF(value);

                label80.Text = phrase;
            }
        }
        private string HF(double value)
        {
            if (value >= 772 && value <= 1178)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox17.Text, out double value))
            {
                string phrase = LF(value);

                label81.Text = phrase;
            }
        }
        private string LF(double value)
        {
            if (value >= 754 && value <= 1586)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox18.Text, out double value))
            {
                string phrase = VLF(value);

                label82.Text = phrase;
            }
        }
        private string VLF(double value)
        {
            if (value >= 765 && value <= 1400)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox19.Text, out double value))
            {
                string phrase = ULF(value);

                label83.Text = phrase;
            }
        }
        private string ULF(double value)
        {
            if (value >= 200 && value <= 311)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox20.Text, out double value))
            {
                string phrase = TP(value);

                label84.Text = phrase;
            }
        }
        private string TP(double value)
        {
            if (value >= 2350 && value <= 4550)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox21.Text, out double value))
            {
                string phrase = HF_p(value);

                label85.Text = phrase;
            }
        }
        private string HF_p(double value)
        {
            if (value >= 15 && value <= 25)
                return "Показник в нормі";
            else if (value >= 8 && value <= 10)
                return "Переважання симпатичного відділу";
            else if (value >= 2 && value <= 3)
                return "Різке переваження симпатичного відділу";
            else
                return "Не відомо";
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox22.Text, out double value))
            {
                string phrase = LF_p(value);

                label86.Text = phrase;
            }
        }
        private string LF_p(double value)
        {
            if (value >= 15 && value <= 40)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox23.Text, out double value))
            {
                string phrase = VLF_p(value);

                label87.Text = phrase;
            }
        }
        private string VLF_p(double value)
        {
            if (value >= 15 && value <= 30)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox24.Text, out double value))
            {
                string phrase = ULF_p(value);

                label88.Text = phrase;
            }
        }
        private string ULF_p(double value)
        {
            if (value >= 1 && value <= 5)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox25.Text, out double value))
            {
                string phrase = HFnorm(value);

                label89.Text = phrase;
            }
        }
        private string HFnorm(double value)
        {
            if (value >= 40 && value <= 58.8)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox26.Text, out double value))
            {
                string phrase = LFnorm(value);

                label90.Text = phrase;
            }
        }
        private string LFnorm(double value)
        {
            if (value >= 41.2 && value <= 60)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox27.Text, out double value))
            {
                string phrase = LF_HF(value);

                label91.Text = phrase;
            }
        }
        private string LF_HF(double value)
        {
            if (value >= 0.7 && value <= 1.5)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox28.Text, out double value))
            {
                string phrase = IC(value);

                label92.Text = phrase;
            }
        }
        private string IC(double value)
        {
            if (value >= 1.3 && value <= 2.5)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox29.Text, out double value))
            {
                string phrase = ISCA(value);

                label93.Text = phrase;
            }
        }
        private string ISCA(double value)
        {
            if (value >= 0.81 && value <= 2.41)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox30.Text, out double value))
            {
                string phrase = PARS(value);

                label94.Text = phrase;
            }
        }
        private string PARS(double value)
        {
            if (value >= 0 && value <= 1)
                return "Показник в нормі";
            else if (value >= 2 && value <= 4)
                return "Помірне функціонал. напруження";
            else if (value >= 5 && value <= 6)
                return "Виражене функціонал. напруження";
            else if (value >= 7 && value <= 8)
                return "Різко виражене функціонал. напруження";
            else if (value >= 9 && value <= 10)
                return "Астенізація регуляторних систем";
            else
                return "Не відомо";
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox31.Text, out double value))
            {
                string phrase = PAPR(value);

                label95.Text = phrase;
            }
        }
        private string PAPR(double value)
        {
            if (value >= 15 && value <= 50)
                return "Показник в нормі";
            else
                return "Показник не в нормі";
        }
    }
}
