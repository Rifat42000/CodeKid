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
    public partial class level : Form
    {
        public level()
        {
            InitializeComponent();
        }

        private void level_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            level1 level1 = new level1();
            level1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            info i1 = new info();
            i1.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            level2 level2 = new level2();
            level2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            level3 level3 = new level3();
            level3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            practice practice = new practice();
            practice.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
