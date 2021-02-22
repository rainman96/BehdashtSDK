// Decompiled with JetBrains decompiler
// Type: SDK.AdditionalTools.Basic.Extra.SimpleSecureShell
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using Microsoft.VisualBasic.CompilerServices;
using SDK.AdditionalTools.Encryption;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace SDK.AdditionalTools.Basic.Extra
{
  public class SimpleSecureShell
  {
    [DebuggerNonUserCode]
    public SimpleSecureShell()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
    }

    public byte[] Dastine(object obj)
    {
      Data data1 = new Data();
      Data data2 = new Data();
      SimpleSecureShell simpleSecureShell = new SimpleSecureShell();
      data1.Hex = "F21CFE97B6555EE84773806E6694326D2565892024C47FC7";
      data2.Hex = "5FBC9394BF8D71EF";
      return simpleSecureShell.SecuredObject(RuntimeHelpers.GetObjectValue(obj), data2.Bytes, data1.Bytes);
    }

    internal byte[] SecuredObject(object obj, byte[] IV, byte[] Key)
    {
      XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
      MemoryStream memoryStream1 = new MemoryStream();
      xmlSerializer.Serialize((Stream) memoryStream1, RuntimeHelpers.GetObjectValue(obj));
      byte[] buffer1 = memoryStream1.GetBuffer();
      MemoryStream memoryStream2 = new MemoryStream();
      Stream stream = (Stream) new GZipStream((Stream) memoryStream2, CompressionMode.Compress, true);
      stream.Write(buffer1, 0, buffer1.Length);
      stream.Close();
      memoryStream2.Position = 0L;
      byte[] buffer2 = new byte[checked ((int) (memoryStream2.Length - 1L) + 1)];
      memoryStream2.Read(buffer2, 0, checked ((int) memoryStream2.Length));
      byte[] buffer3 = buffer2;
      MemoryStream memoryStream3 = new MemoryStream();
      SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm) new TripleDESCryptoServiceProvider();
      symmetricAlgorithm.Key = Key;
      symmetricAlgorithm.IV = IV;
      CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream3, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
      cryptoStream.Write(buffer3, 0, buffer3.Length);
      cryptoStream.Close();
      memoryStream3.Close();
      return memoryStream3.ToArray();
    }

    internal object UnSecuredObject(byte[] b, Type objType, string IV, string key)
    {
      try
      {
        byte[] data = this.Decrypt(b, IV, key);
        CompressFunction compressFunction = new CompressFunction();
        return ObjectSerializeFunction.SerializeByte2Object(CompressFunction.Decompress(data), objType);
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at UnSecuredObject. ", ex);
      }
    }

    internal byte[] Decrypt(byte[] b, string IV, string key)
    {
      try
      {
        MemoryStream memoryStream = new MemoryStream(b, 0, b.Length);
        byte[] buffer = new byte[checked (b.Length - 1 + 1)];
        SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm) new TripleDESCryptoServiceProvider();
        Data data1 = new Data();
        Data data2 = new Data();
        data1.Hex = key;
        data2.Hex = IV;
        symmetricAlgorithm.Key = data1.Bytes;
        symmetricAlgorithm.IV = data2.Bytes;
        CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read);
        try
        {
          cryptoStream.Read(buffer, 0, checked (b.Length - 1));
        }
        catch (CryptographicException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new CryptographicException("Unable to decrypt data. The provided key may be invalid.", (Exception) ex);
        }
        finally
        {
          cryptoStream.Close();
        }
        return buffer;
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at Decrypt. ", ex);
      }
    }

    private byte[] FromHex(string hexEncoded)
    {
      int num1;
      switch (hexEncoded)
      {
        case "":
        case null:
          num1 = 1;
          break;
        default:
          num1 = 0;
          break;
      }
      if (num1 != 0)
        return (byte[]) null;
      try
      {
        int int32 = Convert.ToInt32((double) hexEncoded.Length / 2.0);
        byte[] numArray = new byte[checked (int32 - 1 + 1)];
        int num2 = checked (int32 - 1);
        int index = 0;
        while (index <= num2)
        {
          numArray[index] = Convert.ToByte(hexEncoded.Substring(checked (index * 2), 2), 16);
          checked { ++index; }
        }
        return numArray;
      }
      catch (Exception ex)
      {
      
        Exception innerException = ex;
        throw new FormatException("The provided string does not appear to be Hex encoded:" + Environment.NewLine + hexEncoded + Environment.NewLine, innerException);
      }
    }
  }
}
