using System;
using System.Windows.Forms;

namespace Form_Z05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";

            try
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double h = Convert.ToDouble(textBoxH.Text);

                if (a < b)
                {
                    if (h > 0)
                    {
                        while (a <= b)
                        {
                            f(a);
                            a = a + h;
                        }
                    }
                    else
                    {
                        throw new Exception("H должно быть больше 0!");
                    }
                }
                else
                {
                    throw new Exception("A должно быть меньше B!");
                }
            }
            catch (FormatException)
            {
                textBoxResult.Text = "Некорректный ввод данных!";
            }
            catch (Exception ex)
            {
                textBoxResult.Text = ex.Message;
            }
        }
        private void f(double x)
        {
            try
            {
                if (x != 0.25 && x != 1)
                {
                    double y = 1 / (x - 1) + 2 / (1 - 4 * x);
                    textBoxResult.Text = textBoxResult.Text + "x " + Math.Round(x, 3) + " = y " + Math.Round(y, 3) + "\r\n";
                }
                else
                    throw new Exception("X не должен быть равен ");
            }
            catch (Exception e)
            {
                textBoxResult.Text = textBoxResult.Text + $"{e.Message}" + Math.Round(x, 3) + "!" + "\r\n";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }
    }
}
