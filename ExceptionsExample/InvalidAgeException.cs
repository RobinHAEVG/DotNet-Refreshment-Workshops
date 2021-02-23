using System;

namespace ExceptionsExample
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message = null) : base(message)
        { }
    }
}
