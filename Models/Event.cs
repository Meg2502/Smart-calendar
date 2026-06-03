using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace SmartCalendar.Models
{
    public class Event
    {
        public int Eventid { get; set; }
        public string Name { get; set; }
        [Display(Name = "Kei vette Title, Jonguh!")]
        public DateTime Date { get; set; }
        public DateTime? EndDate { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Note { get; set; }
        public string Colour { get; set; }

        public void AdditionalDateSetter()
        {
            if (EndDate == null)
            {
                EndDate = Date;
            }
            
        }

        public void DateTimeChecker()
        {
            if (EndDate <= Date)
            {
                throw new InvalidOperationException("End date can't be earlier than the start date."); 
            }
        }


        public Event()
        { }
        public Event(string name, DateTime date, DateTime? enddate, string location, DateTime starttime, DateTime endtime, string note, string colour)
        {
            Name= name;
            Date= date;
            EndDate= enddate;
            Location= location;
            StartTime= starttime;
            EndTime= endtime;
            Note= note;
            Colour= colour;
        }
    }
}
