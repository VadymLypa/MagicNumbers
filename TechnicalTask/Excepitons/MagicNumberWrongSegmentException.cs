using System;

namespace TechnicalTask.Excepitons
{
    public class MagicNumberWrongSegmentException : Exception
    {
        public MagicNumberWrongSegmentException(string message) : base(message){}
    }
}
