namespace activity_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chk_loginshowpassword = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_loginpassword = new System.Windows.Forms.TextBox();
            this.lbl_loginpassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_loginusername = new System.Windows.Forms.TextBox();
            this.lbl_loginusername = new System.Windows.Forms.Label();
            this.lbl_welcomeback = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_account = new System.Windows.Forms.Label();
            this.llbl_signup = new System.Windows.Forms.LinkLabel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_loginshowpassword
            // 
            this.chk_loginshowpassword.AutoSize = true;
            this.chk_loginshowpassword.Location = new System.Drawing.Point(611, 262);
            this.chk_loginshowpassword.Margin = new System.Windows.Forms.Padding(2);
            this.chk_loginshowpassword.Name = "chk_loginshowpassword";
            this.chk_loginshowpassword.Size = new System.Drawing.Size(101, 17);
            this.chk_loginshowpassword.TabIndex = 40;
            this.chk_loginshowpassword.Text = "Show password";
            this.chk_loginshowpassword.UseVisualStyleBackColor = true;
            this.chk_loginshowpassword.CheckedChanged += new System.EventHandler(this.chk_loginshowpassword_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(499, 296);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(92, 36);
            this.btn_login.TabIndex = 37;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(690, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(53, 29);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_loginpassword
            // 
            this.txt_loginpassword.BackColor = System.Drawing.Color.Silver;
            this.txt_loginpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginpassword.Location = new System.Drawing.Point(490, 225);
            this.txt_loginpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_loginpassword.Multiline = true;
            this.txt_loginpassword.Name = "txt_loginpassword";
            this.txt_loginpassword.PasswordChar = '*';
            this.txt_loginpassword.Size = new System.Drawing.Size(223, 25);
            this.txt_loginpassword.TabIndex = 34;
            // 
            // lbl_loginpassword
            // 
            this.lbl_loginpassword.AutoSize = true;
            this.lbl_loginpassword.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginpassword.Location = new System.Drawing.Point(391, 229);
            this.lbl_loginpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loginpassword.Name = "lbl_loginpassword";
            this.lbl_loginpassword.Size = new System.Drawing.Size(79, 20);
            this.lbl_loginpassword.TabIndex = 31;
            this.lbl_loginpassword.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 29);
            this.panel2.TabIndex = 36;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // txt_loginusername
            // 
            this.txt_loginusername.BackColor = System.Drawing.Color.Silver;
            this.txt_loginusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginusername.Location = new System.Drawing.Point(490, 176);
            this.txt_loginusername.Margin = new System.Windows.Forms.Padding(2);
            this.txt_loginusername.Multiline = true;
            this.txt_loginusername.Name = "txt_loginusername";
            this.txt_loginusername.Size = new System.Drawing.Size(223, 25);
            this.txt_loginusername.TabIndex = 35;
            this.txt_loginusername.TextChanged += new System.EventHandler(this.txt_loginemail_TextChanged);
            // 
            // lbl_loginusername
            // 
            this.lbl_loginusername.AutoSize = true;
            this.lbl_loginusername.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginusername.Location = new System.Drawing.Point(391, 178);
            this.lbl_loginusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loginusername.Name = "lbl_loginusername";
            this.lbl_loginusername.Size = new System.Drawing.Size(89, 21);
            this.lbl_loginusername.TabIndex = 32;
            this.lbl_loginusername.Text = "Username";
            this.lbl_loginusername.Click += new System.EventHandler(this.lbl_loginemail_Click);
            // 
            // lbl_welcomeback
            // 
            this.lbl_welcomeback.AutoSize = true;
            this.lbl_welcomeback.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_welcomeback.Location = new System.Drawing.Point(364, 58);
            this.lbl_welcomeback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_welcomeback.Name = "lbl_welcomeback";
            this.lbl_welcomeback.Size = new System.Drawing.Size(262, 47);
            this.lbl_welcomeback.TabIndex = 22;
            this.lbl_welcomeback.Text = "Welcome Back!";
            this.lbl_welcomeback.Click += new System.EventHandler(this.lbl_Registration_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 506);
            this.panel1.TabIndex = 21;
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.Location = new System.Drawing.Point(508, 499);
            this.lbl_account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(158, 17);
            this.lbl_account.TabIndex = 42;
            this.lbl_account.Text = "Don\'t have an account?";
            // 
            // llbl_signup
            // 
            this.llbl_signup.AutoSize = true;
            this.llbl_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbl_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_signup.LinkColor = System.Drawing.Color.Black;
            this.llbl_signup.Location = new System.Drawing.Point(670, 499);
            this.llbl_signup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbl_signup.Name = "llbl_signup";
            this.llbl_signup.Size = new System.Drawing.Size(51, 17);
            this.llbl_signup.TabIndex = 41;
            this.llbl_signup.TabStop = true;
            this.llbl_signup.Text = "Sign in";
            this.llbl_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_signup_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 525);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.llbl_signup);
            this.Controls.Add(this.chk_loginshowpassword);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_loginpassword);
            this.Controls.Add(this.lbl_loginpassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_loginusername);
            this.Controls.Add(this.lbl_loginusername);
            this.Controls.Add(this.lbl_welcomeback);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "MySpace";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chk_loginshowpassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_loginpassword;
        private System.Windows.Forms.Label lbl_loginpassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_loginusername;
        private System.Windows.Forms.Label lbl_loginusername;
        private System.Windows.Forms.Label lbl_welcomeback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.LinkLabel llbl_signup;
    }
}