using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Microsoft.AspNetCore.Identity;
using tal_calendar.Entities;
using tal_calendar.Interfaces;

namespace tal_calendar.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private List<Booking> bookings = new List<Booking>();
        private int _nextId = 1;
        
        public BookingRepository()
        {
            Add(new Booking {Id = 1, start = new DateTime(2022, 1, 16, 11, 00, 00), end = new DateTime(2022, 1, 16, 11, 30, 00) });
            Add(new Booking {Id = 1, start = new DateTime(2022, 1, 16, 12, 00, 00), end = new DateTime(2022, 1, 16, 12, 30, 00) });
            Add(new Booking {Id = 1, start = new DateTime(2022, 1, 16, 12, 30, 00), end = new DateTime(2022, 1, 16, 13, 00, 00) });
            Add(new Booking {Id = 1, start = new DateTime(2022, 1, 16, 15, 30, 00), end = new DateTime(2022, 1, 16, 16, 00, 00) });
            Add(new Booking {Id = 1, start = new DateTime(2022, 1, 16, 9, 30, 00), end = new DateTime(2022, 1, 16, 10, 00, 00) });
        }

        public IEnumerable<Booking> GetAll()
        {
            return bookings;
        }
        
        public Booking Add(Booking item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            item.Id = _nextId++;
            bookings.Add(item);
            return item;
        }
    }
}