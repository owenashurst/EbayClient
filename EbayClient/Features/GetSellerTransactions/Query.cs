using EbayClient.Features.GetSellerTransactions.Models;

namespace EbayClient.Features.GetSellerTransactions.DTOs
{
    
    public class Query : BaseQuery, IQuery<GetSellerTransactionsResponse>
    {
        public GetSellerTransactionsRequest GetSellerTransactionsRequest { get; set; }
    }
}
