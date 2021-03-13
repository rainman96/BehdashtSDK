using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ditas.SDK.Helper
{
    internal class AesCryptography
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jsonData"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns>SecuredData</returns>
        internal string SecuredString(string jsonData, string Key, string IV)
        {
            Data data_Key = new Data(Key, Encoding.UTF8);
            Data data_IV = new Data(IV, Encoding.UTF8);
            string plainText = DeserializeObject2String(RuntimeHelpers.GetObjectValue(jsonData));
            byte[] result = this.EncryptStringToBytes_Aes(plainText, data_Key.Bytes, data_IV.Bytes);
            string base64String = Convert.ToBase64String(result);
            return base64String;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns></returns>
        internal string SecuredString(object Data, string Key, string IV)
        {
            Data data_Key = new Data(Key, Encoding.UTF8);
            Data data_IV = new Data(IV, Encoding.UTF8);
            string plainText = DeserializeObject2String(RuntimeHelpers.GetObjectValue(Data));
            byte[] result = this.EncryptStringToBytes_Aes(plainText, data_Key.Bytes, data_IV.Bytes);
            string base64String = Convert.ToBase64String(result);
            return base64String;
        }


        internal string UnSecuredString(string SecuredTextBase64, string Key, string IV)
        {
            Data data_Key = new Data(Key, Encoding.UTF8);
            Data data_IV = new Data(IV, Encoding.UTF8);
            byte[] temp = Convert.FromBase64String(SecuredTextBase64);
            string result = this.DecryptStringFromBytes_Aes(temp, data_Key.Bytes, data_IV.Bytes);
            return result;
        }

        private byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            byte[] encrypted;

            // Create an Aes object with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key,
                                                                    aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt,
                                                                     encryptor,
                                                                     CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt, new UTF8Encoding()))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }

                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }


        private string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold the decrypted text.
            string plaintext = null;

            // Create an Aes object with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key,
                                                                    aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                                                                     decryptor,
                                                                     CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt, new UTF8Encoding()))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }


        private static string DeserializeObject2String(object o)
        {
            string result;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(o.GetType());
                MemoryStream memoryStream = new MemoryStream();
                xmlSerializer.Serialize(memoryStream, RuntimeHelpers.GetObjectValue(o));
                string @string = Encoding.UTF8.GetString(memoryStream.GetBuffer());
                result = @string;
            }
            catch (Exception innerException)
            {
                throw new Exception("Error at SerializeString2Object ", innerException);
            }
            return result;
        }

    }
}
