// Decompiled with JetBrains decompiler
// Type: SDK.Token
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using SDK.iToken.KeyA3Token;

namespace SDK
{
  internal class Token
  {
    private TokenReaderInterface _Token;

    public Token()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      this._Token = new TokenReaderInterface();
    }

    internal string SystemID_ByToken() => this._Token.SystemID;

    internal string PIN_ByToken() => this._Token.PIN;

    internal string KEY_ByToken() => this._Token.KEY;

    internal string LocationID_ByToken() => this._Token.LocationID;

    internal string UserID_ByToken() => this._Token.Username;

    internal string TokenSerialNumber_ByToken()
    {
      string str;
      return str;
    }
  }
}
