
namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.answerTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBoxAnswers = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonSolveAnalytic = new System.Windows.Forms.Button();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxDegree = new System.Windows.Forms.ComboBox();
            this.label0 = new System.Windows.Forms.Label();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxAnswers.SuspendLayout();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(292, 19);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(350, 243);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(6, 19);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(280, 243);
            this.answerTextBox.TabIndex = 5;
            this.answerTextBox.Text = "";
            // 
            // groupBoxAnswers
            // 
            this.groupBoxAnswers.Controls.Add(this.chart1);
            this.groupBoxAnswers.Controls.Add(this.answerTextBox);
            this.groupBoxAnswers.Location = new System.Drawing.Point(12, 170);
            this.groupBoxAnswers.Name = "groupBoxAnswers";
            this.groupBoxAnswers.Size = new System.Drawing.Size(649, 268);
            this.groupBoxAnswers.TabIndex = 3;
            this.groupBoxAnswers.TabStop = false;
            this.groupBoxAnswers.Text = "Результаты вычислений";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(614, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "=  0";
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(542, 20);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(66, 20);
            this.textBox0.TabIndex = 19;
            this.textBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(333, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(66, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(66, 20);
            this.textBox5.TabIndex = 14;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(511, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "x +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(405, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "x² +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(299, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "x³ +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(193, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "x⁴ +";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "x⁵ +";
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.label6);
            this.groupBoxInputData.Controls.Add(this.textBox0);
            this.groupBoxInputData.Controls.Add(this.textBox1);
            this.groupBoxInputData.Controls.Add(this.textBox2);
            this.groupBoxInputData.Controls.Add(this.textBox3);
            this.groupBoxInputData.Controls.Add(this.textBox4);
            this.groupBoxInputData.Controls.Add(this.textBox5);
            this.groupBoxInputData.Controls.Add(this.label5);
            this.groupBoxInputData.Controls.Add(this.label4);
            this.groupBoxInputData.Controls.Add(this.label3);
            this.groupBoxInputData.Controls.Add(this.label2);
            this.groupBoxInputData.Controls.Add(this.label1);
            this.groupBoxInputData.Location = new System.Drawing.Point(12, 108);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(649, 56);
            this.groupBoxInputData.TabIndex = 0;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод данных";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Enabled = false;
            this.buttonCheck.Location = new System.Drawing.Point(433, 21);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(203, 23);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonSolveAnalytic
            // 
            this.buttonSolveAnalytic.Location = new System.Drawing.Point(267, 19);
            this.buttonSolveAnalytic.Name = "buttonSolveAnalytic";
            this.buttonSolveAnalytic.Size = new System.Drawing.Size(160, 23);
            this.buttonSolveAnalytic.TabIndex = 3;
            this.buttonSolveAnalytic.Text = "Решить аналитически";
            this.buttonSolveAnalytic.UseVisualStyleBackColor = true;
            this.buttonSolveAnalytic.Click += new System.EventHandler(this.buttonSolveAnalytic_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(457, 50);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(70, 20);
            this.textBoxFrom.TabIndex = 12;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(566, 50);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(70, 20);
            this.textBoxTo.TabIndex = 13;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(433, 53);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(18, 13);
            this.labelFrom.TabIndex = 10;
            this.labelFrom.Text = "от";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(541, 53);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(19, 13);
            this.labelTo.TabIndex = 11;
            this.labelTo.Text = "до";
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(267, 48);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(160, 23);
            this.buttonSolve.TabIndex = 9;
            this.buttonSolve.Text = "Решить численно";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(9, 48);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(209, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxDegree
            // 
            this.comboBoxDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDegree.FormattingEnabled = true;
            this.comboBoxDegree.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxDegree.Location = new System.Drawing.Point(172, 21);
            this.comboBoxDegree.Name = "comboBoxDegree";
            this.comboBoxDegree.Size = new System.Drawing.Size(46, 21);
            this.comboBoxDegree.TabIndex = 7;
            this.comboBoxDegree.SelectedIndexChanged += new System.EventHandler(this.comboBoxDegree_SelectedIndexChanged);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(6, 24);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(160, 13);
            this.label0.TabIndex = 8;
            this.label0.Text = "Выберите степень уравнения:";
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.textBoxTo);
            this.groupBoxControl.Controls.Add(this.textBoxFrom);
            this.groupBoxControl.Controls.Add(this.labelTo);
            this.groupBoxControl.Controls.Add(this.labelFrom);
            this.groupBoxControl.Controls.Add(this.buttonSolve);
            this.groupBoxControl.Controls.Add(this.label0);
            this.groupBoxControl.Controls.Add(this.comboBoxDegree);
            this.groupBoxControl.Controls.Add(this.buttonCheck);
            this.groupBoxControl.Controls.Add(this.buttonSolveAnalytic);
            this.groupBoxControl.Controls.Add(this.buttonReset);
            this.groupBoxControl.Location = new System.Drawing.Point(18, 12);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(643, 90);
            this.groupBoxControl.TabIndex = 1;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Панель управления";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.groupBoxAnswers);
            this.Controls.Add(this.groupBoxControl);
            this.Controls.Add(this.groupBoxInputData);
            this.Name = "Form1";
            this.Text = "Уравлятор 3.1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxAnswers.ResumeLayout(false);
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonSolveAnalytic;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBoxAnswers;
        private System.Windows.Forms.RichTextBox answerTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxDegree;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
    }
}

