using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ticketManager.Data;
using ticketManager.Models;

namespace ticketManager.Controllers
{
    public class TicketController : Controller
    {
        private readonly TicketDbContext _context;

        public TicketController(TicketDbContext context)
        {
            _context = context;
        }

        // GET: /Ticket - Show all tickets
        public IActionResult Index()
        {
            var tickets = _context.Tickets.ToList();
            return View(tickets);
        }

        // GET: /Ticket/Create - Show create form
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Ticket/Create - Handle form submission
        [HttpPost]
        public IActionResult Create(string title, string description, TicketPriority priority)
        {
            var ticket = new Ticket(title, description, priority);
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: /Ticket/Details/{id}
        public IActionResult Details(Guid id)
        {
            var ticket = _context.Tickets.Find(id);
            if (ticket == null)
                return NotFound();
            
            return View(ticket);
        }

        // POST: /Ticket/Delete/{id}
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var ticket = _context.Tickets.Find(id);
            if (ticket != null)
            {
                _context.Tickets.Remove(ticket);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}