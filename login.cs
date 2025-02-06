using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CodeKid
{
    public partial class login : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CodeKid.mdf;Integrated Security=True;Connect Timeout=30";
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
             log log = new log();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = ValidateCredentials(username, password);

            if (!string.IsNullOrEmpty(role))
            {
                RedirectToRolePage(role);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateCredentials(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to check credentials in admin, sys_manager (Manager), and judge tables
                    string query = @"
                        SELECT 'Admin' AS Role FROM admin WHERE admin_email = @Email AND password = @Password
                        UNION
                        SELECT 'Manager' AS Role FROM sys_manager WHERE manager_email = @Email AND password = @Password
                        UNION
                        SELECT 'Judge' AS Role FROM judge WHERE judge_mail = @Email AND password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();
                        return result?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        public void RedirectToRolePage(string role)
        {
            Form rolePage;
            string email = textBox1.Text; // Get the email/username from the login form

            switch (role)
            {
                case "Admin":
                    rolePage = new admin(email); // Pass email to the admin form
                    break;
                case "Manager":
                    rolePage = new manager(email); // Pass email to the manager form
                    break;
                case "Judge":
                    rolePage = new judge(email); // Pass email to the judge form
                    break;
                default:
                    MessageBox.Show("Unknown role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            rolePage.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
