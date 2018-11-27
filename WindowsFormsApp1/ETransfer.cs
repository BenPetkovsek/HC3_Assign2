using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ETransfer : Form
    {
        public BankAccount selectedAccount;
        List<String> amount;
        public ETransfer() {
            InitializeComponent();
        }

        private void ETransfer_Load(object sender, EventArgs e) {
            // populate from textbox
            fromComboBox.Items.Clear();

            showContacts();

            removeAddScreen();
            toComboBox.SelectedIndex = 0;
            fromComboBox.Items.Clear();

            foreach (BankAccount acc in User.Accounts) {
                fromComboBox.Items.Add(acc.ToString());
            }

            fromComboBox.SelectedIndex = 0;
            showAddBtn.Enabled = true;
            toComboBox.Enabled = true;
            keyboardPanel.Visible = false;

            amountNumberPad.Visible = true;
            confirmPanel.Visible = false;
            confirmBtn.BackColor = Color.Gray;
            errorPanel.Visible = false;
            amount = new List<String>();

            amountTxtBox.Text = formatAmount();
        }

        private void removeAddScreen() {
            newContactBox.Visible = false;

            amountNumberPad.Visible = true;
            keyboardPanel.Visible = false;
            emailTxtBox.Text = "";
        }


        private void showAddScreen() {
            newContactBox.Visible = true;
            amountNumberPad.Visible = false;
            keyboardPanel.Visible = true;
            emailTxtBox.Text = "";
        }

        private void showContacts() {

            toComboBox.Items.Clear();
            foreach (Contact contact in Contacts.contacts) {
                toComboBox.Items.Add(contact.ToString());
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void cancelAddBtn_Click(object sender, EventArgs e) {
            removeAddScreen();
            showAddBtn.Enabled = true;
            toComboBox.Enabled = true;

            amountNumberPad.Visible = true;
        }

        private void addContactbtn_Click(object sender, EventArgs e) {
            Contact newContact = new Contact(emailTxtBox.Text);
            if (Contacts.ContainsContact(newContact)) {
                showError("Error: Duplicate Contact", "A contact with this email address already exists.");
                return;
            }
            if (!newContact.isValid()) {
                showError("Error: Invalid Email", "'" + newContact.email+ "' is not a valid email address.");
                return;
            }
            Contacts.contacts.Add(newContact);
            showContacts();
            removeAddScreen();
            showAddBtn.Enabled = true;
            toComboBox.Enabled = true;
            toComboBox.SelectedIndex = toComboBox.Items.Count - 1;

            amountNumberPad.Visible = true;
        }

        private void showAddBtn_Click(object sender, EventArgs e) {
            showAddScreen();
            showAddBtn.Enabled = false;
            addContactbtn.Enabled = false;
            toComboBox.Enabled = false;
        }

        private void amountTxtBox_TextChanged(object sender, EventArgs e) {

        }

        private void confirmBtn_Click(object sender, EventArgs e) {
            float transferAmount = float.Parse(amountTxtBox.Text.Substring(1));
            if (getAccount().Balance < transferAmount) {
                showError("Error: Insufficent Funds", getAccount().Name + " does not have enough money to transfer");
                return;
            }
            confirmLabel.Text = "Are you sure you want to send: " + Contacts.contacts[toComboBox.SelectedIndex].ToString() + "\n" + amountTxtBox.Text + " from: " + fromComboBox.Text + "?";
            confirmPanel.Visible = true;
            amountNumberPad.Enabled = false;
        }
        private void addText(int num) {
            amount.Add(num.ToString());
            amountTxtBox.Text = formatAmount();
            confirmBtn.Enabled = true;
            confirmBtn.BackColor = Color.FromArgb(132, 200, 135);
            deleteBtn.Enabled = true;
        }

        private string formatAmount() {
            string amount = "";
            for (int i=0;i<this.amount.Count; i++) {
                amount += this.amount[i];
            }
            if (this.amount.Count == 2) {
                amount = "0" + amount;
            }
            if (this.amount.Count == 1) {
                amount = "00" + amount;
            }
            if (this.amount.Count ==0) {
                amount = "000";
            }
            return "$" + amount.Substring(0, amount.Length -2) + "." + amount.Substring(amount.Length - 2, 2);
        }
            
        // delete char
        private void button12_Click_1(object sender, EventArgs e) {
            if (amount.Count != 0) {
                amount.RemoveAt(amount.Count-1);
            }

            amountTxtBox.Text = formatAmount();
            if (amount.Count ==0)
            {
                deleteBtn.Enabled = false;
                confirmBtn.Enabled = false;
                confirmBtn.BackColor = Color.Gray;

            }
            amountTxtBox.Text = formatAmount();
        }


        private void button2_Click_1(object sender, EventArgs e) {
            addText(1);
        }
       

        private void button3_Click_1(object sender, EventArgs e) {
            addText(2);
        }
 private void button4_Click_1(object sender, EventArgs e) {
            addText(3);
        }
        private void button5_Click_1(object sender, EventArgs e) {
            addText(4);
        }

        private void button6_Click_1(object sender, EventArgs e) {
            addText(5);
        }

        private void button7_Click_1(object sender, EventArgs e) {
            addText(6);
        }

        private void button8_Click_1(object sender, EventArgs e) {
            addText(7);
        }

        private void button9_Click_1(object sender, EventArgs e) {
            addText(8);
        }

        private void button10_Click_1(object sender, EventArgs e) {
            addText(9);
        }


        private void button11_Click_1(object sender, EventArgs e) {
            addText(0);
        }

        private void yesBtn_Click(object sender, EventArgs e) {

            float transferAmount = float.Parse(amountTxtBox.Text.Substring(1));
            getAccount().Balance =  getAccount().Balance - transferAmount;
            confirmPanel.Visible = false;
            amount = new List<String>();
            amountTxtBox.Text = formatAmount();
            fromComboBox.Items.Clear();

            foreach (BankAccount acc in User.Accounts) {
                fromComboBox.Items.Add(acc.ToString());
            }
            fromComboBox.SelectedIndex = 0;
            showError("Success", "e-Transfer successfully sent!");
            XactLog x = new XactLog(getAccount().Name, "Transfer", "E-Transfer To: " + toComboBox.SelectedText, transferAmount);
            User.record.Add(x);
        }

        private void noBtn_Click(object sender, EventArgs e) {
            confirmPanel.Visible = false;
            amountNumberPad.Enabled = true;
        }

        private void emailTxtBox_TextChanged(object sender, EventArgs e) {

        }

        private void okErrorBtn_Click(object sender, EventArgs e) {
            errorPanel.Visible = false;
            keyboardPanel.Enabled = true;
            amountNumberPad.Enabled = true;
        }

        private void showError(string title, string message) {
            errorPanel.Visible = true;
            errorTitle.Text = title;
            errorMessage.Text = message;
            keyboardPanel.Enabled = false;
            amountNumberPad.Enabled = false;
        }

        private void addChar(String charS) {
            emailTxtBox.Text += charS;
            addContactbtn.Enabled = true;
            deleteCharbtn.Enabled = true;
        }
        private void removeChar() {
            string text = emailTxtBox.Text;
            if (text == "") {
                addContactbtn.Enabled = false;
                return;
            }
               
        }

        private void button1_Click(object sender, EventArgs e) {
            addChar("1");
        }

        private void button12_Click(object sender, EventArgs e) {
            addChar("2");
        }

        private void button13_Click(object sender, EventArgs e) {
            addChar("3");
        }

        private void button14_Click(object sender, EventArgs e) {
            addChar("4");
        }

        private void button15_Click(object sender, EventArgs e) {
            addChar("5");
        }

        private void button16_Click(object sender, EventArgs e) {
            addChar("6");
        }

        private void button17_Click(object sender, EventArgs e) {
            addChar("7");
        }

        private void button18_Click(object sender, EventArgs e) {
            addChar("8");
        }

        private void button19_Click(object sender, EventArgs e) {
            addChar("9");
        }

        private void button20_Click(object sender, EventArgs e) {
            addChar("0");
        }

        private void button21_Click(object sender, EventArgs e) {
            addChar("_");
        }

        private void button45_Click(object sender, EventArgs e) {
            addChar("@");
        }

        private void button22_Click(object sender, EventArgs e) {
            addChar(".");
        }

        private void deleteCharbtn_Click(object sender, EventArgs e) {
            emailTxtBox.Text = emailTxtBox.Text.Substring(0, emailTxtBox.Text.Length - 1);
            if (emailTxtBox.Text == "") {
                addContactbtn.Enabled = false;
                deleteCharbtn.Enabled = false;
            }
            else
                addContactbtn.Enabled = true;
        }

        private void button23_Click(object sender, EventArgs e) {
            addChar("q");
        }

        private void button24_Click(object sender, EventArgs e) {
            addChar("w");
        }

        private void button26_Click(object sender, EventArgs e) {
            addChar("r");
        }

        private void button25_Click(object sender, EventArgs e) {
            addChar("e");
        }

        private void button27_Click(object sender, EventArgs e) {
            addChar("t");
        }

        private void button28_Click(object sender, EventArgs e) {
            addChar("y");
        }

        private void button29_Click(object sender, EventArgs e) {
            addChar("u");
        }

        private void button30_Click(object sender, EventArgs e) {
            addChar("i");
        }

        private void button31_Click(object sender, EventArgs e) {
            addChar("o");
        }

        private void button32_Click(object sender, EventArgs e) {
            addChar("p");
        }

        private void button44_Click(object sender, EventArgs e) {
            addChar("a");
        }

        private void button43_Click(object sender, EventArgs e) {
            addChar("s");
        }

        private void button42_Click(object sender, EventArgs e) {
            addChar("d");
        }

        private void button41_Click(object sender, EventArgs e) {
            addChar("f");
        }

        private void button40_Click(object sender, EventArgs e) {
            addChar("g");
        }

        private void button39_Click(object sender, EventArgs e) {
            addChar("h");
        }

        private void button38_Click(object sender, EventArgs e) {
            addChar("j");
        }

        private void button37_Click(object sender, EventArgs e) {
            addChar("k");
        }

        private void button36_Click(object sender, EventArgs e) {
            addChar("l");
        }

        private void button55_Click(object sender, EventArgs e) {
            addChar("z");
        }

        private void button54_Click(object sender, EventArgs e) {
            addChar("x");
        }

        private void button53_Click(object sender, EventArgs e) {
            addChar("c");
        }

        private void button52_Click(object sender, EventArgs e) {
            addChar("v");
        }

        private void button51_Click(object sender, EventArgs e) {
            addChar("b");
        }

        private void button50_Click_1(object sender, EventArgs e) {
            addChar("n");
        }

        private void button49_Click_1(object sender, EventArgs e) {
            addChar("m");
        }

        private BankAccount getAccount() {
            return User.Accounts[fromComboBox.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void confirmPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TransferLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
