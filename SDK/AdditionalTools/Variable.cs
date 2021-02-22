// Decompiled with JetBrains decompiler
// Type: SDK.Variable
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using SDK.AdditionalTools.Encryption;
using SDK.DataModel;
using SDK.iToken.KeyA3Token;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace SDK
{
  public class Variable
  {
    private Token T;
    private string VersionControlGetFullVersion;

    public string GetSystemID() => this.T.SystemID_ByToken();

    public string GetLocationID() => this.T.LocationID_ByToken();

    internal string GetKEY() => this.T.KEY_ByToken();

    internal string GetPIN() => this.T.PIN_ByToken();

    internal string GetUserID() => this.T.UserID_ByToken();

    public string GetTokenSerialNumber() => this.T.TokenSerialNumber_ByToken();

    public Variable(byte[] Certificate)
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      this.VersionControlGetFullVersion = "18.0.4";
      this.T = new Token();
    }

    public Variable()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      this.VersionControlGetFullVersion = "18.0.4";
      this.T = new Token();
    }

    internal string GenerateKeyA3Token(string SymmetricKeypair)
    {
      try
      {
        string str = MainFx.EncryptByCertificate_ASCII(MainFx.GenerateISODate() + "|" + MainFx.InternalIP() + "|" + MainFx.MAC() + "|" + this.GetLocationID() + "|" + this.GetSystemID() + "|" + this.GetUserID() + "|" + SymmetricKeypair + "|" + this.VersionControlGetFullVersion);
        Debug.Print("Encrypt Length : " +str.Length);
        return str;
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at GenerateKeyA3Token. ", ex);
      }
    }

    internal string GenerateKeyA2PlusToken()
    {
      try
      {
        string str = MainFx.GenerateISODate() + "|" + MainFx.InternalIP() + "|" + MainFx.MAC() + "|" + this.GetLocationID() + "|" + this.GetSystemID() + "|" + this.GetPIN() + "|" + this.VersionControlGetFullVersion;
        Data data1 = new Data();
        DateTime now = DateTime.Now;
        now.ToBinary();
        BitConverter.GetBytes(now.ToBinary());
        MainFx mainFx = new MainFx();
        Data Plain = new Data();
        Plain.Text = str;
        Data Key1 = new Data();
        Key1.Hex = "C4DCA1A6FAFBA89E4AED193AFC885728";
        Data Key2 = new Data();
        Key2.Hex = "5DD0E7433689923DD279C2F21565500D";
        Debug.Print("KV21 : " + new Data()
        {
          Bytes = mainFx.GetHash(Key1, new Data()
          {
            Text = this.GetTokenSerialNumber()
          })
        }.ToHex());
        Data Key3 = new Data();
        Key3.Bytes = mainFx.GetHash(Key2, new Data()
        {
          Text = this.GetTokenSerialNumber() + this.GetUserID()
        });
        Debug.Print("KV22 : " + Key3.ToHex());
        Data data2 = new Data();
        Data data3 = new Data();
        Data data4 = mainFx.method_1(Plain, Key3);
        return this.GetTokenSerialNumber() + "|" + this.GetUserID() + "|" + data4.Base64;
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at GenerateKeyA2PlusToken. ", ex);
      }
    }

    public string method_0()
    {
      string isoDate = MainFx.GenerateISODate();
      Debug.Print(isoDate);
      string s = isoDate + "|" + MainFx.InternalIP() + "|" + MainFx.MAC() + "|" + this.GetLocationID() + "|" + this.GetSystemID() + "|" + this.GetUserID() + "|" + this.GetPIN() + "|" + this.VersionControlGetFullVersion;
      try
      {
        RSAParameters parameters = new RSAParameters();
        parameters.Modulus = Convert.FromBase64String(Crypto.PubKeyModulus());
        parameters.Exponent = Convert.FromBase64String(Crypto.PubKeyExponent());
        RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(1024);
        cryptoServiceProvider.ImportParameters(parameters);
        int int32_1 = Convert.ToInt32(Math.Floor(128M));
        byte[] bytes = Encoding.UTF32.GetBytes(s);
        int num1 = checked (int32_1 - 42);
        int length = bytes.Length;
        int int32_2 = Convert.ToInt32(Math.Floor(new Decimal(length / num1)));
        StringBuilder stringBuilder = new StringBuilder();
        int num2 = int32_2;
        int num3 = 0;
        while (num3 <= num2)
        {
          byte[] rgb = new byte[checked ((unchecked (checked (length - num1 * num3) > num1) ? num1 : length - num1 * num3) - 1 + 1)];
          Buffer.BlockCopy((Array) bytes, checked (num1 * num3), (Array) rgb, 0, rgb.Length);
          byte[] inArray = cryptoServiceProvider.Encrypt(rgb, true);
          Array.Reverse((Array) inArray);
          stringBuilder.Append(Convert.ToBase64String(inArray));
          checked { ++num3; }
        }
        return stringBuilder.ToString();
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at GenerateURL. ", ex);
      }
    }

    public void ManageTokeninHeader(ref HeaderMessageVO HM)
    {
      try
      {
        TokenReaderInterface tokenReaderInterface = new TokenReaderInterface();
        string symmetricKeypair4KeyA3 = MainFx.GenerateSymmetricKeypair4KeyA3();
        HM.Sender.URL = this.GenerateKeyA3Token(symmetricKeypair4KeyA3);
        HM.Sender.Proof = new SignatureVO();
        HM.Sender.Proof.Certificate = tokenReaderInterface.GetCertificate();
        HM.Sender.Proof.SignatureMethod = "3";
        HM.Sender.IP = symmetricKeypair4KeyA3;
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at ManageTokeninHeader. ", ex);
      }
    }
  }
}
