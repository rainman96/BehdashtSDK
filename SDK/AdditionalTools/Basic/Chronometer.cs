// Decompiled with JetBrains decompiler
// Type: SDK.AdditionalTools.Basic.Chronometer
// Assembly: MiniNPKTB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D5825BBB-35B6-4801-B637-4BC736209947
// Assembly location: C:\Users\Reza\Downloads\Compressed\de4dot-master\de4dot-master\Debug\netcoreapp3.1\MiniNPKTB-cleaned.dll

using Microsoft.VisualBasic.CompilerServices;
using System;

namespace SDK.AdditionalTools.Basic
{
  public class Chronometer
  {
    public DateTime StartEvent;
    public DateTime EndEvent;

    

    public double EventStop()
    {
      this.EndEvent = DateTime.Now;
      try
      {
        return (this.EndEvent - this.StartEvent).TotalMilliseconds;
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at EventStop", ex);
      }
    }

    public void EventStart() => this.StartEvent = DateTime.Now;

    public TimeSpan GetTimeSpan()
    {
      try
      {
        return this.EndEvent - this.StartEvent;
      }
      catch (Exception ex)
      {
      
        throw new Exception("Error at GetTimeSpan", ex);
      }
    }
  }
}
