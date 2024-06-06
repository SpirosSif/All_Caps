using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_Caps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void conv_Click(object sender, EventArgs e)
        {
            output.Text = input.Text.ToUpper();
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
