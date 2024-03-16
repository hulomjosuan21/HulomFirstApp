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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string getRes(char op, int num1, int num2)
        {
            int res = 0;

            switch (op)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
                default:
                    res = 0;
                    break;
            }
            
            return res.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(textBox1.Text.Trim());
                int num2 = Convert.ToInt32(textBox2.Text.Trim());
                Result res = new Result('+', num1, num2, getRes('+', num1, num2));
                res.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(textBox1.Text.Trim());
                int num2 = Convert.ToInt32(textBox2.Text.Trim());
                Result res = new Result('-', num1, num2, getRes('-', num1, num2));
                res.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(textBox1.Text.Trim());
                int num2 = Convert.ToInt32(textBox2.Text.Trim());
                Result res = new Result('*', num1, num2, getRes('*', num1, num2));
                res.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(textBox1.Text.Trim());
                int num2 = Convert.ToInt32(textBox2.Text.Trim());
                Result res = new Result('/', num1, num2, getRes('/', num1, num2));
                res.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
