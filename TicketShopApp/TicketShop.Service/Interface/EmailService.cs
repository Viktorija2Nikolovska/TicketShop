using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TicketShop.Domain.DomainModels;

namespace TicketShop.Service.Interface
{
    interface EmailService
    {

        Task SendEmailAsync(List<EmailMessage> allMails);
    }
}
