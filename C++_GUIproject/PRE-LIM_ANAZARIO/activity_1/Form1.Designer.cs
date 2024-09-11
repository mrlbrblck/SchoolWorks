namespace activity_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Registration = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.signup_firstname = new System.Windows.Forms.TextBox();
            this.signup_lastname = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.signup_address = new System.Windows.Forms.TextBox();
            this.signup_age = new System.Windows.Forms.TextBox();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.signup_btn = new System.Windows.Forms.Button();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.signup_sex = new System.Windows.Forms.ComboBox();
            this.signup_showpassword = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_account = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 623);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lbl_Registration
            // 
            this.lbl_Registration.AutoSize = true;
            this.lbl_Registration.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Registration.Location = new System.Drawing.Point(486, 71);
            this.lbl_Registration.Name = "lbl_Registration";
            this.lbl_Registration.Size = new System.Drawing.Size(375, 59);
            this.lbl_Registration.TabIndex = 1;
            this.lbl_Registration.Text = "Registration Form";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.ForeColor = System.Drawing.Color.Silver;
            this.lbl_firstname.Location = new System.Drawing.Point(575, 220);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(72, 16);
            this.lbl_firstname.TabIndex = 2;
            this.lbl_firstname.Text = "First Name";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.ForeColor = System.Drawing.Color.Silver;
            this.lbl_lastname.Location = new System.Drawing.Point(785, 220);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(72, 16);
            this.lbl_lastname.TabIndex = 3;
            this.lbl_lastname.Text = "Last Name";
            // 
            // signup_firstname
            // 
            this.signup_firstname.BackColor = System.Drawing.Color.Silver;
            this.signup_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_firstname.Location = new System.Drawing.Point(578, 187);
            this.signup_firstname.Multiline = true;
            this.signup_firstname.Name = "signup_firstname";
            this.signup_firstname.Size = new System.Drawing.Size(176, 30);
            this.signup_firstname.TabIndex = 4;
            this.signup_firstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // signup_lastname
            // 
            this.signup_lastname.BackColor = System.Drawing.Color.Silver;
            this.signup_lastname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_lastname.Location = new System.Drawing.Point(788, 187);
            this.signup_lastname.Multiline = true;
            this.signup_lastname.Name = "signup_lastname";
            this.signup_lastname.Size = new System.Drawing.Size(176, 30);
            this.signup_lastname.TabIndex = 5;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(486, 189);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(68, 28);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 274);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.ForeColor = System.Drawing.Color.Black;
            this.lbl_age.Location = new System.Drawing.Point(485, 353);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(50, 28);
            this.lbl_age.TabIndex = 8;
            this.lbl_age.Text = "Age";
            this.lbl_age.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(476, 495);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(96, 25);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "Password";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(486, 423);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(64, 28);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "Email";
            this.lbl_email.Click += new System.EventHandler(this.label5_Click);
            // 
            // signup_address
            // 
            this.signup_address.BackColor = System.Drawing.Color.Silver;
            this.signup_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_address.Location = new System.Drawing.Point(578, 272);
            this.signup_address.Multiline = true;
            this.signup_address.Name = "signup_address";
            this.signup_address.Size = new System.Drawing.Size(384, 30);
            this.signup_address.TabIndex = 8;
            // 
            // signup_age
            // 
            this.signup_age.BackColor = System.Drawing.Color.Silver;
            this.signup_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_age.Location = new System.Drawing.Point(578, 351);
            this.signup_age.Multiline = true;
            this.signup_age.Name = "signup_age";
            this.signup_age.Size = new System.Drawing.Size(114, 30);
            this.signup_age.TabIndex = 11;
            // 
            // signup_password
            // 
            this.signup_password.BackColor = System.Drawing.Color.Silver;
            this.signup_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password.Location = new System.Drawing.Point(578, 490);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(386, 30);
            this.signup_password.TabIndex = 12;
            // 
            // signup_email
            // 
            this.signup_email.BackColor = System.Drawing.Color.Silver;
            this.signup_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_email.Location = new System.Drawing.Point(578, 421);
            this.signup_email.Multiline = true;
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(386, 30);
            this.signup_email.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 36);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(920, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(71, 36);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.Navy;
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Location = new System.Drawing.Point(687, 545);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(123, 44);
            this.signup_btn.TabIndex = 15;
            this.signup_btn.Text = "SIGNUP";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(723, 353);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(45, 28);
            this.lbl_sex.TabIndex = 16;
            this.lbl_sex.Text = "Sex";
            this.lbl_sex.Click += new System.EventHandler(this.lbl_sex_Click);
            // 
            // signup_sex
            // 
            this.signup_sex.BackColor = System.Drawing.Color.Silver;
            this.signup_sex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signup_sex.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_sex.ForeColor = System.Drawing.Color.Black;
            this.signup_sex.FormattingEnabled = true;
            this.signup_sex.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Others",
            "Prefer not to tell"});
            this.signup_sex.Location = new System.Drawing.Point(788, 350);
            this.signup_sex.Name = "signup_sex";
            this.signup_sex.Size = new System.Drawing.Size(176, 31);
            this.signup_sex.TabIndex = 17;
            this.signup_sex.SelectedIndexChanged += new System.EventHandler(this.signup_sex_SelectedIndexChanged);
            // 
            // signup_showpassword
            // 
            this.signup_showpassword.AutoSize = true;
            this.signup_showpassword.Location = new System.Drawing.Point(838, 526);
            this.signup_showpassword.Name = "signup_showpassword";
            this.signup_showpassword.Size = new System.Drawing.Size(124, 20);
            this.signup_showpassword.TabIndex = 18;
            this.signup_showpassword.Text = "Show password";
            this.signup_showpassword.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(912, 613);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 20);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.Location = new System.Drawing.Point(683, 613);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(201, 20);
            this.lbl_account.TabIndex = 20;
            this.lbl_account.Text = "Already have an account?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 647);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.signup_showpassword);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.signup_sex);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.signup_email);
            this.Controls.Add(this.signup_age);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.signup_address);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.signup_lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signup_firstname);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.lbl_Registration);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Registration;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.TextBox signup_firstname;
        private System.Windows.Forms.TextBox signup_lastname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox signup_address;
        private System.Windows.Forms.TextBox signup_age;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.ComboBox signup_sex;
        private System.Windows.Forms.CheckBox signup_showpassword;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_account;
    }
}

