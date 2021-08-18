using System;
using System.Collections.Generic;
using TourVisio.WebService.Adapter.Models.Booking;
using TourVisio.WebService.Adapter.ServiceModels.BookingModels;

namespace TourVisio.Hotel.Client.Controllers
{
    internal class mdlRoomingBlock
    {
        public int RoomNumber { get; internal set; }
        public IEnumerable<mdlTraveller> Travellers { get; internal set; }
        public Func<TransactionResponse, IEnumerable<mdlRoomingBlock>> Rooms { get; internal set; }
    }
}