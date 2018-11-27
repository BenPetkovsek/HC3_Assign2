﻿namespace WindowsFormsApp1
{
    partial class Deposit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDepositCash = new System.Windows.Forms.Button();
            this.btnDepositCheque = new System.Windows.Forms.Button();
            this.pnlDepositCash = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.grpNumberPad = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.pnlResultBox = new System.Windows.Forms.Panel();
            this.btnDepositAgain = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDepositResult = new System.Windows.Forms.Label();
            this.pnlDepositCheque = new System.Windows.Forms.Panel();
            this.btnInsertCheque = new System.Windows.Forms.Button();
            this.lblInsertCheque = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.lblInto = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlDepositCash.SuspendLayout();
            this.grpNumberPad.SuspendLayout();
            this.pnlResultBox.SuspendLayout();
            this.pnlDepositCheque.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepositCash
            // 
            this.btnDepositCash.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDepositCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositCash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDepositCash.Location = new System.Drawing.Point(16, 65);
            this.btnDepositCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDepositCash.Name = "btnDepositCash";
            this.btnDepositCash.Size = new System.Drawing.Size(340, 496);
            this.btnDepositCash.TabIndex = 0;
            this.btnDepositCash.Text = "Deposit Cash";
            this.btnDepositCash.UseVisualStyleBackColor = false;
            this.btnDepositCash.Click += new System.EventHandler(this.btnDepositCash_Click);
            // 
            // btnDepositCheque
            // 
            this.btnDepositCheque.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDepositCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositCheque.Location = new System.Drawing.Point(364, 65);
            this.btnDepositCheque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDepositCheque.Name = "btnDepositCheque";
            this.btnDepositCheque.Size = new System.Drawing.Size(352, 496);
            this.btnDepositCheque.TabIndex = 0;
            this.btnDepositCheque.Text = "Deposit a Cheque";
            this.btnDepositCheque.UseVisualStyleBackColor = false;
            this.btnDepositCheque.Click += new System.EventHandler(this.btnDepositCheque_Click);
            // 
            // pnlDepositCash
            // 
            this.pnlDepositCash.Controls.Add(this.txtAmount);
            this.pnlDepositCash.Controls.Add(this.grpNumberPad);
            this.pnlDepositCash.Controls.Add(this.pnlResultBox);
            this.pnlDepositCash.Location = new System.Drawing.Point(16, 148);
            this.pnlDepositCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDepositCash.Name = "pnlDepositCash";
            this.pnlDepositCash.Size = new System.Drawing.Size(700, 414);
            this.pnlDepositCash.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(184, 15);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(357, 37);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // grpNumberPad
            // 
            this.grpNumberPad.Controls.Add(this.btnBack);
            this.grpNumberPad.Controls.Add(this.btn0);
            this.grpNumberPad.Controls.Add(this.btn9);
            this.grpNumberPad.Controls.Add(this.btn8);
            this.grpNumberPad.Controls.Add(this.btn7);
            this.grpNumberPad.Controls.Add(this.btn6);
            this.grpNumberPad.Controls.Add(this.btn5);
            this.grpNumberPad.Controls.Add(this.btn4);
            this.grpNumberPad.Controls.Add(this.btn3);
            this.grpNumberPad.Controls.Add(this.btn2);
            this.grpNumberPad.Controls.Add(this.btnOK);
            this.grpNumberPad.Controls.Add(this.btn1);
            this.grpNumberPad.Location = new System.Drawing.Point(184, 60);
            this.grpNumberPad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNumberPad.Name = "grpNumberPad";
            this.grpNumberPad.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNumberPad.Size = new System.Drawing.Size(359, 350);
            this.grpNumberPad.TabIndex = 10;
            this.grpNumberPad.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(52, 267);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 74);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(140, 267);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 74);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(228, 186);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 74);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(140, 186);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 74);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(52, 186);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 74);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(228, 105);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 74);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(140, 105);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 74);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(52, 105);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 74);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(228, 23);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 74);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(140, 23);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 74);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(228, 268);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 73);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(52, 23);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 74);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pnlResultBox
            // 
            this.pnlResultBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultBox.Controls.Add(this.btnDepositAgain);
            this.pnlResultBox.Controls.Add(this.btnBackToMenu);
            this.pnlResultBox.Controls.Add(this.lblResult);
            this.pnlResultBox.Controls.Add(this.lblDepositResult);
            this.pnlResultBox.Location = new System.Drawing.Point(153, 142);
            this.pnlResultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlResultBox.Name = "pnlResultBox";
            this.pnlResultBox.Size = new System.Drawing.Size(389, 272);
            this.pnlResultBox.TabIndex = 16;
            // 
            // btnDepositAgain
            // 
            this.btnDepositAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositAgain.Location = new System.Drawing.Point(229, 155);
            this.btnDepositAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepositAgain.Name = "btnDepositAgain";
            this.btnDepositAgain.Size = new System.Drawing.Size(117, 78);
            this.btnDepositAgain.TabIndex = 3;
            this.btnDepositAgain.Text = "Deposit Again";
            this.btnDepositAgain.UseVisualStyleBackColor = true;
            this.btnDepositAgain.Click += new System.EventHandler(this.btnDepositAgain_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(41, 155);
            this.btnBackToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(117, 78);
            this.btnBackToMenu.TabIndex = 2;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(104, 95);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(152, 25);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Deposit More?";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDepositResult
            // 
            this.lblDepositResult.AutoSize = true;
            this.lblDepositResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositResult.Location = new System.Drawing.Point(40, 41);
            this.lblDepositResult.Name = "lblDepositResult";
            this.lblDepositResult.Size = new System.Drawing.Size(274, 36);
            this.lblDepositResult.TabIndex = 0;
            this.lblDepositResult.Text = "Deposit Complete!";
            this.lblDepositResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDepositCheque
            // 
            this.pnlDepositCheque.Controls.Add(this.btnInsertCheque);
            this.pnlDepositCheque.Controls.Add(this.lblInsertCheque);
            this.pnlDepositCheque.Location = new System.Drawing.Point(16, 148);
            this.pnlDepositCheque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDepositCheque.Name = "pnlDepositCheque";
            this.pnlDepositCheque.Size = new System.Drawing.Size(700, 414);
            this.pnlDepositCheque.TabIndex = 14;
            // 
            // btnInsertCheque
            // 
            this.btnInsertCheque.Location = new System.Drawing.Point(125, 155);
            this.btnInsertCheque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertCheque.Name = "btnInsertCheque";
            this.btnInsertCheque.Size = new System.Drawing.Size(469, 63);
            this.btnInsertCheque.TabIndex = 15;
            this.btnInsertCheque.Text = "Insert Cheque (Debug)";
            this.btnInsertCheque.UseVisualStyleBackColor = true;
            this.btnInsertCheque.Click += new System.EventHandler(this.btnInsertCheque_Click);
            // 
            // lblInsertCheque
            // 
            this.lblInsertCheque.AutoSize = true;
            this.lblInsertCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertCheque.Location = new System.Drawing.Point(119, 106);
            this.lblInsertCheque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsertCheque.Name = "lblInsertCheque";
            this.lblInsertCheque.Size = new System.Drawing.Size(438, 31);
            this.lblInsertCheque.TabIndex = 14;
            this.lblInsertCheque.Text = "Insert a cheque into the Machine";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(39, 634);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(271, 54);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Enabled = false;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(428, 634);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(267, 53);
            this.btnDeposit.TabIndex = 21;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(364, 574);
            this.cmbAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(351, 38);
            this.cmbAccounts.TabIndex = 19;
            this.cmbAccounts.SelectedIndexChanged += new System.EventHandler(this.cmbAccounts_SelectedIndexChanged);
            // 
            // lblInto
            // 
            this.lblInto.AutoSize = true;
            this.lblInto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInto.Location = new System.Drawing.Point(285, 577);
            this.lblInto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInto.Name = "lblInto";
            this.lblInto.Size = new System.Drawing.Size(68, 31);
            this.lblInto.TabIndex = 24;
            this.lblInto.Text = "Into:";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(32, 577);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(107, 31);
            this.lblDeposit.TabIndex = 20;
            this.lblDeposit.Text = "Deposit";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(135, 577);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 31);
            this.lblAmount.TabIndex = 23;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 702);
            this.Controls.Add(this.lblInto);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.cmbAccounts);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.pnlDepositCash);
            this.Controls.Add(this.pnlDepositCheque);
            this.Controls.Add(this.btnDepositCheque);
            this.Controls.Add(this.btnDepositCash);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.pnlDepositCash.ResumeLayout(false);
            this.pnlDepositCash.PerformLayout();
            this.grpNumberPad.ResumeLayout(false);
            this.pnlResultBox.ResumeLayout(false);
            this.pnlResultBox.PerformLayout();
            this.pnlDepositCheque.ResumeLayout(false);
            this.pnlDepositCheque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepositCash;
        private System.Windows.Forms.Button btnDepositCheque;
        private System.Windows.Forms.Panel pnlDepositCash;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel pnlDepositCheque;
        private System.Windows.Forms.Button btnInsertCheque;
        private System.Windows.Forms.Label lblInsertCheque;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.Panel pnlResultBox;
        private System.Windows.Forms.Button btnDepositAgain;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDepositResult;
        private System.Windows.Forms.GroupBox grpNumberPad;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblInto;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblAmount;
    }
}