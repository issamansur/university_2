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
        private List<double> answersForCheck = new List<double> { };
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

            buttonSolve.Enabled = false;
            buttonSolveAnalytic.Enabled = false;
            buttonSolve.Enabled = false;
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
                buttonSolve.Enabled = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxDegree.SelectedIndex = -1;
            BlockButton();

            answerTextBox.Text = "";
            chart1.Series[0].Points.Clear();
        }

        private void buttonSolveAnalytic_Click(object sender, EventArgs e)
        {
            bool Check = true;
            
            answerTextBox.Text = "";
            chart1.Series[0].Points.Clear();
            /*
            for (int i = highDegree - Degree; i <= highDegree; i++)
            {
                if (Double.TryParse(textBoxes[i].Text, out double number))
                    coefficients.Add(double.Parse(textBoxes[i].Text));
                else
                {
                    Check = false;
                    break;
                }
            }
            */
            if (Check)
            {
                List<double> answers = Solve(coefficients);
                if (answers.Count != 0)
                {
                    foreach (Double answer in answers)
                        answerTextBox.Text += answer + "\n";
                    
                    buttonCheck.Enabled = true;

                    answersForCheck = answers;
                }                    
                else
                    answerTextBox.Text += "Решения не найдены!";
                
                coefficients.Reverse();
                for (double x = -99; x <= 100; x++)
                {
                    double y = 0, i = 0;
                    foreach (double coef in coefficients)
                    {
                        y += coef * Math.Pow(x, i);
                        i++;
                    }
                    chart1.Series[0].Points.AddXY(x, y);
                }
            }

            else
                MessageBox.Show("Одно или несколько полей ввода заданы неверно!");
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            bool Check = true;
            foreach (double answer in answersForCheck)
            {
                int i = 0;
                double s = 0;
                foreach (double coef in coefficients)
                {
                    s += coef * Math.Pow(answer, i);
                    i++;
                }
                if (Math.Abs(s) > 1)
                    Check = false;
            }
            if (Check)
                MessageBox.Show("Всё верно!");
            else
                MessageBox.Show("Ошибка!");
        }

        // methods for solving equations

        private List<double> Solve(List<double> coef)
        {
            List<double> answers = new List<double> { };

            switch (coef.Count)
            {
                case 2:
                    answers = First(coef[0], coef[1]);
                    break;
                case 3:
                    answers = Second(coef[0], coef[1], coef[2]);
                    break;
                    /*                case 4:
                    answers = Third(coef[0], coef[1], coef[2], coef[3]);
                    break;

                case 5:
                    answers = Fourth(coef[0], coef[1], coef[2], coef[3], coef[4]);
                    break;
                case 6:
                    answers = Fifth(coef[0], coef[1], coef[2], coef[3], coef[4], coef[5]);
                    break;
                    */
            }
            return answers;
        }

        private List<double> First(double a, double b)
        {
            List<double> answers = new List<double> { };
            answers.Add(-b / a);
            return answers;
        }

        private List<double> Second(double a, double b, double c)
        {
            List<double> answers = new List<double> { };
            double D = b * b - 4 * a * c;
            if (D >= 0)
            {
                answers.Add((-b + Math.Sqrt(D)) / (2 * a));
                answers.Add((-b - Math.Sqrt(D)) / (2 * a));
            }
            
            return answers;
        }

        private List<Complex> ThirdAnalitic(double d, double a, double b, double c)
        {
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
                return new List<Complex> { x1, x2, x3 };
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
                    return new List<Complex> { x1, x2 };
                }
                return new List<Complex> { x1, x2, x3 };
            }
        }


        /*
private List<double> ThirdSearch(double d, double a, double b, double c)
{
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
       return new List<Complex> { x1, x2, x3 };
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
           return new List<Complex> { x1, x2 };
       }
       return new List<Complex> { x1, x2, x3 };
   }
}
*/
    }
}
