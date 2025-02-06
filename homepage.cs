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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            info playPage = new info();
            playPage.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            log loog = new log();
            loog.Show();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            scoretable score = new scoretable();    
            score.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            learn learn = new learn();
            learn.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
