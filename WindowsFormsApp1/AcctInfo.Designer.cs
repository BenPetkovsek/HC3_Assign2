namespace WindowsFormsApp1
{
    partial class AcctInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.infoBtn = new System.Windows.Forms.Button();
            this.acctLabel = new System.Windows.Forms.Label();
            this.acctInfoCmbBox = new System.Windows.Forms.ComboBox();
            this.backBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Acct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoBtn
            // 
            this.infoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBtn.Location = new System.Drawing.Point(619, 10);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(121, 41);
            this.infoBtn.TabIndex = 10;
            this.infoBtn.Text = " Info → ";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // acctLabel
            // 
            this.acctLabel.AutoSize = true;
            this.acctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctLabel.Location = new System.Drawing.Point(6, 15);
            this.acctLabel.Name = "acctLabel";
            this.acctLabel.Size = new System.Drawing.Size(233, 31);
            this.acctLabel.TabIndex = 9;
            this.acctLabel.Text = "Account Balance: ";
            // 
            // acctInfoCmbBox
            // 
            this.acctInfoCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acctInfoCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctInfoCmbBox.FormattingEnabled = true;
            this.acctInfoCmbBox.Items.AddRange(new object[] {
            "Chequing $8602.50",
            "Savings $5240.23"});
            this.acctInfoCmbBox.Location = new System.Drawing.Point(270, 11);
            this.acctInfoCmbBox.Name = "acctInfoCmbBox";
            this.acctInfoCmbBox.Size = new System.Drawing.Size(334, 37);
            this.acctInfoCmbBox.TabIndex = 8;
            // 
            // backBttn
            // 
            this.backBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBttn.Location = new System.Drawing.Point(12, 643);
            this.backBttn.Name = "backBttn";
            this.backBttn.Size = new System.Drawing.Size(125, 46);
            this.backBttn.TabIndex = 11;
            this.backBttn.Text = "< Menu";
            this.backBttn.UseVisualStyleBackColor = true;
            this.backBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Account History:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Acct,
            this.Type,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 508);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Acct
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acct.DefaultCellStyle = dataGridViewCellStyle6;
            this.Acct.Frozen = true;
            this.Acct.HeaderText = "Acct";
            this.Acct.Name = "Acct";
            this.Acct.ReadOnly = true;
            this.Acct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Acct.Width = 150;
            // 
            // Type
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.DefaultCellStyle = dataGridViewCellStyle7;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Type.Width = 150;
            // 
            // Amount
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.DefaultCellStyle = dataGridViewCellStyle8;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Amount.Width = 375;
            // 
            // AcctInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 701);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBttn);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.acctLabel);
            this.Controls.Add(this.acctInfoCmbBox);
            this.Name = "AcctInfo";
            this.Text = "AcctInfo";
            this.Load += new System.EventHandler(this.AcctInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Label acctLabel;
        private System.Windows.Forms.ComboBox acctInfoCmbBox;
        private System.Windows.Forms.Button backBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}