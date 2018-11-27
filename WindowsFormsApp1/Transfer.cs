using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApp1
{
    public partial class Transfer : Form
    {
        List<string> amount = new List<string>();
        string amountStr = "";

        public Transfer()
        {
            InitializeComponent();
        }

        private void TransferLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            panel1.Hide();

            transferComboFrom.Items.Clear();
            foreach (BankAccount accnt in User.Accounts)
            {
                transferComboFrom.Items.Add(accnt);
            }
            transferComboFrom.SelectedIndex = 0;

            transferComboTo.Items.Clear();
            foreach (BankAccount accnt in User.Accounts)
            {
                transferComboTo.Items.Add(accnt);
            }
            transferComboTo.SelectedIndex = 1;
            textBox1.Text = "0.00";
            confirmBtn.Enabled = false;
            confirmBtn.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addText(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addText(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addText(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addText(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addText(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addText(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addText(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addText(8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addText(9);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addText(-1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addText(0);
        }

        //0 = chequing, 1 = saving
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            BankAccount accountFrom = (BankAccount) transferComboFrom.SelectedItem;
            BankAccount accountTo = (BankAccount) transferComboTo.SelectedItem;


            if (accountFrom != accountTo && accountFrom != null && accountTo != null && !string.IsNullOrEmpty(amountStr))
            {
                float amt = float.Parse(amountStr);
                if (amt < accountFrom.Balance)
                {
                    accountFrom.Balance -= amt;
                    accountTo.Balance += amt;
                    XactLog x = new XactLog(accountFrom.Name, "Transfer", "Transfer To: " + accountTo.Name, amt);
                    User.record.Add(x);
                    finishTransfer(true);
                }
                else
                {
                    //OVERDRAWN ERROR
                    finishTransfer(false);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void transferComboTo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void transferComboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }


        private void addText(int num)
        {
            amountStr = "";
            if(num >= 0) { amount.Add(num.ToString()); }
            else {
                if (amount.Count != 0) { amount.RemoveAt(amount.Count - 1); }
                else
                {
                    textBox1.Text = "0.00";
                    amountStr = "0.00";
                }
                
            }

            if (amount.Count >2)
            {
                for (int i = 0; i < amount.Count; i++)
                {
                    if (i == amount.Count - 2) { amountStr += "."; }
                    amountStr += amount[i];
                }
                confirmBtn.Enabled = true;
                confirmBtn.BackColor = Color.FromArgb(132, 200, 135);
            }
            else if(amount.Count ==1)
            {
                amountStr = "0.0" + amount[0];
                confirmBtn.Enabled = true;
                confirmBtn.BackColor = Color.FromArgb(132, 200, 135);
            }
            else if (amount.Count == 2)
            {
                amountStr = "0." + amount[0] + amount[1];
                confirmBtn.Enabled = true;
                confirmBtn.BackColor = Color.FromArgb(132, 200, 135);
            }
            else if(amount.Count == 0)
            {
                amountStr = "0.00";
                confirmBtn.Enabled = false;
                confirmBtn.BackColor = Color.Gray;
            }

            textBox1.Text = amountStr;


            
        }

        private void finishTransfer(bool result)
        {
            panel1.Show();
            refresh();

            if (result)
            {
                transferResultLabel.Text = "Transfer Complete!";
                transferResultText.Text = "Please select an option below.";
            }
            else
            {
                transferResultLabel.Text = "Transfer Failed";
                transferResultText.Text = "Withdraw amount more than balance!";
            }
            refresh();
            
            

            
        }

        private void refresh()
        {
            amountStr = "";
            amount = new List<string>();
            textBox1.Text = "";
            transferComboFrom.Items.Clear();
            foreach (BankAccount accnt in User.Accounts)
            {
                transferComboFrom.Items.Add(accnt);
            }
            transferComboFrom.SelectedIndex = 0;

            transferComboTo.Items.Clear();
            foreach (BankAccount accnt in User.Accounts)
            {
                transferComboTo.Items.Add(accnt);
            }
            transferComboTo.SelectedIndex = 1;
            confirmBtn.Enabled = false;
            confirmBtn.BackColor = Color.Gray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            refresh();
            panel1.Hide();
        }
    }
}
