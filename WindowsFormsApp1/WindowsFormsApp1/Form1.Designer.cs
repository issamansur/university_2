namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxb = new System.Windows.Forms.TextBox();
            this.labelb = new System.Windows.Forms.Label();
            this.textBoxa = new System.Windows.Forms.TextBox();
            this.labela = new System.Windows.Forms.Label();
            this.textBoxeps = new System.Windows.Forms.TextBox();
            this.labeleps = new System.Windows.Forms.Label();
            this.groupBoxMethods = new System.Windows.Forms.GroupBox();
            this.radioButtonKas = new System.Windows.Forms.RadioButton();
            this.radioButtonSec = new System.Windows.Forms.RadioButton();
            this.radioButtonPolDel = new System.Windows.Forms.RadioButton();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(265, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(523, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxb);
            this.groupBoxInput.Controls.Add(this.labelb);
            this.groupBoxInput.Controls.Add(this.textBoxa);
            this.groupBoxInput.Controls.Add(this.labela);
            this.groupBoxInput.Controls.Add(this.textBoxeps);
            this.groupBoxInput.Controls.Add(this.labeleps);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(247, 100);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Входные данные:";
            // 
            // textBoxb
            // 
            this.textBoxb.Location = new System.Drawing.Point(123, 48);
            this.textBoxb.Name = "textBoxb";
            this.textBoxb.Size = new System.Drawing.Size(60, 20);
            this.textBoxb.TabIndex = 9;
            this.textBoxb.Text = "10";
            this.textBoxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Location = new System.Drawing.Point(105, 51);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(16, 13);
            this.labelb.TabIndex = 8;
            this.labelb.Text = "b:";
            // 
            // textBoxa
            // 
            this.textBoxa.Location = new System.Drawing.Point(39, 48);
            this.textBoxa.Name = "textBoxa";
            this.textBoxa.Size = new System.Drawing.Size(60, 20);
            this.textBoxa.TabIndex = 7;
            this.textBoxa.Text = "-10";
            this.textBoxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(17, 51);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(16, 13);
            this.labela.TabIndex = 6;
            this.labela.Text = "a:";
            // 
            // textBoxeps
            // 
            this.textBoxeps.Location = new System.Drawing.Point(39, 22);
            this.textBoxeps.Name = "textBoxeps";
            this.textBoxeps.Size = new System.Drawing.Size(144, 20);
            this.textBoxeps.TabIndex = 5;
            this.textBoxeps.Text = "0,01";
            this.textBoxeps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labeleps
            // 
            this.labeleps.AutoSize = true;
            this.labeleps.Location = new System.Drawing.Point(6, 25);
            this.labeleps.Name = "labeleps";
            this.labeleps.Size = new System.Drawing.Size(27, 13);
            this.labeleps.TabIndex = 4;
            this.labeleps.Text = "eps:";
            // 
            // groupBoxMethods
            // 
            this.groupBoxMethods.Controls.Add(this.radioButtonKas);
            this.groupBoxMethods.Controls.Add(this.radioButtonSec);
            this.groupBoxMethods.Controls.Add(this.radioButtonPolDel);
            this.groupBoxMethods.Location = new System.Drawing.Point(12, 118);
            this.groupBoxMethods.Name = "groupBoxMethods";
            this.groupBoxMethods.Size = new System.Drawing.Size(247, 122);
            this.groupBoxMethods.TabIndex = 2;
            this.groupBoxMethods.TabStop = false;
            this.groupBoxMethods.Text = "Выберите метод:";
            // 
            // radioButtonKas
            // 
            this.radioButtonKas.AutoSize = true;
            this.radioButtonKas.Location = new System.Drawing.Point(9, 89);
            this.radioButtonKas.Name = "radioButtonKas";
            this.radioButtonKas.Size = new System.Drawing.Size(105, 17);
            this.radioButtonKas.TabIndex = 2;
            this.radioButtonKas.Text = "Метод Ньютона";
            this.radioButtonKas.UseVisualStyleBackColor = true;
            // 
            // radioButtonSec
            // 
            this.radioButtonSec.AutoSize = true;
            this.radioButtonSec.Location = new System.Drawing.Point(9, 53);
            this.radioButtonSec.Name = "radioButtonSec";
            this.radioButtonSec.Size = new System.Drawing.Size(83, 17);
            this.radioButtonSec.TabIndex = 1;
            this.radioButtonSec.Text = "Метод хорд";
            this.radioButtonSec.UseVisualStyleBackColor = true;
            // 
            // radioButtonPolDel
            // 
            this.radioButtonPolDel.AutoSize = true;
            this.radioButtonPolDel.Checked = true;
            this.radioButtonPolDel.Location = new System.Drawing.Point(9, 19);
            this.radioButtonPolDel.Name = "radioButtonPolDel";
            this.radioButtonPolDel.Size = new System.Drawing.Size(108, 17);
            this.radioButtonPolDel.TabIndex = 0;
            this.radioButtonPolDel.TabStop = true;
            this.radioButtonPolDel.Text = "Метод бисекции";
            this.radioButtonPolDel.UseVisualStyleBackColor = true;
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(12, 246);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(247, 48);
            this.buttonSolve.TabIndex = 0;
            this.buttonSolve.Text = "Решить";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.AcceptsTab = true;
            this.textBoxAnswer.Location = new System.Drawing.Point(12, 300);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnswer.Size = new System.Drawing.Size(247, 138);
            this.textBoxAnswer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.groupBoxMethods);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxMethods.ResumeLayout(false);
            this.groupBoxMethods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxMethods;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.TextBox textBoxeps;
        private System.Windows.Forms.Label labeleps;
        private System.Windows.Forms.TextBox textBoxb;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.TextBox textBoxa;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.RadioButton radioButtonKas;
        private System.Windows.Forms.RadioButton radioButtonSec;
        private System.Windows.Forms.RadioButton radioButtonPolDel;
    }
}

