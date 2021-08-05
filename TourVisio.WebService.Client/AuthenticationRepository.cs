using System;
using System.Reflection;
using TourVisio.WebService.Adapter.Models.Utility;
using TourVisio.WebService.Adapter.ServiceModels.AuthenticationModels;


namespace TourVisio.WebService.Client
{
    public class AuthenticationRepository:AuthenticationRepositoryBase, IAuthenticationRepository
    {
        public AuthenticationRepository() : base()
        {
        }
        public AuthenticationRepository(string pToken, string pApiAddress) : base(pToken, pApiAddress)
        {
        }

        public mdlApiResponse<LoginResponse> ApplicationLogin(ApplicationLoginRequest pRequest)
        {
            return this.Post<mdlApiResponse<LoginResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetDatabasesResponse> GetDatabases(GetDatabasesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetDatabasesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetTokenDataResponse> GetTokenData(GetTokenDataRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetTokenDataResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetUserInfoResponse> GetUserInfo(GetUserInfoRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetUserInfoResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<LoginResponse> AdminLogin(AdminLoginRequest pRequest)
        {
            return this.Post<mdlApiResponse<LoginResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<LoginResponse> Login(LoginRequest pRequest)
        {
            return this.Post<mdlApiResponse<LoginResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<LoginResponse> SystemLogin(SystemLoginRequest pRequest)
        {
            return this.Post<mdlApiResponse<LoginResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetTravelDataResponse> GetTravelData(GetTravelDataRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetTravelDataResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<SetTravelDataResponse> SetTravelData(SetTravelDataRequest pRequest)
        {
            return this.Post<mdlApiResponse<SetTravelDataResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

    }
}
