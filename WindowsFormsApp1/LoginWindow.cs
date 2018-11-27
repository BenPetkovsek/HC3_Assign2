using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class LoginWindow : Form
    {
        public string accountNumFill = "____-____-____-____";
        public string enteredNums = "";
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
          
            if (enteredNums == "")
                return;

            accNumberTxtBox.Text = "";
            int numchars = 0;
            enteredNums = enteredNums.Substring(0, enteredNums.Length - 1);
            foreach (char c in enteredNums)
            {
                accNumberTxtBox.Text += c;
                numchars++;
                if (numchars % 4 == 0)
                {
                    accNumberTxtBox.Text += "-";
                }
            }
            if (accNumberTxtBox.Text.Length < accountNumFill.Length)
            {
                accNumberTxtBox.Text += accountNumFill.Substring(accNumberTxtBox.Text.Length);
            }
            else
            {
                //
            }
            
            confirmBtn.Enabled = false;
            confirmBtn.BackColor = enteredNums.Length == 16 ? Color.FromArgb(132, 200, 135) : Color.Gray;

            button12.BackColor = Color.FromArgb(225, 225, 138);
            button12.Enabled = accNumberTxtBox.Text != "";
            //formatText();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addText(0);
        }

        private void addText(int num) {
            
            if (enteredNums.Length == 16)
                return;

            accNumberTxtBox.Text = "";
            enteredNums += num.ToString();
            int numchars = 0;
            foreach (char c in enteredNums)
            {
                accNumberTxtBox.Text += c;
                numchars++;
                if (numchars % 4 == 0)
                {
                    accNumberTxtBox.Text += "-";
                }
            }
            if (accNumberTxtBox.Text.Length < accountNumFill.Length)
            {
                accNumberTxtBox.Text += accountNumFill.Substring(accNumberTxtBox.Text.Length);
            } else
            {
                //
            }
            confirmBtn.Enabled = enteredNums.Length == 16;
            confirmBtn.BackColor = enteredNums.Length == 16 ? Color.FromArgb(132, 200, 135) : Color.Gray;
            button12.BackColor = Color.FromArgb(225, 225, 138);
            button12.Enabled = accNumberTxtBox.Text != "";
            formatText();
        }

       private void formatText()
        {
            string text = accNumberTxtBox.Text.Replace("_", "").Replace("-","");

            char[] textArr = "____-____-____-____".ToCharArray();
            int j = 0;
            for (int i = 0;i <text.Length;i++)
            {

                if (textArr[j] != '-')
                {
                    textArr[j] = text[i];
                } else
                {
                    i--;
                }
                j++;

            }
            accNumberTxtBox.Text = new string(textArr);
        }

        private void accNumberTxtBox_Click_1(object sender, EventArgs e)
        {
        }


        private void LoginWindow_Load(object sender, EventArgs e)
        {
            accNumberTxtBox.Text = "";
            button12.Enabled = false;
            confirmBtn.Enabled = false;
            confirmBtn.BackColor = Color.Gray;
            button12.BackColor = Color.FromArgb(225, 225, 138);
            formatText();
        }
    }
}
