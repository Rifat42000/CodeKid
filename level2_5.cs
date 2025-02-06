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
    public partial class level2_5 : Form
    {
        public level2_5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
