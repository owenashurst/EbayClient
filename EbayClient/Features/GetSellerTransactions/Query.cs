using EbayClient.Features.GetSellerTransactions.Models;

namespace EbayClient.Features.GetSellerTransactions.DTOs
{
    
    public class Query : IQuery<GetSellerTransactionsResponse>
    {
        public GetSellerTransactionsRequest GetSellerTransactionsRequest { get; set; }
    }
}
