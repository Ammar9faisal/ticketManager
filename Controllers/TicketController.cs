using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ticketManager.Controllers
{
    public class TicketController : Controller
    {
       public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create() //returns the Create view for task
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(string title, string description, TicketPriority priority) //creates a new ticket based on user input
    {
        Ticket newTicket = new Ticket(title, description, priority);
        // Here you would typically save the ticket to a database
        return RedirectToAction("Details", new { id = newTicket.Id });
    }
    }
}