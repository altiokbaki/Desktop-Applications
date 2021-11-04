using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nesne2Lab_1
{
    public class User : Md5
    {
        private String username;
        private String password;

        public User(String username, String password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }


        public bool IsValid(string username, string password)
        {
            byte[] array = Encoding.ASCII.GetBytes(password);
            return this.Username.Equals(username) && this.password.Equals(Md5hash(array));
        }
    }
}