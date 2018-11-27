using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Withdraw : Form
    {
        public BankAccount selectedAccount;
        string enteredAmount = "0";
        float _withdrawalAmount = 0;
        public float WithdrawalAmount
        {
            get { return _withdrawalAmount; }
            set
            {
                _withdrawalAmount = value;
                lblWithdrawalAmount.Text = "$" + _withdrawalAmount.ToString();
                if (_withdrawalAmount > 0) btnWithdraw.Enabled = true; else btnWithdraw.Enabled = false;
            }
        }

        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            btnWithdraw.Enabled = false;

        }
        private void RefreshAll()
        {
            LoadAccounts();
            ShowAllCommonAmountButtons();
            HideCustomAmountButtons();
            HideResultDialog();
            ClearAmount();
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

        private void btnCustomAmount_Click(object sender, EventArgs e)
        {
            HideAllCommonAmountButtons();
            ShowCustomAmountButtons();
            ClearAmount();
        }

        #region WithDrawal Amount Handlers
  

        private void btnWithdraw20_Click(object sender, EventArgs e)
        {
            WithDraw(20);
        }
        private void btnWithdraw40_Click(object sender, EventArgs e)
        {
            WithDraw(40);
        }
        private void btnWithdraw60_Click(object sender, EventArgs e)
        {
            WithDraw(60);
        }
        private void btnWithdraw80_Click(object sender, EventArgs e)
        {
            WithDraw(80);
        }
        private void btnWithdraw100_Click(object sender, EventArgs e)
        {
            WithDraw(100);
        }

        private void WithDraw(float Amount) 
        {
            WithdrawalAmount = Amount;
        }
        #endregion

        #region Number Pad Handlers

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
            if (!String.IsNullOrEmpty(txtAmount.Text)) WithDraw(float.Parse(txtAmount.Text));
            enteredAmount = "0";
            txtAmount.Text = "";
        }

        private void AddText(int num)
        {
            if (num >= 0)
            {
                enteredAmount = enteredAmount + num;
            }
            else if (num == -1) {

                if (enteredAmount.Length > 0) { enteredAmount = enteredAmount.Substring(0, enteredAmount.Length - 1); }
            }

            enteredAmount = enteredAmount.TrimStart('0');
            if (enteredAmount.Length == 0 ) { txtAmount.Text = "0.00"; }
            if (enteredAmount.Length == 1) { txtAmount.Text = "0.0" + enteredAmount; }
            if (enteredAmount.Length == 2) { txtAmount.Text = "0." + enteredAmount; }
            if (enteredAmount.Length > 2) { txtAmount.Text = enteredAmount.Substring(0, enteredAmount.Length - 2) + "." + enteredAmount.Substring(enteredAmount.Length - 2, 2); }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = txtAmount.Text.Length > 0; 
            btnOK.Enabled = txtAmount.Text.Length > 0;
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (grpNumberPad.Visible)
            {
                ShowAllCommonAmountButtons();
                HideCustomAmountButtons();

            } else
            {
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
        }

        private void cmbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAccount = (BankAccount) cmbAccounts.SelectedItem;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (WithdrawalAmount > 0)
            {
                if (WithdrawalAmount <= selectedAccount.Balance)
                {
                    selectedAccount.Balance -= WithdrawalAmount;
                    XactLog x = new XactLog(selectedAccount.Name, "Withdrawal", "Withdrawal", WithdrawalAmount);
                    User.record.Add(x);
                    ShowResultDialog(true);
                    HideAllCommonAmountButtons();
                    HideCustomAmountButtons();
                } else
                {
                    ShowResultDialog(false);
                }
                
            }
        }
        private void btnWithdrawAgain_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        #region Show and Hide Controls
        private void ShowAllCommonAmountButtons()
        {
            grpCommonAmounts.Visible = true;
            btnWithdraw20.Show();
            btnWithdraw40.Show();
            btnWithdraw60.Show();
            btnWithdraw80.Show();
            btnWithdraw100.Show();
            btnCustomAmount.Show();
        }

        private void HideAllCommonAmountButtons()
        {
            grpCommonAmounts.Visible = true;
            btnWithdraw20.Hide();
            btnWithdraw40.Hide();
            btnWithdraw60.Hide();
            btnWithdraw80.Hide();
            btnWithdraw100.Hide();
            btnCustomAmount.Hide();
        }

        private void ShowCustomAmountButtons()
        {
            grpNumberPad.Show();
            txtAmount.Show();
        }

        private void HideCustomAmountButtons()
        {
            grpNumberPad.Hide();
            txtAmount.Hide();
        }

        private void ClearAmount()
        {
            WithdrawalAmount = 0;
            txtAmount.Clear();
        }


        private void ShowResultDialog(Boolean success)
        {
            lblWithdrawalResult.Text = (success) ? "Withdrawal Succesful!" : "Withdrawal Unsuccesful";
            lblResult.Text = (success) ? "Withdrew $" + WithdrawalAmount + " from " + selectedAccount.Name : "Insufficient Funds";
            pnlResultBox.Show();
        }

        private void HideResultDialog()
        {
            pnlResultBox.Hide();
        }
        #endregion

    }
}
