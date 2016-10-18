using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //required the sql connection
using System.Data.OleDb; //required to use OLE DB elements

namespace cS_Assignment3_bankSystem_sql
{
    public partial class Form1 : Form
    {
        string conStr = "Server=CLS01PC15;Database=bankSystem;Trusted_Connection=true";
        string[] AccTypes;
        int[] AccNoArray;
        string query;
        string user;
        decimal ballance;
        int accountNumber = 0; //for transactions tab
        
        public Form1()
        {
            InitializeComponent();
            tabControl1.Selected += new TabControlEventHandler(tabControl1_Selected); //reaqured for tabControl1_Selected function (when changing tabs)
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == tabLogin.Name)//TabLogin selected
            {
                tabControl1.TabPages.Remove(tabAccount); //hides tabAccount
                tabControl1.TabPages.Remove(tabTransactions);
                user = ""; //logs out the user :p
                tbxCID.Clear();
                tbxPass.Clear();
                AccTypes = null; //reset array values
                AccNoArray = null;
            }
            if (e.TabPage.Name == tabAccount.Name)//tabAccount selected
            {
                displayAccountTab();
            }
            if (e.TabPage.Name == tabTransactions.Name)//tabTransactions selected
            {
                displayTransactionsTab();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabAccount);
            tabControl1.TabPages.Remove(tabTransactions);
            query = "SELECT * FROM login;";
            using (SqlConnection sqlConn = new SqlConnection(conStr))
            {
                sqlConn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn);
                DataSet ds = new DataSet();

