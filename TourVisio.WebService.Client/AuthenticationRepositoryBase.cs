using System;
using System.Reflection;

namespace TourVisio.WebService.Client
{
    public abstract class AuthenticationRepositoryBase : RepositoryClient
    {
        protected const string Service = "authenticationservice";

        protected AuthenticationRepositoryBase(string pToken, string pApiAddress) : base(pToken, pApiAddress)
        {
        }
        protected AuthenticationRepositoryBase() : base()
        {
        }

        protected string Resource(MethodBase pMethodBase)
        {
            return string.Format("{0}/{1}", Service, pMethodBase.Name);
        }
    }
}
