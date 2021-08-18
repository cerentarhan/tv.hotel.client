using System.Reflection;

namespace TourVisio.WebService.Client
{
    public abstract class BookingRepositoryBase : RepositoryClient
    {
        protected const string Service = "bookingservice";

        protected BookingRepositoryBase(string pToken, string pApiAddress) : base(pToken, pApiAddress, 600)
        {
        }

        protected string Resource(MethodBase pMethodBase)
        {
            return string.Format("{0}/{1}", Service, pMethodBase.Name);
        }
    }
}
