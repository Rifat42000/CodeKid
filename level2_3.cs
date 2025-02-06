using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeKid
{
    public partial class level2_3 : Form
    {
        private int lives = 3; // Total lives
        private PictureBox[] lifeIcons; // Array to store life PictureBox controls
        private int timeLeft = 300; // 5 minutes = 300 seconds
        private Timer countdownTimer;
        public level2_3()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            // Initialize Timer
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second interval
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--; // Decrease time by 1 second

            // Update the label showing remaining time
            label1.Text = $"Time Left: {timeLeft / 60:D2}:{timeLeft % 60:D2}"; // Format as MM:SS

            if (timeLeft <= 0)
            {
                countdownTimer.Stop();
                MessageBox.Show("Time's up!");
                level2_5 l5 = new level2_5();
                this.Hide();
                l5.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Display a confirmation message box
            var result = MessageBox.Show("Are you sure you want to give up?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                level l = new level();
                l.Show();
                this.Hide();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear previous output
            textBox2.Clear();

            // Retrieve the Python code from textBox1
            string userCode = textBox1.Text;

            // Check if the code contains the required operators
            bool hasAddition = userCode.Contains("+");
            bool hasSubtraction = userCode.Contains("-");
            bool hasMultiplication = userCode.Contains("*");
            bool hasDivision = userCode.Contains("/");

            if (hasAddition && hasSubtraction && hasMultiplication && hasDivision)
            {
                try
                {
                    // Create a Python engine and scope
                    var engine = Python.CreateEngine();
                    var scope = engine.CreateScope();

                    // Redirect Python's standard output to capture print statements
                    using (var memoryStream = new MemoryStream())
                    using (var streamWriter = new StreamWriter(memoryStream))
                    {
                        engine.Runtime.IO.SetOutput(memoryStream, Encoding.UTF8);

                        // Execute the Python code
                        engine.Execute(userCode, scope);

                        // Flush and retrieve the printed output
                        streamWriter.Flush();
                        memoryStream.Position = 0;
                        using (var streamReader = new StreamReader(memoryStream))
                        {
                            string output = streamReader.ReadToEnd();
                            textBox2.Text = output;

                            // If the code executes successfully and contains all operators, it's correct
                            MessageBox.Show("Correct Answer! Moving to the next level.");
                            var nextPage = new level2_4(); 
                            nextPage.Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle compilation or runtime errors in the Python code
                    textBox2.Text = $"Error: {ex.Message}";
                    HandleIncorrectAnswer();
                }
            }
            else
            {
                // If any operator is missing, show an error
                textBox2.Text = "Incorrect Answer. Your code must include +, -, *, and / operators.";
                HandleIncorrectAnswer();
            }
        }

        private void level2_3_Load(object sender, EventArgs e)
        {
            lifeIcons = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4 };
            UpdateLivesDisplay();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void UpdateLivesDisplay()
        {
            // Update visibility of life icons based on remaining lives
            for (int i = 0; i < lifeIcons.Length; i++)
            {
                lifeIcons[i].Visible = i < lives;
            }
        }
        private void HandleIncorrectAnswer()
        {
            lives--;
            if (lives > 0)
            {
                UpdateLivesDisplay();
              //  MessageBox.Show($"Wrong Answer! Lives remaining: {lives}");
            }
            else
            {
                UpdateLivesDisplay();
                MessageBox.Show("Game Over! No lives left.");
                level2_5 l5 = new level2_5();
                this.Hide();
                l5.Show();
            }
        }
    }
}
