using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blum_Blum_Shub {
    public partial class Form1 : Form {

        string helptext;

        public Form1() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            TextResult.ScrollBars = ScrollBars.Vertical;
            TextResultBin.ScrollBars = ScrollBars.Both;
            RunButton.Click += new EventHandler(RunButton_Click);
            ButtonHelp.Click += new EventHandler(ButtonHelp_Click);
            ListQ.SelectedIndex = 0;
            ListP.SelectedIndex = 0;
            helptext = TextResult.Text;
        }

        private void RunButton_Click(object sender, System.EventArgs e) {
            ulong p, q, x0, n;
            LabelError.Text = "";
            TextResult.Text = "";
            TextResultBin.Text = "";
            TextGamma1.Text = "";
            TextGamma2.Text = "";
            TextGamma3.Text = "";

            if (ListP.SelectedIndex == 0) {
                //Входные данные числа?
                if (ulong.TryParse(textP.Text, out p) == false) {
                    LabelError.Text = "p не число!";
                    return;
                }

                //P- проверка остатка
                if (p % 4 != 3) {
                    LabelError.Text = "p не сравнимо с 3 по модулю 4!";
                    return;
                }

                //Проверка простоты
                if (IsPrime(p) == false) {
                    LabelError.Text = "p составное!";
                    return;
                }
            }
            else {
                p = ulong.Parse(ListP.SelectedItem.ToString());
            }

            if (ListQ.SelectedIndex == 0) {
                //Входные данные числа?
                if (ulong.TryParse(textQ.Text, out q) == false) {
                    LabelError.Text = "q не число!";
                    return;
                }

                //P- проверка остатка
                if (q % 4 != 3) {
                    LabelError.Text = "q не сравнимо с 3 по модулю 4!";
                    return;
                }

                //Проверка простоты
                if (IsPrime(q) == false) {
                    LabelError.Text = "q составное!";
                    return;
                }
            }
            else {
                q = ulong.Parse(ListQ.SelectedItem.ToString());
            }


            if (ulong.TryParse(textX0.Text, out x0) == false) {
                LabelError.Text = "x0 не число!";
                return;
            }
            if (ulong.TryParse(textN.Text, out n) == false) {
                LabelError.Text = "n не число!";
                return;
            }




            //А если x0 - 1?
            if (x0 <= 1) {
                LabelError.Text = "Нельзя начинать с 1 или 0";
                return;
            }


            //Проверка взаимной просты
            if (x0 % p == 0 || x0 % q == 0) {
                LabelError.Text = "x0 не взаимнопростое с p*q";
                return;
            }

            TextResult.Text += x0.ToString() + Environment.NewLine;
            TextResultBin.Text += Convert.ToString((long)x0, 2) + Environment.NewLine;
            TextGamma1.Text += ParityByte(x0);
            TextGamma2.Text += (x0 % 2).ToString();
            TextGamma3.Text += YoungTwoBits(x0);
            for (uint i = 1; i < n; i++) {
                x0 = NextValue(x0, p * q);
                TextResult.Text += x0.ToString() + Environment.NewLine;
                TextResultBin.Text += Convert.ToString((long)x0, 2) + Environment.NewLine;
                TextGamma1.Text += ParityByte(x0);
                TextGamma2.Text += (x0 % 2).ToString();
                TextGamma3.Text += YoungTwoBits(x0);
            }
        }

        private void ButtonHelp_Click(object sender, System.EventArgs e) {
            TextResult.Text = helptext;
        }

        private string ParityByte(ulong x0) {
            int t = 0;
            for (int i = 0; i < 64; i++)
                if ((((ulong)1 << i) & x0) > 0)
                    t++;
            if (t % 2 > 0)
                return "1";
            else
                return "0";
        }


        private string YoungTwoBits(ulong x0) {
            ulong t = x0 % 4;
            switch (t) {
                case 0:
                    return "00";
                    break;
                case 1:
                    return "01";
                    break;
                case 2:
                    return "10";
                    break;
                case 3:
                    return "11";
                    break;
            }
            return "";
        }

        private bool IsPrime(ulong x) {
            for (ulong i = 2; i <= Math.Sqrt(x); i++)
                if (x % i == 0)
                    return false;
            return true;
        }

        private ulong NextValue(ulong x0, ulong m) {
            return (x0 * x0) % m;
        }
    }
}
