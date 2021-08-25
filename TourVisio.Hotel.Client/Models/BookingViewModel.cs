using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TourVisio.WebService.Adapter.Models.Booking;

namespace TourVisio.Hotel.Client.Models
{
    public class BookingViewModel
    {
        public IEnumerable<BookingRoomBlock> Rooms { get; set; }  
        public string TransactionId { get; set; }
        public string Currency { get; set; }

        public string AgencyReservationNumber { get; set; }
        public string ReservationInfo { get; set; }
        public mdlCustomerInfo CustomerInfo { get; set; }
       
    }
}