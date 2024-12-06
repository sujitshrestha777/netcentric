using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Result : Form
    {
        public Result(string result)
        {
            InitializeComponent();
            this.label1.Text = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
