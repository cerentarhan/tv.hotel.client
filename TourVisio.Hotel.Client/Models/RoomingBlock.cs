using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourVisio.WebService.Adapter.Models.Booking;

namespace TourVisio.Hotel.Client.Models
{
    public class RoomingBlock
    {
        public int RoomNumber { get; set; }
        public IEnumerable<mdlTraveller> Travellers { get; set; }

        public bool Required(mdlTraveller pTraveller, string pTravellerPropertyName)
        {
            return pTraveller.RequiredFields.Contains(pTravellerPropertyName);
        }

    }
}
