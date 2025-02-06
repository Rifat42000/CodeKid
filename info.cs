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
    public partial class info : Form
    {
        private HashSet<int> generatedIds = new HashSet<int>(); // Stores generated IDs to ensure uniqueness
        public static  int playerId; // Stores the generated player ID
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CodeKid.mdf;Integrated Security=True;Connect Timeout=30";
        public  string playerName = ""; // Stores the name from textBox2
        private int playerAge = 0; // Stores the age from textBox1

        public info()
        {
            InitializeComponent();
            GenerateAndDisplayId();
        }
        private void GenerateAndDisplayId()
        {
            int newId;
            Random random = new Random();

            do
            {
                newId = random.Next(1000, 9999); // Generate a random ID between 1000 and 9999
            } while (generatedIds.Contains(newId)); // Ensure the ID is unique

            generatedIds.Add(newId); // Add the new ID to the HashSet
            SharedData.PlayerId = newId; // Store the new ID in the SharedData class

            label1.Text = $"{SharedData.PlayerId}"; // Display the ID in label1
        }

        private void SaveToDatabase(string name, int age)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO player (player_id, player_name, player_age) VALUES (@player_id, @player_name, @player_age)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@player_id", SharedData.PlayerId);
                        command.Parameters.AddWithValue("@player_name", name);
                        command.Parameters.AddWithValue("@player_age", age);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Data saved successfully! Your ID is {SharedData.PlayerId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void info_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int age))
            {
                SharedData.PlayerAge = age; // Update player age in SharedData
            }
            else
            {
                SharedData.PlayerAge = 0; // Reset to 0 if the input is invalid
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GenerateAndDisplayId();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            int age;

            // Validate user input
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the data to the database
            SaveToDatabase(name, age);

            // Store the player name and age in the SharedData class
            SharedData.PlayerName = name;
            SharedData.PlayerAge = age;

            // Navigate to the level form
            level level = new level();
            level.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SharedData.PlayerName = textBox2.Text.Trim();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
