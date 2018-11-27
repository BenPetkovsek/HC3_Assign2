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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Withdraw withdrawWindow = new Withdraw();
            withdrawWindow.selectedAccount = (BankAccount)accountComboBox.SelectedItem;
            withdrawWindow.ShowDialog();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            accountComboBox.Items.Clear();
            foreach (BankAccount accnt in User.Accounts)
            {
                accountComboBox.Items.Add(accnt);
            }
            accountComboBox.SelectedIndex = 0;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.Show();
            this.Hide();
        }

        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AcctInfo acctWindow = new AcctInfo();
            User.LoadLog();
            acctWindow.selectedAccount = (BankAccount)accountComboBox.SelectedItem;
            acctWindow.ShowDialog();
            this.Close();
		}
        
		private void button5_Click(object sender, EventArgs e) {
            ETransfer transfer = new ETransfer();
            transfer.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.selectedAccount = (BankAccount)accountComboBox.SelectedItem;
            deposit.Show();
            this.Hide();
        }
    }
}
