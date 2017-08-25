using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleShowRoom.Entities;

namespace VehicleShowRoom.Core.Contracts
{
    public interface IOrderManager
    {
        OrderResponse Order(OrderRequest orderRequest);
    }
}
