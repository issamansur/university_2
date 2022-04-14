using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        private TextBox[] textBoxes;

        public int Degree { get; private set; }
        private List<double> realAnswers = new List<double> { };
        private List<Complex> complexAnswers = new List<Complex> { };
        private List<double> coefficients = new List<double> { };

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            textBoxes = new TextBox[] { textBox0, textBox1,
                textBox2, textBox3, textBox4, textBox5 };

            BlockButton();
        }

        private void BlockButton()
        {
            foreach (TextBox box in textBoxes)
            {
                box.Enabled = false;
                box.Text = "";
            }
            textBoxFrom.Text = textBoxTo.Text = "";

            buttonSolve.Enabled = false;
            buttonSolveAnalytic.Enabled = false;
            textBoxFrom.Enabled = textBoxTo.Enabled = false;
        }

        private void ClearSolution()
        {
            answerTextBox.Text = "";
            chart1.Series[0].Points.Clear();

            coefficients = new List<double>() { };
            realAnswers = new List<double>() { };
            complexAnswers = new List<Complex>() { };
        }
        
        private void comboBoxDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            Degree = comboBoxDegree.SelectedIndex + 1;

            BlockButton();
            for (int i = 0; i <= Degree; i++)
                textBoxes[i].Enabled = true;

            if (Degree <= 3)
                buttonSolveAnalytic.Enabled = true;
            if (Degree >= 3)
            {
                buttonSolve.Enabled = true;
                textBoxFrom.Enabled = textBoxTo.Enabled = true;
                textBoxFrom.Text = (-100).ToString();
                textBoxTo.Text = 100.ToString();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxDegree.SelectedIndex = -1;
            BlockButton();

            ClearSolution();
        }

        private bool CheckAndSafe()
        {
            for (int i = 0; i <= Degree; i++)
            {
                if (Double.TryParse(textBoxes[i].Text, out double coef))
                    coefficients.Add(coef);
                else
                    return false;
            }

            foreach (double x in coefficients)
                if (x != 0)
                    return true;

            return false;
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            ClearSolution();

            if (CheckAndSafe())
            {
                CreateGraph(coefficients);

                if (Double.TryParse(textBoxFrom.Text, out double numberFrom) && 
                    Double.TryParse(textBoxTo.Text, out double numberTo) && numberFrom <= numberTo)
                {
                    for (double x = numberFrom; x <= numberTo; x += 0.01)
                    {
                        x = Math.Round(x, 2);
                        /*
                        answerTextBox.Text += $"{x} + {Equation(x)} \n";
                        */
                        if (Equation(x) == 0)
                        {
                            realAnswers.Add(x);
                            answerTextBox.Text += $"{x} \n";
                        }
                    }
                    buttonCheck.Enabled = true;
                }
                else
                    MessageBox.Show("Границы интервала заданы неверно!");
            }
            else
                MessageBox.Show("Одно или несколько полей ввода заданы неверно!");
        }

        private double Equation(double x)
        {
            List<double> coefs = new List<double>(coefficients);
            int i = 0;
            double y = 0;
            foreach (double coef in coefs)
            {
                y += coef * Math.Pow(x, i);
                i++;
            }
            return y;
        }

        private void buttonSolveAnalytic_Click(object sender, EventArgs e)
        {
            ClearSolution();

            if (CheckAndSafe())
            {
                CreateGraph(coefficients);

                switch (Degree)
                {
                    case 1:
                        First(coefficients[1], coefficients[0]);
                        break;
                    case 2:
                        Second(coefficients[2], coefficients[1], coefficients[0]);
                        break;
                    case 3:
                        ThirdAnalitic(coefficients[3], coefficients[2], coefficients[1], coefficients[0]);
                        break;

                }
                foreach (double x in realAnswers)
                    answerTextBox.Text += $"{x} \n";
                foreach (Complex x in complexAnswers)
                    if (x.Imaginary != 0)
                        answerTextBox.Text += $"{x.Real}+({x.Imaginary} i) \n";
                    else
                        answerTextBox.Text += $"{x.Real} \n";
                buttonCheck.Enabled = true;
            }
            else
                MessageBox.Show("Одно или несколько полей ввода заданы неверно!");
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            bool Check = true;
            foreach (double answer in realAnswers)
            {
                if (Math.Abs(Equation(answer)) > 0.001)
                    Check = false;
            }
            if (Check)
                MessageBox.Show("Всё верно!");
            else
                MessageBox.Show("Ошибка!");
        }

        // methods for solving equations

        private void First(double a, double b)
        {
            realAnswers.Add(-b / a);
        }

        private void Second(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            if (D >= 0)
            {
                realAnswers.Add((-b + Math.Sqrt(D)) / (2 * a));
                realAnswers.Add((-b - Math.Sqrt(D)) / (2 * a));
            }
            else
            {
                D = -D;
                complexAnswers.Add(new Complex(-b / (2 * a), + Math.Sqrt(D)) / (2 * a));
                complexAnswers.Add(new Complex(-b / (2 * a), - Math.Sqrt(D)) / (2 * a));
            }
        }

        private void ThirdAnalitic(double d, double a, double b, double c)
        {
            if (d == 0)
            {
                Second(a, b, c);
                return;
            }

            a /= d;
            b /= d;
            c /= d;

            var q = (Math.Pow(a, 2) - 3 * b) / 9;
            var r = (2 * Math.Pow(a, 3) - 9 * a * b + 27 * c) / 54;

            if (Math.Pow(r, 2) < Math.Pow(q, 3))
            {
                var t = Math.Acos(r / Math.Sqrt(Math.Pow(q, 3))) / 3;
                var x1 = -2 * Math.Sqrt(q) * Math.Cos(t) - a / 3;
                var x2 = -2 * Math.Sqrt(q) * Math.Cos(t + (2 * Math.PI / 3)) - a / 3;
                var x3 = -2 * Math.Sqrt(q) * Math.Cos(t - (2 * Math.PI / 3)) - a / 3;
                complexAnswers = new List<Complex> { x1, x2, x3 };
            }
            else
            {
                var A = -Math.Sign(r) * Math.Pow(Math.Abs(r) + Math.Sqrt(Math.Pow(r, 2) - Math.Pow(q, 3)), (1.0 / 3.0));
                var B = (A == 0) ? 0.0 : q / A;

                var x1 = (A + B) - a / 3;
                var x2 = -(A + B) / 2 - (a / 3) + (Complex.ImaginaryOne * Math.Sqrt(3) * (A - B) / 2);
                var x3 = -(A + B) / 2 - (a / 3) - (Complex.ImaginaryOne * Math.Sqrt(3) * (A - B) / 2);

                if (A == B)
                {
                    x2 = -A - a / 3;
                    complexAnswers = new List<Complex> { x1, x2 };
                }
                complexAnswers = new List<Complex> { x1, x2, x3 };
            }
        }

        public void CreateGraph(List<double> coefficients)
        {
            List<double> coefs = new List<double>(coefficients);
            coefs.Reverse();
            for (double x = -99; x <= 100; x++)
            {
                double y = 0, i = 0;
                foreach (double coef in coefs)
                {
                    y += coef * Math.Pow(x, i);
                    i++;
                }
                chart1.Series[0].Points.AddXY(x, y);
            }
        }
    }
}
