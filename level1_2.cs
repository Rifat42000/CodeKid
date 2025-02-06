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
    public partial class level1_2 : Form
    {
        private int lives = 3; // Total lives
        private int timeLeft = 300; // 2 minutes = 120 seconds
        private Timer countdownTimer; // Timer for countdown
        private PictureBox[] lifeIcons;

        private int button2ClickCount = 0;
        public level1_2()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            // Initialize the countdown timer
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1-second interval
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
                countdownTimer.Stop(); // Stop the timer
                MessageBox.Show("Time's up!"); // Notify the user
                level1_6 l6 = new level1_6(); // Transition to level 1-6
                this.Hide();
                l6.Show();
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
            // If "No" 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

            try
            {
                // Get the code written by the user in textBox1
                string userCode = textBox1.Text.Trim();

                // Clear the output box (textBox2)
                textBox2.Clear();

                if (!string.IsNullOrEmpty(userCode))
                {
                    // Execute the Python code
                    var output = ExecutePythonCode(userCode);
                    textBox2.Text = output;
                    // Check if the output contains "go left"
                    if (output.Trim() == "go right")
                    {
                        // Success: correct command
                        MessageBox.Show("Monkey moved to right", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Transition to the next level
                        level1_3 l2 = new level1_3();
                        l2.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Incorrect command
                        textBox2.AppendText("Error! . Hint: Try print(\"go ...\").\n");
                        HandleIncorrectAnswer();
                    }
                }
                else
                {
                    // No code entered
                    textBox2.AppendText("Error: No code entered.\n");
                }
            }
            catch (Exception ex)
            {
                // Display unexpected errors
                textBox2.AppendText($"Error: {ex.Message}\n");
            }
        }

        private string ExecutePythonCode(string code)
        {
            try
            {
                // Create the Python engine
                var engine = Python.CreateEngine();

                // Redirect the output stream to capture printed text
                using (var outputStream = new MemoryStream())
                using (var errorStream = new MemoryStream())
                {
                    engine.Runtime.IO.SetOutput(outputStream, Encoding.UTF8);
                    engine.Runtime.IO.SetErrorOutput(errorStream, Encoding.UTF8);

                    // Execute the Python code
                    engine.Execute(code);

                    // Retrieve and return the standard output
                    outputStream.Position = 0;
                    using (var reader = new StreamReader(outputStream))
                    {
                        string standardOutput = reader.ReadToEnd();
                        return standardOutput;
                    }
                }
            }
            catch (Exception ex)
            {
                // Return the error message if the code fails
                return $"Error: {ex.Message}";
            }
        }


        private void HandleIncorrectAnswer()
        {
            lives--; // Deduct one life
            UpdateLivesDisplay();
            if (lives > 0) // Lives remaining
            {
               
            }
            else // No lives left
            {
                countdownTimer.Stop(); // Stop the timer
                MessageBox.Show("Game Over! No lives left.");
                level1_6 l6 = new level1_6();
                this.Hide();
                l6.Show();
            }
        }
        private void UpdateLivesDisplay()
        {
            // Update visibility of life icons based on remaining lives
            for (int i = 0; i < lifeIcons.Length; i++)
            {
                lifeIcons[i].Visible = i < lives;
            }
        }
        

        private void level1_2_Load(object sender, EventArgs e)
        {


            lifeIcons = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4 };
            UpdateLivesDisplay();
        }
    }
}
