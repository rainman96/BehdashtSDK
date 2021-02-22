// Decompiled with JetBrains decompiler
// Type: SDK.Crypto
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace SDK
{
  public class Crypto
  {
    [DebuggerNonUserCode]
    public Crypto()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    public byte[] SecuredObject(object obj)
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
      symmetricAlgorithm.Key = this.FromHex("F21CFE97B6555EE84773806E6694326D2565892024C47FC7");
      symmetricAlgorithm.IV = this.FromHex("5FBC9394BF8D71EF");
      CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream3, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
      cryptoStream.Write(buffer3, 0, buffer3.Length);
      cryptoStream.Close();
      memoryStream3.Close();
      return memoryStream3.ToArray();
    }

    internal object UnSecuredObject(byte[] b, Type objType)
    {
      try
      {
        MemoryStream memoryStream = new MemoryStream(b, 0, b.Length);
        byte[] buffer1 = new byte[checked (b.Length - 1 + 1)];
        SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm) new TripleDESCryptoServiceProvider();
        symmetricAlgorithm.Key = this.FromHex("F21CFE97B6555EE84773806E6694326D2565892024C47FC7");
        symmetricAlgorithm.IV = this.FromHex("5FBC9394BF8D71EF");
        CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read);
        try
        {
          cryptoStream.Read(buffer1, 0, checked (b.Length - 1));
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
        Stream stream = (Stream) new GZipStream((Stream) new MemoryStream(buffer1), CompressionMode.Decompress);
        int offset = 0;
        byte[] buffer2;
        while (true)
        {
          buffer2 = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) buffer2, (Array) new byte[checked (offset + buffer1.Length + 1)]);
          int num = stream.Read(buffer2, offset, buffer1.Length);
          if (num != 0)
            checked { offset += num; }
          else
            break;
        }
        byte[] buffer3 = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) buffer2, (Array) new byte[checked (offset - 1 + 1)]);
        return new XmlSerializer(objType).Deserialize((Stream) new MemoryStream(buffer3));
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at UnSecuredObject. ", ex);
      }
    }

    public byte[] SecuredObjectByTokenKey(object obj)
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
      symmetricAlgorithm.Key = this.FromHex(Crypto.ReadKEY());
      symmetricAlgorithm.IV = this.FromHex(Crypto.ReadPIN());
      CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream3, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
      cryptoStream.Write(buffer3, 0, buffer3.Length);
      cryptoStream.Close();
      memoryStream3.Close();
      return memoryStream3.ToArray();
    }

    internal object UnSecuredObjectByTokenKey(byte[] b, Type objType)
    {
      try
      {
        MemoryStream memoryStream = new MemoryStream(b, 0, b.Length);
        byte[] buffer1 = new byte[checked (b.Length - 1 + 1)];
        SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm) new TripleDESCryptoServiceProvider();
        symmetricAlgorithm.Key = this.FromHex(Crypto.ReadKEY());
        symmetricAlgorithm.IV = this.FromHex(Crypto.ReadPIN());
        CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read);
        try
        {
          cryptoStream.Read(buffer1, 0, checked (b.Length - 1));
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
        Stream stream = (Stream) new GZipStream((Stream) new MemoryStream(buffer1), CompressionMode.Decompress);
        int offset = 0;
        byte[] buffer2;
        while (true)
        {
          buffer2 = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) buffer2, (Array) new byte[checked (offset + buffer1.Length + 1)]);
          int num = stream.Read(buffer2, offset, buffer1.Length);
          if (num != 0)
            checked { offset += num; }
          else
            break;
        }
        byte[] buffer3 = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) buffer2, (Array) new byte[checked (offset - 1 + 1)]);
        return new XmlSerializer(objType).Deserialize((Stream) new MemoryStream(buffer3));
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at UnSecuredObject. ", ex);
      }
    }

    internal byte[] FromHex(string hexEncoded)
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

    protected internal static string PubKeyExponent() => "AQAB";

    protected internal static string PubKeyModulus() => "vWBoYaraHQUJF4cOYb6rz1QXdCUSEy+7XKGdoJIXsKAAn536lISm9igafb8q4dpvU4lIBw7Eirjw+DN/Gr9z4PDAaegqTnojKnkC/bcs5Lr4myuTSRZFiQNAFOXMrNHSRK9Bl0f74GiWFXQt1s3eRRS8IAVAwKNDw5yPto7QeBs=";

    protected internal static string ReadPIN() => "A2E20C219E704B2A";

    protected internal static string ReadKEY() => "E95B7D2D754F84CC37B0AEE8E6E516751B4BC8E811D7712B";
  }
}
