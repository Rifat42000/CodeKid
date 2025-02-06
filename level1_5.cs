using Microsoft.Scripting.Interpreter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeKid
{
  
    public partial class level1_5 : Form
    {
         
        public level1_5()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level l = new level();
            l.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void level1_5_Load(object sender, EventArgs e)
        {
            int currentPlayerId = SharedData.PlayerId;

            // Example: Update the player's score
            UpdatePlayerScore(currentPlayerId, 100); // Add 100 points to the player's score
        }
        private void UpdatePlayerScore(int playerId, int pointsToAdd)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CodeKid.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE player SET score = score + @pointsToAdd WHERE player_id = @playerId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@pointsToAdd", pointsToAdd);
                    command.Parameters.AddWithValue("@playerId", playerId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Score updated successfully! Added {pointsToAdd} points.");
                        }
                        else
                        {
                            MessageBox.Show("Player not found!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating score: " + ex.Message);
                    }
                }
            }
        }

    }
}

