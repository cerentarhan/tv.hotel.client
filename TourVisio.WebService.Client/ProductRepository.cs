using System;
using System.Reflection;
using TourVisio.WebService.Adapter.Models;
using TourVisio.WebService.Adapter.Models.Utility;
using TourVisio.WebService.Adapter.ServiceModels.LookupModels;
using TourVisio.WebService.Adapter.ServiceModels.ProductModels;

namespace TourVisio.WebService.Client
{
    public sealed class ProductRepository : ProductRepositoryBase, IProductRepository
    {
        public ProductRepository(string pToken, string pApiAddress) : base(pToken, pApiAddress)
        {
        }

        public mdlApiResponse<GetAutoCompleteResponse> GetArrivalAutoComplete(GetArrivalAutoCompleteRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetAutoCompleteResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetArrivalCountriesResponse> GetArrivalCountries(GetArrivalCountriesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetArrivalCountriesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetArrivalsResponse> GetArrivals(GetArrivalsRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetArrivalsResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetCheckInDatesResponse> GetCheckInDates(GetCheckInDatesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetCheckInDatesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetAutoCompleteResponse> GetDepartureAutoComplete(GetDepartureAutoCompleteRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetAutoCompleteResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetDepartureCountriesResponse> GetDepartureCountries(GetDepartureCountriesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetDepartureCountriesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetDeparturesResponse> GetDepartures(GetDeparturesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetDeparturesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public object GetLocations(GetLocationsRequest pRequest2)
        {
            throw new NotImplementedException();
        }

        public mdlApiResponse<GetNightsResponse> GetNights(GetNightsRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetNightsResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetOfferDetailsResponse> GetOfferDetails(GetOfferDetailsRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetOfferDetailsResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<PriceSearchResponse> GetPagingData(GetPagingDataRequest pRequest)
        {
            return this.Post<mdlApiResponse<PriceSearchResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetProductInfoResponse> GetProductInfo(GetProductInfoRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetProductInfoResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetProductsResponse> GetProducts(GetProductsRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetProductsResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetRotatorsResponse> GetRotators(GetRotatorsRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetRotatorsResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<PriceSearchResponse> PriceSearch(PriceSearchRequest pRequest)
        {
            return this.Post<mdlApiResponse<PriceSearchResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetOffersResponse> GetOffers(GetOffersRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetOffersResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<PriceSearchResponse> GetAvailableExtraServices(GetAvailableExtraServicesRequest pRequest)
        {
            return this.Post<mdlApiResponse<PriceSearchResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }
    }
}
