using EbayClient.Features.GetSellerTransactions.DTOs;
using EbayClient.Features.GetSellerTransactions.Models;

namespace EbayClient.Features.GetSellerTransactions
{
    public interface IQueryHandler
    {
        Task<GetSellerTransactionsResponse> GetSellerTransactions(Query query);
    }
}
