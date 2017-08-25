using System;
using System.Linq;
using VehicleShowRoom.Core.Contracts;

namespace VehicleShowRoom.Core.Implementations
{
    public class RevenueReportProvider : IRevenueReportProvider
    {
        IInvoiceReportService _invoiceReportService;
        public RevenueReportProvider(IInvoiceReportService invoiceReportService)
        {
            _invoiceReportService = invoiceReportService;
        }
        public decimal GetTotalRevenue()
        {
            decimal totalRevenue = 0;

            var invoices = _invoiceReportService.GetAll();

            if(invoices != null && invoices.Count > 0)
            totalRevenue = invoices.Sum(invoice=> invoice.chargedAmount);

            return totalRevenue;
        }
        public decimal GetRevenueByDate(DateTime fromDate, DateTime toDate)
        {
            decimal totalRevenue = 0;

            var invoices = _invoiceReportService.GetByDate(fromDate, toDate);

            if (invoices != null && invoices.Count > 0)
                totalRevenue = invoices.Sum(invoice=>invoice.chargedAmount);

            return totalRevenue; 
        }
    }
}
