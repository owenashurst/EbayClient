using EbayClient.Features.GetSellerTransactions;

namespace EbayClient
{
    public class EbayContext
    {
        private QueryHandler _getSellerTransactionsService;

        public EbayContext()
        {
            _getSellerTransactionsService = new QueryHandler();
        }

        public QueryHandler GetSellerTransactionsService => _getSellerTransactionsService;
    }
}