
using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace SDK.AdditionalTools.Encryption
{
  internal class Utils
  {

    internal static string ToHex(byte[] ba)
    {
      string str;
      if ((ba == null || ba.Length == 0 ? 1 : 0) != 0)
      {
        str = "";
      }
      else
      {
        StringBuilder stringBuilder = new StringBuilder();
        byte[] numArray = ba;
        int index = 0;
        while (index < numArray.Length)
        {
          byte num = numArray[index];
          stringBuilder.Append(string.Format("{0:X2}", (object) num));
          checked { ++index; }
        }
        str = stringBuilder.ToString();
      }
      return str;
    }

    internal static byte[] FromHex(string hexEncoded)
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

    internal static byte[] smethod_0(string base64Encoded)
    {
      int num;
      switch (base64Encoded)
      {
        case "":
        case null:
          num = 1;
          break;
        default:
          num = 0;
          break;
      }
      if (num != 0)
        return (byte[]) null;
      try
      {
        return Convert.FromBase64String(base64Encoded);
      }
      catch (FormatException ex)
      {
        FormatException formatException = ex;
        throw new FormatException("The provided string does not appear to be Base64 encoded:" + Environment.NewLine + base64Encoded + Environment.NewLine, (Exception) formatException);
      }
    }

    internal static string ToBase64(byte[] b) => (b == null || b.Length == 0 ? 1 : 0) == 0 ? Convert.ToBase64String(b) : "";

    internal static string GetXmlElement(string xml, object element) => (Regex.Match(xml, "<" + (string) element + ">(?<Element>[^>]*)</" + (string) element + ">", RegexOptions.IgnoreCase) ?? throw new Exception("Could not find <" + (string) element + "></" + (string) element + "> in provided Public Key XML.")).Groups["Element"].ToString();

    

    internal static string WriteConfigKey(object key, object value) => string.Format("<add key=\"{0}\" value=\"{1}\" />" + Environment.NewLine, key, value);

    internal static string WriteXmlElement(object element, object value) => string.Format("<{0}>{1}</{0}>" + Environment.NewLine, element, value);

    internal static string WriteXmlNode(object element, bool isClosing = false) => string.Format(!isClosing ? "<{0}>" + Environment.NewLine : "</{0}>" + Environment.NewLine, element);
  }
}
