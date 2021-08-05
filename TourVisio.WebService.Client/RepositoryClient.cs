using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using TourVisio.WebService.Adapter.Enums;
using TourVisio.WebService.Adapter.Models.Utility;

namespace TourVisio.WebService.Client
{
    public abstract class RepositoryClient
    {
        readonly string Token;
        readonly string ApiAddress;
        readonly RestClient Client;
        protected RepositoryClient() : this(null, null)
        {

        }
        protected RepositoryClient(string pToken, string pApiAddress, int pTimeoutbySeconds = 120)
        {
            this.Token = pToken;
            this.ApiAddress = pApiAddress;
            Client = new RestSharp.RestClient()
            {
                BaseUrl = new Uri(pApiAddress),
                Timeout = pTimeoutbySeconds * 1000
            };
        }
        protected T Post<T>(string pMethod, object pObject) where T : mdlApiResponseBase
        {
            T result = default(T);

            var request = new RestRequest(string.Format("api/{0}", pMethod), Method.POST)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddParameter("application/json", Parser.JsonSerializeObject(pObject), ParameterType.RequestBody);
            if (!string.IsNullOrEmpty(Token))
                request.AddHeader("Authorization", string.Concat("Bearer ", this.Token));


            if (Client.Execute(request) is RestResponse response)
            {
                if (response.StatusCode == HttpStatusCode.OK && response.ResponseStatus == ResponseStatus.Completed)
                {
                    result = Parser.JsonDeserializeObject<T>(response.Content);
                    if (!result.Header.Success && result.Header.Messages[0].Id == (int)enmMessage.TokenRequired)
                    {
                        throw new B2BException("Token Required", "~/Account/SignOut");
                    }
                }
                else
                {
                    throw new ApplicationException(string.Format("Status code is {0} ({1}); response status is {2}", response.StatusCode, response.StatusDescription, response.ResponseStatus));
                }
            }
            else
            {
                throw new ApplicationException("General exception");
            }
            return result;
        }

        protected T Post<T>(string pMethod, object pObject, Method Method)
        {
            T result = default(T);

            var request = new RestRequest(string.Format("api/{0}", pMethod), Method)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddParameter("application/json", Parser.JsonSerializeObject(pObject), ParameterType.RequestBody);
            if (!string.IsNullOrEmpty(Token))
                request.AddHeader("Authorization", string.Concat("Bearer ", this.Token));


            if (Client.Execute(request) is RestResponse response)
            {
                if (response.StatusCode == HttpStatusCode.OK && response.ResponseStatus == ResponseStatus.Completed)
                {
                    result = Parser.JsonDeserializeObject<T>(response.Content);
                }
                else
                {
                    throw new ApplicationException(string.Format("Status code is {0} ({1}); response status is {2}", response.StatusCode, response.StatusDescription, response.ResponseStatus));
                }
            }
            else
            {
                throw new ApplicationException("General exception");
            }
            return result;
        }
    }

    // TODO san.api.common.utils e parser alindiktan sonra oradan kullanilacak
    public static class Parser
    {
        public static string JsonSerializeObject<T>(T pData, bool pIgnoreNullValue = true)
        {
            return JsonConvert.SerializeObject(pData, new JsonSerializerSettings
            {
                NullValueHandling = pIgnoreNullValue ? NullValueHandling.Ignore : NullValueHandling.Include
            });
        }

        public static T JsonDeserializeObject<T>(string pData)
        {
            if (string.IsNullOrEmpty(pData))
                return default(T);
            return JsonConvert.DeserializeObject<T>(pData);
        }
    }
}
