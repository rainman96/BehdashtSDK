// Decompiled with JetBrains decompiler
// Type: SDK.AdditionalTools.Encryption.Data
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using System;
using System.Text;

namespace SDK.AdditionalTools.Encryption
{
  public class Data
  {
    private byte[] _b;
    private int _MaxBytes;
    private int _MinBytes;
    private int _StepBytes;
    public static Encoding DefaultEncoding;
    public Encoding Encoding;

    static Data()
    {
      Class2.gT0CJODzw5nbC();
      Data.DefaultEncoding = Encoding.GetEncoding("Windows-1252");
    }

    public Data()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      this._MaxBytes = 0;
      this._MinBytes = 0;
      this._StepBytes = 0;
      this.Encoding = Data.DefaultEncoding;
    }

    public Data(byte[] b)
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      this._MaxBytes = 0;
      this._MinBytes = 0;
      this._StepBytes = 0;
      this.Encoding = Data.DefaultEncoding;
      this._b = b;
    }

    public Data(string s)
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      this._MaxBytes = 0;
      this._MinBytes = 0;
      this._StepBytes = 0;
      this.Encoding = Data.DefaultEncoding;
      this.Text = s;
    }

    public Data(string s, Encoding encoding)
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      this._MaxBytes = 0;
      this._MinBytes = 0;
      this._StepBytes = 0;
      this.Encoding = Data.DefaultEncoding;
      this.Encoding = encoding;
      this.Text = s;
    }

    public bool IsEmpty => this._b == null || this._b.Length == 0;

    public int StepBytes
    {
      get => this._StepBytes;
      set => this._StepBytes = value;
    }

    public int StepBits
    {
      get => checked (this._StepBytes * 8);
      set => this._StepBytes = value / 8;
    }

    public int MinBytes
    {
      get => this._MinBytes;
      set => this._MinBytes = value;
    }

    public int MinBits
    {
      get => checked (this._MinBytes * 8);
      set => this._MinBytes = value / 8;
    }

    public int MaxBytes
    {
      get => this._MaxBytes;
      set => this._MaxBytes = value;
    }

    public int MaxBits
    {
      get => checked (this._MaxBytes * 8);
      set => this._MaxBytes = value / 8;
    }

    public byte[] Bytes
    {
      get
      {
        if (this._MaxBytes > 0 && this._b.Length > this._MaxBytes)
        {
          byte[] numArray = new byte[checked (this._MaxBytes - 1 + 1)];
          Array.Copy((Array) this._b, (Array) numArray, numArray.Length);
          this._b = numArray;
        }
        if (this._MinBytes > 0 && this._b.Length < this._MinBytes)
        {
          byte[] numArray = new byte[checked (this._MinBytes - 1 + 1)];
          Array.Copy((Array) this._b, (Array) numArray, this._b.Length);
          this._b = numArray;
        }
        return this._b;
      }
      set => this._b = value;
    }

    public string Text
    {
      get
      {
        string str;
        if (this._b == null)
        {
          str = "";
        }
        else
        {
          int count = Array.IndexOf<byte>(this._b, (byte) 0);
          str = count < 0 ? this.Encoding.GetString(this._b) : this.Encoding.GetString(this._b, 0, count);
        }
        return str;
      }
      set => this._b = this.Encoding.GetBytes(value);
    }

    public string Hex
    {
      get => Utils.ToHex(this._b);
      set => this._b = Utils.FromHex(value);
    }

    public string Base64
    {
      get => Utils.ToBase64(this._b);
      set => this._b = Utils.smethod_0(value);
    }

    public new string ToString() => this.Text;

    public string ToBase64() => this.Base64;

    public string ToHex() => this.Hex;
  }
}
