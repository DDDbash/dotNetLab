using System;
using System.Text;

namespace XORCipher
{
    class Program
    {
        static void Main()
        {
            string plainText = Input("Plaintext: ");
            char key = char.Parse(Input("Key: "));
            XORCipher(plainText, key);
        }

        private static void XORCipher(string plainText, char key)
        {
            string cipherText = Encrypt(plainText, key);
            Decrypt(cipherText, key);
        }

        private static void Decrypt(string cipherText, char key)
        {
            string decryptedText = XORDecryption(cipherText, key);
            Console.WriteLine($"Decrypted text:\n{decryptedText}");
        }

        private static string Encrypt(string plainText, char key)
        {
            string cipherText = XOREncryption(plainText, key);
            Console.WriteLine($"Encrypted text:\n{cipherText}");
            return cipherText;
        }

        private static string XORDecryption(string cipherText, char key)
        {
            return XOREncryption(cipherText, key);
        }

        private static string XOREncryption(string plainText, char key)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char character in plainText)
                sb.Append((char)(character ^ key));
            return sb.ToString();
        }

        private static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}