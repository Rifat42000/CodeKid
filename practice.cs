using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeKid
{
    public partial class practice : Form
    {
        private ScriptEngine pythonEngine;
        private ScriptScope pythonScope; public practice()
        {
            InitializeComponent();
            pythonEngine = Python.CreateEngine(); // Initialize IronPython engine
            pythonScope = pythonEngine.CreateScope(); // Create a scope for variables
        }

        private void practice_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            level level = new level();
            this.Hide();
            level.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string script = textBox1.Text;
                textBox2.Clear();
                ExecutePythonScript(script);
            }
            catch (Exception ex)
            {
                textBox2.Text = $"Error: {ex.Message}";
            }
        }

        private void ExecutePythonScript(string script)
        {
            try
            {
                // Redirect IronPython's output to the textBox2
                var memoryStream = new System.IO.MemoryStream();
                var outputWriter = new System.IO.StreamWriter(memoryStream);
                pythonEngine.Runtime.IO.SetOutput(memoryStream, outputWriter);

                // Execute the script
                pythonEngine.Execute(script, pythonScope);

                // Read the output and display it in textBox2
                outputWriter.Flush();
                memoryStream.Position = 0;
                using (var reader = new System.IO.StreamReader(memoryStream))
                {
                    textBox2.AppendText(reader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                textBox2.AppendText($"Error: {ex.Message}\n");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
