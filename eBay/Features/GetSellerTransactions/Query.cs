using EbayClient.Features.GetSellerTransactions.Models;

namespace EbayClient.Features.GetSellerTransactions.DTOs
{
    
    public class Query : BaseQuery
    {
        public GetSellerTransactionsRequest GetSellerTransactionsRequest { get; set; }
    }
}
