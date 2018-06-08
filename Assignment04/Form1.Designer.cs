namespace Assignment04
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrvCd = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCntryCd = new System.Windows.Forms.TextBox();
            this.textBoxTaxCd = new System.Windows.Forms.TextBox();
            this.textBoxTaxRate = new System.Windows.Forms.TextBox();
            this.buttonNewRec = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBoxFedTax = new System.Windows.Forms.CheckBox();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DA Province Maintenance";
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 16;
            this.listBoxDisplay.Location = new System.Drawing.Point(84, 98);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(173, 276);
            this.listBoxDisplay.TabIndex = 1;
            this.listBoxDisplay.SelectedIndexChanged += new System.EventHandler(this.listBoxDisplay_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Province Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Country Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tax Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tax Rate";
            // 
            // textBoxPrvCd
            // 
            this.textBoxPrvCd.Location = new System.Drawing.Point(598, 123);
            this.textBoxPrvCd.Name = "textBoxPrvCd";
            this.textBoxPrvCd.Size = new System.Drawing.Size(54, 22);
            this.textBoxPrvCd.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(598, 158);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(173, 22);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxCntryCd
            // 
            this.textBoxCntryCd.Location = new System.Drawing.Point(598, 195);
            this.textBoxCntryCd.Name = "textBoxCntryCd";
            this.textBoxCntryCd.Size = new System.Drawing.Size(54, 22);
            this.textBoxCntryCd.TabIndex = 9;
            // 
            // textBoxTaxCd
            // 
            this.textBoxTaxCd.Location = new System.Drawing.Point(598, 234);
            this.textBoxTaxCd.Name = "textBoxTaxCd";
            this.textBoxTaxCd.Size = new System.Drawing.Size(75, 22);
            this.textBoxTaxCd.TabIndex = 10;
            // 
            // textBoxTaxRate
            // 
            this.textBoxTaxRate.Location = new System.Drawing.Point(598, 272);
            this.textBoxTaxRate.Name = "textBoxTaxRate";
            this.textBoxTaxRate.Size = new System.Drawing.Size(75, 22);
            this.textBoxTaxRate.TabIndex = 11;
            // 
            // buttonNewRec
            // 
            this.buttonNewRec.Location = new System.Drawing.Point(385, 350);
            this.buttonNewRec.Name = "buttonNewRec";
            this.buttonNewRec.Size = new System.Drawing.Size(109, 23);
            this.buttonNewRec.TabIndex = 12;
            this.buttonNewRec.Text = "New Record";
            this.buttonNewRec.UseVisualStyleBackColor = true;
            this.buttonNewRec.Click += new System.EventHandler(this.buttonNewRec_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(530, 350);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(633, 350);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(737, 350);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // checkBoxFedTax
            // 
            this.checkBoxFedTax.AutoSize = true;
            this.checkBoxFedTax.Location = new System.Drawing.Point(598, 309);
            this.checkBoxFedTax.Name = "checkBoxFedTax";
            this.checkBoxFedTax.Size = new System.Drawing.Size(161, 21);
            this.checkBoxFedTax.TabIndex = 16;
            this.checkBoxFedTax.Text = "Includes Federal Tax";
            this.checkBoxFedTax.UseVisualStyleBackColor = true;
            // 
            // labelDisplay
            // 
            this.labelDisplay.BackColor = System.Drawing.Color.MintCream;
            this.labelDisplay.ForeColor = System.Drawing.Color.Red;
            this.labelDisplay.Location = new System.Drawing.Point(90, 427);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(763, 118);
            this.labelDisplay.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 573);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.checkBoxFedTax);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNewRec);
            this.Controls.Add(this.textBoxTaxRate);
            this.Controls.Add(this.textBoxTaxCd);
            this.Controls.Add(this.textBoxCntryCd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPrvCd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DAPatientMaintenance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrvCd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCntryCd;
        private System.Windows.Forms.TextBox textBoxTaxCd;
        private System.Windows.Forms.TextBox textBoxTaxRate;
        private System.Windows.Forms.Button buttonNewRec;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxFedTax;
        private System.Windows.Forms.Label labelDisplay;
    }
}

