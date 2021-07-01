using System;
using System.Collections.Generic;
using System.Text;
using TicketShop.Domain.DomainModels;

namespace TicketShop.Service.Interface
{
    public interface OrderService
    {

        List<Order> getAllOrders();

        Order getOrderDetails(BaseEntity model);
    }
}
