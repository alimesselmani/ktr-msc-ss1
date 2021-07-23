using System;

namespace epitech.exceptions
{
    public class WeaponException : Exception
    {
        public WeaponException(string message) : base(message) { }
    }
}