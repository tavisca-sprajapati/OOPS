using System;
using VehicleShowRoom.Entities;
using VehicleShowRoom.Core.Contracts;

namespace VehicleShowRoom.Core.Implementations
{
    public class MaintainanceServiceProvider : IVehicleServiceProvider
    {
        IVehicleRepository _vehicleRepository;
        public MaintainanceServiceProvider(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public OrderResponse DoService(OrderRequest vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
