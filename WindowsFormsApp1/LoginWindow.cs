using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showPINWindow();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            showPINWindow();
        }

        private void showPINWindow()
        {
            PinWindow pin = new PinWindow();
            pin.Show();
            this.Hide();
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
            string text = accNumberTxtBox.Text;
            if (text == "")
                return;
            text = text.Substring(0, text.Length - 1);
            accNumberTxtBox.Text = text;
            confirmBtn.Enabled = false;
            button12.Enabled = accNumberTxtBox.Text != "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addText(0);
        }

        private void addText(int num) {
            if (accNumberTxtBox.Text.Length == 16)
                return;
            accNumberTxtBox.Text += num.ToString();
            confirmBtn.Enabled = accNumberTxtBox.Text.Length == 16;
            button12.Enabled = accNumberTxtBox.Text != "";
        }

        private void accNumberTxtBox_Click_1(object sender, EventArgs e)
        {
        }

        private void accNumberTxtBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            accNumberTxtBox.Text = "";
            button12.Enabled = false;
            confirmBtn.Enabled = false;
        }
    }
}
