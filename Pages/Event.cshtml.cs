using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartCalendar.Pages
{
    public class EventModel : PageModel
    {
        [BindProperty]
        public EventInput input { get; set; }
        public void OnGet()
        {
            
        }

    }
    public class Event
    {
        public Date Date { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }

    }
}
