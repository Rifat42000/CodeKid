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
    public partial class level3 : Form
    {
        public level3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            level level = new level();
            this.Hide();
            level.Show();
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
