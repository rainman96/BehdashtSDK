// Decompiled with JetBrains decompiler
// Type: SDK.URLManagment
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll


using SDK.AdditionalTools.Basic;
using SDK.DataModel;
using System;
using System.Diagnostics;
using System.IO;

namespace SDK
{
  public class URLManagment
  {
    [DebuggerNonUserCode]
    public URLManagment()
    {
      Class2.gT0CJODzw5nbC();
      // ISSUE: explicit constructor call
    }

    public static void SyncWithEyeofProvidence(string FilePath)
    {
      try
      {
        Chronometer chronometer = new Chronometer();
        SDK.ClientWebService.EyeOfProvidence.EyeOfProvidence eyeOfProvidence = new SDK.ClientWebService.EyeOfProvidence.EyeOfProvidence();
        eyeOfProvidence.Url = "https://eop3.behdasht.gov.ir/eyeofprovidence.asmx";
        try
        {
          Variable variable = new Variable();
          MainFx mainFx = new MainFx();
          eyeOfProvidence.HeaderMessageVOValue = new HeaderMessageVO();
          eyeOfProvidence.HeaderMessageVOValue.Sender = new SystemSenderVO();
          eyeOfProvidence.HeaderMessageVOValue.Sender.LocationID = variable.GetLocationID();
          eyeOfProvidence.HeaderMessageVOValue.Sender.SystemID = variable.GetSystemID();
          eyeOfProvidence.HeaderMessageVOValue.Sender.URL = variable.method_0();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw new Exception("Error at Configuration.", ex);
        }
        URLPackageVO urlPackageVo1;
        try
        {
          urlPackageVo1 = eyeOfProvidence.GetPath();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw new Exception("first blindness.", ex);
        }
        if (urlPackageVo1.Channel.Count > 1)
        {
          URLPackageVO urlPackageVo2 = new URLPackageVO();
          URLPackageVO urlPackageVo3;
          try
          {
            urlPackageVo3 = (URLPackageVO) new Crypto().UnSecuredObjectByTokenKey(urlPackageVo1.Channel.ToArray(), urlPackageVo2.GetType());
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            throw new Exception(MainFx.CreateException("Channel. ", ex));
          }
          urlPackageVo1 = urlPackageVo3;
        }
        try
        {
          try
          {
            if (File.Exists(FilePath))
              File.Delete(FilePath);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            throw new Exception("delete access.");
          }
          using (BinaryWriter binaryWriter = new BinaryWriter((Stream) File.Open(FilePath, FileMode.Create)))
            binaryWriter.Write(urlPackageVo1.ToByte());
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw new Exception("write access.");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new Exception("Error at SyncWithEyeofProvidence. ", ex);
      }
    }

    public static URLPackageVO smethod_0()
    {
      LogWriter logWriter = new LogWriter();
      bool flag = false;
      try
      {
        string str = AppDomain.CurrentDomain.BaseDirectory + "SDK.bin";
        URLPackageVO urlPackageVo = new URLPackageVO();
        if (!File.Exists(str))
        {
          try
          {
            URLManagment.SyncWithEyeofProvidence(str);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            throw new Exception("first blindness.", ex);
          }
          urlPackageVo.Read(str);
        }
        else
        {
          urlPackageVo.Read(str);
          double num = (double) DateAndTime.DateDiff(DateInterval.Minute, urlPackageVo.ModifiedDate, DateTime.Now);
          string txt1 = Conversions.ToString(DateTime.Now.ToFileTimeUtc()) + "|...SyncWithEyeofProvidence : ModifiedDate = |" + urlPackageVo.ModifiedDate.ToShortDateString();
          if (flag)
            logWriter.method_0(txt1);
          string txt2 = Conversions.ToString(DateTime.Now.ToFileTimeUtc()) + "|...SyncWithEyeofProvidence : TTL = |" + Conversions.ToString(num);
          if (flag)
            logWriter.method_0(txt2);
          string txt3 = Conversions.ToString(DateTime.Now.ToFileTimeUtc()) + "|...SyncWithEyeofProvidence : U.TTL = |" + Conversions.ToString(urlPackageVo.TTL);
          if (flag)
            logWriter.method_0(txt3);
          if (num >= urlPackageVo.TTL)
          {
            if (flag)
              logWriter.method_0("----------------------------------------------------------------------");
            string txt4 = Conversions.ToString(DateTime.Now.ToFileTimeUtc()) + "|...SyncWithEyeofProvidence : ttl >= U.TTL  Must be Update ";
            if (flag)
              logWriter.method_0(txt4);
            try
            {
              URLManagment.SyncWithEyeofProvidence(str);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              throw new Exception("Second blindness.", ex);
            }
            urlPackageVo.Read(str);
          }
        }
        return Operators.CompareString(urlPackageVo.BlockMessage, "", false) == 0 ? urlPackageVo : throw new Exception(urlPackageVo.BlockMessage);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw new Exception("Network. ", ex);
      }
    }
  }
}
