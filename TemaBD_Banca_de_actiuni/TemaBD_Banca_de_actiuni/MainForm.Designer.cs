
namespace TemaBD_Banca_de_actiuni
{
    partial class MainForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bvbUpdateLabel = new System.Windows.Forms.Label();
            this.sideMenuHomeButton = new System.Windows.Forms.Button();
            this.sideMenuAccountButton = new System.Windows.Forms.Button();
            this.sideMenuTransactionsButton = new System.Windows.Forms.Button();
            this.sideMenuStocksButton = new System.Windows.Forms.Button();
            this.sideMenuInvestButton = new System.Windows.Forms.Button();
            this.sideMenuSettingsButton = new System.Windows.Forms.Button();
            this.headerMenuButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.sideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.headerPanel.Controls.Add(this.headerMenuButton);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1200, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(72, 15);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(143, 25);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Banca lui Gigel";
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.sideMenuPanel.Controls.Add(this.bvbUpdateLabel);
            this.sideMenuPanel.Controls.Add(this.label1);
            this.sideMenuPanel.Controls.Add(this.sideMenuHomeButton);
            this.sideMenuPanel.Controls.Add(this.sideMenuAccountButton);
            this.sideMenuPanel.Controls.Add(this.sideMenuTransactionsButton);
            this.sideMenuPanel.Controls.Add(this.sideMenuStocksButton);
            this.sideMenuPanel.Controls.Add(this.sideMenuInvestButton);
            this.sideMenuPanel.Controls.Add(this.sideMenuSettingsButton);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 60);
            this.sideMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(200, 651);
            this.sideMenuPanel.TabIndex = 2;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1000, 651);
            this.contentPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "BVB Update in:";
            // 
            // bvbUpdateLabel
            // 
            this.bvbUpdateLabel.AutoSize = true;
            this.bvbUpdateLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvbUpdateLabel.Location = new System.Drawing.Point(78, 501);
            this.bvbUpdateLabel.Name = "bvbUpdateLabel";
            this.bvbUpdateLabel.Size = new System.Drawing.Size(43, 32);
            this.bvbUpdateLabel.TabIndex = 13;
            this.bvbUpdateLabel.Text = "60";
            // 
            // sideMenuHomeButton
            // 
            this.sideMenuHomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.sideMenuHomeButton.FlatAppearance.BorderSize = 0;
            this.sideMenuHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuHomeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideMenuHomeButton.Image = global::TemaBD_Banca_de_actiuni.Properties.Resources.outline_home_black_24dp;
            this.sideMenuHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuHomeButton.Location = new System.Drawing.Point(0, 3);
            this.sideMenuHomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.sideMenuHomeButton.Name = "sideMenuHomeButton";
            this.sideMenuHomeButton.Size = new System.Drawing.Size(200, 60);
            this.sideMenuHomeButton.TabIndex = 6;
            this.sideMenuHomeButton.Text = "Home";
            this.sideMenuHomeButton.UseVisualStyleBackColor = false;
            this.sideMenuHomeButton.Click += new System.EventHandler(this.OnSideMenuHomeClick);
            // 
            // sideMenuAccountButton
            // 
            this.sideMenuAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.sideMenuAccountButton.FlatAppearance.BorderSize = 0;
            this.sideMenuAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuAccountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideMenuAccountButton.Image = global::TemaBD_Banca_de_actiuni.Properties.Resources.outline_manage_accounts_black_24dp;
            this.sideMenuAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuAccountButton.Location = new System.Drawing.Point(0, 63);
            this.sideMenuAccountButton.Margin = new System.Windows.Forms.Padding(0);
            this.sideMenuAccountButton.Name = "sideMenuAccountButton";
            this.sideMenuAccountButton.Size = new System.Drawing.Size(200, 60);
            this.sideMenuAccountButton.TabIndex = 7;
            this.sideMenuAccountButton.Text = "Account Details";
            this.sideMenuAccountButton.UseVisualStyleBackColor = false;
            this.sideMenuAccountButton.Click += new System.EventHandler(this.OnSideMenuAccountClick);
            // 
            // sideMenuTransactionsButton
            // 
            this.sideMenuTransactionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.sideMenuTransactionsButton.FlatAppearance.BorderSize = 0;
            this.sideMenuTransactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuTransactionsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideMenuTransactionsButton.Image = global::TemaBD_Banca_de_actiuni.Properties.Resources.outline_view_list_black_24dp;
            this.sideMenuTransactionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuTransactionsButton.Location = new System.Drawing.Point(0, 123);
            this.sideMenuTransactionsButton.Margin = new System.Windows.Forms.Padding(0);
            this.sideMenuTransactionsButton.Name = "sideMenuTransactionsButton";
            this.sideMenuTransactionsButton.Size = new System.Drawing.Size(200, 60);
            this.sideMenuTransactionsButton.TabIndex = 8;
            this.sideMenuTransactionsButton.Text = "Transactions";
            this.sideMenuTransactionsButton.UseVisualStyleBackColor = false;
            this.sideMenuTransactionsButton.Click += new System.EventHandler(this.OnSideMenuTransactionsClick);
            // 
            // sideMenuStocksButton
            // 
            this.sideMenuStocksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.sideMenuStocksButton.FlatAppearance.BorderSize = 0;
            this.sideMenuStocksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuStocksButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideMenuStocksButton.Image = global::TemaBD_Banca_de_actiuni.Properties.Resources.outline_savings_black_24dp;
            this.sideMenuStocksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuStocksButton.Location = new System.Drawing.Point(0, 183);
            this.sideMenuStocksButton.Margin = new System.Windows.Forms.Padding(0);
            this.sideMenuStocksButton.Name = "sideMenuStocksButton";
            this.sideMenuStocksButton.Size = new System.Drawing.Size(200, 60);
            this.sideMenuStocksButton.TabIndex = 9;
            this.sideMenuStocksButton.Text = "Portfolio";
            this.sideMenuStocksButton.UseVisualStyleBackColor = false;
            this.sideMenuStocksButton.Click += new System.EventHandler(this.OnSideMenuStocksClick);
            // 
            // sideMenuInvestButton
            // 
            this.sideMenuInvestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.sideMenuInvestButton.FlatAppearance.BorderSize = 0;
            this.sideMenuInvestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuInvestButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideMenuInvestButton.Image = global::TemaBD_Banca_de_actiuni.Properties.Resources.outline_account_balance_black_24dp;
            this.sideMenuInvestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuInvestButton.Location = new System.Drawing.Point(0, 243);
            this.sideMenuInvestButton.Margin = new System.Windows.Forms.Padding(0);
            this.sideMenuInvestButton.Name = "sideMenuInvestButton";
            this.sideMenuInvestButton.Size = new System.Drawing.Size(200, 60);
            this.sideMenuInvestButton.TabIndex = 10;
            this.sideMenuInvestButton.Text = "Invest";
            this.sideMenuInvestButton.UseVisualStyleBackColor = false;
            this.sideMenuInvestButton.Click += new System.EventHandler(this.OnSideMenuInvestClick);
            // 
            // sideMenuSettingsButton
            // 
            this.sideMenuSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.sideMenuSettingsButton.FlatAppearance.BorderSize = 0;
            this.sideMenuSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideMenuSettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideMenuSettingsButton.Image = global::TemaBD_Banca_de_actiuni.Properties.Resources.outline_trending_up_black_24dp;
            this.sideMenuSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideMenuSettingsButton.Location = new System.Drawing.Point(0, 303);
            this.sideMenuSettingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.sideMenuSettingsButton.Name = "sideMenuSettingsButton";
            this.sideMenuSettingsButton.Size = new System.Drawing.Size(200, 60);
            this.sideMenuSettingsButton.TabIndex = 11;
            this.sideMenuSettingsButton.Text = "Performance";
            this.sideMenuSettingsButton.UseVisualStyleBackColor = false;
            this.sideMenuSettingsButton.Click += new System.EventHandler(this.OnSideMenuPerformanceClick);
            // 
            // headerMenuButton
            // 
            this.headerMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.headerMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headerMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(64)))));
            this.headerMenuButton.FlatAppearance.BorderSize = 0;
            this.headerMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerMenuButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerMenuButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.headerMenuButton.Image = global::TemaBD_Banca_de_actiuni.Properties.Resources.outline_menu_black_24dp;
            this.headerMenuButton.Location = new System.Drawing.Point(5, 5);
            this.headerMenuButton.Name = "headerMenuButton";
            this.headerMenuButton.Size = new System.Drawing.Size(50, 50);
            this.headerMenuButton.TabIndex = 1;
            this.headerMenuButton.UseVisualStyleBackColor = false;
            this.headerMenuButton.Click += new System.EventHandler(this.OnSideMenuClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 711);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Banca lui Gigel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.sideMenuPanel.ResumeLayout(false);
            this.sideMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button headerMenuButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button sideMenuHomeButton;
        private System.Windows.Forms.Button sideMenuAccountButton;
        private System.Windows.Forms.Button sideMenuTransactionsButton;
        private System.Windows.Forms.Button sideMenuStocksButton;
        private System.Windows.Forms.Button sideMenuInvestButton;
        private System.Windows.Forms.Button sideMenuSettingsButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label bvbUpdateLabel;
        private System.Windows.Forms.Label label1;
    }
}

