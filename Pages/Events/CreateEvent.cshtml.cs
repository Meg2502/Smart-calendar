using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartCalendar.Models;

namespace SmartCalendar.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        [BindProperty]
        public Event inputEvent { get; set; }
        public void OnGet()
        {
            
        }
        public void OnPost(Event e)
        {
            
            Event.EndDate ??= Event.Date;

            
            return Page();
        }
       
    }
}
