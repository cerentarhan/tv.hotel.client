using TourVisio.WebService.Adapter.Models;
using TourVisio.WebService.Adapter.Models.Utility;
using TourVisio.WebService.Adapter.ServiceModels.ProductModels;

namespace TourVisio.WebService.Client
{
    public interface IProductRepository
    {
        mdlApiResponse<GetDepartureCountriesResponse> GetDepartureCountries(GetDepartureCountriesRequest pRequest);
        mdlApiResponse<GetDeparturesResponse> GetDepartures(GetDeparturesRequest pRequest);
        mdlApiResponse<GetArrivalCountriesResponse> GetArrivalCountries(GetArrivalCountriesRequest pRequest);
        mdlApiResponse<GetArrivalsResponse> GetArrivals(GetArrivalsRequest pRequest);
        mdlApiResponse<GetCheckInDatesResponse> GetCheckInDates(GetCheckInDatesRequest pRequest);
        mdlApiResponse<GetNightsResponse> GetNights(GetNightsRequest pRequest);
        mdlApiResponse<GetProductsResponse> GetProducts(GetProductsRequest pRequest);
        mdlApiResponse<PriceSearchResponse> PriceSearch(PriceSearchRequest pRequest);
        mdlApiResponse<PriceSearchResponse> GetPagingData(GetPagingDataRequest pRequest);
        mdlApiResponse<GetProductInfoResponse> GetProductInfo(GetProductInfoRequest pRequest);
        mdlApiResponse<GetAutoCompleteResponse> GetDepartureAutoComplete(GetDepartureAutoCompleteRequest pRequest);
        mdlApiResponse<GetAutoCompleteResponse> GetArrivalAutoComplete(GetArrivalAutoCompleteRequest pRequest);
        mdlApiResponse<GetOfferDetailsResponse> GetOfferDetails(GetOfferDetailsRequest pRequest);
        mdlApiResponse<GetRotatorsResponse> GetRotators(GetRotatorsRequest pRequest);
        mdlApiResponse<GetOffersResponse> GetOffers(GetOffersRequest pRequest);
    }
}
