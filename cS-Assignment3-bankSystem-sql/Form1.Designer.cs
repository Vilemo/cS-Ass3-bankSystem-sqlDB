namespace cS_Assignment3_bankSystem_sql
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.lbxClients = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.lbxANo = new System.Windows.Forms.ListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lbxACName = new System.Windows.Forms.ListBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lbxABallance = new System.Windows.Forms.ListBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lbxAAccNo = new System.Windows.Forms.ListBox();
            this.tx = new System.Windows.Forms.TextBox();
            this.lbxAAccT = new System.Windows.Forms.ListBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.lbxAClientID = new System.Windows.Forms.ListBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.btnTrans = new System.Windows.Forms.Button();
            this.lbxAccNo = new System.Windows.Forms.ListBox();
            this.lbxAccType = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDep = new System.Windows.Forms.Button();
            this.btnWithd = new System.Windows.Forms.Button();
            this.tabTransactions = new System.Windows.Forms.TabPage();
            this.lbxTNo = new System.Windows.Forms.ListBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lbxTAccNo = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTClose = new System.Windows.Forms.Button();
            this.btnTLogOut = new System.Windows.Forms.Button();
            this.tbxTAccNo = new System.Windows.Forms.TextBox();
            this.cbxTAccType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTShow = new System.Windows.Forms.Button();
            this.lbxTDate = new System.Windows.Forms.ListBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbxTAmount = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbxTAction = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbxTid = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tabTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Controls.Add(this.tabTransactions);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 227);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.label8);
            this.tabLogin.Controls.Add(this.lbxClients);
            this.tabLogin.Controls.Add(this.btnCancel);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.tbxPass);
            this.tabLogin.Controls.Add(this.label2);
            this.tabLogin.Controls.Add(this.tbxCID);
            this.tabLogin.Controls.Add(this.label1);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(502, 201);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Clients:";
            // 
            // lbxClients
            // 
            this.lbxClients.FormattingEnabled = true;
            this.lbxClients.Location = new System.Drawing.Point(276, 29);
            this.lbxClients.Name = "lbxClients";
            this.lbxClients.Size = new System.Drawing.Size(120, 95);
            this.lbxClients.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(120, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(39, 114);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(95, 76);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(100, 20);
            this.tbxPass.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // tbxCID
            // 
            this.tbxCID.Location = new System.Drawing.Point(95, 50);
            this.tbxCID.Name = "tbxCID";
            this.tbxCID.Size = new System.Drawing.Size(100, 20);
            this.tbxCID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client ID:";
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.lbxANo);
            this.tabAccount.Controls.Add(this.textBox7);
            this.tabAccount.Controls.Add(this.lbxACName);
            this.tabAccount.Controls.Add(this.textBox8);
            this.tabAccount.Controls.Add(this.lbxABallance);
            this.tabAccount.Controls.Add(this.textBox9);
            this.tabAccount.Controls.Add(this.lbxAAccNo);
            this.tabAccount.Controls.Add(this.tx);
            this.tabAccount.Controls.Add(this.lbxAAccT);
            this.tabAccount.Controls.Add(this.textBox11);
            this.tabAccount.Controls.Add(this.lbxAClientID);
            this.tabAccount.Controls.Add(this.textBox12);
            this.tabAccount.Controls.Add(this.btnTrans);
            this.tabAccount.Controls.Add(this.lbxAccNo);
            this.tabAccount.Controls.Add(this.lbxAccType);
            this.tabAccount.Controls.Add(this.btnClose);
            this.tabAccount.Controls.Add(this.btnLogOut);
            this.tabAccount.Controls.Add(this.btnDep);
            this.tabAccount.Controls.Add(this.btnWithd);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(502, 201);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.Text = "Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // lbxANo
            // 
            this.lbxANo.FormattingEnabled = true;
            this.lbxANo.Location = new System.Drawing.Point(12, 25);
            this.lbxANo.Name = "lbxANo";
            this.lbxANo.Size = new System.Drawing.Size(22, 134);
            this.lbxANo.TabIndex = 39;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(12, 6);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(22, 20);
            this.textBox7.TabIndex = 38;
            this.textBox7.Text = "No";
            // 
            // lbxACName
            // 
            this.lbxACName.FormattingEnabled = true;
            this.lbxACName.Location = new System.Drawing.Point(69, 25);
            this.lbxACName.Name = "lbxACName";
            this.lbxACName.Size = new System.Drawing.Size(76, 134);
            this.lbxACName.TabIndex = 37;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(69, 6);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 20);
            this.textBox8.TabIndex = 36;
            this.textBox8.Text = "Name";
            // 
            // lbxABallance
            // 
            this.lbxABallance.FormattingEnabled = true;
            this.lbxABallance.Location = new System.Drawing.Point(256, 25);
            this.lbxABallance.Name = "lbxABallance";
            this.lbxABallance.Size = new System.Drawing.Size(67, 134);
            this.lbxABallance.TabIndex = 35;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(256, 6);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(67, 20);
            this.textBox9.TabIndex = 34;
            this.textBox9.Text = "Ballance";
            // 
            // lbxAAccNo
            // 
            this.lbxAAccNo.FormattingEnabled = true;
            this.lbxAAccNo.Location = new System.Drawing.Point(202, 25);
            this.lbxAAccNo.Name = "lbxAAccNo";
            this.lbxAAccNo.Size = new System.Drawing.Size(55, 134);
            this.lbxAAccNo.TabIndex = 33;
            // 
            // tx
            // 
            this.tx.Enabled = false;
            this.tx.Location = new System.Drawing.Point(202, 6);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(55, 20);
            this.tx.TabIndex = 32;
            this.tx.Text = "Acc No";
            // 
            // lbxAAccT
            // 
            this.lbxAAccT.FormattingEnabled = true;
            this.lbxAAccT.Location = new System.Drawing.Point(144, 25);
            this.lbxAAccT.Name = "lbxAAccT";
            this.lbxAAccT.Size = new System.Drawing.Size(59, 134);
            this.lbxAAccT.TabIndex = 31;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(144, 6);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(59, 20);
            this.textBox11.TabIndex = 30;
            this.textBox11.Text = "Acc type";
            // 
            // lbxAClientID
            // 
            this.lbxAClientID.FormattingEnabled = true;
            this.lbxAClientID.Location = new System.Drawing.Point(33, 25);
            this.lbxAClientID.Name = "lbxAClientID";
            this.lbxAClientID.Size = new System.Drawing.Size(37, 134);
            this.lbxAClientID.TabIndex = 29;
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(33, 6);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(37, 20);
            this.textBox12.TabIndex = 28;
            this.textBox12.Text = "ID";
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(162, 172);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(69, 23);
            this.btnTrans.TabIndex = 23;
            this.btnTrans.Text = "Transfer";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click_1);
            // 
            // lbxAccNo
            // 
            this.lbxAccNo.FormattingEnabled = true;
            this.lbxAccNo.Location = new System.Drawing.Point(230, 48);
            this.lbxAccNo.Name = "lbxAccNo";
            this.lbxAccNo.Size = new System.Drawing.Size(27, 108);
            this.lbxAccNo.TabIndex = 22;
            this.lbxAccNo.Visible = false;
            // 
            // lbxAccType
            // 
            this.lbxAccType.FormattingEnabled = true;
            this.lbxAccType.Location = new System.Drawing.Point(204, 48);
            this.lbxAccType.Name = "lbxAccType";
            this.lbxAccType.Size = new System.Drawing.Size(27, 108);
            this.lbxAccType.TabIndex = 19;
            this.lbxAccType.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(409, 48);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(409, 19);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDep
            // 
            this.btnDep.Location = new System.Drawing.Point(87, 172);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(69, 23);
            this.btnDep.TabIndex = 12;
            this.btnDep.Text = "Deposit";
            this.btnDep.UseVisualStyleBackColor = true;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btnWithd
            // 
            this.btnWithd.Location = new System.Drawing.Point(12, 172);
            this.btnWithd.Name = "btnWithd";
            this.btnWithd.Size = new System.Drawing.Size(69, 23);
            this.btnWithd.TabIndex = 11;
            this.btnWithd.Text = "Withdrawal";
            this.btnWithd.UseVisualStyleBackColor = true;
            this.btnWithd.Click += new System.EventHandler(this.btnWithd_Click);
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.lbxTNo);
            this.tabTransactions.Controls.Add(this.textBox6);
            this.tabTransactions.Controls.Add(this.lbxTAccNo);
            this.tabTransactions.Controls.Add(this.textBox2);
            this.tabTransactions.Controls.Add(this.dateTo);
            this.tabTransactions.Controls.Add(this.dateFrom);
            this.tabTransactions.Controls.Add(this.label12);
            this.tabTransactions.Controls.Add(this.btnTClose);
            this.tabTransactions.Controls.Add(this.btnTLogOut);
            this.tabTransactions.Controls.Add(this.tbxTAccNo);
            this.tabTransactions.Controls.Add(this.cbxTAccType);
            this.tabTransactions.Controls.Add(this.label11);
            this.tabTransactions.Controls.Add(this.label10);
            this.tabTransactions.Controls.Add(this.label9);
            this.tabTransactions.Controls.Add(this.btnTShow);
            this.tabTransactions.Controls.Add(this.lbxTDate);
            this.tabTransactions.Controls.Add(this.textBox5);
            this.tabTransactions.Controls.Add(this.lbxTAmount);
            this.tabTransactions.Controls.Add(this.textBox3);
            this.tabTransactions.Controls.Add(this.lbxTAction);
            this.tabTransactions.Controls.Add(this.textBox4);
            this.tabTransactions.Controls.Add(this.lbxTid);
            this.tabTransactions.Controls.Add(this.textBox1);
            this.tabTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransactions.Size = new System.Drawing.Size(501, 201);
            this.tabTransactions.TabIndex = 2;
            this.tabTransactions.Text = "Transactions";
            this.tabTransactions.UseVisualStyleBackColor = true;
            // 
            // lbxTNo
            // 
            this.lbxTNo.FormattingEnabled = true;
            this.lbxTNo.Location = new System.Drawing.Point(100, 25);
            this.lbxTNo.Name = "lbxTNo";
            this.lbxTNo.Size = new System.Drawing.Size(22, 160);
            this.lbxTNo.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(100, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(22, 20);
            this.textBox6.TabIndex = 26;
            this.textBox6.Text = "No";
            // 
            // lbxTAccNo
            // 
            this.lbxTAccNo.FormattingEnabled = true;
            this.lbxTAccNo.Location = new System.Drawing.Point(157, 25);
            this.lbxTAccNo.Name = "lbxTAccNo";
            this.lbxTAccNo.Size = new System.Drawing.Size(44, 160);
            this.lbxTAccNo.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(157, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 20);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "Acc no";
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(399, 64);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(95, 20);
            this.dateTo.TabIndex = 23;
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(399, 21);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(95, 20);
            this.dateFrom.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Account no:";
            // 
            // btnTClose
            // 
            this.btnTClose.Location = new System.Drawing.Point(9, 159);
            this.btnTClose.Name = "btnTClose";
            this.btnTClose.Size = new System.Drawing.Size(75, 23);
            this.btnTClose.TabIndex = 20;
            this.btnTClose.Text = "Close";
            this.btnTClose.UseVisualStyleBackColor = true;
            this.btnTClose.Click += new System.EventHandler(this.btnTClose_Click);
            // 
            // btnTLogOut
            // 
            this.btnTLogOut.Location = new System.Drawing.Point(9, 130);
            this.btnTLogOut.Name = "btnTLogOut";
            this.btnTLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnTLogOut.TabIndex = 19;
            this.btnTLogOut.Text = "Log out";
            this.btnTLogOut.UseVisualStyleBackColor = true;
            this.btnTLogOut.Click += new System.EventHandler(this.btnTLogOut_Click);
            // 
            // tbxTAccNo
            // 
            this.tbxTAccNo.Location = new System.Drawing.Point(9, 72);
            this.tbxTAccNo.Name = "tbxTAccNo";
            this.tbxTAccNo.Size = new System.Drawing.Size(75, 20);
            this.tbxTAccNo.TabIndex = 17;
            // 
            // cbxTAccType
            // 
            this.cbxTAccType.FormattingEnabled = true;
            this.cbxTAccType.Location = new System.Drawing.Point(9, 29);
            this.cbxTAccType.Name = "cbxTAccType";
            this.cbxTAccType.Size = new System.Drawing.Size(75, 21);
            this.cbxTAccType.TabIndex = 16;
            this.cbxTAccType.SelectedIndexChanged += new System.EventHandler(this.cbxTAccType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Choose account:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "To date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "From date:";
            // 
            // btnTShow
            // 
            this.btnTShow.Location = new System.Drawing.Point(399, 91);
            this.btnTShow.Name = "btnTShow";
            this.btnTShow.Size = new System.Drawing.Size(95, 23);
            this.btnTShow.TabIndex = 10;
            this.btnTShow.Text = "Show";
            this.btnTShow.UseVisualStyleBackColor = true;
            this.btnTShow.Click += new System.EventHandler(this.btnTShow_Click);
            // 
            // lbxTDate
            // 
            this.lbxTDate.FormattingEnabled = true;
            this.lbxTDate.Location = new System.Drawing.Point(322, 25);
            this.lbxTDate.Name = "lbxTDate";
            this.lbxTDate.Size = new System.Drawing.Size(66, 160);
            this.lbxTDate.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(322, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(66, 20);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Date";
            // 
            // lbxTAmount
            // 
            this.lbxTAmount.FormattingEnabled = true;
            this.lbxTAmount.Location = new System.Drawing.Point(268, 25);
            this.lbxTAmount.Name = "lbxTAmount";
            this.lbxTAmount.Size = new System.Drawing.Size(55, 160);
            this.lbxTAmount.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(268, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Amount";
            // 
            // lbxTAction
            // 
            this.lbxTAction.FormattingEnabled = true;
            this.lbxTAction.Location = new System.Drawing.Point(200, 25);
            this.lbxTAction.Name = "lbxTAction";
            this.lbxTAction.Size = new System.Drawing.Size(69, 160);
            this.lbxTAction.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(200, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Action";
            // 
            // lbxTid
            // 
            this.lbxTid.FormattingEnabled = true;
            this.lbxTid.Location = new System.Drawing.Point(121, 25);
            this.lbxTid.Name = "lbxTid";
            this.lbxTid.Size = new System.Drawing.Size(37, 160);
            this.lbxTid.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(121, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 251);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bank System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.tabTransactions.ResumeLayout(false);
            this.tabTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabTransactions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDep;
        private System.Windows.Forms.Button btnWithd;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxAccType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbxClients;
        private System.Windows.Forms.ListBox lbxTid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbxTAmount;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox lbxTAction;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox lbxTDate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTShow;
        private System.Windows.Forms.ComboBox cbxTAccType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbxAccNo;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.TextBox tbxTAccNo;
        private System.Windows.Forms.Button btnTClose;
        private System.Windows.Forms.Button btnTLogOut;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.ListBox lbxTAccNo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox lbxTNo;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListBox lbxANo;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ListBox lbxACName;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ListBox lbxABallance;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ListBox lbxAAccNo;
        private System.Windows.Forms.TextBox tx;
        private System.Windows.Forms.ListBox lbxAAccT;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.ListBox lbxAClientID;
        private System.Windows.Forms.TextBox textBox12;
    }
}

