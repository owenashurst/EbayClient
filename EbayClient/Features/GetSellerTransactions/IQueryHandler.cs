using EbayClient.Features.GetSellerTransactions.DTOs;
using EbayClient.Features.GetSellerTransactions.Models;
using System.Threading.Tasks;

namespace EbayClient.Features.GetSellerTransactions
{
    public interface IQueryHandler<in TQuery, out TResponse> where TQuery : IQuery<TResponse>
    {
        Task<GetSellerTransactionsResponse> GetSellerTransactions(Query query);
    }
}
