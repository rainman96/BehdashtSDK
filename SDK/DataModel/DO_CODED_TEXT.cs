// Decompiled with JetBrains decompiler
// Type: SDK.DataModel.DO_CODED_TEXT
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
    [GeneratedCode("System.Xml", "4.0.30319.1")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://thrita.behdasht.gov.ir/VM/")]
    [Serializable]
    public class DO_CODED_TEXT
    {
        [XmlAttribute]
        public string Value { get; set; }

        [XmlAttribute]
        public string Terminology_id { get; set; }

        [XmlAttribute]
        public string Coded_string { get; set; }
    }
}
