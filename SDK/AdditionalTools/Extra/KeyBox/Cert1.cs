// Decompiled with JetBrains decompiler
// Type: SDK.AdditionalTools.Extra.KeyBox.Cert1
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using Microsoft.VisualBasic.CompilerServices;
using SDK.AdditionalTools.Encryption;
using System;

namespace SDK.AdditionalTools.Extra.KeyBox
{
  internal class Cert1
  {
    protected internal string Exponent;
    protected internal string Modulus;

    public Cert1()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      this.Exponent = "AQAB";
      this.Modulus = "pPKJY/Q0XEpXSDTHhYSQ8eAi6hAF3XhBf/8ozRanb+ILt7kz83fk8uyL+gqFMEbhDs4RSI5gWck6HSDcjTrbyfkcAXza0tOUtaG21ShL7WCl58/6g+hnG2yfFl4v8jU8u/QAQwmD9adSM0ovayHVNl8Xbls2RdIeKwzVnnBhW+E=";
    }

    internal Asymmetric.PublicKey GetPublicKey()
    {
      try
      {
        return new Asymmetric.PublicKey()
        {
          Exponent = this.Exponent,
          Modulus = this.Modulus
        };
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at Token. ", ex);
      }
    }
  }
}
