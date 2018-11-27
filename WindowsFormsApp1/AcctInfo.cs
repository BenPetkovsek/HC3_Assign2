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
            //listView1.Items.Clear();
            
            //add items to ListView
            foreach (XactLog log in User.record)
            {
                DataGridViewRow itm = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                itm.Cells[0].Value = log.Name;
                itm.Cells[1].Value = log.Type;
                itm.Cells[2].Value = "$" + log.amt.ToString();
                dataGridView1.Rows.Add(itm);
                
            }
            
        }


        private void infoBtn_Click(object sender, EventArgs e)
        {
            LoadLog(selectedAccount.Name, "all");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AcctInfo_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            acctInfoCmbBox.SelectedItem = selectedAccount;
        }
    }




}


