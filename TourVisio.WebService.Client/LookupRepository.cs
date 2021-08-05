using System;
using System.Reflection;
using TourVisio.WebService.Adapter.Models.Utility;
using TourVisio.WebService.Adapter.ServiceModels.LookupModels;

namespace TourVisio.WebService.Client
{
    public sealed class LookupRepository : LookupRepositoryBase, ILookupRepository
    {
        public object WebRequestDetail { get; set; }
        public string Version { get; set; }

        public LookupRepository(string pToken, string pApiAddress) : base(pToken, pApiAddress)
        {
        }

        public mdlApiResponse<GetAnnouncesResponse> GetAnnounces(GetAnnouncesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetAnnouncesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetCountriesResponse> GetCountries(GetCountriesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetCountriesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetCurrenciesResponse> GetCurrencies(GetCurrenciesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetCurrenciesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public object GetCurrencies(LookupRepository pToken)
        {
            throw new NotImplementedException();
        }

        public mdlApiResponse<GetExchangeRatesResponse> GetExchangeRates(GetExchangeRatesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetExchangeRatesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetNationalitiesResponse> GetNationalities(GetCurrenciesRequest pRequest)
        {
            throw new NotImplementedException();
        }

        public object GetCountries(LookupRepository pRequest)
        {
            throw new NotImplementedException();
        }

        public mdlApiResponse<GetMarketMediasResponse> GetMarketMedias(GetMarketMediasRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetMarketMediasResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetNationalitiesResponse> GetNationalities(GetNationalitiesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetNationalitiesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetReservationArrivalsResponse> GetReservationArrivals(GetReservationArrivalsRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetReservationArrivalsResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetReservationDeparturesResponse> GetReservationDepartures(GetReservationDeparturesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetReservationDeparturesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetSpecialDaysResponse> GetSpecialDays(GetSpecialDaysRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetSpecialDaysResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetSupplierResponse> GetSuppliers(GetSupplierRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetSupplierResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetThirdPartyMappingResponse> GetThirdPartyMappings(GetThirdPartyMappingRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetThirdPartyMappingResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<MarkAnnouncesAsReadedResponse> MarkAnnouncesAsReaded(MarkAnnouncesAsReadedRequest pRequest)
        {
            return this.Post<mdlApiResponse<MarkAnnouncesAsReadedResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetTourVisioParameterResponse> GetTourvisioParameters(GetTourVisioParameterRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetTourVisioParameterResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetProjectCodesResponse> GetProjectCodes(GetProjectCodesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetProjectCodesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetServeCodesResponse> GetServeCodes(GetServeCodesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetServeCodesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetAdditionalPriceSearchParametersResponse> GetAdditionalPriceSearchParameters(GetAdditionalPriceSearchParametersRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetAdditionalPriceSearchParametersResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetAirlinesResponse> GetAirlines(GetAirlinesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetAirlinesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetAirlinesResponse> GetAirlinesOfSoldFlights(GetAirlinesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetAirlinesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetRotatorGroupsResponse> GetRotatorGroups(GetRotatorGroupsRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetRotatorGroupsResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetLastMinutesResponse> GetLastMinutes(GetLastMinutesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetLastMinutesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetLocationsResponse> GetLocations(GetLocationsRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetLocationsResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }
    }
}
