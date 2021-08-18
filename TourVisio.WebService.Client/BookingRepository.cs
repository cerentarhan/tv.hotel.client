using System.Reflection;
using TourVisio.WebService.Adapter.Models.Utility;
using TourVisio.WebService.Adapter.ServiceModels.BookingModels;

namespace TourVisio.WebService.Client
{
    public sealed class BookingRepository : BookingRepositoryBase, IBookingRepository
    {
        public BookingRepository(string pToken, string pApiAddress) : base(pToken, pApiAddress)
        {
        }

        public mdlApiResponse<TransactionResponse> AddServices(AddServicesRequest pRequest)
        {
            return this.Post<mdlApiResponse<TransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<TransactionResponse> BeginTransaction(BeginTransactionRequest pRequest)
        {
            return this.Post<mdlApiResponse<TransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<CancelReservationResponse> CancelReservation(CancelReservationRequest pRequest)
        {
            return this.Post<mdlApiResponse<CancelReservationResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<TransactionResponse> CommitIncompleteTransaction(CommitIncompleteTransactionRequest pRequest)
        {
            return this.Post<mdlApiResponse<TransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<TransactionResponse> CommitTransaction(CommitTransactionRequest pRequest)
        {
            return this.Post<mdlApiResponse<TransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<CompleteReservationResponse> CompleteReservation(CompleteReservationRequest pRequest)
        {
            return this.Post<mdlApiResponse<CompleteReservationResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetAvailableServicesResponse> GetAvailableServices(GetAvailableServicesRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetAvailableServicesResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetCancellationPenaltyResponse> GetCancellationPenalty(GetCancellationPenaltyRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetCancellationPenaltyResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<TransactionResponse> GetReservationDetail(GetReservationDetailRequest pRequest)
        {
            return this.Post<mdlApiResponse<TransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetReservationListResponse> GetReservationList(GetReservationListRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetReservationListResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<TransactionResponse> ReadAndCreatePNR(ReadAndCreatePNRRequest pRequest)
        {
            return this.Post<mdlApiResponse<TransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<TransactionResponse> RemoveServices(RemoveServicesRequest pRequest)
        {
            return this.Post<mdlApiResponse<TransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<RollBackCommitTransactionResponse> RollBackCommitTransaction(RollBackCommitTransactionRequest pRequest)
        {
            return this.Post<mdlApiResponse<RollBackCommitTransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<RollBackTransactionResponse> RollBackTransaction(RollBackTransactionRequest pRequest)
        {
            return this.Post<mdlApiResponse<RollBackTransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<SaveTransactionResponse> SaveTransaction(SaveTransactionRequest pRequest)
        {
            return this.Post<mdlApiResponse<SaveTransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<SendReservationNumberToProviderResponse> SendReservationNumberToProvider(SendReservationNumberToProviderRequest pRequest)
        {
            return this.Post<mdlApiResponse<SendReservationNumberToProviderResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<TransactionResponse> SetReservationInfo(SetReservationInfoRequest pRequest)
        {
            return this.Post<mdlApiResponse<TransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<TransactionResponse> UpdatePNR(UpdatePNRRequest pRequest)
        {
            return this.Post<mdlApiResponse<TransactionResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }
        public mdlApiResponse<GetAllReservationCommentResponse> GetAllReservationComments(GetAllReservationCommentRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetAllReservationCommentResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }
        public mdlApiResponse<SendReservationCommentResponse> SendReservationComment(SendReservationCommentRequest pRequest)
        {
            return this.Post<mdlApiResponse<SendReservationCommentResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }

        public mdlApiResponse<GetPaymentListResponse> GetPaymentList(GetPaymentListRequest pRequest)
        {
            return this.Post<mdlApiResponse<GetPaymentListResponse>>(Resource(MethodBase.GetCurrentMethod()), pRequest);
        }
    }
}
