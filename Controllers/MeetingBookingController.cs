using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tal_calendar.Entities;
using tal_calendar.Interfaces;

namespace tal_calendar.Controllers
{

    [ApiController]
    public class MeetingBookingController : ControllerBase
    {

        private readonly ILogger<MeetingBookingController> _logger;
        private readonly IBookingRepository _bookingRepository;

        public MeetingBookingController(ILogger<MeetingBookingController> logger, IBookingRepository bookingRepository)
        {
            _logger = logger;
            _bookingRepository = bookingRepository;
        }

        [HttpGet]
        [Route("api/bookings")]
        public IEnumerable<Booking> GetAllBookings()
        {
            return _bookingRepository.GetAll();
        }
    }
}
