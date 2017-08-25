using System.Collections.Generic;

namespace VehicleShowRoom.Entities
{
    public class OrderStatus
    {
        public StatusOptions Status;

        public List<ErrorInformation> errors;
    }
}
