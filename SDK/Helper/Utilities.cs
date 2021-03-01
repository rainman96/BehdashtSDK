using Ditas.SDK.Mappers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using static Ditas.SDK.Constants.Enumarations;

namespace Ditas.SDK.Helper
{
    public class Utilities
    {
        public static string ToJson<T>(T secureRequest)
        {
            return JsonConvert.SerializeObject(secureRequest);
        }
        public static T JsonTextToModel<T>(string secureRequest)
        {
            return JsonConvert.DeserializeObject<T>(secureRequest);
        }

        public static string GetClientIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var item in host.AddressList)
            {
                if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    return item.ToString();
            }
            return "192.255.255.254";
        }

        public static T GetModelFromXmlFile<T>(string filename)
        {
            if (string.IsNullOrEmpty(filename)) return default;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (Stream file = File.OpenRead(filename))
            {
                return (T)xmlSerializer.Deserialize(file);
            }
        }

        internal static InsuranceType GetOrganizationType(string code_string)
        {
            if (string.IsNullOrEmpty(code_string))
                throw new ArgumentOutOfRangeException("value of Insurance is null or empty");

            if (int.TryParse(code_string, out int index))
            {
                return (InsuranceType)index;
            }
            throw new ArgumentOutOfRangeException("Unable detect insurance type");
        }
        internal static T ToServiceHeader<T>(HeaderMessageVO headerMessage)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(headerMessage));
        }
        internal static string ToXmlString<T>(T input)
        {
            XmlSerializer convertor = new XmlSerializer(typeof(T));
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    convertor.Serialize(writer, input);
                    xml = sww.ToString();
                }
            }
            return xml;
        }

        internal static int ToIntSafe(string value, string fieldName = "")
        {
            if (string.IsNullOrEmpty(value) || !int.TryParse(value, out int number)) throw new ArgumentOutOfRangeException($"{(string.IsNullOrEmpty(fieldName) ? "value" : fieldName)} isn't a number");

            return number;
        }

        public static bool ValidateIranianNationalCode(string nationalCode)
        {
            if (string.IsNullOrEmpty(nationalCode) || nationalCode.Length != 10)
            {
                return false;
            }
            var value = 0;
            var controller = Convert.ToInt32(nationalCode[9].ToString());//last Char
            int positionValue = 10;
            for (int i = 0; i < 9; i++)
            {
                value += (Convert.ToInt32(nationalCode[i].ToString()) * positionValue--);
            }
            var checkpoint = value % 11;

            if (checkpoint < 2)
            {
                return controller == checkpoint;
            }
            else
            {
                return controller == (11 - checkpoint);
            }
        }

    }
}
