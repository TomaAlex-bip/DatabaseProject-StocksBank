
namespace TemaBD_Banca_de_actiuni.ContentForms
{
    partial class TransactionsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.depositNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.withdrawNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.transferIbanTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.transferNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.transactionIbanLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.transactionCashLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.transactionHourLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.transactionDateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.transactionDetailsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.transactionIdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.transactionsHistoryListBox = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transferNumeric)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.depositNumeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnDepositButtonClick);
            // 
            // depositNumeric
            // 
            this.depositNumeric.DecimalPlaces = 2;
            this.depositNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.depositNumeric.Location = new System.Drawing.Point(6, 69);
            this.depositNumeric.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.depositNumeric.Name = "depositNumeric";
            this.depositNumeric.Size = new System.Drawing.Size(225, 29);
            this.depositNumeric.TabIndex = 1;
            this.depositNumeric.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ammount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.withdrawNumeric);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 162);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Withdraw";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Withdraw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnWithdrawButtonClick);
            // 
            // withdrawNumeric
            // 
            this.withdrawNumeric.DecimalPlaces = 2;
            this.withdrawNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.withdrawNumeric.Location = new System.Drawing.Point(6, 76);
            this.withdrawNumeric.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.withdrawNumeric.Name = "withdrawNumeric";
            this.withdrawNumeric.Size = new System.Drawing.Size(225, 29);
            this.withdrawNumeric.TabIndex = 1;
            this.withdrawNumeric.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "ammount";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.transferIbanTextbox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.transferNumeric);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 229);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transfer";
            // 
            // transferIbanTextbox
            // 
            this.transferIbanTextbox.Location = new System.Drawing.Point(6, 139);
            this.transferIbanTextbox.Name = "transferIbanTextbox";
            this.transferIbanTextbox.Size = new System.Drawing.Size(225, 33);
            this.transferIbanTextbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "transfer to (iban)";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Transfer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnTransferButtonClick);
            // 
            // transferNumeric
            // 
            this.transferNumeric.DecimalPlaces = 2;
            this.transferNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.transferNumeric.Location = new System.Drawing.Point(6, 70);
            this.transferNumeric.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.transferNumeric.Name = "transferNumeric";
            this.transferNumeric.Size = new System.Drawing.Size(225, 29);
            this.transferNumeric.TabIndex = 1;
            this.transferNumeric.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "ammount";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.transactionIbanLabel);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.transactionCashLabel);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.transactionHourLabel);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.transactionDateLabel);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.transactionDetailsLabel);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.transactionIdLabel);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.transactionsHistoryListBox);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(257, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(647, 561);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transactions History";
            // 
            // transactionIbanLabel
            // 
            this.transactionIbanLabel.AutoSize = true;
            this.transactionIbanLabel.Location = new System.Drawing.Point(428, 486);
            this.transactionIbanLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.transactionIbanLabel.Name = "transactionIbanLabel";
            this.transactionIbanLabel.Size = new System.Drawing.Size(0, 25);
            this.transactionIbanLabel.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(429, 462);
            this.label15.Margin = new System.Windows.Forms.Padding(10, 20, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 21);
            this.label15.TabIndex = 12;
            this.label15.Text = "transaction IBAN:";
            // 
            // transactionCashLabel
            // 
            this.transactionCashLabel.AutoSize = true;
            this.transactionCashLabel.Location = new System.Drawing.Point(427, 417);
            this.transactionCashLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.transactionCashLabel.Name = "transactionCashLabel";
            this.transactionCashLabel.Size = new System.Drawing.Size(0, 25);
            this.transactionCashLabel.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(428, 393);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 20, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "transaction cash:";
            // 
            // transactionHourLabel
            // 
            this.transactionHourLabel.AutoSize = true;
            this.transactionHourLabel.Location = new System.Drawing.Point(426, 348);
            this.transactionHourLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.transactionHourLabel.Name = "transactionHourLabel";
            this.transactionHourLabel.Size = new System.Drawing.Size(0, 25);
            this.transactionHourLabel.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(427, 324);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 20, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "transaction hour:";
            // 
            // transactionDateLabel
            // 
            this.transactionDateLabel.AutoSize = true;
            this.transactionDateLabel.Location = new System.Drawing.Point(426, 279);
            this.transactionDateLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.transactionDateLabel.Name = "transactionDateLabel";
            this.transactionDateLabel.Size = new System.Drawing.Size(0, 25);
            this.transactionDateLabel.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(427, 255);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 20, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "transaction date:";
            // 
            // transactionDetailsLabel
            // 
            this.transactionDetailsLabel.AutoSize = true;
            this.transactionDetailsLabel.Location = new System.Drawing.Point(426, 210);
            this.transactionDetailsLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.transactionDetailsLabel.Name = "transactionDetailsLabel";
            this.transactionDetailsLabel.Size = new System.Drawing.Size(0, 25);
            this.transactionDetailsLabel.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 20, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "transaction details:";
            // 
            // transactionIdLabel
            // 
            this.transactionIdLabel.AutoSize = true;
            this.transactionIdLabel.Location = new System.Drawing.Point(426, 141);
            this.transactionIdLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.transactionIdLabel.Name = "transactionIdLabel";
            this.transactionIdLabel.Size = new System.Drawing.Size(0, 25);
            this.transactionIdLabel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 20, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "transaction ID:";
            // 
            // transactionsHistoryListBox
            // 
            this.transactionsHistoryListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsHistoryListBox.FormattingEnabled = true;
            this.transactionsHistoryListBox.ItemHeight = 21;
            this.transactionsHistoryListBox.Location = new System.Drawing.Point(14, 42);
            this.transactionsHistoryListBox.Name = "transactionsHistoryListBox";
            this.transactionsHistoryListBox.Size = new System.Drawing.Size(383, 508);
            this.transactionsHistoryListBox.TabIndex = 1;
            this.transactionsHistoryListBox.SelectedIndexChanged += new System.EventHandler(this.OnTransactionSelect);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(404, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OnRefreshButton);
            // 
            // TransactionsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1000, 651);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionsForm";
            this.Text = "TransactionsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transferNumeric)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown depositNumeric;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown withdrawNumeric;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox transferIbanTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown transferNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox transactionsHistoryListBox;
        private System.Windows.Forms.Label transactionIdLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label transactionIbanLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label transactionCashLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label transactionHourLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label transactionDateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label transactionDetailsLabel;
        private System.Windows.Forms.Label label7;
    }
}