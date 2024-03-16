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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        public Result(char op,int num1 = 0, int num2 = 0, string res = null)
        {
            InitializeComponent();
            label1.Text = String.Format($"{num1} {op} {num2} = {res}");
        }
    }
}
