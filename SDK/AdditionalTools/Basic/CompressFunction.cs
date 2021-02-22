// Decompiled with JetBrains decompiler
// Type: SDK.AdditionalTools.Basic.CompressFunction
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using SDK.AdditionalTools.Encryption;
using System;
using System.IO;
using System.IO.Compression;

namespace SDK.AdditionalTools.Basic
{
  public class CompressFunction
  {
    public CompressFunction()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
    }

    public static byte[] Decompress(byte[] data)
    {
      try
      {
        return CompressFunction.ExtractBytesFromStream((Stream) new GZipStream((Stream) new MemoryStream(data), CompressionMode.Decompress), data.Length);
      }
      catch (Exception ex)
      {
        throw new Exception("Error at Decompress. ", ex);
      }
    }

    public static byte[] ExtractBytesFromStream(Stream stream, int dataBlock)
    {
      int offset = 0;
      try
      {
        byte[] buffer;
        while (true)
        {
          buffer = (byte[]) Utils.CopyArray((Array) buffer, (Array) new byte[checked (offset + dataBlock + 1)]);
          int num = stream.Read(buffer, offset, dataBlock);
          if (num != 0)
            checked { offset += num; }
          else
            break;
        }
        return (byte[]) Utils.CopyArray((Array) buffer, (Array) new byte[checked (offset - 1 + 1)]);
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at ExtractBytesFromStream", ex);
      }
    }

    public static byte[] Compress(byte[] data)
    {
      try
      {
        MemoryStream memoryStream = new MemoryStream();
        Stream stream = (Stream) new GZipStream((Stream) memoryStream, CompressionMode.Compress, true);
        stream.Write(data, 0, data.Length);
        stream.Close();
        memoryStream.Position = 0L;
        byte[] buffer = new byte[checked ((int) (memoryStream.Length - 1L) + 1)];
        memoryStream.Read(buffer, 0, checked ((int) memoryStream.Length));
        return buffer;
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at Compress.", ex);
      }
    }
  }
}
