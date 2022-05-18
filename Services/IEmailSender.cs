using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogMvc.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string name, string emailFrom, string subject, string htmlMessage);

    }
}
