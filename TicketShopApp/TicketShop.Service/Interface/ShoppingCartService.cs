using System;
using System.Collections.Generic;
using System.Text;
using TicketShop.Domain.Dto;

namespace TicketShop.Service.Interface
{
    public interface ShoppingCartService
    {

        ShoppingCartDto getShoppingCartInfo(string userId);
        bool deleteProductFromShoppingCart(string userId, Guid id);
        bool orderNow(string userId);
    }
}
