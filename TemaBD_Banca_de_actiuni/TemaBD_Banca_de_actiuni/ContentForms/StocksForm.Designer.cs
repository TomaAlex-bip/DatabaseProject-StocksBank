
namespace TemaBD_Banca_de_actiuni.ContentForms
{
    partial class StocksForm
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
            this.ownedStocksListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.historyPrice = new System.Windows.Forms.Label();
            this.historyHour = new System.Windows.Forms.Label();
            this.historyDate = new System.Windows.Forms.Label();
            this.historyAmmount = new System.Windows.Forms.Label();
            this.historyTicker = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.investmentHistoryListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalStocksOwnedLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ownedStocksListBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 299);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Owned Stocks";
            // 
            // ownedStocksListBox
            // 
            this.ownedStocksListBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownedStocksListBox.FormattingEnabled = true;
            this.ownedStocksListBox.ItemHeight = 22;
            this.ownedStocksListBox.Location = new System.Drawing.Point(13, 44);
            this.ownedStocksListBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.ownedStocksListBox.Name = "ownedStocksListBox";
            this.ownedStocksListBox.Size = new System.Drawing.Size(396, 224);
            this.ownedStocksListBox.TabIndex = 0;
            this.ownedStocksListBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedStockChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.historyPrice);
            this.groupBox4.Controls.Add(this.historyHour);
            this.groupBox4.Controls.Add(this.historyDate);
            this.groupBox4.Controls.Add(this.historyAmmount);
            this.groupBox4.Controls.Add(this.historyTicker);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.investmentHistoryListBox);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(437, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 630);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Investment history";
            // 
            // historyPrice
            // 
            this.historyPrice.AutoSize = true;
            this.historyPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyPrice.Location = new System.Drawing.Point(138, 591);
            this.historyPrice.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.historyPrice.Name = "historyPrice";
            this.historyPrice.Size = new System.Drawing.Size(28, 17);
            this.historyPrice.TabIndex = 21;
            this.historyPrice.Text = "     ";
            // 
            // historyHour
            // 
            this.historyHour.AutoSize = true;
            this.historyHour.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyHour.Location = new System.Drawing.Point(136, 564);
            this.historyHour.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.historyHour.Name = "historyHour";
            this.historyHour.Size = new System.Drawing.Size(28, 17);
            this.historyHour.TabIndex = 20;
            this.historyHour.Text = "     ";
            // 
            // historyDate
            // 
            this.historyDate.AutoSize = true;
            this.historyDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyDate.Location = new System.Drawing.Point(138, 537);
            this.historyDate.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.historyDate.Name = "historyDate";
            this.historyDate.Size = new System.Drawing.Size(28, 17);
            this.historyDate.TabIndex = 19;
            this.historyDate.Text = "     ";
            // 
            // historyAmmount
            // 
            this.historyAmmount.AutoSize = true;
            this.historyAmmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyAmmount.Location = new System.Drawing.Point(138, 510);
            this.historyAmmount.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.historyAmmount.Name = "historyAmmount";
            this.historyAmmount.Size = new System.Drawing.Size(28, 17);
            this.historyAmmount.TabIndex = 18;
            this.historyAmmount.Text = "     ";
            // 
            // historyTicker
            // 
            this.historyTicker.AutoSize = true;
            this.historyTicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyTicker.Location = new System.Drawing.Point(138, 483);
            this.historyTicker.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.historyTicker.Name = "historyTicker";
            this.historyTicker.Size = new System.Drawing.Size(28, 17);
            this.historyTicker.TabIndex = 17;
            this.historyTicker.Text = "     ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(31, 591);
            this.label18.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 17);
            this.label18.TabIndex = 16;
            this.label18.Text = "Investment Price:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(30, 564);
            this.label19.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 17);
            this.label19.TabIndex = 15;
            this.label19.Text = "Investment hour:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(30, 537);
            this.label20.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 17);
            this.label20.TabIndex = 14;
            this.label20.Text = "Investment date: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(65, 510);
            this.label21.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 17);
            this.label21.TabIndex = 13;
            this.label21.Text = "Ammount: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(41, 483);
            this.label22.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 17);
            this.label22.TabIndex = 12;
            this.label22.Text = "Ticker Symbol: ";
            // 
            // investmentHistoryListBox
            // 
            this.investmentHistoryListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investmentHistoryListBox.FormattingEnabled = true;
            this.investmentHistoryListBox.ItemHeight = 21;
            this.investmentHistoryListBox.Location = new System.Drawing.Point(13, 26);
            this.investmentHistoryListBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.investmentHistoryListBox.Name = "investmentHistoryListBox";
            this.investmentHistoryListBox.Size = new System.Drawing.Size(525, 424);
            this.investmentHistoryListBox.TabIndex = 0;
            this.investmentHistoryListBox.SelectedIndexChanged += new System.EventHandler(this.OnInvestmentHistoryChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalStocksOwnedLabel);
            this.groupBox2.Controls.Add(this.label11);
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
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 316);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Details";
            // 
            // totalStocksOwnedLabel
            // 
            this.totalStocksOwnedLabel.AutoSize = true;
            this.totalStocksOwnedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStocksOwnedLabel.Location = new System.Drawing.Point(180, 280);
            this.totalStocksOwnedLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.totalStocksOwnedLabel.Name = "totalStocksOwnedLabel";
            this.totalStocksOwnedLabel.Size = new System.Drawing.Size(32, 17);
            this.totalStocksOwnedLabel.TabIndex = 19;
            this.totalStocksOwnedLabel.Text = "      ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total stocks owned: ";
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel.Location = new System.Drawing.Point(180, 253);
            this.percentLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(32, 17);
            this.percentLabel.TabIndex = 17;
            this.percentLabel.Text = "      ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 253);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Your percent of company: ";
            // 
            // stockDetailsOldPriceLabel
            // 
            this.stockDetailsOldPriceLabel.AutoSize = true;
            this.stockDetailsOldPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsOldPriceLabel.Location = new System.Drawing.Point(167, 169);
            this.stockDetailsOldPriceLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsOldPriceLabel.Name = "stockDetailsOldPriceLabel";
            this.stockDetailsOldPriceLabel.Size = new System.Drawing.Size(32, 17);
            this.stockDetailsOldPriceLabel.TabIndex = 15;
            this.stockDetailsOldPriceLabel.Text = "      ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 169);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Old Price:";
            // 
            // stockDetailsMajorShareholderLabel
            // 
            this.stockDetailsMajorShareholderLabel.AutoSize = true;
            this.stockDetailsMajorShareholderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsMajorShareholderLabel.Location = new System.Drawing.Point(173, 223);
            this.stockDetailsMajorShareholderLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsMajorShareholderLabel.Name = "stockDetailsMajorShareholderLabel";
            this.stockDetailsMajorShareholderLabel.Size = new System.Drawing.Size(32, 17);
            this.stockDetailsMajorShareholderLabel.TabIndex = 13;
            this.stockDetailsMajorShareholderLabel.Text = "      ";
            // 
            // stockDetailsChangeLabel
            // 
            this.stockDetailsChangeLabel.AutoSize = true;
            this.stockDetailsChangeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsChangeLabel.Location = new System.Drawing.Point(166, 196);
            this.stockDetailsChangeLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsChangeLabel.Name = "stockDetailsChangeLabel";
            this.stockDetailsChangeLabel.Size = new System.Drawing.Size(32, 17);
            this.stockDetailsChangeLabel.TabIndex = 12;
            this.stockDetailsChangeLabel.Text = "      ";
            // 
            // stockDetailsCurrentPriceLabel
            // 
            this.stockDetailsCurrentPriceLabel.AutoSize = true;
            this.stockDetailsCurrentPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsCurrentPriceLabel.Location = new System.Drawing.Point(170, 142);
            this.stockDetailsCurrentPriceLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsCurrentPriceLabel.Name = "stockDetailsCurrentPriceLabel";
            this.stockDetailsCurrentPriceLabel.Size = new System.Drawing.Size(32, 17);
            this.stockDetailsCurrentPriceLabel.TabIndex = 11;
            this.stockDetailsCurrentPriceLabel.Text = "      ";
            // 
            // stockDetailsTotalLabel
            // 
            this.stockDetailsTotalLabel.AutoSize = true;
            this.stockDetailsTotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsTotalLabel.Location = new System.Drawing.Point(168, 115);
            this.stockDetailsTotalLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsTotalLabel.Name = "stockDetailsTotalLabel";
            this.stockDetailsTotalLabel.Size = new System.Drawing.Size(32, 17);
            this.stockDetailsTotalLabel.TabIndex = 10;
            this.stockDetailsTotalLabel.Text = "      ";
            // 
            // stockDetailsAvailableLabel
            // 
            this.stockDetailsAvailableLabel.AutoSize = true;
            this.stockDetailsAvailableLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsAvailableLabel.Location = new System.Drawing.Point(170, 88);
            this.stockDetailsAvailableLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsAvailableLabel.Name = "stockDetailsAvailableLabel";
            this.stockDetailsAvailableLabel.Size = new System.Drawing.Size(32, 17);
            this.stockDetailsAvailableLabel.TabIndex = 9;
            this.stockDetailsAvailableLabel.Text = "      ";
            // 
            // stockDetailsNameLabel
            // 
            this.stockDetailsNameLabel.AutoSize = true;
            this.stockDetailsNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsNameLabel.Location = new System.Drawing.Point(170, 61);
            this.stockDetailsNameLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsNameLabel.Name = "stockDetailsNameLabel";
            this.stockDetailsNameLabel.Size = new System.Drawing.Size(32, 17);
            this.stockDetailsNameLabel.TabIndex = 8;
            this.stockDetailsNameLabel.Text = "      ";
            // 
            // stockDetailsCodeLabel
            // 
            this.stockDetailsCodeLabel.AutoSize = true;
            this.stockDetailsCodeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsCodeLabel.Location = new System.Drawing.Point(170, 34);
            this.stockDetailsCodeLabel.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.stockDetailsCodeLabel.Name = "stockDetailsCodeLabel";
            this.stockDetailsCodeLabel.Size = new System.Drawing.Size(32, 17);
            this.stockDetailsCodeLabel.TabIndex = 7;
            this.stockDetailsCodeLabel.Text = "      ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Major Shareholder: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Change:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Shares:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchasable Shares: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Complete Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ticker Symbol: ";
            // 
            // StocksForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1000, 651);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StocksForm";
            this.Text = "StocksForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ownedStocksListBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox investmentHistoryListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label stockDetailsOldPriceLabel;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalStocksOwnedLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label historyPrice;
        private System.Windows.Forms.Label historyHour;
        private System.Windows.Forms.Label historyDate;
        private System.Windows.Forms.Label historyAmmount;
        private System.Windows.Forms.Label historyTicker;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}