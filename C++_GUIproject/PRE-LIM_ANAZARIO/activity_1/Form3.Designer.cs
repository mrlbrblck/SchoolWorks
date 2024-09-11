namespace activity_1
{
    partial class Form3
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
            this.lbl_login = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_email = new System.Windows.Forms.TextBox();
            this.lbl_loginemail = new System.Windows.Forms.Label();
            this.lbl_loginpassword = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_registernow = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.login_showpassword = new System.Windows.Forms.CheckBox();
            this.login_close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(381, 41);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(127, 54);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(296, 222);
            this.login_password.Multiline = true;
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(324, 39);
            this.login_password.TabIndex = 1;
            // 
            // login_email
            // 
            this.login_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_email.Location = new System.Drawing.Point(296, 148);
            this.login_email.Multiline = true;
            this.login_email.Name = "login_email";
            this.login_email.Size = new System.Drawing.Size(324, 39);
            this.login_email.TabIndex = 2;
            // 
            // lbl_loginemail
            // 
            this.lbl_loginemail.AutoSize = true;
            this.lbl_loginemail.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginemail.Location = new System.Drawing.Point(213, 159);
            this.lbl_loginemail.Name = "lbl_loginemail";
            this.lbl_loginemail.Size = new System.Drawing.Size(64, 28);
            this.lbl_loginemail.TabIndex = 3;
            this.lbl_loginemail.Text = "Email";
            this.lbl_loginemail.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_loginpassword
            // 
            this.lbl_loginpassword.AutoSize = true;
            this.lbl_loginpassword.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginpassword.Location = new System.Drawing.Point(175, 233);
            this.lbl_loginpassword.Name = "lbl_loginpassword";
            this.lbl_loginpassword.Size = new System.Drawing.Size(102, 28);
            this.lbl_loginpassword.TabIndex = 4;
            this.lbl_loginpassword.Text = "Password";
            this.lbl_loginpassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(358, 303);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(183, 46);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Sign in";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // login_registernow
            // 
            this.login_registernow.BackColor = System.Drawing.Color.Navy;
            this.login_registernow.ForeColor = System.Drawing.Color.White;
            this.login_registernow.Location = new System.Drawing.Point(652, 415);
            this.login_registernow.Name = "login_registernow";
            this.login_registernow.Size = new System.Drawing.Size(196, 53);
            this.login_registernow.TabIndex = 6;
            this.login_registernow.Text = "Register now";
            this.login_registernow.UseVisualStyleBackColor = false;
            this.login_registernow.Click += new System.EventHandler(this.btn_registernow_Click);
            // 
            // login_showpassword
            // 
            this.login_showpassword.AutoSize = true;
            this.login_showpassword.Location = new System.Drawing.Point(496, 267);
            this.login_showpassword.Name = "login_showpassword";
            this.login_showpassword.Size = new System.Drawing.Size(124, 20);
            this.login_showpassword.TabIndex = 7;
            this.login_showpassword.Text = "Show password";
            this.login_showpassword.UseVisualStyleBackColor = true;
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_close.Location = new System.Drawing.Point(865, 9);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(22, 22);
            this.login_close.TabIndex = 8;
            this.login_close.Text = "X";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 497);
            this.Controls.Add(this.login_close);
            this.Controls.Add(this.login_showpassword);
            this.Controls.Add(this.login_registernow);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.lbl_loginpassword);
            this.Controls.Add(this.lbl_loginemail);
            this.Controls.Add(this.login_email);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.lbl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "MySpace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.TextBox login_email;
        private System.Windows.Forms.Label lbl_loginemail;
        private System.Windows.Forms.Label lbl_loginpassword;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button login_registernow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox login_showpassword;
        private System.Windows.Forms.Label login_close;
    }
}