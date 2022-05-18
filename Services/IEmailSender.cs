using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogMvc.Services
{
    interface IEmailSender
    {
        Task SendEmailAsync(string name, string emailFrom, string subject, string htmlMessage);

    }
}
