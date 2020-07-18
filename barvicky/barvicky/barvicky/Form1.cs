using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barvicky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void michani()
        {
            lblRed.Text = red.Value.ToString();
            lblGreen.Text = green.Value.ToString();
            lblBlue.Text = blue.Value.ToString();
            panel1.BackColor = Color.FromArgb(red.Value, green.Value, blue.Value);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            michani();
        }

        private void red_Scroll(object sender, ScrollEventArgs e)
        {
            michani();
        }

        private void green_Scroll(object sender, ScrollEventArgs e)
        {
            michani();
        }

        private void blue_Scroll(object sender, ScrollEventArgs e)
        {
            michani();
        }
    }
}
