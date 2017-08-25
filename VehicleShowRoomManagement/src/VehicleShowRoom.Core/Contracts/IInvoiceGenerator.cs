using VehicleShowRoom.Entities;

namespace VehicleShowRoom.Core.Contracts
{
    public interface IInvoiceGenerator
    {
        Invoice CreateInvoice(Product product, Customer customer);
    }
}
