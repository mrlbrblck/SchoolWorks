using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.SqlClient;

namespace activity_1
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\UIS\SchoolWorks\C++_GUIproject\PRE-LIM_ANAZARIO\activity_1\SQL\LoginData.mdf;Integrated Security=True;Connect Timeout=30");

        public const int WM_NCLBUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_sex_Click(object sender, EventArgs e)
        {

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void signup_sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_signin(object sender, EventArgs e)
        {
            {
                if (txt_signupemail.Text == "" || txt_signupusername.Text == ""
                    || txt_signuppassword.Text == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            String checkUsername = "SELECT * FROM admin WHERE username = '"
                                + txt_signupusername.Text.Trim() + "'"; // admin is our table name

                            using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count >= 1)
                                {
                                    MessageBox.Show(txt_signupusername.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string insertData = "INSERT INTO admin (email, username, password, date_created) " +
                                        "VALUES(@email, @username, @pass, @date)";

                                    DateTime date = DateTime.Today;

                                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                    {
                                        cmd.Parameters.AddWithValue("@email", txt_signupemail.Text.Trim());
                                        cmd.Parameters.AddWithValue("@username", txt_signupusername.Text.Trim());
                                        cmd.Parameters.AddWithValue("@pass", txt_signuppassword.Text.Trim());
                                        cmd.Parameters.AddWithValue("@date", date);

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // TO SWITCH THE FORM 
                                        Form1 lForm = new Form1();
                                        lForm.Show();
                                        this.Hide();
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }

                }
            }

        }

        private void llbl_loginclick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 sForm = new Form2();
            sForm.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_signupshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cb_signupshowpassword.Checked)
                {
                    txt_signuppassword.PasswordChar = '\0';
                    txt_signupconfirmpassword.PasswordChar = '\0';
                }
                else
                {
                    txt_signuppassword.PasswordChar = '*';
                    txt_signupconfirmpassword.PasswordChar = '*';
                }
            }
        }
    }
}
    

