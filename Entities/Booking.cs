using System;

namespace tal_calendar.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}