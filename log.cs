using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CodeKid
{
    public partial class log : Form
    {
        public static string selectedRole;
        public log()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin"; // Set the role
            NavigateToLoginPage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedRole = "Judge"; // Set the role
            NavigateToLoginPage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedRole = "Manager"; // Set the role
            NavigateToLoginPage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
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
        private void NavigateToLoginPage()
        {
            login loginPage = new login();
            loginPage.Show();
            this.Hide(); // Optionally hide the current form
        }

        private void log_Load(object sender, EventArgs e)
        {

        }
    }
}
