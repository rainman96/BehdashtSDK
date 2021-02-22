// Decompiled with JetBrains decompiler
// Type: SDK.DataModel.URLPackageVO
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace SDK.DataModel
{
    //[GeneratedCode("System.Xml", "4.0.30319.1")]
    //[DesignerCategory("code")]
    //[XmlType(Namespace = "http://HIX.MOHME.IR/")]
    //[Serializable]
    //public class URLPackageVO
    //{

    //    public byte[] ToByte()
    //    {
    //        try
    //        {
    //            return new Crypto().SecuredObjectByTokenKey((object)this);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Error at ToByte. ", ex);
    //        }
    //    }

    //    public void Read(string FilePath)
    //    {
    //        try
    //        {
    //            URLPackageVO urlPackageVo = File.Exists(FilePath) ? (URLPackageVO)new Crypto().UnSecuredObjectByTokenKey(File.ReadAllBytes(FilePath), new URLPackageVO().GetType()) : throw new Exception("File not found. ");
    //            BlockMessage = urlPackageVo.BlockMessage;
    //            Channel = urlPackageVo.Channel;
    //            ModifiedDate = urlPackageVo.ModifiedDate;
    //            TTL = urlPackageVo.TTL;
    //            URLs = urlPackageVo.URLs;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Error at Read. ", ex);
    //        }
    //    }

    //    public string GetURL(string ServiceName, string ServiceMode)
    //    {
    //        try
    //        {
    //            ServiceURLVO serviceUrlvo = new ServiceURLVO();
    //            return (URLs.Find((Predicate<ServiceURLVO>)(x => x.ServiceName == ServiceName & x.ServiceMode == ServiceMode)) ?? throw new Exception("URL is not define.")).ServiceURL;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Error at GetURL. ", ex);
    //        }
    //    }

    //    public URLPackageVO()
    //    {
    //        Class2.gT0CJODzw5nbC();
    //        // ISSUE: explicit constructor call
    //       URLs = new List<ServiceURLVO>();
    //       Channel = new List<byte>();
    //    }

    //    public DateTime ModifiedDate { get; set; }

    //    public double TTL { get; set; }

    //    public string BlockMessage { get; set;   }

    //    public List<ServiceURLVO> URLs { get; set; }
    //    public List<byte> Channel { get; set; }
    //}
}
