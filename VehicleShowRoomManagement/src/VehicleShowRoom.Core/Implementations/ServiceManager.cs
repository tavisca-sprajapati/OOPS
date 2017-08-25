using VehicleShowRoom.Entities;
using VehicleShowRoom.Core.Contracts;
using System;

namespace VehicleShowRoom.Core.Implementations
{
    public class ServiceManager : IServiceManager
    {
        IInvoiceGenerator _invoiceGenerator;
        IVehicleServiceProvider _serviceProvider;
        public ServiceManager(IInvoiceGenerator invoiceGenerator, IVehicleServiceProvider serviceProvider)
        {
            _invoiceGenerator = invoiceGenerator;
            _serviceProvider = serviceProvider;
        }

        public Invoice GenerateInvoice(OrderResponse orderResponse, OrderRequest orderRequest)
        {
            return _invoiceGenerator.CreateInvoice(orderResponse.Product, orderRequest.Customer);
        }
        
        public OrderResponse Order(OrderRequest orderRequest)
        {
            return _serviceProvider.DoService(orderRequest);
        }
    }
}
