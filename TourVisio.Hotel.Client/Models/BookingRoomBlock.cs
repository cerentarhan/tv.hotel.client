using System;
using System.Collections.Generic;
namespace TourVisio.Hotel.Client.Models
{
    public class BookingRoomBlock
    {
        public int RoomNumber { get; set; }

        public IEnumerable<TravellerModel> Travellers { get; set; }

      
    }
}
