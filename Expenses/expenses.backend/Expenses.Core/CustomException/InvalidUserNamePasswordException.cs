using System;
using System.Runtime.Serialization;

namespace Expenses.Core.CustomException
{
    public class InvalidUserNamePasswordException : Exception
    {
        public InvalidUserNamePasswordException()
        {
        }

        public InvalidUserNamePasswordException(string message) : base(message)
        {
        }

        public InvalidUserNamePasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidUserNamePasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
