using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordVault
{
    public static class CryptClass
    {
        private static string strKey = "nT9EcymsFFtAPnhG7YOyBO8f3U3AKJnqTEv5sqhan0Y="; // Encryption key
        private static string strIv = "ArJykA1WJwsmWcgWl389tg=="; // Initialisation vector
        private static string passwordHashed = "436D6F2548D591A8D1EF477CDB51274D46E4555103C489BE5E8CA517638E083B"; // Hashed password of the app

        /// <summary>
        /// Encrypts the data with the rijndael algorithm
        /// </summary>
        /// <param name="clearText">Text to encrypt</param>
        /// <returns>Encrypted text</returns>
        public static string EncryptString(string clearText)
        {
            byte[] encArray;
            RijndaelManaged algo = new RijndaelManaged();
            algo.Key = Convert.FromBase64String(strKey);
            algo.IV = Convert.FromBase64String(strIv);
            ICryptoTransform encryptor = algo.CreateEncryptor(algo.Key, algo.IV);
            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

            using (StreamWriter Encrypt = new StreamWriter(csEncrypt))
            {
                Encrypt.Write(clearText);
            }
            encArray = msEncrypt.ToArray();

            return Convert.ToBase64String(encArray);
        }

        /// <summary>
        /// Decrypts the data with the rijndael algorithm
        /// </summary>
        /// <param name="cryptedText">Text to decrypt</param>
        /// <returns>Decrypted text</returns>
        public static string DecryptString(string cryptedText)
        {
            byte[] cryptedbytes = Convert.FromBase64String(cryptedText);
            string plaintext = null;
            RijndaelManaged algo = new RijndaelManaged();

            algo.Key = Convert.FromBase64String(strKey);
            algo.IV = Convert.FromBase64String(strIv);
            ICryptoTransform decryptor = algo.CreateDecryptor(algo.Key, algo.IV);
            MemoryStream msDecrypt = new MemoryStream(cryptedbytes);

            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);

            using (StreamReader Decrypt = new StreamReader(csDecrypt))
            {
                plaintext = Decrypt.ReadToEnd();
            }
            return plaintext;
        }

        /// <summary>
        /// Compares the hashed password with the password that the user entered
        /// </summary>
        /// <param name="password">Password to compare</param>
        /// <returns>True if the password is correct and false if it doesn't corresponds</returns>
        public static bool Login(string password)
        {
            if (GetHashString(password) == passwordHashed)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Hash a string
        /// </summary>
        /// <param name="inputString">String to hash</param>
        /// <returns>String hashed as bytes</returns>
        private static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        /// <summary>
        /// Uses the GetHash method and converts the result to string
        /// </summary>
        /// <param name="inputString">String to hash</param>
        /// <returns>String hashed as a string</returns>
        private static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
