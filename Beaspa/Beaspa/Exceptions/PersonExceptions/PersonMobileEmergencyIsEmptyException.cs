using System;

namespace Beaspa.Exceptions
{
    internal class PersonMobileEmergencyIsEmptyException : Exception
    {
        public override string Message { get; } = "La Emergencia Móvil de la Persona no puede estar vacía";
    }
}