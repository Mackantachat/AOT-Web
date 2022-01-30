using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aot_e_security_frontend.Controllers
{
    public class BookingCalendarController : Controller
    {
        public IActionResult Calendar()
        {
            return View();
        }
    }
}