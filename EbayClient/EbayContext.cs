using EbayClient.Features.GetSellerTransactions;

namespace EbayClient
{
    public class EbayContext
    {
        private readonly EbayCredentials _ebayCredentials;

        private QueryHandler _getSellerTransactionsService;

        public EbayContext(EbayCredentials ebayCredentials)
        {
            _ebayCredentials = ebayCredentials;

            _getSellerTransactionsService = new QueryHandler(_ebayCredentials);
        }

        public QueryHandler GetSellerTransactionsService => _getSellerTransactionsService;
    }
}