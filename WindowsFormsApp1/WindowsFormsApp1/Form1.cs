using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart1.Series[0].LegendText = Func6Name();
        }


        // 6 variant
        public double Func6(double x) => 1.00 / Math.Tan(x) - x;
        public double DFunc6(double x) => (-Math.Tan(x) * Math.Tan(x) - 1) / (Math.Tan(x) * Math.Tan(x));

        public string Func6Name()
        {
            return "ctan(x)-x";
        }

        // Logic of programm

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            double a, b, eps;
            (a, b, eps) = GetData();

            textBoxAnswer.Text = "";
            List<(double, double)> values1 = CreateGraphic(a, b ,eps);

            List<double> values2 = Solve(Func6, DFunc6, values1, eps);

            List<double> values3 = Check(Func6, values2, eps);

            Print(values1, values2, values3);
        }

        private (double, double, double) GetData()
        {
            if (!double.TryParse(textBoxa.Text, out double a) || !double.TryParse(textBoxb.Text, out double b))
            {
                textBoxa.Text = "-10"; textBoxb.Text = "10";
                a = -10; b = 10;
            }


            if (!double.TryParse(textBoxeps.Text, out double eps))
            {
                textBoxeps.Text = "0,01";
                eps = 0.01;
            }

            return (a, b, eps);
        } 

        private List<(double, double)> CreateGraphic(double a, double b, double eps)
        {
            chart1.Series[0].Points.Clear();
            double prev = 0;
            double prevX = 0;

            List<(double, double)> vls = new List<(double, double)>();

            for (double x = a; x <= b; x += eps)
            {
                double current = Func6(x);
                chart1.Series[0].Points.AddXY(x, 
                    Math.Abs(current) < 1000 ? current : 1000);
                if (prev * current < 0)
                    vls.Add((prevX, x));

                prev = current;
                prevX = x;
            }
            return vls;
        }

        private void Print(List<(double, double)> values1, List<double> values2, List<double> values3)
        {
            textBoxAnswer.Text += "Уточняемые | Уточненные | |F(уточн.)|";
            textBoxAnswer.Text += Environment.NewLine;
            for (int i = 0; i < values1.Count; i++)
                textBoxAnswer.Text += 
                    string.Format("{0:f4} | {1:f4} | {2:f4}",
                    (values1[i].Item2 + values1[i].Item1) / 2, values2[i], values3[i]) + Environment.NewLine; ;

        }

        private List<double> Solve(Numeric.Func func, Numeric.Func dfunc,
            List<(double, double)> values, double eps)
        {
            List<double> values2 = new List<double>();

            if (radioButtonPolDel.Checked)
                foreach ((double a1, double b1) in values)
                {
                    double answer = Numeric.PolDel(func, a1, b1, eps);
                    
                    values2.Add(answer);
                }
            else if (radioButtonSec.Checked)
                foreach ((double a1, double b1) in values)
                {
                    double answer = Numeric.Sec(func, a1, b1, eps);
                    values2.Add(answer);
                }
            else
                foreach ((double a1, double b1) in values)
                {
                    double answer = Numeric.Kas(func, dfunc, a1, b1, eps);
                    values2.Add(answer);
                }
            return values2;
        }

        private List<double> Check(Numeric.Func func, List<double> values, double eps)
        {
            List<double> values3 = new List<double>();

            foreach (double value in values)
            {
                double answer = func(value);
                if (answer > 1)
                    answer = double.PositiveInfinity;
                if (answer < -1)
                    answer = double.NegativeInfinity;

                values3.Add(answer);
            }

            return values3;
        }
    }
}
