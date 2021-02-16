using System;
using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime.ToString("MMM dd, yyyy HH:mm tt");
            return View();
        }

        // DateTime Info
        // https://docs.microsoft.com/en-us/dotnet/api/system.globalization.datetimeformatinfo?view=net-5.0
    }
}