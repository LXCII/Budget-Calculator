namespace Budget_Calculator
{
    partial class Categorise
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
            this.listViewTransactions = new System.Windows.Forms.ListView();
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPayee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnParticulars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAllocate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.columnNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewTransactions
            // 
            this.listViewTransactions.CheckBoxes = true;
            this.listViewTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNum,
            this.columnDate,
            this.columnPayee,
            this.columnDescription,
            this.columnReference,
            this.columnParticulars,
            this.columnAmount,
            this.columnCategory});
            this.listViewTransactions.FullRowSelect = true;
            this.listViewTransactions.GridLines = true;
            this.listViewTransactions.HideSelection = false;
            this.listViewTransactions.Location = new System.Drawing.Point(25, 23);
            this.listViewTransactions.Name = "listViewTransactions";
            this.listViewTransactions.Size = new System.Drawing.Size(525, 337);
            this.listViewTransactions.TabIndex = 0;
            this.listViewTransactions.UseCompatibleStateImageBehavior = false;
            this.listViewTransactions.View = System.Windows.Forms.View.Details;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 50;
            // 
            // columnPayee
            // 
            this.columnPayee.Text = "Payee";
            this.columnPayee.Width = 70;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 92;
            // 
            // columnReference
            // 
            this.columnReference.Text = "Reference";
            this.columnReference.Width = 74;
            // 
            // columnParticulars
            // 
            this.columnParticulars.Text = "Particulars";
            this.columnParticulars.Width = 71;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.Location = new System.Drawing.Point(579, 36);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(235, 24);
            this.labelHeading.TabIndex = 1;
            this.labelHeading.Text = "Categorise Transactions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "2. Select a category below";
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.Location = new System.Drawing.Point(667, 65);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(48, 13);
            this.labelReturn.TabIndex = 3;
            this.labelReturn.Text = "< Return";
            this.labelReturn.Click += new System.EventHandler(this.labelReturn_Click);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Items.AddRange(new object[] {
            "Entertainment",
            "Food",
            "Miscellaneous",
            "Rent",
            "Shopping",
            "Transport",
            "Utilities"});
            this.comboBoxCategories.Location = new System.Drawing.Point(637, 165);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategories.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "(Optional) Add a category";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(620, 216);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategory.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(726, 214);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(48, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "1. Check transactions to categorise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "3. Allocate selected items to chosen category";
            // 
            // buttonAllocate
            // 
            this.buttonAllocate.Location = new System.Drawing.Point(659, 277);
            this.buttonAllocate.Name = "buttonAllocate";
            this.buttonAllocate.Size = new System.Drawing.Size(75, 23);
            this.buttonAllocate.TabIndex = 10;
            this.buttonAllocate.Text = "Allocate";
            this.buttonAllocate.UseVisualStyleBackColor = true;
            this.buttonAllocate.Click += new System.EventHandler(this.buttonAllocate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Finish allocation";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // columnNum
            // 
            this.columnNum.Text = "";
            this.columnNum.Width = 20;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            // 
            // Categorise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 376);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAllocate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.listViewTransactions);
            this.Name = "Categorise";
            this.Text = "Categorise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTransactions;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnPayee;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnReference;
        private System.Windows.Forms.ColumnHeader columnParticulars;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAllocate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnNum;
        private System.Windows.Forms.ColumnHeader columnCategory;
    }
}