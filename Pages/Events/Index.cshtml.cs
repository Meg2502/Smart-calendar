using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataAccessLayer;
using Org.BouncyCastle.Asn1;

namespace SmartCalendar.Pages.Events
{
    public class IndexModel : PageModel
    {
        public List<Models.Event> events { get; set; }

        

        public void OnGet()
        {
            events = new List<Models.Event>();

            List<EventDTO> eventDTOs = new EventRepo().GetEvents();

            foreach (var eventDTO in eventDTOs)
            {
                Models.Event ev = new Models.Event();
                ev.Eventid = eventDTO.Eventid;
                ev.Name = eventDTO.Name;
                ev.Date = eventDTO.Date;
                ev.EndDate = eventDTO.EndDate;
                ev.Location = eventDTO.Location;
                events.Add(ev);

            }

            
        }
    }
}
