using System.Collections.Generic;
using tal_calendar.Entities;

namespace tal_calendar.Interfaces
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetAll();

        Booking Add(Booking item);
    }
}