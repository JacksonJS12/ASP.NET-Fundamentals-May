using Homies.Data;
using Homies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homies.Controllers
{
    public class EventController : Controller
    {
        private readonly HomiesDbContext _context;

        public EventController(HomiesDbContext context)
        {
            _context = context;
        }

        // GET: Event/All
        public async Task<IActionResult> All()
        {
            List<EventViewModel> events = await _context.Events
                .Select(e => new EventViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start.ToString("yyyy-MM-dd H:mm"),
                    Type = e.Type.Name,
                    Organiser = e.Organiser.UserName
                })
                .ToListAsync();

            return View(events);
        }

        // Other action methods (e.g., Create, Edit, Delete) can be added here

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}