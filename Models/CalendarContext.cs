using Microsoft.EntityFrameworkCore;

namespace SmartCalendar.Models
{
    public class CalendarContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public CalendarContext(DbContextOptions options) : base(options)
        {
            
    }
    }
}
