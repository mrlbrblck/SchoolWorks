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
            this.lbl_registrationform = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.txt_signupfirstname = new System.Windows.Forms.TextBox();
            this.txt_signuplastname = new System.Windows.Forms.TextBox();
            this.lbl_signupname = new System.Windows.Forms.Label();
            this.lbl_signupaddress = new System.Windows.Forms.Label();
            this.lbl_signupage = new System.Windows.Forms.Label();
            this.lbl_signuppassword = new System.Windows.Forms.Label();
            this.lbl_signupemail = new System.Windows.Forms.Label();
            this.txt_signupaddress = new System.Windows.Forms.TextBox();
            this.txt_signupage = new System.Windows.Forms.TextBox();
            this.txt_signuppassword = new System.Windows.Forms.TextBox();
            this.txt_signupemail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.cmb_signupgender = new System.Windows.Forms.ComboBox();
            this.cb_signupshowpassword = new System.Windows.Forms.CheckBox();
            this.llbl_login = new System.Windows.Forms.LinkLabel();
            this.lbl_account = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_signupconfirmpassword = new System.Windows.Forms.TextBox();
            this.lbl_signupbirthday = new System.Windows.Forms.Label();
            this.dtp_signupbirthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_signupusername = new System.Windows.Forms.Label();
            this.txt_signupusername = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 506);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lbl_registrationform
            // 
            this.lbl_registrationform.AutoSize = true;
            this.lbl_registrationform.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registrationform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_registrationform.Location = new System.Drawing.Point(364, 45);
            this.lbl_registrationform.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_registrationform.Name = "lbl_registrationform";
            this.lbl_registrationform.Size = new System.Drawing.Size(305, 47);
            this.lbl_registrationform.TabIndex = 1;
            this.lbl_registrationform.Text = "Registration Form";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.ForeColor = System.Drawing.Color.Silver;
            this.lbl_firstname.Location = new System.Drawing.Point(446, 136);
            this.lbl_firstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(57, 13);
            this.lbl_firstname.TabIndex = 2;
            this.lbl_firstname.Text = "First Name";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.ForeColor = System.Drawing.Color.Silver;
            this.lbl_lastname.Location = new System.Drawing.Point(591, 136);
            this.lbl_lastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(58, 13);
            this.lbl_lastname.TabIndex = 3;
            this.lbl_lastname.Text = "Last Name";
            // 
            // txt_signupfirstname
            // 
            this.txt_signupfirstname.BackColor = System.Drawing.Color.Silver;
            this.txt_signupfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signupfirstname.Location = new System.Drawing.Point(449, 109);
            this.txt_signupfirstname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_signupfirstname.Multiline = true;
            this.txt_signupfirstname.Name = "txt_signupfirstname";
            this.txt_signupfirstname.Size = new System.Drawing.Size(120, 25);
            this.txt_signupfirstname.TabIndex = 4;
            this.txt_signupfirstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_signuplastname
            // 
            this.txt_signuplastname.BackColor = System.Drawing.Color.Silver;
            this.txt_signuplastname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signuplastname.Location = new System.Drawing.Point(593, 109);
            this.txt_signuplastname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_signuplastname.Multiline = true;
            this.txt_signuplastname.Name = "txt_signuplastname";
            this.txt_signuplastname.Size = new System.Drawing.Size(133, 25);
            this.txt_signuplastname.TabIndex = 5;
            // 
            // lbl_signupname
            // 
            this.lbl_signupname.AutoSize = true;
            this.lbl_signupname.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signupname.Location = new System.Drawing.Point(366, 112);
            this.lbl_signupname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_signupname.Name = "lbl_signupname";
            this.lbl_signupname.Size = new System.Drawing.Size(56, 21);
            this.lbl_signupname.TabIndex = 6;
            this.lbl_signupname.Text = "Name";
            this.lbl_signupname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_signupaddress
            // 
            this.lbl_signupaddress.AutoSize = true;
            this.lbl_signupaddress.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signupaddress.Location = new System.Drawing.Point(366, 162);
            this.lbl_signupaddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_signupaddress.Name = "lbl_signupaddress";
            this.lbl_signupaddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_signupaddress.Size = new System.Drawing.Size(73, 21);
            this.lbl_signupaddress.TabIndex = 7;
            this.lbl_signupaddress.Text = "Address";
            this.lbl_signupaddress.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_signupage
            // 
            this.lbl_signupage.AutoSize = true;
            this.lbl_signupage.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signupage.ForeColor = System.Drawing.Color.Black;
            this.lbl_signupage.Location = new System.Drawing.Point(366, 244);
            this.lbl_signupage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_signupage.Name = "lbl_signupage";
            this.lbl_signupage.Size = new System.Drawing.Size(40, 21);
            this.lbl_signupage.TabIndex = 8;
            this.lbl_signupage.Text = "Age";
            this.lbl_signupage.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // lbl_signuppassword
            // 
            this.lbl_signuppassword.AutoSize = true;
            this.lbl_signuppassword.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signuppassword.Location = new System.Drawing.Point(368, 362);
            this.lbl_signuppassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_signuppassword.Name = "lbl_signuppassword";
            this.lbl_signuppassword.Size = new System.Drawing.Size(79, 20);
            this.lbl_signuppassword.TabIndex = 9;
            this.lbl_signuppassword.Text = "Password";
            this.lbl_signuppassword.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // lbl_signupemail
            // 
            this.lbl_signupemail.AutoSize = true;
            this.lbl_signupemail.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signupemail.Location = new System.Drawing.Point(366, 292);
            this.lbl_signupemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_signupemail.Name = "lbl_signupemail";
            this.lbl_signupemail.Size = new System.Drawing.Size(53, 21);
            this.lbl_signupemail.TabIndex = 10;
            this.lbl_signupemail.Text = "Email";
            this.lbl_signupemail.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_signupaddress
            // 
            this.txt_signupaddress.BackColor = System.Drawing.Color.Silver;
            this.txt_signupaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signupaddress.Location = new System.Drawing.Point(449, 160);
            this.txt_signupaddress.Margin = new System.Windows.Forms.Padding(2);
            this.txt_signupaddress.Multiline = true;
            this.txt_signupaddress.Name = "txt_signupaddress";
            this.txt_signupaddress.Size = new System.Drawing.Size(276, 25);
            this.txt_signupaddress.TabIndex = 8;
            // 
            // txt_signupage
            // 
            this.txt_signupage.BackColor = System.Drawing.Color.Silver;
            this.txt_signupage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signupage.Location = new System.Drawing.Point(449, 242);
            this.txt_signupage.Margin = new System.Windows.Forms.Padding(2);
            this.txt_signupage.Multiline = true;
            this.txt_signupage.Name = "txt_signupage";
            this.txt_signupage.Size = new System.Drawing.Size(86, 25);
            this.txt_signupage.TabIndex = 11;
            // 
            // txt_signuppassword
            // 
            this.txt_signuppassword.BackColor = System.Drawing.Color.Silver;
            this.txt_signuppassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signuppassword.Location = new System.Drawing.Point(449, 362);
            this.txt_signuppassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_signuppassword.Multiline = true;
            this.txt_signuppassword.Name = "txt_signuppassword";
            this.txt_signuppassword.PasswordChar = '*';
            this.txt_signuppassword.Size = new System.Drawing.Size(276, 25);
            this.txt_signuppassword.TabIndex = 12;
            // 
            // txt_signupemail
            // 
            this.txt_signupemail.BackColor = System.Drawing.Color.Silver;
            this.txt_signupemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signupemail.Location = new System.Drawing.Point(449, 290);
            this.txt_signupemail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_signupemail.Multiline = true;
            this.txt_signupemail.Name = "txt_signupemail";
            this.txt_signupemail.Size = new System.Drawing.Size(277, 25);
            this.txt_signupemail.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 29);
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
            this.btn_close.Location = new System.Drawing.Point(690, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(53, 29);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.Navy;
            this.btn_signup.ForeColor = System.Drawing.Color.White;
            this.btn_signup.Location = new System.Drawing.Point(506, 446);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(2);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(92, 36);
            this.btn_signup.TabIndex = 15;
            this.btn_signup.Text = "SIGN UP";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signin);
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(539, 244);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(67, 21);
            this.lbl_gender.TabIndex = 16;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.Click += new System.EventHandler(this.lbl_sex_Click);
            // 
            // cmb_signupgender
            // 
            this.cmb_signupgender.BackColor = System.Drawing.Color.Silver;
            this.cmb_signupgender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_signupgender.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_signupgender.ForeColor = System.Drawing.Color.Black;
            this.cmb_signupgender.FormattingEnabled = true;
            this.cmb_signupgender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Others",
            "Prefer not to tell"});
            this.cmb_signupgender.Location = new System.Drawing.Point(610, 241);
            this.cmb_signupgender.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_signupgender.Name = "cmb_signupgender";
            this.cmb_signupgender.Size = new System.Drawing.Size(116, 27);
            this.cmb_signupgender.TabIndex = 17;
            this.cmb_signupgender.SelectedIndexChanged += new System.EventHandler(this.signup_sex_SelectedIndexChanged);
            // 
            // cb_signupshowpassword
            // 
            this.cb_signupshowpassword.AutoSize = true;
            this.cb_signupshowpassword.Location = new System.Drawing.Point(631, 436);
            this.cb_signupshowpassword.Margin = new System.Windows.Forms.Padding(2);
            this.cb_signupshowpassword.Name = "cb_signupshowpassword";
            this.cb_signupshowpassword.Size = new System.Drawing.Size(101, 17);
            this.cb_signupshowpassword.TabIndex = 18;
            this.cb_signupshowpassword.Text = "Show password";
            this.cb_signupshowpassword.UseVisualStyleBackColor = true;
            this.cb_signupshowpassword.CheckedChanged += new System.EventHandler(this.cb_signupshowpassword_CheckedChanged);
            // 
            // llbl_login
            // 
            this.llbl_login.AutoSize = true;
            this.llbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_login.LinkColor = System.Drawing.Color.Black;
            this.llbl_login.Location = new System.Drawing.Point(684, 498);
            this.llbl_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbl_login.Name = "llbl_login";
            this.llbl_login.Size = new System.Drawing.Size(43, 17);
            this.llbl_login.TabIndex = 19;
            this.llbl_login.TabStop = true;
            this.llbl_login.Text = "Login";
            this.llbl_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_loginclick);
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.Location = new System.Drawing.Point(512, 498);
            this.lbl_account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(173, 17);
            this.lbl_account.TabIndex = 20;
            this.lbl_account.Text = "Already have an account?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 392);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "Confirm \r\nPassword";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_signupconfirmpassword
            // 
            this.txt_signupconfirmpassword.BackColor = System.Drawing.Color.Silver;
            this.txt_signupconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signupconfirmpassword.Location = new System.Drawing.Point(449, 407);
            this.txt_signupconfirmpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_signupconfirmpassword.Multiline = true;
            this.txt_signupconfirmpassword.Name = "txt_signupconfirmpassword";
            this.txt_signupconfirmpassword.PasswordChar = '*';
            this.txt_signupconfirmpassword.Size = new System.Drawing.Size(276, 25);
            this.txt_signupconfirmpassword.TabIndex = 22;
            // 
            // lbl_signupbirthday
            // 
            this.lbl_signupbirthday.AutoSize = true;
            this.lbl_signupbirthday.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signupbirthday.ForeColor = System.Drawing.Color.Black;
            this.lbl_signupbirthday.Location = new System.Drawing.Point(366, 208);
            this.lbl_signupbirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_signupbirthday.Name = "lbl_signupbirthday";
            this.lbl_signupbirthday.Size = new System.Drawing.Size(76, 21);
            this.lbl_signupbirthday.TabIndex = 23;
            this.lbl_signupbirthday.Text = "Birthday";
            // 
            // dtp_signupbirthday
            // 
            this.dtp_signupbirthday.CalendarForeColor = System.Drawing.Color.Silver;
            this.dtp_signupbirthday.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dtp_signupbirthday.CalendarTitleBackColor = System.Drawing.Color.Silver;
            this.dtp_signupbirthday.CalendarTitleForeColor = System.Drawing.Color.Silver;
            this.dtp_signupbirthday.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.dtp_signupbirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_signupbirthday.Location = new System.Drawing.Point(449, 204);
            this.dtp_signupbirthday.Name = "dtp_signupbirthday";
            this.dtp_signupbirthday.Size = new System.Drawing.Size(276, 26);
            this.dtp_signupbirthday.TabIndex = 24;
            // 
            // lbl_signupusername
            // 
            this.lbl_signupusername.AutoSize = true;
            this.lbl_signupusername.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signupusername.Location = new System.Drawing.Point(366, 330);
            this.lbl_signupusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_signupusername.Name = "lbl_signupusername";
            this.lbl_signupusername.Size = new System.Drawing.Size(83, 20);
            this.lbl_signupusername.TabIndex = 25;
            this.lbl_signupusername.Text = "Username";
            // 
            // txt_signupusername
            // 
            this.txt_signupusername.BackColor = System.Drawing.Color.Silver;
            this.txt_signupusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signupusername.Location = new System.Drawing.Point(450, 326);
            this.txt_signupusername.Margin = new System.Windows.Forms.Padding(2);
            this.txt_signupusername.Multiline = true;
            this.txt_signupusername.Name = "txt_signupusername";
            this.txt_signupusername.Size = new System.Drawing.Size(276, 25);
            this.txt_signupusername.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 526);
            this.Controls.Add(this.txt_signupusername);
            this.Controls.Add(this.lbl_signupusername);
            this.Controls.Add(this.dtp_signupbirthday);
            this.Controls.Add(this.lbl_signupbirthday);
            this.Controls.Add(this.txt_signupconfirmpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.llbl_login);
            this.Controls.Add(this.cb_signupshowpassword);
            this.Controls.Add(this.txt_signuppassword);
            this.Controls.Add(this.lbl_signuppassword);
            this.Controls.Add(this.cmb_signupgender);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_signupemail);
            this.Controls.Add(this.txt_signupage);
            this.Controls.Add(this.lbl_signupemail);
            this.Controls.Add(this.lbl_signupage);
            this.Controls.Add(this.txt_signupaddress);
            this.Controls.Add(this.lbl_signupname);
            this.Controls.Add(this.txt_signuplastname);
            this.Controls.Add(this.lbl_signupaddress);
            this.Controls.Add(this.txt_signupfirstname);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.lbl_registrationform);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label lbl_registrationform;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.TextBox txt_signupfirstname;
        private System.Windows.Forms.TextBox txt_signuplastname;
        private System.Windows.Forms.Label lbl_signupname;
        private System.Windows.Forms.Label lbl_signupaddress;
        private System.Windows.Forms.Label lbl_signupage;
        private System.Windows.Forms.Label lbl_signuppassword;
        private System.Windows.Forms.Label lbl_signupemail;
        private System.Windows.Forms.TextBox txt_signupaddress;
        private System.Windows.Forms.TextBox txt_signupage;
        private System.Windows.Forms.TextBox txt_signuppassword;
        private System.Windows.Forms.TextBox txt_signupemail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.ComboBox cmb_signupgender;
        private System.Windows.Forms.CheckBox cb_signupshowpassword;
        private System.Windows.Forms.LinkLabel llbl_login;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_signupconfirmpassword;
        private System.Windows.Forms.Label lbl_signupbirthday;
        private System.Windows.Forms.DateTimePicker dtp_signupbirthday;
        private System.Windows.Forms.Label lbl_signupusername;
        private System.Windows.Forms.TextBox txt_signupusername;
    }
}

