using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordVault
{
    public static class CryptClass
    {
        private static string strKey = "l+Ayx12DPDHopitXD4VTfQ=="; // Encryption key
        private static string strIv = "+4n3xhu3sr4BO6fU0PKrGg=="; // Initialisation vector
        private static string passwordHashed = "436D6F2548D591A8D1EF477CDB51274D46E4555103C489BE5E8CA517638E083B"; // Hashed password of the app

        /// <summary>
        /// Encrypts the data with the rijndael algorithm
        /// </summary>
        /// <param name="clearText">Text to encrypt</param>
        /// <returns>Encrypted text</returns>
        public static string EncryptString(string clearText)
        {
            // Converts text to bytes
            byte[] plainText = Encoding.UTF8.GetBytes(clearText);

            // Converts key string to bytes
            byte[] key = Encoding.UTF8.GetBytes(strKey);

            // Converts iv string to bytes
            byte[] iv = Encoding.UTF8.GetBytes(strIv);


            RijndaelManaged rijndael = new RijndaelManaged();

            // Defines the used mode
            rijndael.Mode = CipherMode.CBC;

            // Creates the AES - Rijndael encryptor
            ICryptoTransform aesEncryptor = rijndael.CreateEncryptor(key, iv);

            MemoryStream ms = new MemoryStream();

            // Writes encrypted data in MemoryStream
            CryptoStream cs = new CryptoStream(ms, aesEncryptor, CryptoStreamMode.Write);
            cs.Write(plainText, 0, plainText.Length);
            cs.FlushFinalBlock();


            // Converts encrypted data to an array
            byte[] CipherBytes = ms.ToArray();


            ms.Close();
            cs.Close();

            // Convert encrypted data to string
            return Convert.ToBase64String(CipherBytes);
        }

        /// <summary>
        /// Decrypts the data with the rijndael algorithm
        /// </summary>
        /// <param name="cipherText">Text to decrypt</param>
        /// <returns>Decrypted text</returns>
        public static string DecryptString(string cipherText)
        {
            // Converts text to bytes
            byte[] cipheredData = Convert.FromBase64String(cipherText);

            // Converts key string to bytes
            byte[] key = Encoding.UTF8.GetBytes(strKey);

            // Converts iv string to bytes
            byte[] iv = Encoding.UTF8.GetBytes(strIv);

            RijndaelManaged rijndael = new RijndaelManaged();
            rijndael.Mode = CipherMode.CBC;


            // Writes decrypted data in MemoryStream
            ICryptoTransform decryptor = rijndael.CreateDecryptor(key, iv);
            MemoryStream ms = new MemoryStream(cipheredData);
            CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);

            // Converts decrypted data to an array
            byte[] plainTextData = new byte[cipheredData.Length];

            int decryptedByteCount = cs.Read(plainTextData, 0, plainTextData.Length);


            ms.Close();
            cs.Close();

            // Returns the decrypted data as a string
            return Encoding.UTF8.GetString(plainTextData, 0, decryptedByteCount);
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
