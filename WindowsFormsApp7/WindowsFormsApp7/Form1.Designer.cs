
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
            this.groupBoxDegrees = new System.Windows.Forms.GroupBox();
            this.radioButtonDegree5 = new System.Windows.Forms.RadioButton();
            this.radioButtonDegree4 = new System.Windows.Forms.RadioButton();
            this.radioButtonDegree3 = new System.Windows.Forms.RadioButton();
            this.radioButtonDegree2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDegree1 = new System.Windows.Forms.RadioButton();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxDegrees.SuspendLayout();
            this.groupBoxInputData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDegrees
            // 
            this.groupBoxDegrees.Controls.Add(this.radioButtonDegree5);
            this.groupBoxDegrees.Controls.Add(this.radioButtonDegree4);
            this.groupBoxDegrees.Controls.Add(this.radioButtonDegree3);
            this.groupBoxDegrees.Controls.Add(this.radioButtonDegree2);
            this.groupBoxDegrees.Controls.Add(this.radioButtonDegree1);
            this.groupBoxDegrees.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDegrees.Name = "groupBoxDegrees";
            this.groupBoxDegrees.Size = new System.Drawing.Size(441, 51);
            this.groupBoxDegrees.TabIndex = 0;
            this.groupBoxDegrees.TabStop = false;
            this.groupBoxDegrees.Text = "Степень уравнения";
            // 
            // radioButtonDegree5
            // 
            this.radioButtonDegree5.AutoSize = true;
            this.radioButtonDegree5.Checked = true;
            this.radioButtonDegree5.Location = new System.Drawing.Point(376, 19);
            this.radioButtonDegree5.Name = "radioButtonDegree5";
            this.radioButtonDegree5.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDegree5.TabIndex = 4;
            this.radioButtonDegree5.TabStop = true;
            this.radioButtonDegree5.Text = "Пятая";
            this.radioButtonDegree5.UseVisualStyleBackColor = true;
            this.radioButtonDegree5.CheckedChanged += new System.EventHandler(this.radioButtonDegrees_CheckedChanged);
            // 
            // radioButtonDegree4
            // 
            this.radioButtonDegree4.AutoSize = true;
            this.radioButtonDegree4.Location = new System.Drawing.Point(285, 19);
            this.radioButtonDegree4.Name = "radioButtonDegree4";
            this.radioButtonDegree4.Size = new System.Drawing.Size(79, 17);
            this.radioButtonDegree4.TabIndex = 3;
            this.radioButtonDegree4.TabStop = true;
            this.radioButtonDegree4.Text = "Четвёртая";
            this.radioButtonDegree4.UseVisualStyleBackColor = true;
            this.radioButtonDegree4.CheckedChanged += new System.EventHandler(this.radioButtonDegrees_CheckedChanged);
            // 
            // radioButtonDegree3
            // 
            this.radioButtonDegree3.AutoSize = true;
            this.radioButtonDegree3.Location = new System.Drawing.Point(194, 19);
            this.radioButtonDegree3.Name = "radioButtonDegree3";
            this.radioButtonDegree3.Size = new System.Drawing.Size(61, 17);
            this.radioButtonDegree3.TabIndex = 2;
            this.radioButtonDegree3.TabStop = true;
            this.radioButtonDegree3.Text = "Третья";
            this.radioButtonDegree3.UseVisualStyleBackColor = true;
            this.radioButtonDegree3.CheckedChanged += new System.EventHandler(this.radioButtonDegrees_CheckedChanged);
            // 
            // radioButtonDegree2
            // 
            this.radioButtonDegree2.AutoSize = true;
            this.radioButtonDegree2.Location = new System.Drawing.Point(103, 19);
            this.radioButtonDegree2.Name = "radioButtonDegree2";
            this.radioButtonDegree2.Size = new System.Drawing.Size(61, 17);
            this.radioButtonDegree2.TabIndex = 1;
            this.radioButtonDegree2.TabStop = true;
            this.radioButtonDegree2.Text = "Вторая";
            this.radioButtonDegree2.UseVisualStyleBackColor = true;
            this.radioButtonDegree2.CheckedChanged += new System.EventHandler(this.radioButtonDegrees_CheckedChanged);
            // 
            // radioButtonDegree1
            // 
            this.radioButtonDegree1.AutoSize = true;
            this.radioButtonDegree1.Location = new System.Drawing.Point(12, 19);
            this.radioButtonDegree1.Name = "radioButtonDegree1";
            this.radioButtonDegree1.Size = new System.Drawing.Size(63, 17);
            this.radioButtonDegree1.TabIndex = 0;
            this.radioButtonDegree1.TabStop = true;
            this.radioButtonDegree1.Text = "Первая";
            this.radioButtonDegree1.UseVisualStyleBackColor = true;
            this.radioButtonDegree1.CheckedChanged += new System.EventHandler(this.radioButtonDegrees_CheckedChanged);
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.label6);
            this.groupBoxInputData.Controls.Add(this.textBox6);
            this.groupBoxInputData.Controls.Add(this.textBox5);
            this.groupBoxInputData.Controls.Add(this.textBox4);
            this.groupBoxInputData.Controls.Add(this.textBox3);
            this.groupBoxInputData.Controls.Add(this.textBox2);
            this.groupBoxInputData.Controls.Add(this.textBox1);
            this.groupBoxInputData.Controls.Add(this.label5);
            this.groupBoxInputData.Controls.Add(this.label4);
            this.groupBoxInputData.Controls.Add(this.label3);
            this.groupBoxInputData.Controls.Add(this.label2);
            this.groupBoxInputData.Controls.Add(this.label1);
            this.groupBoxInputData.Location = new System.Drawing.Point(12, 69);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(710, 56);
            this.groupBoxInputData.TabIndex = 0;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод данных";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(610, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "=  0";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(538, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(66, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(436, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(66, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(330, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(66, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(508, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "x +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(402, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "x² +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(296, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "x³ +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(190, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "x⁴ +";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "x⁵ +";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCheck);
            this.groupBox1.Controls.Add(this.buttonSolve);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Location = new System.Drawing.Point(459, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(166, 19);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(84, 23);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(92, 19);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(68, 23);
            this.buttonSolve.TabIndex = 3;
            this.buttonSolve.Text = "Решить";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(10, 19);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(76, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInputData);
            this.Controls.Add(this.groupBoxDegrees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxDegrees.ResumeLayout(false);
            this.groupBoxDegrees.PerformLayout();
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDegrees;
        private System.Windows.Forms.RadioButton radioButtonDegree5;
        private System.Windows.Forms.RadioButton radioButtonDegree4;
        private System.Windows.Forms.RadioButton radioButtonDegree3;
        private System.Windows.Forms.RadioButton radioButtonDegree2;
        private System.Windows.Forms.RadioButton radioButtonDegree1;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button buttonReset;
    }
}

