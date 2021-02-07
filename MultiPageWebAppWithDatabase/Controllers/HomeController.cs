using System.Linq;
using Ch04ContactList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ch04ContactList.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = context.Contacts.Include(c => c.Note)
                .OrderBy(c => c.Name).ToList();
           
            return View(contacts);
        }
    }
}
