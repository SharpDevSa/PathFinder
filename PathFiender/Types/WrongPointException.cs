using System;

namespace PathFiender.Types
{
    public class WrongPointException : Exception
    {
        public WrongPointException() : base("Wrong point") { }
    }
}
