using VehicleShowRoom.Core.Implementations;
using VehicleShowRoom.Core.Contracts;

namespace VehicleShowRoom.Core
{
    public class InvoiceFactory
    {
        public IInvoiceGenerator GetInvoiceGenerator()
        {
            IInvoiceRepository invoiceRepository = new InvoiceRepository();
            return new InvoiceGenerator(invoiceRepository);
        }
    }
}
