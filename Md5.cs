using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Nesne2Lab_1
{
    public class Md5
    {
        public string Md5hash(byte[] value)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var hash = md5.ComputeHash(value);
                return Convert.ToBase64String(hash);
            }
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(value.ToString());
            return Md5hash(passtohash);
        }
    }
}