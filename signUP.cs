using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nesne2Lab_1
{
    public partial class signUP : Form
    {
        public signUP()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
  
            User user = new User(txtBoxUsername.Text, txtBoxPassword.Text);
            byte[] array = Encoding.ASCII.GetBytes(txtBoxPassword.Text);
            if (txtBoxUsername.Text != "" && txtBoxPassword.Text != "" && txtBoxConfirmpassword.Text == txtBoxPassword.Text)
            {
                signIN.userList.Add(new User(user.Username, user.Md5hash(array)));
                signIN signin1 = new signIN();
                signin1.Show();
                this.Hide();
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Passwords doesn't match";
            }
            
        }

        private void signUP_Load(object sender, EventArgs e)
        {

        }
    }
}
