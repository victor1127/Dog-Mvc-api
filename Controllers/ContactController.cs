using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogMvc.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ContactSender(EmailInputModel model)
        {
            return View();
        }
    }
}
