namespace Budget_Calculator
{
    partial class Calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotalIncome = new System.Windows.Forms.TextBox();
            this.textBoxTotalExpenses = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxLeastEarned = new System.Windows.Forms.TextBox();
            this.textBoxMostSpent = new System.Windows.Forms.TextBox();
            this.textBoxMostEarned = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLeastSpent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.textBoxExpenses = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxBalance);
            this.panel1.Controls.Add(this.textBoxTotalExpenses);
            this.panel1.Controls.Add(this.textBoxTotalIncome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 173);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Overview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Income";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Expenses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance";
            // 
            // textBoxTotalIncome
            // 
            this.textBoxTotalIncome.Location = new System.Drawing.Point(107, 53);
            this.textBoxTotalIncome.Name = "textBoxTotalIncome";
            this.textBoxTotalIncome.ReadOnly = true;
            this.textBoxTotalIncome.Size = new System.Drawing.Size(81, 20);
            this.textBoxTotalIncome.TabIndex = 4;
            // 
            // textBoxTotalExpenses
            // 
            this.textBoxTotalExpenses.Location = new System.Drawing.Point(107, 91);
            this.textBoxTotalExpenses.Name = "textBoxTotalExpenses";
            this.textBoxTotalExpenses.ReadOnly = true;
            this.textBoxTotalExpenses.Size = new System.Drawing.Size(81, 20);
            this.textBoxTotalExpenses.TabIndex = 5;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(107, 129);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(81, 20);
            this.textBoxBalance.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxLeastSpent);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxLeastEarned);
            this.panel2.Controls.Add(this.textBoxMostSpent);
            this.panel2.Controls.Add(this.textBoxMostEarned);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(29, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 201);
            this.panel2.TabIndex = 7;
            // 
            // textBoxLeastEarned
            // 
            this.textBoxLeastEarned.Location = new System.Drawing.Point(115, 121);
            this.textBoxLeastEarned.Name = "textBoxLeastEarned";
            this.textBoxLeastEarned.ReadOnly = true;
            this.textBoxLeastEarned.Size = new System.Drawing.Size(81, 20);
            this.textBoxLeastEarned.TabIndex = 6;
            // 
            // textBoxMostSpent
            // 
            this.textBoxMostSpent.Location = new System.Drawing.Point(115, 86);
            this.textBoxMostSpent.Name = "textBoxMostSpent";
            this.textBoxMostSpent.ReadOnly = true;
            this.textBoxMostSpent.Size = new System.Drawing.Size(81, 20);
            this.textBoxMostSpent.TabIndex = 5;
            // 
            // textBoxMostEarned
            // 
            this.textBoxMostEarned.Location = new System.Drawing.Point(115, 50);
            this.textBoxMostEarned.Name = "textBoxMostEarned";
            this.textBoxMostEarned.ReadOnly = true;
            this.textBoxMostEarned.Size = new System.Drawing.Size(81, 20);
            this.textBoxMostEarned.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Least Earned From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Most Spent In";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Most Earned From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Summary";
            // 
            // textBoxLeastSpent
            // 
            this.textBoxLeastSpent.Location = new System.Drawing.Point(115, 156);
            this.textBoxLeastSpent.Name = "textBoxLeastSpent";
            this.textBoxLeastSpent.ReadOnly = true;
            this.textBoxLeastSpent.Size = new System.Drawing.Size(81, 20);
            this.textBoxLeastSpent.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Least Spent In";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.buttonCalculate);
            this.panel3.Controls.Add(this.textBoxExpenses);
            this.panel3.Controls.Add(this.textBoxIncome);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.labelExit);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(275, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 396);
            this.panel3.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(91, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Calculator";
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.Location = new System.Drawing.Point(130, 43);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(24, 13);
            this.labelExit.TabIndex = 1;
            this.labelExit.Text = "Exit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Projected Income";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Projected Expenses";
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(141, 88);
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(100, 20);
            this.textBoxIncome.TabIndex = 4;
            // 
            // textBoxExpenses
            // 
            this.textBoxExpenses.Location = new System.Drawing.Point(141, 126);
            this.textBoxExpenses.Name = "textBoxExpenses";
            this.textBoxExpenses.Size = new System.Drawing.Size(100, 20);
            this.textBoxExpenses.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(92, 168);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(96, 24);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Estimated Balance:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(71, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 23);
            this.label14.TabIndex = 8;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxTotalExpenses;
        private System.Windows.Forms.TextBox textBoxTotalIncome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxLeastSpent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLeastEarned;
        private System.Windows.Forms.TextBox textBoxMostSpent;
        private System.Windows.Forms.TextBox textBoxMostEarned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxExpenses;
        private System.Windows.Forms.Label label14;
    }
}