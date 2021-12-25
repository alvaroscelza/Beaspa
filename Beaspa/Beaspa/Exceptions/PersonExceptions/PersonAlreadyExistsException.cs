using System;

namespace Beaspa.Exceptions
{
    internal class PersonAlreadyExistsException : Exception
    {
        public override string Message { get; } = "Esa Persona ya existe.";
    }
}