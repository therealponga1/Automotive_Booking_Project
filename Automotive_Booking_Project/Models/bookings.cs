﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automotive_Booking_Project.Models
{
    public class bookings
    {
        public int Id { get; set; }

        public Users users { get; set; }
        public BookingReason BookingReason { get; set; }
    }
}
