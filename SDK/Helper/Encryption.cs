using System;
using System.Collections.Generic;
using System.IO;
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
            var path = AppConfiguration.AbsolutePublicKeyFileName;
            if (path.StartsWith("~/"))
            {
                var webroot = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                path = Path.Combine(webroot, path.Replace("~/", ""));
            }
            if (!File.Exists(path))
                throw new SdkException($"The file was not found in the following path :{path}");
            return System.IO.File.ReadAllText(path);
        }

        internal static (string PrivateKey, string IV, string EncryptedData) AesEncryptData(this object input)
        {
            if (input == null)
                throw new SdkException("Input argument is null or empty!");
            AesCryptography Aes = new AesCryptography();
            string pkey, iv;
            (pkey, iv) = GetAESKey();
            return (RsaCryptography.Encrypt(pkey, _rsaPublicKey), RsaCryptography.Encrypt(iv, _rsaPublicKey), Aes.SecuredString(input, pkey, iv));
        }
    }
}
