// Decompiled with JetBrains decompiler
// Type: SDK.AdditionalTools.Basic.Extra.determined
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace SDK.AdditionalTools.Basic.Extra
{
  public class determined
  {
    [DebuggerNonUserCode]
    public determined()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
    }

    public object TaggedObject(byte[] b, Type objType)
    {
      try
      {
        MemoryStream memoryStream = new MemoryStream(b, 0, b.Length);
        byte[] buffer1 = new byte[checked (b.Length - 1 + 1)];
        SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm) new TripleDESCryptoServiceProvider();
        StringBuilder stringBuilder1 = new StringBuilder();
        int CharCode1 = checked ((int) Math.Round(unchecked (71.2641957923697 * (Math.Sqrt(7.0) + Math.Log10(2.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode1));
        int CharCode2 = checked ((int) Math.Round(unchecked (48.0326996507878 * (Math.Sqrt(7.0) + Math.Log10(3.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode2));
        int CharCode3 = checked ((int) Math.Round(unchecked (45.261250212323 * (Math.Sqrt(7.0) + Math.Log10(4.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode3));
        int CharCode4 = checked ((int) Math.Round(unchecked (60.0946928147661 * (Math.Sqrt(7.0) + Math.Log10(5.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode4));
        int CharCode5 = checked ((int) Math.Round(unchecked (61.3335211008968 * (Math.Sqrt(7.0) + Math.Log10(6.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode5));
        int CharCode6 = checked ((int) Math.Round(unchecked (59.2978897631393 * (Math.Sqrt(7.0) + Math.Log10(7.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode6));
        int CharCode7 = checked ((int) Math.Round(unchecked (48.1847413389957 * (Math.Sqrt(7.0) + Math.Log10(8.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode7));
        int CharCode8 = checked ((int) Math.Round(unchecked (45.8334120076083 * (Math.Sqrt(7.0) + Math.Log10(9.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode8));
        int CharCode9 = checked ((int) Math.Round(unchecked (54.3097932651315 * (Math.Sqrt(7.0) + Math.Log10(10.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode9));
        int CharCode10 = checked ((int) Math.Round(unchecked (43.9364451635076 * (Math.Sqrt(7.0) + Math.Log10(11.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode10));
        int CharCode11 = checked ((int) Math.Round(unchecked (42.6853365966084 * (Math.Sqrt(7.0) + Math.Log10(12.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode11));
        int CharCode12 = checked ((int) Math.Round(unchecked (42.2906683218312 * (Math.Sqrt(7.0) + Math.Log10(13.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode12));
        int CharCode13 = checked ((int) Math.Round(unchecked (41.9317139234872 * (Math.Sqrt(7.0) + Math.Log10(14.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode13));
        int CharCode14 = checked ((int) Math.Round(unchecked (54.1623565602509 * (Math.Sqrt(7.0) + Math.Log10(15.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode14));
        int CharCode15 = checked ((int) Math.Round(unchecked (53.7680312424043 * (Math.Sqrt(7.0) + Math.Log10(16.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode15));
        int CharCode16 = checked ((int) Math.Round(unchecked (43.3414142525147 * (Math.Sqrt(7.0) + Math.Log10(17.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode16));
        int CharCode17 = checked ((int) Math.Round(unchecked (39.9895020772377 * (Math.Sqrt(7.0) + Math.Log10(18.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode17));
        int CharCode18 = checked ((int) Math.Round(unchecked (42.0435198067265 * (Math.Sqrt(7.0) + Math.Log10(19.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode18));
        int CharCode19 = checked ((int) Math.Round(unchecked (41.8062180741314 * (Math.Sqrt(7.0) + Math.Log10(20.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode19));
        int CharCode20 = checked ((int) Math.Round(unchecked (38.5587533779652 * (Math.Sqrt(7.0) + Math.Log10(21.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode20));
        int CharCode21 = checked ((int) Math.Round(unchecked (42.1245412917704 * (Math.Sqrt(7.0) + Math.Log10(22.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode21));
        int CharCode22 = checked ((int) Math.Round(unchecked (35.9328133010612 * (Math.Sqrt(7.0) + Math.Log10(23.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode22));
        int CharCode23 = checked ((int) Math.Round(unchecked (40.2388243497916 * (Math.Sqrt(7.0) + Math.Log10(24.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode23));
        int CharCode24 = checked ((int) Math.Round(unchecked (51.1908510399063 * (Math.Sqrt(7.0) + Math.Log10(25.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode24));
        int CharCode25 = checked ((int) Math.Round(unchecked (39.8943571905419 * (Math.Sqrt(7.0) + Math.Log10(26.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode25));
        int CharCode26 = checked ((int) Math.Round(unchecked (39.7339778277208 * (Math.Sqrt(7.0) + Math.Log10(27.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode26));
        int CharCode27 = checked ((int) Math.Round(unchecked (41.7795718630417 * (Math.Sqrt(7.0) + Math.Log10(28.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode27));
        int CharCode28 = checked ((int) Math.Round(unchecked (37.9733033703582 * (Math.Sqrt(7.0) + Math.Log10(29.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode28));
        int CharCode29 = checked ((int) Math.Round(unchecked (37.1100482876303 * (Math.Sqrt(7.0) + Math.Log10(30.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode29));
        int CharCode30 = checked ((int) Math.Round(unchecked (36.2571676969861 * (Math.Sqrt(7.0) + Math.Log10(31.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode30));
        int CharCode31 = checked ((int) Math.Round(unchecked (39.0276686208603 * (Math.Sqrt(7.0) + Math.Log10(32.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode31));
        int CharCode32 = checked ((int) Math.Round(unchecked (48.9882338676264 * (Math.Sqrt(7.0) + Math.Log10(33.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode32));
        int CharCode33 = checked ((int) Math.Round(unchecked (35.9089616346048 * (Math.Sqrt(7.0) + Math.Log10(34.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode33));
        int CharCode34 = checked ((int) Math.Round(unchecked (37.9491301443606 * (Math.Sqrt(7.0) + Math.Log10(35.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode34));
        int CharCode35 = checked ((int) Math.Round(unchecked (38.5525762530338 * (Math.Sqrt(7.0) + Math.Log10(36.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode35));
        int CharCode36 = checked ((int) Math.Round(unchecked (37.7317921377914 * (Math.Sqrt(7.0) + Math.Log10(37.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode36));
        int CharCode37 = checked ((int) Math.Round(unchecked (39.7582799977822 * (Math.Sqrt(7.0) + Math.Log10(38.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode37));
        int CharCode38 = checked ((int) Math.Round(unchecked (40.3604979083077 * (Math.Sqrt(7.0) + Math.Log10(39.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode38));
        int CharCode39 = checked ((int) Math.Round(unchecked (35.3123030478104 * (Math.Sqrt(7.0) + Math.Log10(40.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode39));
        int CharCode40 = checked ((int) Math.Round(unchecked (33.8144442458419 * (Math.Sqrt(7.0) + Math.Log10(41.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode40));
        int CharCode41 = checked ((int) Math.Round(unchecked (35.1370294838123 * (Math.Sqrt(7.0) + Math.Log10(42.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode41));
        int CharCode42 = checked ((int) Math.Round(unchecked (36.4552438311289 * (Math.Sqrt(7.0) + Math.Log10(43.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode42));
        int CharCode43 = checked ((int) Math.Round(unchecked (46.8618421001644 * (Math.Sqrt(7.0) + Math.Log10(44.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode43));
        int CharCode44 = checked ((int) Math.Round(unchecked (36.2878140771069 * (Math.Sqrt(7.0) + Math.Log10(45.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode44));
        int CharCode45 = checked ((int) Math.Round(unchecked (38.2963095895468 * (Math.Sqrt(7.0) + Math.Log10(46.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode45));
        int CharCode46 = checked ((int) Math.Round(unchecked (48.6353255476546 * (Math.Sqrt(7.0) + Math.Log10(47.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode46));
        int CharCode47 = checked ((int) Math.Round(unchecked (46.4525875073341 * (Math.Sqrt(7.0) + Math.Log10(48.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode47));
        int CharCode48 = checked ((int) Math.Round(unchecked (38.053967245761 * (Math.Sqrt(7.0) + Math.Log10(49.0)) / 3.0)));
        stringBuilder1.Append(Strings.Chr(CharCode48));
        string str1 = stringBuilder1.ToString();
        int int32_1 = Convert.ToInt32((double) str1.Length / 2.0);
        byte[] numArray1 = new byte[checked (int32_1 - 1 + 1)];
        int num1 = checked (int32_1 - 1);
        int index1 = 0;
        while (index1 <= num1)
        {
          numArray1[index1] = Convert.ToByte(str1.Substring(checked (index1 * 2), 2), 16);
          checked { ++index1; }
        }
        StringBuilder stringBuilder2 = new StringBuilder();
        int CharCode49 = checked ((int) Math.Round(unchecked (84.6792238409923 * (Math.Sqrt(8.0) + Math.Log10(2.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode49));
        int CharCode50 = checked ((int) Math.Round(unchecked (105.88258280357 * (Math.Sqrt(8.0) + Math.Log10(3.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode50));
        int CharCode51 = checked ((int) Math.Round(unchecked (96.1962510961568 * (Math.Sqrt(8.0) + Math.Log10(4.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode51));
        int CharCode52 = checked ((int) Math.Round(unchecked (94.9708773185863 * (Math.Sqrt(8.0) + Math.Log10(5.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode52));
        int CharCode53 = checked ((int) Math.Round(unchecked (79.0222671896712 * (Math.Sqrt(8.0) + Math.Log10(6.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode53));
        int CharCode54 = checked ((int) Math.Round(unchecked (69.4156126780279 * (Math.Sqrt(8.0) + Math.Log10(7.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode54));
        int CharCode55 = checked ((int) Math.Round(unchecked (76.3764419312143 * (Math.Sqrt(8.0) + Math.Log10(8.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode55));
        int CharCode56 = checked ((int) Math.Round(unchecked (68.7345248578609 * (Math.Sqrt(8.0) + Math.Log10(9.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode56));
        int CharCode57 = checked ((int) Math.Round(unchecked (86.1972787380347 * (Math.Sqrt(8.0) + Math.Log10(10.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode57));
        int CharCode58 = checked ((int) Math.Round(unchecked (90.4434876022419 * (Math.Sqrt(8.0) + Math.Log10(11.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode58));
        int CharCode59 = checked ((int) Math.Round(unchecked (71.6550824521648 * (Math.Sqrt(8.0) + Math.Log10(12.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode59));
        int CharCode60 = checked ((int) Math.Round(unchecked (86.2425289502864 * (Math.Sqrt(8.0) + Math.Log10(13.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode60));
        int CharCode61 = checked ((int) Math.Round(unchecked (69.1901329583343 * (Math.Sqrt(8.0) + Math.Log10(14.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode61));
        int CharCode62 = checked ((int) Math.Round(unchecked (61.1808903140552 * (Math.Sqrt(8.0) + Math.Log10(15.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode62));
        int CharCode63 = checked ((int) Math.Round(unchecked (85.5538672732974 * (Math.Sqrt(8.0) + Math.Log10(16.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode63));
        int CharCode64 = checked ((int) Math.Round(unchecked (86.2307683266629 * (Math.Sqrt(8.0) + Math.Log10(17.0)) / 5.0)));
        stringBuilder2.Append(Strings.Chr(CharCode64));
        string str2 = stringBuilder2.ToString();
        int int32_2 = Convert.ToInt32((double) str2.Length / 2.0);
        byte[] numArray2 = new byte[checked (int32_2 - 1 + 1)];
        int num2 = checked (int32_2 - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          numArray2[index2] = Convert.ToByte(str2.Substring(checked (index2 * 2), 2), 16);
          checked { ++index2; }
        }
        symmetricAlgorithm.Key = numArray1;
        symmetricAlgorithm.IV = numArray2;
        CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read);
        try
        {
          cryptoStream.Read(buffer1, 0, checked (b.Length - 1));
        }
        catch (CryptographicException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw new CryptographicException("The provided key may be invalid.", (Exception) ex);
        }
        finally
        {
          cryptoStream.Close();
        }
        Stream stream = (Stream) new GZipStream((Stream) new MemoryStream(buffer1), CompressionMode.Decompress);
        int length = buffer1.Length;
        int offset = 0;
        byte[] buffer2;
        try
        {
          byte[] buffer3;
          while (true)
          {
            buffer3 = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) buffer3, (Array) new byte[checked (offset + length + 1)]);
            int num3 = stream.Read(buffer3, offset, length);
            if (num3 != 0)
              checked { offset += num3; }
            else
              break;
          }
          buffer2 = (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) buffer3, (Array) new byte[checked (offset - 1 + 1)]);
        }
        catch (Exception ex)
        {
        
          throw new Exception("Error at ExtractBytesFromStream", ex);
        }
        return new XmlSerializer(objType).Deserialize((Stream) new MemoryStream(buffer2));
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at UnSecuredObject. ", ex);
      }
    }
  }
}
