// Decompiled with JetBrains decompiler
// Type: SDK.AdditionalTools.Encryption.Asymmetric
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace SDK.AdditionalTools.Encryption
{
  internal class Asymmetric
  {
    private RSACryptoServiceProvider _rsa;
    private string _KeyContainerName;
    private bool _UseMachineKeystore;
    private int _KeySize;
    private const string _ElementParent = "RSAKeyValue";
    private const string _ElementModulus = "Modulus";
    private const string _ElementExponent = "Exponent";
    private const string _ElementPrimeP = "P";
    private const string _ElementPrimeQ = "Q";
    private const string _ElementPrimeExponentP = "DP";
    private const string _ElementPrimeExponentQ = "DQ";
    private const string _ElementCoefficient = "InverseQ";
    private const string _ElementPrivateExponent = "D";
    private const string _KeyModulus = "PublicKey.Modulus";
    private const string _KeyExponent = "PublicKey.Exponent";
    private const string _KeyPrimeP = "PrivateKey.P";
    private const string _KeyPrimeQ = "PrivateKey.Q";
    private const string _KeyPrimeExponentP = "PrivateKey.DP";
    private const string _KeyPrimeExponentQ = "PrivateKey.DQ";
    private const string _KeyCoefficient = "PrivateKey.InverseQ";
    private const string _KeyPrivateExponent = "PrivateKey.D";

    public Asymmetric()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._KeyContainerName = "Encryption.AsymmetricEncryption.DefaultContainerName";
      this._UseMachineKeystore = false;
      this._KeySize = 1024;
      this._rsa = this.GetRSAProvider();
    }

    private RSACryptoServiceProvider GetRSAProvider()
    {
      RSACryptoServiceProvider cryptoServiceProvider = (RSACryptoServiceProvider) null;
      CspParameters parameters = (CspParameters) null;
      try
      {
        parameters = new CspParameters();
        parameters.KeyContainerName = this._KeyContainerName;
        cryptoServiceProvider = new RSACryptoServiceProvider(this._KeySize, parameters);
        cryptoServiceProvider.PersistKeyInCsp = false;
        RSACryptoServiceProvider.UseMachineKeyStore = this._UseMachineKeystore;
        return cryptoServiceProvider;
      }
      catch (CryptographicException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        CryptographicException cryptographicException = ex;
        if (cryptographicException.Message.ToLower().IndexOf("csp for this implementation could not be acquired") > -1)
          throw new Exception("Unable to obtain Cryptographic Service Provider. Either the permissions are incorrect on the 'C:\\Documents and Settings\\All Users\\Application Data\\Microsoft\\Crypto\\RSA\\MachineKeys' folder, or the current security context '" + WindowsIdentity.GetCurrent().Name + "' does not have access to this folder.", (Exception) cryptographicException);
        throw;
      }
      finally
      {
        if (cryptoServiceProvider != null)
          ;
        if (parameters != null)
          ;
      }
    }

    public byte[] EncryptBadlength(byte[] InputBytes, Asymmetric.PublicKey PublicKey)
    {
      try
      {
        this._rsa.ImportParameters(PublicKey.ToParameters());
        int int32_1 = Convert.ToInt32(Math.Floor(new Decimal(this._KeySize / 8)));
        byte[] numArray1 = InputBytes;
        int num1 = checked (int32_1 - 42);
        int length = numArray1.Length;
        int int32_2 = Convert.ToInt32(Math.Floor(new Decimal(length / num1)));
        List<byte> byteList = new List<byte>();
        int num2 = int32_2;
        int num3 = 0;
        while (num3 <= num2)
        {
          byte[] rgb = new byte[checked ((unchecked (checked (length - num1 * num3) > num1) ? num1 : length - num1 * num3) - 1 + 1)];
          Buffer.BlockCopy((Array) numArray1, checked (num1 * num3), (Array) rgb, 0, rgb.Length);
          byte[] numArray2 = this._rsa.Encrypt(rgb, true);
          Array.Reverse((Array) numArray2);
          byteList.AddRange((IEnumerable<byte>) numArray2);
          checked { ++num3; }
        }
        return byteList.ToArray();
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at EncryptBadlength. ", ex);
      }
    }

    public class PublicKey
    {
      public string Modulus;
      public string Exponent;

      public PublicKey()
      {
        Class2.gT0CJODzw5nbC();
        // ISSUE: explicit constructor call
        base.\u002Ector();
      }

      public PublicKey(string KeyXml)
      {
        Class2.gT0CJODzw5nbC();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.LoadFromXml(KeyXml);
      }

      public void LoadFromConfig()
      {
        this.Modulus = Utils.GetConfigString((object) "PublicKey.Modulus");
        this.Exponent = Utils.GetConfigString((object) "PublicKey.Exponent");
      }

      public string ToConfigSection()
      {
        StringBuilder stringBuilder1 = new StringBuilder();
        StringBuilder stringBuilder2 = stringBuilder1;
        stringBuilder2.Append(Utils.WriteConfigKey((object) "PublicKey.Modulus", (object) this.Modulus));
        stringBuilder2.Append(Utils.WriteConfigKey((object) "PublicKey.Exponent", (object) this.Exponent));
        return stringBuilder1.ToString();
      }

      public void ExportToConfigFile(string filePath)
      {
        StreamWriter streamWriter = new StreamWriter(filePath, false);
        streamWriter.Write(this.ToConfigSection());
        streamWriter.Close();
      }

      public void LoadFromXml(string keyXml)
      {
        this.Modulus = Utils.GetXmlElement(keyXml, (object) "Modulus");
        this.Exponent = Utils.GetXmlElement(keyXml, (object) "Exponent");
      }

      public RSAParameters ToParameters() => new RSAParameters()
      {
        Modulus = Convert.FromBase64String(this.Modulus),
        Exponent = Convert.FromBase64String(this.Exponent)
      };

      public string ToXml()
      {
        StringBuilder stringBuilder1 = new StringBuilder();
        StringBuilder stringBuilder2 = stringBuilder1;
        stringBuilder2.Append(Utils.WriteXmlNode((object) "RSAKeyValue"));
        stringBuilder2.Append(Utils.WriteXmlElement((object) "Modulus", (object) this.Modulus));
        stringBuilder2.Append(Utils.WriteXmlElement((object) "Exponent", (object) this.Exponent));
        stringBuilder2.Append(Utils.WriteXmlNode((object) "RSAKeyValue", true));
        return stringBuilder1.ToString();
      }

      public void ExportToXmlFile(string filePath)
      {
        StreamWriter streamWriter = new StreamWriter(filePath, false);
        streamWriter.Write(this.ToXml());
        streamWriter.Close();
      }
    }
  }
}
