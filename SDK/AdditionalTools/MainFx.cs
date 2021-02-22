// Decompiled with JetBrains decompiler
// Type: SDK.MainFx
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SDK.AdditionalTools.Basic;
using SDK.AdditionalTools.Basic.Extra;
using SDK.AdditionalTools.Encryption;
using SDK.DataModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace SDK
{
  public class MainFx
  {
    private const int BLOCK_LENGTH = 16;

    [DebuggerNonUserCode]
    public MainFx()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
    }

    internal Data method_0(Data Cipher, Data Key)
    {
      try
      {
        string str = Cipher != null ? Cipher.ToHex() : throw new Exception("Error: Cipher is empty!");
        if (str.Length % 32 != 0)
          throw new Exception("Error in cipher length! Cipher Length is: " + Conversions.ToString(str.Length));
        int startIndex = 0;
        Data data = new Data();
        while (startIndex < str.Length)
        {
          data.Hex += new Data()
          {
            Bytes = this.AES_Decrypt_Block(new Data()
            {
              Hex = str.Substring(startIndex, 32)
            }.Bytes, Key)
          }.ToHex();
          checked { startIndex += 32; }
        }
        return data;
      }
      catch (Exception ex)
      {
      
        throw new Exception("", ex);
      }
    }

    private byte[] AES_Decrypt_Block(byte[] bCipher, Data Key)
    {
      byte[] outputBuffer = new byte[16];
      using (AesManaged aesManaged = new AesManaged())
      {
        aesManaged.Mode = CipherMode.ECB;
        aesManaged.BlockSize = 128;
        aesManaged.KeySize = 128;
        aesManaged.Padding = PaddingMode.None;
        aesManaged.Key = Key.Bytes;
        aesManaged.CreateDecryptor(aesManaged.Key, (byte[]) null).TransformBlock(bCipher, 0, 16, outputBuffer, 0);
      }
      return outputBuffer;
    }

    internal Data method_1(Data Plain, Data Key)
    {
      try
      {
        string hex = Plain.ToHex();
        while (hex.Length % 16 != 0)
          hex += "0";
        int startIndex = 0;
        Data data = new Data();
        while (startIndex < hex.Length)
        {
          data.Hex += new Data()
          {
            Bytes = this.AES_Encrypt_Block(new Data()
            {
              Hex = hex.Substring(startIndex, 32)
            }.Bytes, Key)
          }.ToHex();
          checked { startIndex += 32; }
        }
        return data;
      }
      catch (Exception ex)
      {
      
        throw new Exception("", ex);
      }
    }

    private byte[] AES_Encrypt_Block(byte[] bPlain, Data Key)
    {
      byte[] outputBuffer = new byte[16];
      using (AesManaged aesManaged = new AesManaged())
      {
        aesManaged.Mode = CipherMode.ECB;
        aesManaged.BlockSize = 128;
        aesManaged.KeySize = 128;
        aesManaged.Padding = PaddingMode.None;
        aesManaged.Key = Key.Bytes;
        aesManaged.CreateEncryptor(aesManaged.Key, (byte[]) null).TransformBlock(bPlain, 0, 16, outputBuffer, 0);
      }
      return outputBuffer;
    }

    internal byte[] GetHash(Data Key, Data message)
    {
      MainFx mainFx = new MainFx();
      return new HMACMD5(Key.Bytes).ComputeHash(message.Bytes);
    }

    public static object _CObject(GeneralResponseMessageVO GRM, object o, string KP)
    {
      object obj;
      try
      {
        switch (GRM.ObjectSerializedAlgorithm)
        {
          case 1:
            o = RuntimeHelpers.GetObjectValue(ObjectSerializeFunction.SerializeByte2Object(GRM.ObjectByte, o.GetType()));
            obj = o;
            break;
          case 2:
            o = RuntimeHelpers.GetObjectValue(ObjectSerializeFunction.SerializeByte2Object(CompressFunction.Decompress(GRM.ObjectByte), o.GetType()));
            obj = o;
            break;
          case 3:
          case 4:
            break;
          case 5:
            string[] strArray = Operators.CompareString(KP, "", false) != 0 ? KP.Split('|') : throw new Exception("key does not transfer. ");
            if (strArray.Length != 2)
              throw new Exception("Error at key transfer. ");
            o = RuntimeHelpers.GetObjectValue(new SimpleSecureShell().UnSecuredObject(GRM.ObjectByte, o.GetType(), strArray[0], strArray[1]));
            obj = o;
            break;
          default:
            throw new Exception("Serialized Algorithm is unknown. ");
        }
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at cast object. ", ex);
      }
      return obj;
    }

    internal byte[] HexToByte(string strHEX)
    {
      try
      {
        int index1 = 0;
        byte[] numArray = new byte[checked ((int) Math.Round(unchecked ((double) strHEX.Length / 2.0 - 1.0)) + 1)];
        int num1 = checked (strHEX.Length - 1);
        int index2 = 0;
        while (index2 <= num1)
        {
          byte num2 = Convert.ToByte(strHEX[index2].ToString() + strHEX[checked (index2 + 1)].ToString(), 16);
          numArray[index1] = num2;
          checked { ++index1; }
          checked { index2 += 2; }
        }
        return numArray;
      }
      catch (Exception ex)
      {
      
        throw new Exception("", ex);
      }
    }

    internal string ByteToHex(byte[] bufferByte)
    {
      string str1 = "";
      int index = 0;
      while (index < bufferByte.Length)
      {
        string str2 = bufferByte[index].ToString("X");
        str1 += str2.PadLeft(2, '0');
        checked { ++index; }
      }
      return str1;
    }

    internal byte[] EncryptBadlength(byte[] InputBytes)
    {
      try
      {
        RSAParameters parameters = new RSAParameters();
        parameters.Modulus = Convert.FromBase64String(Crypto.PubKeyModulus());
        parameters.Exponent = Convert.FromBase64String(Crypto.PubKeyExponent());
        RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(1024);
        cryptoServiceProvider.ImportParameters(parameters);
        int int32_1 = Convert.ToInt32(Math.Floor(128M));
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
          byte[] numArray2 = cryptoServiceProvider.Encrypt(rgb, true);
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

    internal static string EncryptByCertificate_ASCII(string str)
    {
      RSAParameters parameters = new RSAParameters();
      parameters.Modulus = Convert.FromBase64String(Crypto.PubKeyModulus());
      parameters.Exponent = Convert.FromBase64String(Crypto.PubKeyExponent());
      RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(1024);
      cryptoServiceProvider.ImportParameters(parameters);
      int int32_1 = Convert.ToInt32(Math.Floor(128M));
      byte[] bytes = Encoding.ASCII.GetBytes(str);
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

    internal static string InternalIP()
    {
      try
      {
        return Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at InternalIP. ", ex);
      }
    }

    internal static string MAC()
    {
      try
      {
        return NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString();
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at MAC. ", ex);
      }
    }

    internal static string GenerateISODate()
    {
      DateTime now = DateTime.Now;
      return Strings.Format((object) now.Year, "0000") + Strings.Format((object) now.Month, "00") + Strings.Format((object) now.Day, "00") + "T" + Strings.Format((object) now.Hour, "00") + Strings.Format((object) now.Minute, "00") + Strings.Format((object) now.Second, "00");
    }

    internal static void WL(object msg, ref Chronometer time)
    {
      string txt = "";
      bool flag = false;
      try
      {
        if (!flag)
          return;
        txt = Conversions.ToString(DateTime.Now.ToFileTimeUtc()) + "|" + (string) msg + "|" + Conversions.ToString(time.EventStop());
        new LogWriter().method_0(txt);
      }
      catch (Exception ex)
      {
      
        if (flag)
          new LogWriter()
          {
            LogFileName = ("Log" + Guid.NewGuid().ToString() + ".log")
          }.method_0(txt);
        ProjectData.ClearProjectError();
      }
    }

    internal static string ExceptionToStringLine(Exception ex)
    {
      string Expression = ex.Message;
      for (Exception innerException = ex.InnerException; innerException != null; innerException = innerException.InnerException)
        Expression = Expression + " " + innerException.Message;
      return Strings.Replace(Expression, "\r\n", " ");
    }

    internal static string NormalException(Exception ex) => MainFx.ExceptionToStringLine(ex).Replace("System.Web.Services.Protocols.SoapException: Server was unable to process request.", "").Replace("System.Exception:", "");

    public static string CreateException(string MethodName, Exception ex)
    {
      Debug.Print("Error at Service. Error at " + MethodName + ". " + MainFx.NormalException(ex));
      return "Error at Service. Error at " + MethodName + ". " + MainFx.NormalException(ex);
    }

    public static void CheckNationalCode(string NC)
    {
      if (Operators.CompareString(NC, "", false) == 0)
        return;
      try
      {
        if (!(NC.Length == 10 & Operators.CompareString(NC, "1111111111", false) != 0 & Operators.CompareString(NC, "2222222222", false) != 0 & Operators.CompareString(NC, "3333333333", false) != 0 & Operators.CompareString(NC, "4444444444", false) != 0 & Operators.CompareString(NC, "5555555555", false) != 0 & Operators.CompareString(NC, "6666666666", false) != 0 & Operators.CompareString(NC, "7777777777", false) != 0 & Operators.CompareString(NC, "8888888888", false) != 0 & Operators.CompareString(NC, "9999999999", false) != 0 & Operators.CompareString(NC, "0000000000", false) != 0))
          throw new Exception("Invalid national code format.");
        int num1;
        try
        {
          num1 = checked (Conversions.ToInteger(NC.Substring(0, 1)) * 10 + Conversions.ToInteger(NC.Substring(1, 1)) * 9 + Conversions.ToInteger(NC.Substring(2, 1)) * 8 + Conversions.ToInteger(NC.Substring(3, 1)) * 7 + Conversions.ToInteger(NC.Substring(4, 1)) * 6 + Conversions.ToInteger(NC.Substring(5, 1)) * 5 + Conversions.ToInteger(NC.Substring(6, 1)) * 4 + Conversions.ToInteger(NC.Substring(7, 1)) * 3 + Conversions.ToInteger(NC.Substring(8, 1)) * 2) % 11;
        }
        catch (Exception ex)
        {
        
          throw new Exception("Invalid character.");
        }
        byte num2 = Conversions.ToByte(NC.Substring(9, 1));
        if (!(num1 < 2 & num1 == (int) num2 | num1 > 1 & num1 == checked (11 - (int) num2)))
          throw new Exception("Invalid check digit.");
      }
      catch (Exception ex)
      {
      
        throw new Exception("NationalCode invalid. ", ex);
      }
    }

    internal static int GetExpiryDay(DateTime ExpirationDate)
    {
      try
      {
        TimeSpan timeSpan = DateTime.Now.Subtract(ExpirationDate);
        return timeSpan.TotalDays > 0.0 ? checked ((int) Math.Round(unchecked (-1.0 * Conversion.Int(timeSpan.TotalDays)))) : checked ((int) Math.Round(Math.Abs(Conversion.Int(timeSpan.TotalDays))));
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at GetExpiryDay. ", ex);
      }
    }

    internal static string GenerateSymmetricKeypair4KeyA3()
    {
      try
      {
        string Left = "1";
        Data data1 = new Data();
        Data data2 = new Data();
        if (Operators.CompareString(Left, "1", false) == 0)
        {
          data1.Hex = "F21CFE97B6555EE84773806E6694326D2565892024C47FC7";
          data2.Hex = "5FBC9394BF8D71EF";
        }
        return data2.Hex + "|" + data1.Hex;
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at GenerateSymmetricKeypair4KeyA3. ", ex);
      }
    }
  }
}
