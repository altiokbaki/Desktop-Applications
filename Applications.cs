using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nesne2Lab_1
{
    public partial class Applications : Form
    {
        public Applications()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            FormCalc clc1 = new FormCalc();
            clc1.Show();
            this.Hide();
        }

        private void Applications_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEncryption_Click(object sender, EventArgs e)
        {
            Encryption en1 = new Encryption();
            en1.Show();
            this.Hide();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            PositionGuesser pg1 = new PositionGuesser();
            pg1.Show();
            this.Hide();
        }
    }
}
