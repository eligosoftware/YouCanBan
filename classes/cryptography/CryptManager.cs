using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace YouCanBan.classes.cryptography
{
    internal class CryptManager
    {

        public static void EncryptFile(string inputFile, string outputFile,string password)
        {
            using (Aes aesAlg = Aes.Create())
            {
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(password, 16); // 16 bytes for AES-128
                aesAlg.Key = keyDerivation.GetBytes(16); // 16 bytes for AES-128
                aesAlg.IV = keyDerivation.GetBytes(16); // 16 bytes IV for AES

                using (FileStream inputStream = new FileStream(inputFile, FileMode.Open))
                using (FileStream outputStream = new FileStream(outputFile, FileMode.Create))
                using (CryptoStream cryptoStream = new CryptoStream(outputStream, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    inputStream.CopyTo(cryptoStream);
                }
            }
        }

        public static void DecryptFile(string inputFile, string outputFile, string password)
        {
            using (Aes aesAlg = Aes.Create())
            {
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(password, 16); // 16 bytes for AES-128
                aesAlg.Key = keyDerivation.GetBytes(16); // 16 bytes for AES-128
                aesAlg.IV = keyDerivation.GetBytes(16); // 16 bytes IV for AES

                using (FileStream inputStream = new FileStream(inputFile, FileMode.Open))
                using (FileStream outputStream = new FileStream(outputFile, FileMode.Create))
                using (CryptoStream cryptoStream = new CryptoStream(inputStream, aesAlg.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(outputStream);
                }
            }
        }

    }
}
