using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DiplomaClient
{
    class SecurityModule
    {
        /// <summary>
        /// Salt Generation Method
        /// </summary>
        /// <param name="size">Salt String Lenth</param>
        /// <returns>Salt String of Input Lenth value generated randomly</returns>
       public string GenerateSalt(int size)
       {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
       }
       /// <summary>
       /// Hash String Method
       /// </summary>
       /// <param name="input">string to hash</param>
       /// <param name="salt">salt string</param>
       /// <returns>Hash String</returns>
       public string GenerateSHA256Hash(string input, string salt)
       {
            var bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed obj = new SHA256Managed();
            var hash = obj.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
       }
    }
}
