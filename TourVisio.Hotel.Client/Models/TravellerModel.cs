using TourVisio.WebService.Adapter.Models.Booking;

namespace TourVisio.Hotel.Client.Models
{
    public class TravellerModel
    {
        public int Title { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Nationality { get; set; }
        public string Code { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportNo { get; set; }
        public string ExpireDate { get; set; }
        public string IssueDate { get; set; }
        public string IssueCountry { get; set; }
    
    }
}