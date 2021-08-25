using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourVisio.WebService.Adapter.Models;
using TourVisio.WebService.Adapter.Models.Booking;

namespace TourVisio.Hotel.Client.Models
{
    public class ResultModelView
    {
        public mdlReservationInfo ReservationInfo { get; set; }
        public string BookingNumber { get; set; }
        public string ErrorMsg { get; set; }
        public string TransactionId { get; set; }
        public List<mdlTraveller> Travellers { get; set; }
        public List<mdlService> Services { get; set; }
        public mdlPrice TotalPrice { get; set; }

    }
}
