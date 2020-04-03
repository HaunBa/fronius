using System;
using System.Runtime.Serialization;

namespace _20200328_arraystack
{
    [Serializable]
    internal class StackFullException : Exception
    {
        public StackFullException()
        {
        }

        public StackFullException(string message) : base(message)
        {
        }

        public StackFullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StackFullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}