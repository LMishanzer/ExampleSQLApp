namespace ExampleSQLApp
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
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.userLog = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.userLogo = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderText = new System.Windows.Forms.Label();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(9)))), ((int)(((byte)(182)))));
            this.BackgroundPanel.BackgroundImage = global::ExampleSQLApp.Properties.Resources.background1;
            this.BackgroundPanel.Controls.Add(this.loginButton);
            this.BackgroundPanel.Controls.Add(this.passwordField);
            this.BackgroundPanel.Controls.Add(this.userLog);
            this.BackgroundPanel.Controls.Add(this.loginField);
            this.BackgroundPanel.Controls.Add(this.userLogo);
            this.BackgroundPanel.Controls.Add(this.Header);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(462, 593);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(155)))), ((int)(((byte)(245)))));
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(117, 462);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(223, 61);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(99, 338);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(340, 45);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // userLog
            // 
            this.userLog.BackColor = System.Drawing.Color.Transparent;
            this.userLog.Image = global::ExampleSQLApp.Properties.Resources._lock;
            this.userLog.Location = new System.Drawing.Point(13, 321);
            this.userLog.Name = "userLog";
            this.userLog.Size = new System.Drawing.Size(80, 80);
            this.userLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userLog.TabIndex = 3;
            this.userLog.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(99, 212);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(340, 45);
            this.loginField.TabIndex = 2;
            // 
            // userLogo
            // 
            this.userLogo.BackColor = System.Drawing.Color.Transparent;
            this.userLogo.Image = global::ExampleSQLApp.Properties.Resources.user;
            this.userLogo.Location = new System.Drawing.Point(13, 195);
            this.userLogo.Name = "userLogo";
            this.userLogo.Size = new System.Drawing.Size(80, 80);
            this.userLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userLogo.TabIndex = 1;
            this.userLogo.TabStop = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Controls.Add(this.closeButton);
            this.Header.Controls.Add(this.label1);
            this.Header.Controls.Add(this.HeaderText);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(462, 156);
            this.Header.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(433, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 20);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(471, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // HeaderText
            // 
            this.HeaderText.BackColor = System.Drawing.Color.Transparent;
            this.HeaderText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderText.Font = new System.Drawing.Font("Freestyle Script", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HeaderText.Location = new System.Drawing.Point(0, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(462, 156);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Log In";
            this.HeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeaderText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.HeaderText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 593);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.PictureBox userLog;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox userLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label closeButton;
    }
}