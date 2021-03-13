using System;
using System.Runtime.Serialization;

namespace Ditas.SDK
{
    [Serializable]
    public class SdkException : Exception
    {
        private string[] messages;
        public string[] Messages => messages;
        public SdkException()
        {
        }
        public SdkException(string[] messages) : base(messages.Length >= 1 ? messages[0] : "")
        {
            this.messages = messages;

        }
        public SdkException(string messages) : base(messages)
        {
            this.messages = new[] { messages };
        }

        public SdkException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SdkException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}