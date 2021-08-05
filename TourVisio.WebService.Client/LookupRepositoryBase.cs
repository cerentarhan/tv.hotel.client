using System;
using System.Reflection;

namespace TourVisio.WebService.Client
{
    public abstract class LookupRepositoryBase : RepositoryClient
    {
        protected const string Service = "lookupservice";

        public LookupRepositoryBase(string pToken, string pApiAddress) : base(pToken, pApiAddress)
        {
        }

        protected string Resource(MethodBase pMethodBase)
        {
            return string.Format("{0}/{1}", Service, pMethodBase.Name);
        }
    }
}
