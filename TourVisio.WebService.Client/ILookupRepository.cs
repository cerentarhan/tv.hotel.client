using TourVisio.WebService.Adapter.Models.Utility;
using TourVisio.WebService.Adapter.ServiceModels.LookupModels;

namespace TourVisio.WebService.Client
{
    public interface ILookupRepository
    {
        mdlApiResponse<GetNationalitiesResponse> GetNationalities(GetNationalitiesRequest pRequest);
        mdlApiResponse<GetCurrenciesResponse> GetCurrencies(GetCurrenciesRequest pRequest);
        mdlApiResponse<GetCountriesResponse> GetCountries(GetCountriesRequest pRequest);
        mdlApiResponse<GetExchangeRatesResponse> GetExchangeRates(GetExchangeRatesRequest pRequest);
        mdlApiResponse<GetMarketMediasResponse> GetMarketMedias(GetMarketMediasRequest pRequest);
        mdlApiResponse<GetSupplierResponse> GetSuppliers(GetSupplierRequest pRequest);
        mdlApiResponse<GetReservationArrivalsResponse> GetReservationArrivals(GetReservationArrivalsRequest pRequest);
        mdlApiResponse<GetReservationDeparturesResponse> GetReservationDepartures(GetReservationDeparturesRequest pRequest);
        mdlApiResponse<GetThirdPartyMappingResponse> GetThirdPartyMappings(GetThirdPartyMappingRequest pRequest);
        mdlApiResponse<GetAnnouncesResponse> GetAnnounces(GetAnnouncesRequest pRequest);
        mdlApiResponse<MarkAnnouncesAsReadedResponse> MarkAnnouncesAsReaded(MarkAnnouncesAsReadedRequest pRequest);
        mdlApiResponse<GetSpecialDaysResponse> GetSpecialDays(GetSpecialDaysRequest pRequest);
        mdlApiResponse<GetAdditionalPriceSearchParametersResponse> GetAdditionalPriceSearchParameters(GetAdditionalPriceSearchParametersRequest pRequest);
        mdlApiResponse<GetRotatorGroupsResponse> GetRotatorGroups(GetRotatorGroupsRequest pRequest);
        mdlApiResponse<GetLastMinutesResponse> GetLastMinutes(GetLastMinutesRequest pRequest);
        mdlApiResponse<GetLocationsResponse> GetLocations(GetLocationsRequest pRequest);
    }
}
