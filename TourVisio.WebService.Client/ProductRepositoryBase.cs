using System.Reflection;

namespace TourVisio.WebService.Client
{
    public abstract class ProductRepositoryBase : RepositoryClient
    {
        protected const string Service = "productservice";

        protected ProductRepositoryBase(string pToken, string pApiAddress) : base(pToken, pApiAddress)
        {
        }
        protected string Resource(MethodBase pMethodBase)
        {
            return string.Format("{0}/{1}", Service, pMethodBase.Name);
        }
    }
}
