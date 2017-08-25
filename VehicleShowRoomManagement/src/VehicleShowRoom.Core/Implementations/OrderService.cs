using System;
using System.Collections.Generic;
using VehicleShowRoom.Entities;
using VehicleShowRoom.Core.Contracts;

namespace VehicleShowRoom.Core.Implementations
{
    public class OrderService : IOrderService
    {
        IVehicleServiceProvider _serviceProvider;
        IServiceManager _serviceManager;
        IInvoiceGenerator _invoiceGenerator;
        public OrderService()
        {
            _invoiceGenerator = new InvoiceFactory().GetInvoiceGenerator();
        }
        public OrderResponse Order(OrderRequest orderRequest)
        {

            _serviceProvider = new ServiceFactory().GetServiceProvider(orderRequest.OrderType);

            _serviceManager = new ServiceManager(_invoiceGenerator, _serviceProvider);

            Invoice invoice = null;
            OrderStatus status = null;
            OrderResponse orderResponse = null;
            try
            {
                orderResponse = _serviceManager.DoService(orderRequest);
                if (IsOrderConfirmed(orderResponse))
                {
                    invoice = _serviceManager.GenerateInvoice(orderResponse, orderRequest);
                }

            }
            catch (InValidOrderException exception)
            {
                status = GetOrderStatus(exception, Constants.ErrorCode.InvalidOrder);
                orderResponse = new OrderResponse { Status = status };
            }
            catch (Exception exception)
            {
                status = GetOrderStatus(exception, Constants.ErrorCode.Default);
                orderResponse = new OrderResponse { Status = status };
            }
            
            return orderResponse;
        }

        private static bool IsOrderConfirmed(OrderResponse orderResponse)
        {
            return orderResponse != null 
                && orderResponse.Status != null 
                && orderResponse.Status.Status == StatusOptions.Success;
        }

        private OrderStatus GetOrderStatus(Exception exception, string errorCode)
        {
             var errors = new List<ErrorInformation> { new ErrorInformation { ErrorCode = errorCode, ErrorMessage = exception.ToString() } };
            return new OrderStatus { Status = StatusOptions.Failure, errors = errors };
        }
    }
}
