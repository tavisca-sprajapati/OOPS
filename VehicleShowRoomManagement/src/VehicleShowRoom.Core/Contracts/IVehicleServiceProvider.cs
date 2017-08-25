using VehicleShowRoom.Entities;

namespace VehicleShowRoom.Core.Contracts
{
    public interface IVehicleServiceProvider
    {
        OrderResponse DoService(OrderRequest vehicle);
    }
}
