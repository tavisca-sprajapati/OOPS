using System;

namespace VehicleShowRoom.Entities
{
    public class InValidOrderException : Exception
    {
        public InValidOrderException(string message) : base(message)
        {
        }
    }
}
