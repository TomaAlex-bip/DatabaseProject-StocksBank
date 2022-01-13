
namespace TemaBD_Banca_de_actiuni.ContentForms
{
    partial class InvestForm
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
            this.sortStocksByChangeButton = new System.Windows.Forms.Button();
            this.sortStocksByPriceButton = new System.Windows.Forms.Button();
            this.sortStocksByCodeButton = new System.Windows.Forms.Button();
            this.availableStocksListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.percentLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.stockDetailsOldPriceLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.stockDetailsMajorShareholderLabel = new System.Windows.Forms.Label();
            this.stockDetailsChangeLabel = new System.Windows.Forms.Label();
            this.stockDetailsCurrentPriceLabel = new System.Windows.Forms.Label();
            this.stockDetailsTotalLabel = new System.Windows.Forms.Label();
            this.stockDetailsAvailableLabel = new System.Windows.Forms.Label();
            this.stockDetailsNameLabel = new System.Windows.Forms.Label();
            this.stockDetailsCodeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stockActionsBuyButton = new System.Windows.Forms.Button();
            this.stockActionsBuyNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.stockActionsSellButton = new System.Windows.Forms.Button();
            this.stockActionsSellNumeric = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockActionsBuyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockActionsSellNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortStocksByChangeButton);
            this.groupBox1.Controls.Add(this.sortStocksByPriceButton);
            this.groupBox1.Controls.Add(this.sortStocksByCodeButton);
            this.groupBox1.Controls.Add(this.availableStocksListBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 627);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Stocks";
            // 
            // sortStocksByChangeButton
            // 
            this.sortStocksByChangeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortStocksByChangeButton.Location = new System.Drawing.Point(305, 32);
            this.sortStocksByChangeButton.Name = "sortStocksByChangeButton";
            this.sortStocksByChangeButton.Size = new System.Drawing.Size(131, 27);
            this.sortStocksByChangeButton.TabIndex = 7;
            this.sortStocksByChangeButton.Text = "Change";
            this.sortStocksByChangeButton.UseVisualStyleBackColor = true;
            this.sortStocksByChangeButton.Click += new System.EventHandler(this.OnSortByChangeButton);
            // 
            // sortStocksByPriceButton
            // 
            this.sortStocksByPriceButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortStocksByPriceButton.Location = new System.Drawing.Point(132, 32);
            this.sortStocksByPriceButton.Name = "sortStocksByPriceButton";
            this.sortStocksByPriceButton.Size = new System.Drawing.Size(112, 27);
            this.sortStocksByPriceButton.TabIndex = 6;
            this.sortStocksByPriceButton.Text = "Price";
            this.sortStocksByPriceButton.UseVisualStyleBackColor = true;
            this.sortStocksByPriceButton.Click += new System.EventHandler(this.OnSortByPriceButton);
            // 
            // sortStocksByCodeButton
            // 
            this.sortStocksByCodeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortStocksByCodeButton.Location = new System.Drawing.Point(13, 32);
            this.sortStocksByCodeButton.Name = "sortStocksByCodeButton";
            this.sortStocksByCodeButton.Size = new System.Drawing.Size(70, 27);
            this.sortStocksByCodeButton.TabIndex = 4;
            this.sortStocksByCodeButton.Text = "Ticker";
            this.sortStocksByCodeButton.UseVisualStyleBackColor = true;
            this.sortStocksByCodeButton.Click += new System.EventHandler(this.OnSortByTickerButton);
            // 
            // availableStocksListBox
            // 
            this.availableStocksListBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableStocksListBox.FormattingEnabled = true;
            this.availableStocksListBox.ItemHeight = 18;
            this.availableStocksListBox.Items.AddRange(new object[] {
            "-TLV -------- 2.4802 --------- +0.2 %",
            "-TLV -------- 2.4802 --------- +0.2 %",
            "-TLV -------- 2.4802 --------- +0.2 %",
            "-TLV -------- 2.4802 --------- +0.2 %",
            "-TLV -------- 2.4802 --------- +0.2 %",
            "-TLM -------- 2.4802 --------- +0.2 %",
            "-M  --------- 2.4802 --------- +0.2 %"});
            this.availableStocksListBox.Location = new System.Drawing.Point(13, 62);
            this.availableStocksListBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.availableStocksListBox.Name = "availableStocksListBox";
            this.availableStocksListBox.Size = new System.Drawing.Size(423, 544);
            this.availableStocksListBox.TabIndex = 0;
            this.availableStocksListBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedStockChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.percentLabel);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.stockDetailsOldPriceLabel);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.stockDetailsMajorShareholderLabel);
            this.groupBox2.Controls.Add(this.stockDetailsChangeLabel);
            this.groupBox2.Controls.Add(this.stockDetailsCurrentPriceLabel);
            this.groupBox2.Controls.Add(this.stockDetailsTotalLabel);
            this.groupBox2.Controls.Add(this.stockDetailsAvailableLabel);
            this.groupBox2.Controls.Add(this.stockDetailsNameLabel);
            this.groupBox2.Controls.Add(this.stockDetailsCodeLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(466, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 422);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Details";
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel.Location = new System.Drawing.Point(283, 341);
            this.percentLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(0, 21);
            this.percentLabel.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(90, 341);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 21);
            this.label13.TabIndex = 16;
            this.label13.Text = "Your percent of company: ";
            // 
            // stockDetailsOldPriceLabel
            // 
            this.stockDetailsOldPriceLabel.AutoSize = true;
            this.stockDetailsOldPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsOldPriceLabel.Location = new System.Drawing.Point(172, 217);
            this.stockDetailsOldPriceLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsOldPriceLabel.Name = "stockDetailsOldPriceLabel";
            this.stockDetailsOldPriceLabel.Size = new System.Drawing.Size(0, 21);
            this.stockDetailsOldPriceLabel.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(90, 217);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Old Price: ";
            // 
            // stockDetailsMajorShareholderLabel
            // 
            this.stockDetailsMajorShareholderLabel.AutoSize = true;
            this.stockDetailsMajorShareholderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsMajorShareholderLabel.Location = new System.Drawing.Point(172, 279);
            this.stockDetailsMajorShareholderLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsMajorShareholderLabel.Name = "stockDetailsMajorShareholderLabel";
            this.stockDetailsMajorShareholderLabel.Size = new System.Drawing.Size(0, 21);
            this.stockDetailsMajorShareholderLabel.TabIndex = 13;
            // 
            // stockDetailsChangeLabel
            // 
            this.stockDetailsChangeLabel.AutoSize = true;
            this.stockDetailsChangeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsChangeLabel.Location = new System.Drawing.Point(172, 248);
            this.stockDetailsChangeLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsChangeLabel.Name = "stockDetailsChangeLabel";
            this.stockDetailsChangeLabel.Size = new System.Drawing.Size(0, 21);
            this.stockDetailsChangeLabel.TabIndex = 12;
            // 
            // stockDetailsCurrentPriceLabel
            // 
            this.stockDetailsCurrentPriceLabel.AutoSize = true;
            this.stockDetailsCurrentPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsCurrentPriceLabel.Location = new System.Drawing.Point(172, 186);
            this.stockDetailsCurrentPriceLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsCurrentPriceLabel.Name = "stockDetailsCurrentPriceLabel";
            this.stockDetailsCurrentPriceLabel.Size = new System.Drawing.Size(0, 21);
            this.stockDetailsCurrentPriceLabel.TabIndex = 11;
            // 
            // stockDetailsTotalLabel
            // 
            this.stockDetailsTotalLabel.AutoSize = true;
            this.stockDetailsTotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsTotalLabel.Location = new System.Drawing.Point(172, 155);
            this.stockDetailsTotalLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsTotalLabel.Name = "stockDetailsTotalLabel";
            this.stockDetailsTotalLabel.Size = new System.Drawing.Size(0, 21);
            this.stockDetailsTotalLabel.TabIndex = 10;
            // 
            // stockDetailsAvailableLabel
            // 
            this.stockDetailsAvailableLabel.AutoSize = true;
            this.stockDetailsAvailableLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsAvailableLabel.Location = new System.Drawing.Point(172, 124);
            this.stockDetailsAvailableLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsAvailableLabel.Name = "stockDetailsAvailableLabel";
            this.stockDetailsAvailableLabel.Size = new System.Drawing.Size(0, 21);
            this.stockDetailsAvailableLabel.TabIndex = 9;
            // 
            // stockDetailsNameLabel
            // 
            this.stockDetailsNameLabel.AutoSize = true;
            this.stockDetailsNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsNameLabel.Location = new System.Drawing.Point(172, 93);
            this.stockDetailsNameLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsNameLabel.Name = "stockDetailsNameLabel";
            this.stockDetailsNameLabel.Size = new System.Drawing.Size(0, 21);
            this.stockDetailsNameLabel.TabIndex = 8;
            // 
            // stockDetailsCodeLabel
            // 
            this.stockDetailsCodeLabel.AutoSize = true;
            this.stockDetailsCodeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsCodeLabel.Location = new System.Drawing.Point(172, 62);
            this.stockDetailsCodeLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsCodeLabel.Name = "stockDetailsCodeLabel";
            this.stockDetailsCodeLabel.Size = new System.Drawing.Size(0, 21);
            this.stockDetailsCodeLabel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Major Shareholder: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Change: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current Price: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Shares: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchasable Shares: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Complete Name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ticker Symbol: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stockActionsBuyButton);
            this.groupBox3.Controls.Add(this.stockActionsBuyNumeric);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.stockActionsSellButton);
            this.groupBox3.Controls.Add(this.stockActionsSellNumeric);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(466, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 199);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stock Actions";
            // 
            // stockActionsBuyButton
            // 
            this.stockActionsBuyButton.Location = new System.Drawing.Point(329, 121);
            this.stockActionsBuyButton.Name = "stockActionsBuyButton";
            this.stockActionsBuyButton.Size = new System.Drawing.Size(100, 35);
            this.stockActionsBuyButton.TabIndex = 5;
            this.stockActionsBuyButton.Text = "Buy";
            this.stockActionsBuyButton.UseVisualStyleBackColor = true;
            this.stockActionsBuyButton.Click += new System.EventHandler(this.OnStockBuyButton);
            // 
            // stockActionsBuyNumeric
            // 
            this.stockActionsBuyNumeric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockActionsBuyNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.stockActionsBuyNumeric.Location = new System.Drawing.Point(283, 71);
            this.stockActionsBuyNumeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.stockActionsBuyNumeric.Name = "stockActionsBuyNumeric";
            this.stockActionsBuyNumeric.Size = new System.Drawing.Size(192, 33);
            this.stockActionsBuyNumeric.TabIndex = 4;
            this.stockActionsBuyNumeric.ThousandsSeparator = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "ammount";
            // 
            // stockActionsSellButton
            // 
            this.stockActionsSellButton.Location = new System.Drawing.Point(62, 121);
            this.stockActionsSellButton.Name = "stockActionsSellButton";
            this.stockActionsSellButton.Size = new System.Drawing.Size(100, 35);
            this.stockActionsSellButton.TabIndex = 2;
            this.stockActionsSellButton.Text = "Sell";
            this.stockActionsSellButton.UseVisualStyleBackColor = true;
            this.stockActionsSellButton.Click += new System.EventHandler(this.OnStockSellButton);
            // 
            // stockActionsSellNumeric
            // 
            this.stockActionsSellNumeric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockActionsSellNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.stockActionsSellNumeric.Location = new System.Drawing.Point(16, 71);
            this.stockActionsSellNumeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.stockActionsSellNumeric.Name = "stockActionsSellNumeric";
            this.stockActionsSellNumeric.Size = new System.Drawing.Size(192, 33);
            this.stockActionsSellNumeric.TabIndex = 1;
            this.stockActionsSellNumeric.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(66, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "ammount";
            // 
            // InvestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1000, 651);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvestForm";
            this.Text = "InvestForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockActionsBuyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockActionsSellNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sortStocksByChangeButton;
        private System.Windows.Forms.Button sortStocksByPriceButton;
        private System.Windows.Forms.Button sortStocksByCodeButton;
        private System.Windows.Forms.ListBox availableStocksListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label stockDetailsMajorShareholderLabel;
        private System.Windows.Forms.Label stockDetailsChangeLabel;
        private System.Windows.Forms.Label stockDetailsCurrentPriceLabel;
        private System.Windows.Forms.Label stockDetailsTotalLabel;
        private System.Windows.Forms.Label stockDetailsAvailableLabel;
        private System.Windows.Forms.Label stockDetailsNameLabel;
        private System.Windows.Forms.Label stockDetailsCodeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button stockActionsBuyButton;
        private System.Windows.Forms.NumericUpDown stockActionsBuyNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button stockActionsSellButton;
        private System.Windows.Forms.NumericUpDown stockActionsSellNumeric;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label stockDetailsOldPriceLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label percentLabel;
    }
}