using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AcctInfo : Form
    {
        public BankAccount selectedAccount;
        public AcctInfo()
        {
            InitializeComponent();
        }


        private void LoadAccounts()
        {
            acctInfoCmbBox.Items.Clear();
            foreach (BankAccount accnt in User.Accounts)
            {
                acctInfoCmbBox.Items.Add(accnt);
            }
            acctInfoCmbBox.Items.Add(new BankAccount("Total", User.Accounts[0].Balance + User.Accounts[1].Balance));
            acctInfoCmbBox.SelectedItem = selectedAccount;
        }

        private void cmbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAccount = (BankAccount)acctInfoCmbBox.SelectedItem;
        }


        private void button1_Click(object sender, EventArgs e)//menu button
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void LoadLog(string acct, string type) //fix
        {
            dataGridView1.Rows.Clear();
            
            //add items to ListView
            foreach (XactLog log in User.record)
            {
                DataGridViewRow itm = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                
                if ((checkBox1.Checked && log.Type.Equals("Withdrawal")) || (checkBox2.Checked && log.Type.Equals("Deposit")) || (checkBox3.Checked && log.Type.Equals("Purchase")) || (checkBox4.Checked && log.Type.Equals("Transfer")))
                {
                    if (log.Name.Equals(selectedAccount.Name) || selectedAccount.Name.Equals("Total"))
                    {
                        itm.Cells[0].Value = log.Name;
                        itm.Cells[1].Value = log.message;
                        itm.Cells[2].Value = "$" + log.amt.ToString();
                        dataGridView1.Rows.Add(itm);
                    }
                }
            }
            
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AcctInfo_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            LoadLog("temp","temp");
            acctInfoCmbBox.SelectedItem = selectedAccount;
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //with
        {
            LoadLog("temp", "temp");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //depo
        {
            LoadLog("temp", "temp");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) //purch
        {
            LoadLog("temp", "temp");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) //transfers
        {
            LoadLog("temp", "temp");
        }

        private void acctInfoCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAccount = (BankAccount) acctInfoCmbBox.SelectedItem;
            LoadLog("temp", "temp"); 
        }
    }




}


