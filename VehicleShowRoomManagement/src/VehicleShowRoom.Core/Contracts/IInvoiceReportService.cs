using System;
using System.Collections.Generic;
using VehicleShowRoom.Entities;

namespace VehicleShowRoom.Core.Contracts
{
    public interface IInvoiceReportService : IReportService<Invoice>
    {
        List<Invoice> GetByDate(DateTime fromDate, DateTime toDate);

        List<Invoice> GetBy(Func<Invoice, bool> condition);

        Invoice Get(int id);
    }
}
