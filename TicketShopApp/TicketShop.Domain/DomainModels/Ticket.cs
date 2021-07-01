using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TicketShop.Domain.DomainModels
{
    public class Ticket:BaseEntity
    {

        [Required]
        public string TicketName { get; set; }
        [Required]
        public string TicketImage { get; set; }
        [Required]
        public string TicketDescription { get; set; }
        [Required]
        public int TicketPrice { get; set; }
        [Required]
        public int Rating { get; set; }

        public DateTime ValidDate { get; set; }

        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
        public IEnumerable<TicketOrder> TicketsInOrders { get; set; }
    }
}
