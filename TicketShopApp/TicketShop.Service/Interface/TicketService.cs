using System;
using System.Collections.Generic;
using System.Text;
using TicketShop.Domain.DomainModels;
using TicketShop.Domain.Dto;

namespace TicketShop.Service.Interface
{
    public interface TicketService
    {

        List<Ticket> GetAllProducts();
        Ticket GetDetailsForTicket(Guid? id);
        void CreateNewProduct(Ticket t);
        void UpdeteExistingProduct(Ticket t);
        AddToShoppingCartDto GetShoppingCartInfo(Guid? id);
        void DeleteProduct(Guid id);
        bool AddToShoppingCart(AddToShoppingCartDto item, string userID);
    }
}
