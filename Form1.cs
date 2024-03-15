using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HulomFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.Blue;
            pnlColor.Text = "Blue";
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.Red;
            pnlColor.Text = "Red";
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.Green;
            pnlColor.Text = "Green";
        }
    }
}
