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
    public partial class admin : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CodeKid.mdf;Integrated Security=True;Connect Timeout=30";
        private string loggedInAdminEmail; // Store the logged-in admin's email
        public admin(string email)
        {
            InitializeComponent();
            loggedInAdminEmail = email;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            log log = new log();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            var result = MessageBox.Show("Are you sure you want to destroy the app?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The app has been destroyed");
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_Load(object sender, EventArgs e)
        {
           
            FetchAndDisplayAdminInfo();

            // Load judge information into dataGridView1
            LoadJudgeInfo();

            // Load system management information into dataGridView2
            LoadSystemManagementInfo();

        }
        private void FetchAndDisplayAdminInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT admin_email, password FROM admin WHERE admin_email = @email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", loggedInAdminEmail);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        label1.Text = reader["admin_email"].ToString(); // Display email in label1
                        label2.Text = reader["password"].ToString(); // Display password in label2
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching admin info: " + ex.Message);
            }
        }

        private void LoadJudgeInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT judge_id, judge_name, judge_mail FROM judge";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading judge information: " + ex.Message);
            }
        }

        private void LoadSystemManagementInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT manager_id, manager_name, manager_email FROM sys_manager";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading system management information: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
