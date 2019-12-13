using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SaltHashOutput
{
    public class Hash
    {
        // Additive Hashing
        public string AdditiveHashing(string value)
        {
            // Converts string in Bytes
            byte[] ascii = Encoding.ASCII.GetBytes(value);
            StringBuilder additive = new StringBuilder();
            // for each byte convert to string
            foreach (Byte b in ascii)
            {
                string s = b.ToString();
                additive.Append(s);
            }
            return additive.ToString();

        }

        //public string FoldingHashing(string value)
        //{
            // TODO
            // Split string into chunks of 4 chararcters
            // Obtain remaining chunk if the inputed string is not divisable by 4
            // Convert each chunk into a string and add to output string
           
        //}

        public string SHA256HashingNoSalt(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public string SHA256HashingWithSalt(string value)
        {
            string salt = value + DateTime.Now.ToString();

            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(salt));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }

        }
    }
}
