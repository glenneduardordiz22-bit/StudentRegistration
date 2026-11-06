using System;

namespace StudentRegistration
{
    
    public class EmptyFileException : Exception
    {
        public EmptyFileException() : base("The selected file is empty.") { }
    }
}
