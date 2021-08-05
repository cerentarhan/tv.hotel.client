using TourVisio.WebService.Adapter.Models.Utility;
using TourVisio.WebService.Adapter.ServiceModels.AuthenticationModels;

namespace TourVisio.WebService.Client
{
    public interface IAuthenticationRepository
    {
        mdlApiResponse<LoginResponse> Login(LoginRequest pRequest);
        mdlApiResponse<LoginResponse> SystemLogin(SystemLoginRequest pRequest);
        mdlApiResponse<LoginResponse> ApplicationLogin(ApplicationLoginRequest pRequest);
        mdlApiResponse<GetTokenDataResponse> GetTokenData(GetTokenDataRequest pRequest);
        mdlApiResponse<GetUserInfoResponse> GetUserInfo(GetUserInfoRequest pRequest);
        mdlApiResponse<GetDatabasesResponse> GetDatabases(GetDatabasesRequest pRequest);
    }
}
