using VehicleShowRoom.Entities;

namespace VehicleShowRoom.Core.Contracts
{
    public interface IOrderService
    {
        OrderResponse Order(OrderRequest orderRequest);
    }
}
