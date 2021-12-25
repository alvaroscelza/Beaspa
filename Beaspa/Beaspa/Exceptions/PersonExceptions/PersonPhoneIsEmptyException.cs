using System;

namespace Beaspa.Exceptions
{
    internal class PersonPhoneIsEmptyException : Exception
    {
        public override string Message { get; } = "El teléfono de la Persona no puede estar vacío";
    }
}