using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        private List<RadioButton> radioButtons;
        private TextBox[] textBoxes;

        public Form1()
        {
            InitializeComponent();
            radioButtons = new List<RadioButton>() { radioButtonDegree1, radioButtonDegree2,
                radioButtonDegree3, radioButtonDegree4, radioButtonDegree5 };
            textBoxes = new TextBox[] { textBox1, textBox2, 
                textBox3, textBox4, textBox5, textBox6 };

            radioButtonDegrees_CheckedChanged(radioButtonDegree5, EventArgs.Empty);
        }

        private void radioButtonDegrees_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            int index = 4 - radioButtons.IndexOf(radioButton);
            textBox1.Text = index.ToString();

            foreach (TextBox box in textBoxes)
                box.Enabled = true;
            for (int i = 0; i < index; i++)
                textBoxes[i].Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (TextBox box in textBoxes)
                box.Text = "";
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
