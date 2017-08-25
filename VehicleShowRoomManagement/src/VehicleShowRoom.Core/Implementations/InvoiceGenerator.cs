using System;
using VehicleShowRoom.Entities;
using VehicleShowRoom.Core.Contracts;

namespace VehicleShowRoom.Core.Implementations
{
    public class InvoiceGenerator : IInvoiceGenerator
    {
        IInvoiceRepository _invoiceRepository;
        public InvoiceGenerator(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        public Invoice CreateInvoice(Product product, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
