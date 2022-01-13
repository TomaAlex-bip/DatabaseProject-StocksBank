
namespace TemaBD_Banca_de_actiuni.ContentForms
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginRegisterButton = new System.Windows.Forms.Button();
            this.loginNoAccountLabel = new System.Windows.Forms.Label();
            this.loginLoginButton = new System.Windows.Forms.Button();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.loginRegisterButton);
            this.panel1.Controls.Add(this.loginNoAccountLabel);
            this.panel1.Controls.Add(this.loginLoginButton);
            this.panel1.Controls.Add(this.loginPasswordTextBox);
            this.panel1.Controls.Add(this.loginPasswordLabel);
            this.panel1.Controls.Add(this.loginUsernameTextBox);
            this.panel1.Controls.Add(this.loginUsernameLabel);
            this.panel1.Location = new System.Drawing.Point(300, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 600);
            this.panel1.TabIndex = 0;
            // 
            // loginRegisterButton
            // 
            this.loginRegisterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginRegisterButton.Location = new System.Drawing.Point(123, 428);
            this.loginRegisterButton.Name = "loginRegisterButton";
            this.loginRegisterButton.Size = new System.Drawing.Size(150, 50);
            this.loginRegisterButton.TabIndex = 6;
            this.loginRegisterButton.Text = "Register";
            this.loginRegisterButton.UseVisualStyleBackColor = true;
            this.loginRegisterButton.Click += new System.EventHandler(this.OnRegisterClick);
            // 
            // loginNoAccountLabel
            // 
            this.loginNoAccountLabel.AutoSize = true;
            this.loginNoAccountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNoAccountLabel.Location = new System.Drawing.Point(152, 404);
            this.loginNoAccountLabel.Name = "loginNoAccountLabel";
            this.loginNoAccountLabel.Size = new System.Drawing.Size(93, 21);
            this.loginNoAccountLabel.TabIndex = 5;
            this.loginNoAccountLabel.Text = "no account?";
            // 
            // loginLoginButton
            // 
            this.loginLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLoginButton.Location = new System.Drawing.Point(123, 281);
            this.loginLoginButton.Name = "loginLoginButton";
            this.loginLoginButton.Size = new System.Drawing.Size(150, 50);
            this.loginLoginButton.TabIndex = 4;
            this.loginLoginButton.Text = "Login";
            this.loginLoginButton.UseVisualStyleBackColor = true;
            this.loginLoginButton.Click += new System.EventHandler(this.OnLoginClick);
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordTextBox.Location = new System.Drawing.Point(73, 215);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(250, 33);
            this.loginPasswordTextBox.TabIndex = 3;
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordLabel.Location = new System.Drawing.Point(158, 183);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(80, 21);
            this.loginPasswordLabel.TabIndex = 2;
            this.loginPasswordLabel.Text = "password:";
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsernameTextBox.Location = new System.Drawing.Point(73, 115);
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(250, 33);
            this.loginUsernameTextBox.TabIndex = 1;
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsernameLabel.Location = new System.Drawing.Point(157, 83);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(82, 21);
            this.loginUsernameLabel.TabIndex = 0;
            this.loginUsernameLabel.Text = "username:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1000, 651);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginRegisterButton;
        private System.Windows.Forms.Label loginNoAccountLabel;
        private System.Windows.Forms.Button loginLoginButton;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.Label loginUsernameLabel;
    }
}