using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.Constants
{
    public class Enumarations
    {

        public enum ChannelType
        {
            Rest,
            Soap
        }
        public enum InsuranceType
        {
            Tamin = 1,
            Salamt = 2,
            NirohayeMosallah = 3,
            Azad = 37,
        }
        public enum PrescType
        {
            Drug = 1,
            Paracilinic = 2,
            Visit = 3,
            DrService = 5
        }
        public enum LogLevel
        {
            Off,
            Info,
            Warn,
            Debug,
            Error,
            Fatal,
            All,
        }
    }
}
