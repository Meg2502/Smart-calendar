using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartCalendar.Models;
using Microsoft.EntityFrameworkCore;


namespace SmartCalendar.Pages.Events
{
    public class EventloaderModel : PageModel
    {

        private readonly CalendarContext _context;

        public EventloaderModel(CalendarContext context)
        {
            _context = context;
        }

        public List<Event> Events { get; set; }
        public void OnGet()
        {
            Events = _context.Events.ToList();
        }
       
    }
}