                adapter.Fill(ds, "login");
                foreach (DataRow row in ds.Tables["login"].Rows)
                {
                    lbxClients.Items.Add(row["lClientID"].ToString() + ", " + row["lPass"].ToString());
                }
                sqlConn.Close();
            }            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = tbxCID.Text;
            string pass = tbxPass.Text;
            if (user == "" || pass == "") MessageBox.Show("Missing login info!"+user+","+pass);
            else
            {
                query = "SELECT * FROM login;";
                using (SqlConnection sqlConn = new SqlConnection(conStr))
                {
                    sqlConn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "login");

                    bool f = false;
                    foreach (DataRow cRow in ds.Tables["Login"].Rows)
                    {
                        if (user == cRow["lClientID"].ToString())
                        {
                            if (pass == cRow["lPass"].ToString())
                            {
                                f = true;
                                tabControl1.TabPages.Add(tabAccount); //makes tab Account visible
                                tabControl1.TabPages.Add(tabTransactions);
                                tabControl1.SelectTab(tabAccount); //goes to Tab Account
                                tabControl1.SelectedIndex = 1;
                            }
                        }
                    }
                    if (f == false) MessageBox.Show("Wrong login information");
                }
                tbxCID.Clear();
                tbxPass.Clear();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabAccount); //hide the tab
            tabControl1.TabPages.Remove(tabTransactions);
            tabControl1.SelectTab(tabLogin); //goes to Tab Login
            tabControl1.SelectedIndex = 0;
            user = ""; //removes value for user variable
        }
        public void displayAccountTab()
        {
            query = "SELECT * FROM AccountHolders WHERE aClientID='" + user + "';";
            using (SqlConnection sqlConn = new SqlConnection(conStr))
            {
                sqlConn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "AccountHolders");
                string accType;
                int i = 0;
                lbxANo.Items.Clear();
                lbxAClientID.Items.Clear();
                lbxACName.Items.Clear();
                lbxAAccT.Items.Clear();
                lbxAAccNo.Items.Clear();
                lbxABallance.Items.Clear();

                foreach (DataRow row in ds.Tables["AccountHolders"].Rows)
                {
                    i++;
                    lbxANo.Items.Add(i.ToString());
                    lbxAClientID.Items.Add(row["aClientID"].ToString());
                    lbxACName.Items.Add(row["aClientName"].ToString());
                    lbxAAccT.Items.Add(row["aAccType"].ToString());
                    lbxAAccNo.Items.Add(row["aAccNo"].ToString());
                    lbxABallance.Items.Add(row["aBallance"].ToString());
                }
            }
            getAccTypes(); //gives me array AccTypes with types of account that client has
            if (AccTypes.Length == 1) btnTrans.Enabled = false; //if client has only one account
            else btnTrans.Enabled = true;
        }
        public void getAccTypes(){
            lbxAccType.Items.Clear();
            lbxAccNo.Items.Clear();
            int a = lbxAccType.Items.Count;
            int b = lbxAccNo.Items.Count;

            query = "SELECT * FROM AccountHolders WHERE aClientID='" + user + "';";

            //using (SqlConnection sqlConn = new SqlConnection(conStr))
            //{
            //    sqlConn.Open();
            //    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn);
            //    adapter.Fill(ds, "AccountHolders");

            //    foreach (DataRow row in ds.Tables["AccountHolders"].Rows)
            //    {
            //        if (row["aClientID"].ToString() == user)
            //            lbxAccType.Items.Add(row["aAccType"].ToString());
            //    }
            //}

            SqlConnection sqlConn = new SqlConnection(conStr);
            SqlCommand Comm1 = new SqlCommand(query, sqlConn);
            sqlConn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            while (DR1.Read())
            {
                lbxAccType.Items.Add(DR1["aAccType"].ToString());
                lbxAccNo.Items.Add(DR1["aAccNo"].ToString());
            }
            AccTypes = new string[lbxAccType.Items.Count];
            AccNoArray = new int[lbxAccNo.Items.Count];
            for (int i = 0; i < lbxAccType.Items.Count; i++)
            {
                AccTypes[i] = lbxAccType.Items[i].ToString();
                AccNoArray[i] = Convert.ToInt32(lbxAccNo.Items[i]);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnWithd_Click(object sender, EventArgs e)
        {
            string accTypeChoice="";
            decimal amount=0;
            bool balanceFlag = true; //balance is ok
            string dd = "";

            ShowWithdrawal(ref accTypeChoice, ref AccTypes, ref amount, ref dd);
            if (amount > 0)
            {
                checkBallance(ref accTypeChoice, ref amount, ref balanceFlag);
                if (balanceFlag) updateBallance(ref accTypeChoice, ref amount, "withdrawal");
                else MessageBox.Show("Amount is too high! \nYour balance is too low");

                int acNo = 0;
                getAccNo(accTypeChoice, ref acNo); //get account no passing the account name, user is as global variable = known
                updateTransactionsTable(acNo, dd, "withdrawal", amount);
                displayAccountTab();
            }
            else MessageBox.Show("amount negative?");
       }
        public void checkBallance(ref string atc, ref decimal a, ref bool b)
        {
            query = "SELECT * FROM AccountHolders WHERE aClientID='" + user + "' AND aAccType='" + atc + "';";
            SqlConnection sqlConn = new SqlConnection(conStr);
            SqlCommand Comm1 = new SqlCommand(query, sqlConn);
            sqlConn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            while (DR1.Read())
            {
                ballance = Convert.ToDecimal(DR1["aBallance"]);
            }
            if (a > ballance) b = false; //ballance is too low
            else b = true; //ballance is ok
        }
        public void ShowWithdrawal(ref string atc, ref string[] atl, ref decimal a, ref string d)
        {
            FormWithdrawal fw = new FormWithdrawal();
            for (int i = 0; i < atl.Length; i++)//fill out comboBoxes with the values from listBoxes
            {
                fw.cbxWAccType.Items.Add(atl[i].ToString());
            }

            if (fw.ShowDialog(this) == DialogResult.OK)
            {
                atc = fw.cbxWAccType.GetItemText(fw.cbxWAccType.SelectedItem);
                a = Convert.ToDecimal(fw.tbxWAmount.Text);
                d = fw.dateDepWith.Value.ToString("MM/dd/yyyy");            }
            fw.Dispose();
        }
        public void updateBallance(ref string atc, ref decimal a, string op)
        {
                if (op == "withdrawal" || op == "transfer") ballance = ballance - a;
                else ballance = ballance + a;
                query = "UPDATE AccountHolders SET aBallance=" + ballance + " WHERE aClientID='" + user + "' AND aAccType='" + atc + "';";
                using (SqlConnection sqlConn = new SqlConnection(conStr))
                {
                    SqlCommand com = new SqlCommand(query, sqlConn);
                    com.Connection.Open();
                    com.ExecuteNonQuery();
                }
        }
        private void btnDep_Click(object sender, EventArgs e)
        {
            string accTypeChoice = "";
            decimal amount = 0;
            bool balanceFlag = true; //ballance ok
            string dd = "";

            ShowWithdrawal(ref accTypeChoice, ref AccTypes, ref amount, ref dd);
                        if (amount > 0)
            {

            checkBallance(ref accTypeChoice, ref amount, ref balanceFlag);

            if (accTypeChoice == "visa") MessageBox.Show("Deposits are not allowed on visa");
            else updateBallance(ref accTypeChoice, ref amount, "deposit");

            int acNo = 0;
            getAccNo(accTypeChoice, ref acNo); //get account no passing the account name, user is as global variable = known
            updateTransactionsTable(acNo, dd, "deposit", amount);
            displayAccountTab();
            }
                        else MessageBox.Show("amount negative?");

        }
        private void btnTrans_Click_1(object sender, EventArgs e)
        {
            string accTypeChoice1 = "";
            string accTypeChoice2 = "";
            decimal amount = 0;
            bool balanceFlag = true; //balance is ok
            string dd = "";
            int acNo = 0; //to update transactions table

            showTransactiosn(ref accTypeChoice1, ref accTypeChoice2, ref AccTypes, ref amount, ref dd); //opens form for transactions
            if (amount > 0)
            {
                checkBallance(ref accTypeChoice1, ref amount, ref balanceFlag);
                if (balanceFlag)
                {
                    if (accTypeChoice2 == "visa") MessageBox.Show("Deposits are not allowed on visa");
                    else
                    {
                        updateBallance(ref accTypeChoice1, ref amount, "withdrawal"); //withdrawal from the FromAccount
                        getAccNo(accTypeChoice1, ref acNo); //get account no passing the account name, user is as global variable = known
                        updateTransactionsTable(acNo, dd, "withdrawal", amount);

                        checkBallance(ref accTypeChoice2, ref amount, ref balanceFlag); //get the ballance value for second account
                        updateBallance(ref accTypeChoice2, ref amount, "deposit"); //deposit to the ToAccunt
                        getAccNo(accTypeChoice2, ref acNo);
                        updateTransactionsTable(acNo, dd, "deposit", amount);
                    }
                }
                else MessageBox.Show("Amount is too high! \nYour balance is too low");
                displayAccountTab();
            }
            else MessageBox.Show("amount negative?");
        }
        public void showTransactiosn(ref string atc1, ref string atc2, ref string[] atl, ref decimal a, ref string d){
            FormTransaction ft = new FormTransaction();
            for (int i = 0; i < atl.Length; i++)//fill out comboBoxes with the values from listBoxes
            {
                ft.cbxTAccFrom.Items.Add(atl[i].ToString());
                ft.cbxTAccTo.Items.Add(atl[i].ToString());
            }
            if (ft.ShowDialog(this) == DialogResult.OK)
            {
                atc1 = ft.cbxTAccFrom.GetItemText(ft.cbxTAccFrom.SelectedItem);
                atc2 = ft.cbxTAccTo.GetItemText(ft.cbxTAccTo.SelectedItem);
                a = Convert.ToDecimal(ft.tbxTAmount.Text);
                d = ft.dateTrans.Value.ToString("MM/dd/yyyy");
            }
            ft.Dispose();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnTLogOut_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabAccount); //hide the tab
            tabControl1.TabPages.Remove(tabTransactions);
            tabControl1.SelectTab(tabLogin); //goes to Tab Login
            tabControl1.SelectedIndex = 0;
            user = ""; //removes value for user variable
        }
        private void btnTClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        public void displayTransactionsTab()
        {
            cbxTAccType.SelectedIndex = -1;
            tbxTAccNo.Text = "";
            cbxTAccType.Items.Clear(); //removes all items from comboBox
            for (int i = 0; i < AccTypes.Length; i++)//fill out comboBoxes with the values from listBoxes
            {
                cbxTAccType.Items.Add(AccTypes[i].ToString());
            }
            cbxTAccType.Items.Add("All");
            clearTListBoxes();

            dateFrom.Enabled = false;
            dateTo.Enabled = false;
            btnTShow.Enabled = false;
            tbxTAccNo.Enabled = false;
            getAccTypes(); //fills out AccTypes and AccNoArray arrays
        }
        private void cbxTAccType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int at = cbxTAccType.SelectedIndex; //index of selected account (0=saving, 1=checking, 3=visa)

            if (at != -1 && at != cbxTAccType.Items.Count-1)
            {
                accountNumber = AccNoArray[at];
                query = "SELECT * FROM Transactions WHERE tAccNo=" + accountNumber + ";";
                clearTListBoxes();
                int j = 0;
                displayTransactions(accountNumber, query, ref j);
            }
            else if (at == cbxTAccType.Items.Count-1) //if choosen last option -> all transactions
            {
                clearTListBoxes();
                int j = 0;
                for (int i = 0; i < AccNoArray.Length; i++)
                {
                    query = "SELECT * FROM Transactions WHERE tAccNo=" + AccNoArray[i] + ";";
                    displayTransactions(accountNumber, query,ref j);
                }
            }
        }
        public void displayTransactions(int accountNumber, string query, ref int j)
        {
            if (accountNumber == cbxTAccType.Items.Count - 1) tbxTAccNo.Text = "NA";
            else tbxTAccNo.Text = accountNumber.ToString();

            using (SqlConnection sqlConn = new SqlConnection(conStr))
            {
                dateFrom.Enabled = true;
                dateTo.Enabled = true;
                btnTShow.Enabled = true;

                sqlConn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Transactions");
                foreach (DataRow row in ds.Tables["Transactions"].Rows)
                {
                    j++;
                    lbxTNo.Items.Add(j.ToString());
                    lbxTid.Items.Add(row["tID"].ToString());
                    lbxTAccNo.Items.Add(row["tAccNo"].ToString());
                    lbxTAction.Items.Add(row["tAction"].ToString());
                    lbxTAmount.Items.Add(row["tAmount"].ToString());
                    lbxTDate.Items.Add(row["tDate"].ToString());
                }
            }//end using()
        }
        private void btnTShow_Click(object sender, EventArgs e)
        {
            //string dateFro = dateFrom.Value.ToString("MM/dd/yyyy");
            //string dateToo = dateTo.Value.ToString("MM/dd/yyyy");

            if (dateFrom.Value >= dateTo.Value) MessageBox.Show("Date To can't be older than Date From");
            else
            {
                query = "SELECT * FROM Transactions WHERE tAccNo=" + accountNumber + " AND tDate > '"+dateFrom.Value+"' AND tDate < '"+dateTo.Value+"';";
                clearTListBoxes();
                int j = 0;
                displayTransactions(accountNumber, query, ref j);
            }
        }
        public void clearTListBoxes()
        {
                lbxTNo.Items.Clear();
                lbxTid.Items.Clear();
                lbxTAccNo.Items.Clear();
                lbxTAction.Items.Clear();
                lbxTAmount.Items.Clear();
                lbxTDate.Items.Clear();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void updateTransactionsTable(int AccNo1, string tDate, string tAction, decimal tAmount)
        {
            int id=0;
            //int AccNo1 = 0;
            getLastID(ref id);
            //            updateTransactionsTable(acNo, dd, "withdrawal", amount);
            query = "INSERT INTO Transactions (tID, tAccNo, tDate, tAction, tAmount) VALUES (" + (id + 1) + ", " + AccNo1 + ", '" + tDate + "', '" + tAction + "', " + tAmount + ");";
            using (SqlConnection sqlConn = new SqlConnection(conStr))
            {
                SqlCommand com = new SqlCommand(query, sqlConn);
                com.Connection.Open();
                com.ExecuteNonQuery();
            }
        }
        public void getLastID(ref int idd)
        {
            query = "SELECT * FROM Transactions;";
            using (SqlConnection sqlConn = new SqlConnection(conStr))
            {
                sqlConn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "AccountHolders");
                foreach (DataRow row in ds.Tables["AccountHolders"].Rows)
                {
                    idd++;
                }
            }
        }
        public void getAccNo(string accName, ref int accNo2)
        {
            query = "SELECT * FROM AccountHolders WHERE aAccType='"+ accName+"' AND aClientID='"+user+"';";
            using (SqlConnection sqlConn = new SqlConnection(conStr))
            {
                sqlConn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "AccountHolders");
                foreach (DataRow row in ds.Tables["AccountHolders"].Rows)
                {
                    accNo2 = Convert.ToInt32(row["aAccNo"]);
                }
            }
        }

    }
}
