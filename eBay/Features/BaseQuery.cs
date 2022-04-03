namespace EbayClient.Features
{
    public class BaseQuery
    {
        public string ApiUrl { get; set; }

        public int SiteId { get; set; }

        public string EbayAuthToken { get; set; }
    }
}