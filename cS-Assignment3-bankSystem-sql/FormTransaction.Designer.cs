namespace cS_Assignment3_bankSystem_sql
{
    partial class FormTransaction
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxTAmount = new System.Windows.Forms.TextBox();
            this.cbxTAccFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTAccTo = new System.Windows.Forms.ComboBox();
            this.dateTrans = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(107, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(26, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbxTAmount
            // 
            this.tbxTAmount.Location = new System.Drawing.Point(91, 70);
            this.tbxTAmount.Name = "tbxTAmount";
            this.tbxTAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxTAmount.TabIndex = 9;
            // 
            // cbxTAccFrom
            // 
            this.cbxTAccFrom.FormattingEnabled = true;
            this.cbxTAccFrom.Location = new System.Drawing.Point(91, 16);
            this.cbxTAccFrom.Name = "cbxTAccFrom";
            this.cbxTAccFrom.Size = new System.Drawing.Size(100, 21);
            this.cbxTAccFrom.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "From account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "To account:";
            // 
            // cbxTAccTo
            // 
            this.cbxTAccTo.FormattingEnabled = true;
            this.cbxTAccTo.Location = new System.Drawing.Point(91, 43);
            this.cbxTAccTo.Name = "cbxTAccTo";
            this.cbxTAccTo.Size = new System.Drawing.Size(100, 21);
            this.cbxTAccTo.TabIndex = 13;
            // 
            // dateTrans
            // 
            this.dateTrans.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTrans.Location = new System.Drawing.Point(91, 96);
            this.dateTrans.Name = "dateTrans";
            this.dateTrans.Size = new System.Drawing.Size(100, 20);
            this.dateTrans.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Date:";
            // 
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 173);
            this.Controls.Add(this.dateTrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTAccTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxTAmount);
            this.Controls.Add(this.cbxTAccFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaction";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbxTAmount;
        public System.Windows.Forms.ComboBox cbxTAccFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbxTAccTo;
        public System.Windows.Forms.DateTimePicker dateTrans;
        private System.Windows.Forms.Label label4;
    }
}