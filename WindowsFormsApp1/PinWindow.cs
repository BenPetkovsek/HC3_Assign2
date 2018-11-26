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
    public partial class PinWindow : Form
    {
        public PinWindow()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
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
            string text = pinTxtBox.Text;
            if (text == "")
                return;
            text = text.Substring(0, text.Length - 1);
            pinTxtBox.Text = text;
            confirmBtn.Enabled = false;
            button12.Enabled = pinTxtBox.Text != "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addText(0);
        }

        private void addText(int num)
        {
            if (pinTxtBox.Text.Length == 4)
                return;
            pinTxtBox.Text += num.ToString();
            confirmBtn.Enabled = pinTxtBox.Text.Length == 4;
            button12.Enabled = pinTxtBox.Text != "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            LoginWindow wind = new LoginWindow();
            wind.Show();
            this.Hide();
        }

        private void pinTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
