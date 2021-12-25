using System;

namespace Beaspa.Exceptions
{
    internal class PersonMedicSocietyIsEmptyException : Exception
    {
        public override string Message { get; } = "La Sociedad Médica de la Persona no puede estar vacía";
    }
}