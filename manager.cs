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
using Microsoft.Scripting.Utils;

namespace CodeKid
{
    public partial class manager : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CodeKid.mdf;Integrated Security=True;Connect Timeout=30";
        private string loggedInUserEmail; // Store the logged-in user's email 
        public manager(string email)
        {
            InitializeComponent();
            loggedInUserEmail = email;
        }

        private void manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'codeKidDataSet11.judge' table. You can move, or remove it, as needed.
           
            FetchAndDisplayUserInfo();

            // Load Player table into dataGridView1
            LoadPlayerTable();

            // Load Judge table into dataGridView2
            LoadJudgeTable();

        }
        private void FetchAndDisplayUserInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT manager_email, password FROM sys_manager WHERE manager_email = @email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", loggedInUserEmail);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        label1.Text = reader["manager_email"].ToString(); // Display email in label1
                        label2.Text = reader["password"].ToString(); // Display password in label2
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching user info: " + ex.Message);
            }
        }

        private void LoadPlayerTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT player_id, player_name, player_age, score FROM player";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Player table: " + ex.Message);
            }
        }

        private void LoadJudgeTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT judge_id, judge_name, judge_mail,password FROM judge";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Assuming you have another DataGridView named dataGridView2
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Judge table: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login l2 =  new login();
            this.Hide();
            l2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
