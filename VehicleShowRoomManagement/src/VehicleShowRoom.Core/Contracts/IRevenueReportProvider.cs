using System;

namespace VehicleShowRoom.Core.Contracts
{
    public interface IRevenueReportProvider
    {
        decimal GetTotalRevenue();
        decimal GetRevenueByDate(DateTime fromDate, DateTime toDate);
    }
}
