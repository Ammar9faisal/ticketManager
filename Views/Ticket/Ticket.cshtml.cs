using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ticketManager.Views
{
    public class Ticket : PageModel
    {
        private readonly ILogger<Ticket> _logger;

        public Ticket(ILogger<Ticket> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}