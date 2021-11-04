using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nesne2Lab_1
{
    
    public partial class PositionGuesser : Form
    {
        Coordinates c = new Coordinates();
        int left = -1024, downward = -1024, upward = 1024, right = 1024;

        public PositionGuesser()
        {
            InitializeComponent();
        }
        private void BtnWest_Click(object sender, EventArgs e)
        {
            right = c.x;
            c.West(c, left);
            textBox1.Text = c.PrintC(c);
        }
        private void BtnEast_Click(object sender, EventArgs e)
        {
            left = c.x;
            c.East(c, right);
            textBox1.Text = c.PrintC(c);
        }

        private void PositionGuesser_Load(object sender, EventArgs e)
        {
            textBox1.Text = "x: 0 y: 0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "x: 0 y: 0";
        }

        private void BtnNorth_Click(object sender, EventArgs e)
        {
            downward = c.y;
            c.North(c, upward);
            textBox1.Text = c.PrintC(c);
        }

        private void BtnSouth_Click(object sender, EventArgs e)
        {
            upward = c.y;
            c.South(c, downward);
            textBox1.Text = c.PrintC(c);
        }
        
        private void PositionGuesser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Applications app2 = new Applications();
            app2.Show();
            this.Hide();
        }
    }
}
