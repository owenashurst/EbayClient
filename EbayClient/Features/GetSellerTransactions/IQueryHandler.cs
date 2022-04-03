using EbayClient.Features.GetSellerTransactions.Models;

namespace EbayClient.Features.GetSellerTransactions
{
    public interface IQuery<out TResponse> { }

    public interface IQueryHandler<Query, TResponse> where TResponse : IQuery<GetSellerTransactionsResponse>
    {
        Task<GetSellerTransactionsResponse> GetSellerTransactions(Query query);
    }
}
