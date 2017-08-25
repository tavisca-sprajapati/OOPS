using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleShowRoom.Core.Contracts;
using VehicleShowRoom.Core.Implementations;
using VehicleShowRoom.Entities;

namespace VehicleShowRoom.Core.Test
{
    [TestClass]
    public class OrderServiceTest
    {
        [TestMethod]
        public void Test_Order_service()
        {
            OrderRequest request = GetOrderRequest();
            IOrderService orderService = GetOrderServiceProvider();

            var orderResponse = orderService.Order(request);

            Assert.IsNotNull(orderResponse);
            Assert.AreEqual(orderResponse.Status, StatusOptions.Success);
            Assert.IsNotNull(orderResponse.Invoice);

            IRevenueReportProvider reportProvider = GetRevenueReportProvider();

            decimal totalRevenue = reportProvider.GetTotalRevenue();
        }

        private IOrderService GetOrderServiceProvider()
        {
            return new OrderService();
        }

        private IRevenueReportProvider GetRevenueReportProvider()
        {
            return new RevenueReportProvider(new InvoiceReportService(new InvoiceRepository()));
        }

        private OrderRequest GetOrderRequest()
        {
            return new OrderRequest();
        }
    }
}
