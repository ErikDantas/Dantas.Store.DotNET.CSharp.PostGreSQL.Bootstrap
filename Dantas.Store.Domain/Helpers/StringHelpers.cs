using System;
using System.Security.Cryptography;
using System.Text;

namespace Dantas.Store.Domain.Helpers
{
    public static class StringHelpers
    {
        public static string Encrypt(this string password)
        {
            var salt = "|D6057D452A5C4F668DD90A04BAA3EF05DCF07304E4A04611902823E9E615FCF0";
            var arrayBytes = Encoding.UTF8.GetBytes(password + salt);

            byte[] HashBytes;
            using (var sha = SHA512.Create())
            {
                HashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(HashBytes);
        }
    }
}
