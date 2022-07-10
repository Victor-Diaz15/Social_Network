using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.Helpers
{
    public static class PasswordEncryption
    {
        public static string ComputeSha256Hash(string password)
        {
            //Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                //Convert byte array to a string
                StringBuilder builder = new();
                foreach (byte by in bytes)
                {
                    builder.Append(by.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
