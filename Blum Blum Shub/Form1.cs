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
            //textBox4.Text = "Hello" + Environment.NewLine + "Hello" + Environment.NewLine + "Hello" + Environment.NewLine + "Hello" + Environment.NewLine + "Hello" + Environment.NewLine + "Hello" + Environment.NewLine + "Hello" + Environment.NewLine + "Hello" + Environment.NewLine + "Hello";
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
            for (uint i = 1; i < n; i++) {
                x0 = NextValue(x0, p * q);
                TextResult.Text += x0.ToString() + Environment.NewLine;
            }
        }

        private void ButtonHelp_Click(object sender, System.EventArgs e) {
            TextResult.Text = helptext;
        }

        public bool IsPrime(ulong x) {
            for (ulong i = 2; i <= Math.Sqrt(x); i++)
                if (x % i == 0)
                    return false;
            return true;
        }

        public ulong NextValue(ulong x0, ulong m) {
            return (x0 * x0) % m;
        }
    }
}
