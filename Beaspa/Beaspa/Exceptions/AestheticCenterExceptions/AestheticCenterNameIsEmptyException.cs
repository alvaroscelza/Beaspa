using System;

namespace Beaspa.Exceptions
{
    internal class AestheticCenterNameIsEmptyException : Exception
    {
        public override string Message { get; } = "El nombre del Centro no puede estar vacío";
    }
}