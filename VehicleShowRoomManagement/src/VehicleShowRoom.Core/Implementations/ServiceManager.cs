using VehicleShowRoom.Entities;
using VehicleShowRoom.Core.Contracts;
using System;

namespace VehicleShowRoom.Core.Implementations
{
    public class ServiceManager : IServiceManager
    {
        IInvoiceGenerator _invoiceGenerator;
        IVehicleServiceProvider _serviceProvider;
        public ServiceManager(IInvoiceGenerator invoiceGenerator)
        {
            _invoiceGenerator = invoiceGenerator;
        }

        public Invoice GenerateInvoice(OrderResponse orderResponse, OrderRequest orderRequest)
        {
            return _invoiceGenerator.CreateInvoice(orderResponse.Product, orderRequest.Customer);
        }
        
        public OrderResponse Order(OrderRequest orderRequest)
        {
            _serviceProvider = new ServiceFactory().GetServiceProvider(orderRequest.OrderType);
            return _serviceProvider.DoService(orderRequest);
        }
    }
}
