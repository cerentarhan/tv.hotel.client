using TourVisio.WebService.Adapter.Models.Utility;
using TourVisio.WebService.Adapter.ServiceModels.BookingModels;

namespace TourVisio.WebService.Client
{
    public interface IBookingRepository
    {
        mdlApiResponse<TransactionResponse> BeginTransaction(BeginTransactionRequest pRequest);
        mdlApiResponse<TransactionResponse> SetReservationInfo(SetReservationInfoRequest pRequest);
        mdlApiResponse<GetAvailableServicesResponse> GetAvailableServices(GetAvailableServicesRequest pRequest);
        mdlApiResponse<TransactionResponse> AddServices(AddServicesRequest pRequest);
        mdlApiResponse<TransactionResponse> RemoveServices(RemoveServicesRequest pRequest);
        mdlApiResponse<TransactionResponse> CommitTransaction(CommitTransactionRequest pRequest);
        mdlApiResponse<TransactionResponse> CommitIncompleteTransaction(CommitIncompleteTransactionRequest pRequest);
        mdlApiResponse<GetReservationListResponse> GetReservationList(GetReservationListRequest pRequest);
        mdlApiResponse<TransactionResponse> GetReservationDetail(GetReservationDetailRequest pRequest);
        mdlApiResponse<RollBackTransactionResponse> RollBackTransaction(RollBackTransactionRequest pRequest);
        mdlApiResponse<RollBackCommitTransactionResponse> RollBackCommitTransaction(RollBackCommitTransactionRequest pRequest);
        mdlApiResponse<SaveTransactionResponse> SaveTransaction(SaveTransactionRequest pRequest);
        mdlApiResponse<CancelReservationResponse> CancelReservation(CancelReservationRequest pRequest);
        mdlApiResponse<GetCancellationPenaltyResponse> GetCancellationPenalty(GetCancellationPenaltyRequest pRequest);
        mdlApiResponse<CompleteReservationResponse> CompleteReservation(CompleteReservationRequest pRequest);
        mdlApiResponse<SendReservationNumberToProviderResponse> SendReservationNumberToProvider(SendReservationNumberToProviderRequest pRequest);
        mdlApiResponse<TransactionResponse> ReadAndCreatePNR(ReadAndCreatePNRRequest pRequest);
        mdlApiResponse<TransactionResponse> UpdatePNR(UpdatePNRRequest pRequest);
    }
}
