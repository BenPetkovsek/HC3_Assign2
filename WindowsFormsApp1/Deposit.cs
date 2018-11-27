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
    public partial class Deposit : Form
    {
        public BankAccount selectedAccount;
        string enteredAmount = "0";
        float _depositAmount = 0;
        public float DepositAmount
        {
            get { return _depositAmount; }
            set
            {
                _depositAmount = value;
                lblAmount.Text = "$" + _depositAmount.ToString();
                if (_depositAmount > 0) btnDeposit.Enabled = true; else btnDeposit.Enabled = false;
            }
        }

        public Deposit()
        {
            InitializeComponent();
        }

        #region Amount Buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            AddText(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddText(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddText(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddText(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddText(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddText(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddText(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddText(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddText(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AddText(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AddText(-1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAmount.Text)) SetDepositAmount(float.Parse(txtAmount.Text));
            enteredAmount = "0";
            txtAmount.Text = "";
        }

        private void AddText(int num)
        {
            if (num >= 0)
            {
                enteredAmount = enteredAmount + num;
            }
            else if (num == -1)
            {

                if (enteredAmount.Length > 0) { enteredAmount = enteredAmount.Substring(0, enteredAmount.Length - 1); }
            }

            enteredAmount = enteredAmount.TrimStart('0');
            if (enteredAmount.Length == 0) { txtAmount.Text = "0.00"; }
            if (enteredAmount.Length == 1) { txtAmount.Text = "0.0" + enteredAmount; }
            if (enteredAmount.Length == 2) { txtAmount.Text = "0." + enteredAmount; }
            if (enteredAmount.Length > 2) { txtAmount.Text = enteredAmount.Substring(0, enteredAmount.Length - 2) + "." + enteredAmount.Substring(enteredAmount.Length - 2, 2); }
        }
        #endregion

        private void btnDepositCash_Click(object sender, EventArgs e)
        {
            btnDepositCash.Size = new Size(255, 61);
            btnDepositCheque.Size = new Size(264, 61);
            btnDepositCheque.BackColor = Color.LightGray;
            btnDepositCash.BackColor = Color.ForestGreen;
            pnlDepositCheque.Visible = false;
            pnlResultBox.Visible = false;
            pnlDepositCash.Show();
            
        }

        private void btnDepositCheque_Click(object sender, EventArgs e)
        {
            btnDepositCash.Size = new Size(255, 61);
            btnDepositCheque.Size = new Size(264, 61);
            btnDepositCash.BackColor = Color.LightGray;
            btnDepositCheque.BackColor = Color.PowderBlue;
            pnlDepositCash.Visible = false;
            pnlDepositCheque.Visible = true;
            pnlResultBox.Visible = false;
        }

        private void SetDepositAmount(float amt)
        {
            DepositAmount = amt;
        }

        private void cmbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAccount = (BankAccount)cmbAccounts.SelectedItem;
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            pnlResultBox.Hide();
            pnlDepositCheque.Hide();
            pnlDepositCash.Hide();
            LoadAccounts();
        }
        private void LoadAccounts()
        {
            cmbAccounts.Items.Clear();
            foreach (BankAccount accnt in User.Accounts)
            {
                cmbAccounts.Items.Add(accnt);
            }
            cmbAccounts.SelectedItem = selectedAccount;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {


            if (_depositAmount > 0)
            {
                selectedAccount.Balance += _depositAmount;
                ShowResultDialog(true);
                XactLog x = new XactLog(selectedAccount.Name, "Deposit", "Deposit", DepositAmount);
                User.record.Add(x);

            }
        }
        private void ShowResultDialog(Boolean success)
        {
            if (success) {
                pnlDepositCash.Hide();
                pnlDepositCheque.Hide();
                pnlResultBox.Parent = this;
                pnlResultBox.Show();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnDepositAgain_Click(object sender, EventArgs e)
        {
            LoadAccounts();
            pnlResultBox.Hide();
            pnlDepositCheque.Hide();
            pnlDepositCash.Hide();
            btnDepositCash.Size = new Size(255, 400);
            btnDepositCheque.Size = new Size(264, 400);
            btnDepositCheque.BackColor = Color.PowderBlue;
            btnDepositCash.BackColor = Color.ForestGreen;
            txtAmount.Text = "";
            DepositAmount = 0;

        }

        private void btnInsertCheque_Click(object sender, EventArgs e)
        {
            DepositAmount = 500.00f;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = txtAmount.Text.Length > 0;
            btnOK.Enabled = txtAmount.Text.Length > 0;
        }
    }
}
