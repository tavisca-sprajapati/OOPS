using VehicleShowRoom.Entities;
using VehicleShowRoom.Core.Contracts;
using VehicleShowRoom.Core.Implementations;

namespace VehicleShowRoom.Core
{
    public class ServiceFactory
    {
        public IVehicleServiceProvider GetServiceProvider(OrderType orderType)
        {
            IVehicleServiceProvider provider = null;
            IVehicleRepository vehicleRepository = new VehicleRepository();
            switch (orderType)
            {
                case OrderType.Buy:
                    provider = new PurchaseServiceProvider(vehicleRepository);
                    break;
                case OrderType.Rent:
                    provider = new RentServiceProvider(vehicleRepository);
                    break;
                case OrderType.TestDrive:
                    provider = new TestDriveServiceProvider(vehicleRepository);
                    break;
                case OrderType.Maintainance:
                    provider = new MaintainanceServiceProvider(vehicleRepository);
                    break;
                default:
                    throw new InvalidOrderException(Constants.ErrorMessage.InvalidOrder) ;
            }
            return provider;
        }
    }
}
