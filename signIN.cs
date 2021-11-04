using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne2Lab_1
{
    public partial class signIN : Form
    {
        public static List<User> userList = new List<User>();
        public signIN()
        {
            InitializeComponent();

            userList.Add(new User("Deniz", "uOsbU9NkB7xdlsR9evbiPQ=="));    //152120141016
            userList.Add(new User("Baki", "QooH5DWo2/VAUtokG80AWg=="));     //152120151055
        }
        public void signIN_Load(object sender, EventArgs e)
        {

        }

        public void btnSignup_Click(object sender, EventArgs e)
        {
            signUP signup1 = new signUP();
            signup1.Show();
            this.Hide();
        }

        public void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            for (int i = 0; i < userList.Count; i++)
            {
                User user = userList[i];

                if (user.IsValid(username, password))
                {
                    lblSuccess.Text = "Success";
                    lblSuccess.ForeColor = Color.Green;

                    Applications app1 = new Applications();
                    app1.Show();
                    this.Hide();
                    return;
                }
            }
            lblSuccess.Text = "Failure";
            lblSuccess.ForeColor = Color.Red;
        }
    }
}
    

