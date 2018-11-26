﻿using System;
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
    public partial class Withdraw : Form
    {
        public BankAccount selectedAccount;
        float _withdrawalAmount;
        public float WithdrawalAmount
        {
            get { return _withdrawalAmount; }
            set
            {
                _withdrawalAmount = value;
                lblWithdrawalAmount.Text = "$" + _withdrawalAmount.ToString();
            }
        }

        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            LoadAccounts();

        }
        private void RefreshAll()
        {
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

        private void btnCustomAmount_Click(object sender, EventArgs e)
        {
            btnWithdraw20.Hide();
            btnWithdraw40.Hide();
            btnWithdraw60.Hide();
            btnWithdraw80.Hide();
            btnWithdraw100.Hide();
            btnCustomAmount.Hide();
            grpNumberPad.Show();
            txtAmount.Show();
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
            if (selectedAccount.Balance > Amount)
            {
                WithdrawalAmount = Amount;
            }
            else
            {
                MessageBox.Show("Insufficient Funds", "You do not have enough funds to withdraw the chosen amount. Select a different Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            if (txtAmount.Text.Length > 0) txtAmount.Text = txtAmount.Text.Remove(txtAmount.Text.Length - 1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAmount.Text)) WithDraw(float.Parse(txtAmount.Text));
            txtAmount.Text = "";
        }

        private void AddText(int num)
        {
            
            txtAmount.Text += num.ToString();
           
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
                btnWithdraw20.Show();
                btnWithdraw40.Show();
                btnWithdraw60.Show();
                btnWithdraw80.Show();
                btnWithdraw100.Show();
                btnCustomAmount.Show();
                grpNumberPad.Hide();
                txtAmount.Hide();
            } else
            {
                this.Close();
            }
        }

        private void cmbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAccount = (BankAccount) cmbAccounts.SelectedItem;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Confirm Withdrawal", "Are you sure you want to withdraw $" + WithdrawalAmount + " From " + selectedAccount.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    selectedAccount.Balance -= WithdrawalAmount;
                    RefreshAll();

                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
            }
                else
                {
                    //Do Nothing
                }
        }
    }
}