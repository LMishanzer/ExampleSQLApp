namespace ExampleSQLApp
{
    partial class RegisterForm
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
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.passwordConfirmField = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.passwordRegField = new System.Windows.Forms.TextBox();
            this.userLog = new System.Windows.Forms.PictureBox();
            this.loginRegField = new System.Windows.Forms.TextBox();
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
            this.BackgroundPanel.Controls.Add(this.ConfirmPassword);
            this.BackgroundPanel.Controls.Add(this.passwordConfirmField);
            this.BackgroundPanel.Controls.Add(this.registerButton);
            this.BackgroundPanel.Controls.Add(this.passwordRegField);
            this.BackgroundPanel.Controls.Add(this.userLog);
            this.BackgroundPanel.Controls.Add(this.loginRegField);
            this.BackgroundPanel.Controls.Add(this.userLogo);
            this.BackgroundPanel.Controls.Add(this.Header);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(459, 588);
            this.BackgroundPanel.TabIndex = 1;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.ConfirmPassword.Location = new System.Drawing.Point(109, 322);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(179, 46);
            this.ConfirmPassword.TabIndex = 7;
            this.ConfirmPassword.Text = "Confirm:";
            // 
            // passwordConfirmField
            // 
            this.passwordConfirmField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordConfirmField.Location = new System.Drawing.Point(99, 382);
            this.passwordConfirmField.Name = "passwordConfirmField";
            this.passwordConfirmField.Size = new System.Drawing.Size(340, 45);
            this.passwordConfirmField.TabIndex = 6;
            this.passwordConfirmField.UseSystemPasswordChar = true;
            this.passwordConfirmField.Enter += new System.EventHandler(this.passwordConfirmField_Enter);
            this.passwordConfirmField.Leave += new System.EventHandler(this.passwordConfirmField_Leave);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(58)))), ((int)(((byte)(6)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(155)))), ((int)(((byte)(245)))));
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerButton.Location = new System.Drawing.Point(117, 479);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(223, 61);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passwordRegField
            // 
            this.passwordRegField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegField.Location = new System.Drawing.Point(99, 257);
            this.passwordRegField.Name = "passwordRegField";
            this.passwordRegField.Size = new System.Drawing.Size(340, 45);
            this.passwordRegField.TabIndex = 4;
            this.passwordRegField.UseSystemPasswordChar = true;
            this.passwordRegField.Enter += new System.EventHandler(this.passwordRegField_Enter);
            this.passwordRegField.Leave += new System.EventHandler(this.passwordRegField_Leave);
            // 
            // userLog
            // 
            this.userLog.BackColor = System.Drawing.Color.Transparent;
            this.userLog.Image = global::ExampleSQLApp.Properties.Resources._lock;
            this.userLog.Location = new System.Drawing.Point(13, 240);
            this.userLog.Name = "userLog";
            this.userLog.Size = new System.Drawing.Size(80, 80);
            this.userLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userLog.TabIndex = 3;
            this.userLog.TabStop = false;
            // 
            // loginRegField
            // 
            this.loginRegField.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegField.Location = new System.Drawing.Point(99, 159);
            this.loginRegField.Name = "loginRegField";
            this.loginRegField.Size = new System.Drawing.Size(340, 45);
            this.loginRegField.TabIndex = 2;
            this.loginRegField.Enter += new System.EventHandler(this.loginRegField_Enter);
            this.loginRegField.Leave += new System.EventHandler(this.loginRegField_Leave);
            // 
            // userLogo
            // 
            this.userLogo.BackColor = System.Drawing.Color.Transparent;
            this.userLogo.Image = global::ExampleSQLApp.Properties.Resources.user;
            this.userLogo.Location = new System.Drawing.Point(13, 142);
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
            this.Header.Size = new System.Drawing.Size(459, 156);
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
            this.HeaderText.Size = new System.Drawing.Size(459, 156);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Register";
            this.HeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeaderText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.HeaderText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 588);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
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
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox passwordRegField;
        private System.Windows.Forms.PictureBox userLog;
        private System.Windows.Forms.TextBox loginRegField;
        private System.Windows.Forms.PictureBox userLogo;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.TextBox passwordConfirmField;
    }
}