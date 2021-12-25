using System;

namespace Beaspa.Exceptions
{
    internal class PersonNameIsEmptyException : Exception
    {
        public override string Message { get; } = "El nombre de la Persona no puede estar vacío";
    }
}