using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HotelGestSystem.Aplication.Seguridad
{
    public class PasswordHelper
    {
        private const int SALTSIZE = 16;
        private const int HASHSIZE = 16;
        private const int ITERATIONS = 35000;
        


        public static byte[] GenerarSalt()
        {
            byte[] saltByte = RandomNumberGenerator.GetBytes(SALTSIZE);
            

            return saltByte;
        }


        public static string HashPassword(string password, byte[] salt)
        {         

            var hash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password), salt, ITERATIONS, HashAlgorithmName.SHA256, HASHSIZE);

            return Convert.ToBase64String(hash);          
            
                
            
        }


        public static bool VerificarPassword(string password, string hashStored, string saltStored)
        {
            var salt = Convert.FromBase64String(saltStored);

            var hashCompared = Rfc2898DeriveBytes.Pbkdf2(password, salt, ITERATIONS, HashAlgorithmName.SHA256, HASHSIZE);

            return CryptographicOperations.FixedTimeEquals(hashCompared, Convert.FromBase64String(hashStored));
        }

        
    }
}
