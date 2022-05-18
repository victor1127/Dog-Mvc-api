using DogMvc.Services;
using DogMvc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogMvc.Controllers
{
    public class ContactController : Controller
    {
        private readonly IEmailSender _emailService;
        public ContactController(IEmailSender emailService)
        {
            _emailService = emailService;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactSender([Bind("Name", "Email", "Subject", "Message")] EmailInputModel model)
        {
            await _emailService.SendEmailAsync(model.Name, model.Email, model.Subject, model.Message);
            return RedirectToAction(nameof(Index), "Breeds");
        }
    }
}




