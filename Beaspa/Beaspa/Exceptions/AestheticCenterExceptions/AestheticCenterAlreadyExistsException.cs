using System;

namespace Beaspa.Exceptions
{
    internal class AestheticCenterAlreadyExistsException : Exception
    {
        public override string Message { get; } = "Ese Centro ya existe.";
    }
}