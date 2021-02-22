// Decompiled with JetBrains decompiler
// Type: SDK.AdditionalTools.Basic.ObjectSerializeFunction
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;

namespace SDK.AdditionalTools.Basic
{
  public class ObjectSerializeFunction
  {
    public ObjectSerializeFunction()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
    }

    internal static void DeserializeObject2File(object o, string filename)
    {
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(o.GetType());
        StreamWriter streamWriter = new StreamWriter((Stream) new FileStream(filename, FileMode.Create), (Encoding) new UTF8Encoding());
        xmlSerializer.Serialize((TextWriter) streamWriter, RuntimeHelpers.GetObjectValue(o));
        streamWriter.Close();
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at DeserializeObject2File ", ex);
      }
    }

    internal static string DeserializeObject2String(object o)
    {
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(o.GetType());
        MemoryStream memoryStream = new MemoryStream();
        xmlSerializer.Serialize((Stream) memoryStream, RuntimeHelpers.GetObjectValue(o));
        return Encoding.UTF8.GetString(memoryStream.GetBuffer());
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at SerializeString2Object ", ex);
      }
    }

    internal static SqlXml DeserializeObject2XML(object o)
    {
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(o.GetType());
        MemoryStream memoryStream = new MemoryStream();
        xmlSerializer.Serialize((Stream) memoryStream, RuntimeHelpers.GetObjectValue(o));
        List<byte> byteList = new List<byte>();
        byte num1 = 0;
        byte[] buffer = memoryStream.GetBuffer();
        int index = 0;
        while (index < buffer.Length)
        {
          byte num2 = buffer[index];
          if ((int) num2 != (int) num1)
            byteList.Add(num2);
          checked { ++index; }
        }
        return new SqlXml((Stream) new MemoryStream(byteList.ToArray()));
      }
      catch (Exception ex)
      {
      
        throw new Exception(nameof (DeserializeObject2XML), ex);
      }
    }

    internal static SqlXml DeserializeObject2XML(object o, string defaultnamespace)
    {
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(o.GetType(), defaultnamespace);
        MemoryStream memoryStream = new MemoryStream();
        xmlSerializer.Serialize((Stream) memoryStream, RuntimeHelpers.GetObjectValue(o));
        List<byte> byteList = new List<byte>();
        byte num1 = 0;
        byte[] buffer = memoryStream.GetBuffer();
        int index = 0;
        while (index < buffer.Length)
        {
          byte num2 = buffer[index];
          if ((int) num2 != (int) num1)
            byteList.Add(num2);
          checked { ++index; }
        }
        return new SqlXml((Stream) new MemoryStream(byteList.ToArray()));
      }
      catch (Exception ex)
      {
      
        throw new Exception(nameof (DeserializeObject2XML), ex);
      }
    }

    internal static byte[] DeserializeObject2Byte(object o)
    {
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(o.GetType());
        MemoryStream memoryStream = new MemoryStream();
        xmlSerializer.Serialize((Stream) memoryStream, RuntimeHelpers.GetObjectValue(o));
        return memoryStream.GetBuffer();
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at DeserializeObject2Byte ", ex);
      }
    }

    internal static object SerializeString2Object(string xml, Type objType)
    {
      try
      {
        UTF8Encoding utF8Encoding = new UTF8Encoding();
        return new XmlSerializer(objType).Deserialize((Stream) new MemoryStream(utF8Encoding.GetBytes(xml)));
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at SerializeString2Object ", ex);
      }
    }

    public static object SerializeByte2Object(byte[] ObjByte, Type objType)
    {
      try
      {
        return new XmlSerializer(objType).Deserialize((Stream) new MemoryStream(ObjByte));
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at SerializeByte2Object ", ex);
      }
    }

    internal static object SerializeFile2Object(string filename, Type objType)
    {
      try
      {
        byte[] buffer = File.ReadAllBytes(filename);
        return new XmlSerializer(objType).Deserialize((Stream) new MemoryStream(buffer));
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at SerializeFile2Object ", ex);
      }
    }
  }
}
