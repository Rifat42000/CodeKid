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
    public partial class level1 : Form
    {
        public level1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            level level = new level();
            level.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            level1_1cs l1 = new level1_1cs();   
            l1.Show();  
            this.Hide();
        }

        private void level1_Load(object sender, EventArgs e)
        {

        }
    }
}
