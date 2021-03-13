using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.Helper
{
    internal static class Encryption
    {
        private static readonly string _rsaPublicKey;

        static Encryption()
        {
            _rsaPublicKey = GetRSAPublicKey();
        }

        private static (string KEY, string IV) GetAESKey()
        {
            Random random = new Random();
            var bytes = new Byte[16];
            random.NextBytes(bytes);
            var hexArray = Array.ConvertAll(bytes, x => x.ToString("X2"));
            var publicKeyString = String.Concat(hexArray);
            var key = publicKeyString.ToString();

            var bytesIV = new Byte[8];
            random.NextBytes(bytesIV);
            hexArray = Array.ConvertAll(bytesIV, x => x.ToString("X2"));
            var privateKeyString = String.Concat(hexArray);
            var iv = privateKeyString.ToString();

            return (key, iv);
        }

        private static string GetRSAPublicKey()
        {
            return System.IO.File.ReadAllText(Constants.ConstatKeyValues.PUBLIC_KEY_FILE_PATH);
        }

        internal static (string PrivateKey, string IV, string EncryptedData) AesEncryptData(this object input)
        {
            AesCryptography Aes = new AesCryptography();
            string pkey, iv;
            (pkey, iv) = GetAESKey();
            return (RsaCryptography.Encrypt(pkey, _rsaPublicKey), RsaCryptography.Encrypt(iv, _rsaPublicKey), Aes.SecuredString(input, pkey, iv));
        }
    }
}
