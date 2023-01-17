using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Security.Cryptography;

namespace ConsoleApp8
{

    public class BlockRsaEngine
    {

        private readonly IAsymmetricBlockCipher _engine;

        private readonly Encoding _encoding;


        public BlockRsaEngine(Encoding encoding)
        {
            _engine = new RsaEngine();
            _encoding = encoding;
        }


        public (string, string) Encrypt(string textToEncrypt, AsymmetricKeyParameter key)
        {
            byte[] result = BouncyCastleCrypto(true, _encoding.GetBytes(textToEncrypt), key);
            return (Convert.ToBase64String(result), string.Join("", result.Select(c => ((int)c).ToString("X2"))));
        }


        public string Decrypt(string base64ToDecrypt, AsymmetricKeyParameter key)
        {
            byte[] result = BouncyCastleCrypto(false, Convert.FromBase64String(base64ToDecrypt), key);

            return _encoding.GetString(result);
        }


        private byte[] BouncyCastleCrypto(bool forEncrypt, byte[] input, AsymmetricKeyParameter key)
        {
            try
            {
                _engine.Init(forEncrypt, key);
                return _engine.ProcessBlock(input, 0, input.Length);
            }
            catch (CryptoException ex)
            {
                throw new CryptoException($"Exception during RSA Encryption/Decryption - error: {ex.Message}");
            }
        }


        public AsymmetricKeyParameter ReadPublicKey(string publicKeyFileName)
        {
            using var reader = File.OpenText(publicKeyFileName) ;
            Console.WriteLine(reader.ReadToEnd());
            return (AsymmetricKeyParameter)new PemReader(reader).ReadObject();
        }


        public AsymmetricKeyParameter ReadPrivateKey(string privateKeyFileName)
        {
            using var reader = File.OpenText(privateKeyFileName);
            Console.WriteLine(reader.ReadToEnd());

            return ((AsymmetricCipherKeyPair)new PemReader(reader, new PasswordFinder()).ReadObject())?.Private;
        }


        public (AsymmetricKeyParameter, AsymmetricKeyParameter) GenerateKeys()
        {
            //RSA key pair constructor 
            RsaKeyPairGenerator keyGenerator = new RsaKeyPairGenerator();
            // RSA key constructor parameters 
            RsaKeyGenerationParameters param = new RsaKeyGenerationParameters(
                Org.BouncyCastle.Math.BigInteger.ValueOf(3),
                new Org.BouncyCastle.Security.SecureRandom(),
                1024, //key length 
                25);

            // Initialize the key constructor with parameters 
            keyGenerator.Init(param);
            AsymmetricCipherKeyPair keyPair = keyGenerator.GenerateKeyPair();
            return (keyPair.Private, keyPair.Public);
        }
    }
}