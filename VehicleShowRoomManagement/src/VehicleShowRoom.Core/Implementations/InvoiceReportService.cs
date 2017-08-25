using System;
using System.Collections.Generic;
using System.Linq;
using VehicleShowRoom.Entities;
using VehicleShowRoom.Core.Contracts;

namespace VehicleShowRoom.Core.Implementations
{
    public class InvoiceReportService : IInvoiceReportService
    {
        IInvoiceRepository _invoiceRepository;
        public InvoiceReportService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public Invoice Get(int id)
        {
            return _invoiceRepository.Get(id);
        }

        public List<Invoice> GetAll()
        {
            return _invoiceRepository.GetAll();
        }

        public List<Invoice> GetBy(Func<Invoice, bool> condition)
        {
            return GetAll().Where(condition).ToList();
        }

        public List<Invoice> GetByDate(DateTime fromDate, DateTime toDate)
        {
            return GetBy(invoice => invoice.CreateDate >= fromDate && invoice.CreateDate <= toDate);
        }
    }
}
