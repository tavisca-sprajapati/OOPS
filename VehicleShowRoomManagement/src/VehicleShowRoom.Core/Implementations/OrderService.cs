using System;
using System.Collections.Generic;
using VehicleShowRoom.Entities;
using VehicleShowRoom.Core.Contracts;

namespace VehicleShowRoom.Core.Implementations
{
    public class OrderService : IOrderService
    {
        IServiceManager _serviceManager;
        public OrderService()
        {
        }
        public OrderResponse Order(OrderRequest orderRequest)
        {
            _serviceManager = GetServiceManager(orderRequest);
            
            Invoice invoice = null;
            OrderStatus status = null;
            OrderResponse orderResponse = null;
            try
            {
                orderResponse = _serviceManager.Order(orderRequest);
                if (IsOrderConfirmed(orderResponse))
                {
                    invoice = _serviceManager.GenerateInvoice(orderResponse, orderRequest);
                }

            }
            catch (InvalidOrderException exception)
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
        private IServiceManager GetServiceManager(OrderRequest orderRequest)
        {
            IInvoiceGenerator invoiceGenerator = new InvoiceFactory().GetInvoiceGenerator();
            return new ServiceManager(invoiceGenerator);
        }
    }
}
