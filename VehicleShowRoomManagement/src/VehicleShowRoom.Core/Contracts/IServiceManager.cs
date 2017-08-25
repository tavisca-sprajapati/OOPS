using VehicleShowRoom.Entities;

namespace VehicleShowRoom.Core.Contracts
{
    public interface IServiceManager
    {
        OrderResponse DoService(OrderRequest vehicle);
        Invoice GenerateInvoice(OrderResponse orderResponse, OrderRequest orderRequest);
    }
}
