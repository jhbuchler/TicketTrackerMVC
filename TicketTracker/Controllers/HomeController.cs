using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TicketTracker.Models;
using TicketTrackerModels;

namespace TicketTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TestPage()
        {
            var t = new Ticket();
            t.Id = 27;
            t.TicketPriority = Priority.Routine;
            t.TicketStatus = Status.Open;
            t.TicketCreatedBy = "John Conner";
            t.StakeholderEmails = "bob@gmail.com";
            t.Issue = "User can't create category";
            t.HoursOfLabor = 45;
            t.Resolution = null;
            t.Description = "Some issues going on here";

            ViewData["MyCustomKey"] = "This is my data";

            return View(t);
        }

        public IActionResult SimpleDataPage()
        {
            var s = new List<string>();
            ViewData["MyCustomKey"] = "This is my data";
            s.Add("Data 1");
            s.Add("Data 2");
            s.Add("Data 3");
            return View(s);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}