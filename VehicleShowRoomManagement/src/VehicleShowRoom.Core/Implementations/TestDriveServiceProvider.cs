using System;
using VehicleShowRoom.Entities;
using VehicleShowRoom.Core.Contracts;

namespace VehicleShowRoom.Core.Implementations
{
    public class TestDriveServiceProvider : IVehicleServiceProvider
    {
        IVehicleRepository _vehicleRepository;
        public TestDriveServiceProvider(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public OrderResponse DoService(OrderRequest vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
