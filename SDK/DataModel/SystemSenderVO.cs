// Decompiled with JetBrains decompiler
// Type: SDK.DataModel.SystemSenderVO
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SDK.DataModel
{
    [DesignerCategory("code")]
    [GeneratedCode("System.Xml", "4.0.30319.1")]
    [XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    [DebuggerStepThrough]
    [Serializable]
    public class SystemSenderVO
    {
        public string SystemID { get; set; }
        public string LocationID { get; set; }
        public string IP { get; set; }
        public string URL { get; set; }
        public SignatureVO Proof { get; set; }
        [XmlElement(IsNullable = true)]
        public DateTime? DateTimeStamp { get; set; }
    }
}
