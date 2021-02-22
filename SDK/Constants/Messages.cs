using System;

namespace Ditas.SDK.Constants
{
    internal class Messages
    {
        public static readonly (bool, string, string) OK=(true, "", "");
        internal static (bool State, string Message, string FieldName) ValueIsNullMessage(string fieldName)
        {
           return (false, $"The value of {fieldName} is null or empty", fieldName);
        }

        internal static (bool State, string Message, string FieldName) InvalidFieldValue(string fieldName)
        {
            return (false, $"Invalid {fieldName} field value", fieldName);
        }
    }
}