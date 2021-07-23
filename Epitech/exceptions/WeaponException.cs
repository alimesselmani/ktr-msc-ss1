using System;

namespace Epitech.exceptions
{
    public class WeaponException : Exception
    {
        public WeaponException(string message) : base(message) { }
    }
}