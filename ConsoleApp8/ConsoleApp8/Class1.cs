using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Class1
    {
        /// <summary>
        /// Encrypts the decrypt text by RSA.
        /// </summary>
        public static void EncryptDecryptTextByRsa()
        {
            try
            {
                string plain = "mohammed sajid";
                BlockRsaEngine blockRsaEngine = new BlockRsaEngine(Encoding.UTF8);

                //Generate new private/public key.
                //var generatedKeys = blockRsaEngine.GenerateKeys();
                
                // use existing private/public key.
                AsymmetricKeyParameter publicKey = blockRsaEngine.ReadPublicKey(@"C:\Users\kush.pachghare\source\repos\Keys\Combined.txt"); 
                AsymmetricKeyParameter privateKey = blockRsaEngine.ReadPrivateKey(@"C:\Users\kush.pachghare\source\repos\Keys\Combined.txt");

                Console.WriteLine("*******************************Encryption******************************");

                var encryptedPlain = blockRsaEngine.Encrypt(plain, publicKey);
                Console.WriteLine($"Encrypted text : {plain} - by publicKey is :");
                Console.WriteLine($"For Hex : {Environment.NewLine}{encryptedPlain.Item2.ToLower()}");
                Console.WriteLine($"For Base64 : {Environment.NewLine}{encryptedPlain.Item1}");

                Console.WriteLine("*******************************Decryption*******************************");

                string decryptedPlain = blockRsaEngine.Decrypt(encryptedPlain.Item1, privateKey).ToLower();
                Console.WriteLine($"Decrypted base64 : {encryptedPlain.Item1}, by privateKey is : {decryptedPlain}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
