using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourVisio.WebService.Adapter.Enums;
using TourVisio.WebService.Adapter.Models.Product.Hotel;

namespace TourVisio.Hotel.Client.Models
{
    public class SearchResultModel
    {
        internal static object mdlApiResponseMessage;

        public string ErrorMsg { get; set; }

        public IEnumerable<mdlHotel> Hotels { get; set; }

    }
}
