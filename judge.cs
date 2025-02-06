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
    public partial class judge : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CodeKid.mdf;Integrated Security=True;Connect Timeout=30";
        private string loggedInJudgeEmail; // Store the logged-in judge's email
        private int loggedInJudgeId; // Store the logged-in judge's ID
        public judge(string email)
        {
            InitializeComponent();
            loggedInJudgeEmail = email;
        }

        private void judge_Load(object sender, EventArgs e)
        {
           


            // Fetch and display judge info (email and password)
            FetchAndDisplayJudgeInfo();

            // Load Player table into dataGridView1
            LoadPlayerTable();

            // Load Player ranks into dataGridView2
            LoadPlayerRanks();

            // Ensure proper column mapping for dataGridView2
            dataGridView2.AutoGenerateColumns = false; // Disable auto-generation of columns
            dataGridView2.Columns.Clear();

            // Add columns manually
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "player_id", // Map to the player_id field
                HeaderText = "Player ID",
                Name = "player_id"
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "rank", // Map to the rank field
                HeaderText = "Player Rank",
                Name = "rank"
            });

            // Refresh the data
            LoadPlayerRanks();
        }
        private void FetchAndDisplayJudgeInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT judge_id, judge_mail, password FROM judge WHERE judge_mail = @email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", loggedInJudgeEmail);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        loggedInJudgeId = Convert.ToInt32(reader["judge_id"]); // Store the judge ID
                        label1.Text = reader["judge_mail"].ToString(); // Display email in label1
                        label2.Text = reader["password"].ToString(); // Display password in label2
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching judge info: " + ex.Message);
            }
        }

        // Load Player table into dataGridView1
        private void LoadPlayerTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT player_id, player_name, player_age,score FROM player";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Player table: " + ex.Message);
            }
        }

        // Load Player ranks into dataGridView2
        private void LoadPlayerRanks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT r.player_id, r.rank 
                        FROM rank r
                        INNER JOIN judge j ON r.judge_id = j.judge_id
                        WHERE j.judge_mail = @email";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@email", loggedInJudgeEmail);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to dataGridView2
                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Player ranks: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO rank (judge_id, player_id, rank) VALUES (@judge_id, @player_id, @rank)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Get values from input fields
                    int playerId = int.Parse(textBox1.Text); // Player ID input
                    int playerRank = int.Parse(textBox2.Text); // Player Rank input

                    command.Parameters.AddWithValue("@judge_id", loggedInJudgeId);
                    command.Parameters.AddWithValue("@player_id", playerId);
                    command.Parameters.AddWithValue("@rank", playerRank);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Player rank added successfully.");
                    LoadPlayerRanks(); // Refresh the dataGridView2
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding player rank: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadPlayerRanks();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM rank WHERE player_id = @player_id AND judge_id = @judge_id";
                        SqlCommand command = new SqlCommand(query, connection);

                        // Get the selected row's player_id
                        int playerId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["player_id"].Value);
                        command.Parameters.AddWithValue("@player_id", playerId);
                        command.Parameters.AddWithValue("@judge_id", loggedInJudgeId);

                        // Execute the delete query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Player rank removed successfully.");
                            LoadPlayerRanks(); // Refresh the dataGridView2
                        }
                        else
                        {
                            MessageBox.Show("No matching record found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing player rank: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE rank SET rank = @rank WHERE player_id = @player_id AND judge_id = @judge_id";
                    SqlCommand command = new SqlCommand(query, connection);

                    int playerId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["player_id"].Value);
                    int playerRank = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["rank"].Value);

                    command.Parameters.AddWithValue("@rank", playerRank);
                    command.Parameters.AddWithValue("@player_id", playerId);
                    command.Parameters.AddWithValue("@judge_id", loggedInJudgeId);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Player rank updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating player rank: " + ex.Message);
            }
        }
    }
}

