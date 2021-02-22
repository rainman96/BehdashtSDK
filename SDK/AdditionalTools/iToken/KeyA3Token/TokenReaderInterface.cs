// Decompiled with JetBrains decompiler
// Type: SDK.iToken.KeyA3Token.TokenReaderInterface
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PKTB;
using SDK.AdditionalTools.Basic;
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace SDK.iToken.KeyA3Token
{
  internal class TokenReaderInterface
  {
    private X509Certificate _Certificate;
    private string _SystemID;
    private string _LocationID;
    private string _Username;
    private string _PIN;
    private string _KEY;
    private bool _Active;

    public string Active
    {
      get => Conversions.ToString(this._Active);
      set => this._Active = Conversions.ToBoolean(value);
    }

    public string SystemID
    {
      get => this._SystemID;
      set => this._SystemID = value;
    }

    public string LocationID
    {
      get => this._LocationID;
      set => this._LocationID = value;
    }

    public string Username
    {
      get => this._Username;
      set => this._Username = value;
    }

    public string KEY
    {
      get => this._KEY;
      set => this._KEY = value;
    }

    public string PIN
    {
      get => this._PIN;
      set => this._PIN = value;
    }

    private void ReadCertificate()
    {
      try
      {
        Chronometer time = new Chronometer();
        CertificateCriteria searchCriteria = new CertificateCriteria();
        searchCriteria.AddAndCriteria(CriteriaField.Issuer, (object) "Ministry of Health and Medical Education Sub CA");
        searchCriteria.AddAndCriteria(CriteriaField.InHardToken, (object) true);
        X509Certificate[] windowsByCriteria = (X509Certificate[]) new VAClient().GetCertificateListFromWindowsByCriteria(searchCriteria, WinStoreType.All, WinStoreName.Personal);
        if (windowsByCriteria == null)
          throw new Exception("There is no certificate!");
        this._Certificate = windowsByCriteria.Length != 0 ? windowsByCriteria[0] : throw new Exception("There is no certificate!");
        MainFx.WL((object) "...ReadCertificate Time", ref time);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new Exception("Error at ReadCertificate. ", ex);
      }
    }

    private void ParseCertificate()
    {
      try
      {
        string[] strArray1 = this._Certificate.Subject.Split(',');
        int index = 0;
        while (index < strArray1.Length)
        {
          string[] strArray2 = Strings.Trim(strArray1[index]).Split('=');
          string upper = Strings.Trim(strArray2[0]).ToUpper();
          if (Operators.CompareString(upper, "OU", false) == 0)
            this._LocationID = strArray2[1];
          else if (Operators.CompareString(upper, "T", false) == 0)
            this._SystemID = strArray2[1];
          else if (Operators.CompareString(upper, "CN", false) == 0)
            this._Username = strArray2[1];
          else if (Operators.CompareString(upper, "O", false) == 0)
            Debug.Print("O = " + strArray2[1]);
          checked { ++index; }
        }
        if (Operators.CompareString(this._LocationID, "", false) == 0 | Operators.CompareString(this._SystemID, "", false) == 0 | Operators.CompareString(this._Username, "", false) == 0)
          throw new Exception("Certificate is not contain of valid info. ");
        if (MainFx.GetExpiryDay(DateTime.Parse(this._Certificate.GetExpirationDateString())) <= 0)
          throw new Exception("Certificate has expired. ");
        this._KEY = Crypto.ReadKEY();
        this._PIN = Crypto.ReadPIN();
        this._Active = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new Exception("Error at Certificate. ", ex);
      }
    }

    public byte[] GetCertificate()
    {
      try
      {
        return this._Certificate.Export(X509ContentType.Cert);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new Exception("Error at GetCertificate. ", ex);
      }
    }

    public TokenReaderInterface()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      this.ReadCertificate();
      this.ParseCertificate();
    }

    public TokenReaderInterface(byte[] Certificate)
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
      try
      {
        this._Certificate = new X509Certificate(Certificate);
        this.ParseCertificate();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new Exception("Error at TokenReaderInterface. ", ex);
      }
    }
  }
}
