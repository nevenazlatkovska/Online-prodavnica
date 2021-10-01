using Store.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> getAllOrders();
        Order getOrderDetails(BaseEntity model);
    }
}
