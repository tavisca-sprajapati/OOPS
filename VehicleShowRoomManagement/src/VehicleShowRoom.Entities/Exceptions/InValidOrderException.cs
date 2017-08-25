using System;

namespace VehicleShowRoom.Entities
{
    public class InvalidOrderException : Exception
    {
        public InvalidOrderException(string message) : base(message)
        {
        }
    }
}
