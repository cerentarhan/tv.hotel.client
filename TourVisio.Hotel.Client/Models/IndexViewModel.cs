using System.Collections.Generic;
using TourVisio.WebService.Adapter.Models;

namespace TourVisio.Hotel.Client.Models
{
    public class IndexViewModel
    {
        public IEnumerable<mdlCurrency> Currencies { get; set; }
        public IEnumerable<mdlNationalityItem> Nationalities { get; set; }
       
    }
}