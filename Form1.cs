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
        private Color[] listOfColor = { Color.Blue, Color.Red, Color.Green };
        private string[] texts = { "Tagal Labasan" , "Kaulion nako", "Absent ko ugma" };
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            _ = ChangePanelColorAsync();
        }
        private async Task ChangePanelColorAsync()
        {
            while (true)
            {
                int randomIndex = random.Next(0, listOfColor.Length);
                pnlColor.BackColor = listOfColor[randomIndex];
                pnlColor.Text = texts[randomIndex];
                await Task.Delay(800);
            }
        }
        private void btnBlue_Click(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.Blue;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            pnlColor.BackColor = Color.Green;
        }
    }
}
