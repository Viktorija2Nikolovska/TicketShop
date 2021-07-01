using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketShopAdminApp.Models
{
    public class Ticket
    {

        public string TicketName { get; set; }

        public string TicketImage { get; set; }

        public string TicketDescription { get; set; }

        public int TicketPrice { get; set; }

        public int Rating { get; set; }
    }
}
