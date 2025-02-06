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
    public partial class scoretable : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CodeKid.mdf;Integrated Security=True;Connect Timeout=30";

        public scoretable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home h3 = new home();
            h3.Show();
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

        private void scoretable_Load(object sender, EventArgs e)
        {
            LoadPlayerScores();

            // Load player ranks into dataGridView2
            LoadPlayerRanks();

        }
        private void LoadPlayerScores()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT player_id, player_name, player_age, score 
                    FROM player";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataGridView1 == null)
                    {
                        MessageBox.Show("dataGridView1 is not initialized.");
                        return;
                    }

                    // Bind data properly
                    dataGridView1.DataSource = dataTable;

                    // Explicitly set column headers
                   // dataGridView1.Columns["player_id"].HeaderText = "Player ID";
                  //  dataGridView1.Columns["player_name"].HeaderText = "Player Name";
                   // dataGridView1.Columns["player_age"].HeaderText = "Player Age";
                  //  dataGridView1.Columns["score"].HeaderText = "Score";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error loading player scores: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading player scores: " + ex.Message);
            }
        }

        private void LoadPlayerRanks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM PlayerRanking"; // Use the view

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataGridView2 == null)
                    {
                        MessageBox.Show("dataGridView2 is not initialized.");
                        return;
                    }

                    dataGridView2.AutoGenerateColumns = false;
                   dataGridView2.Columns.Clear();

                    dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "player_id", HeaderText = "Player ID" });
                    dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "player_name", HeaderText = "Player Name" });
                    dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "player_age", HeaderText = "Player Age" });
                   dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "rank", HeaderText = "Rank" });

                   dataGridView2.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error loading player ranks: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading player ranks: " + ex.Message);
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
