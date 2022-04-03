using EbayClient.Features.GetSellerTransactions.DTOs;
using EbayClient.Features.GetSellerTransactions.Models;
using System.Xml.Serialization;

namespace EbayClient.Features.GetSellerTransactions
{
    public class QueryHandler : IQueryHandler<Query, IQuery<GetSellerTransactionsResponse>>
    {
        public async Task<GetSellerTransactionsResponse> GetSellerTransactions(Query query)
        {
            using var httpClient = new HttpClient
            {
                BaseAddress = new Uri(query.ApiUrl),
            };

            httpClient.DefaultRequestHeaders.Add("X-EBAY-API-COMPATIBILITY-LEVEL", "1147");
            httpClient.DefaultRequestHeaders.Add("X-EBAY-API-SITEID", query.SiteId.ToString());
            httpClient.DefaultRequestHeaders.Add("X-EBAY-API-CALL-NAME", "GetSellerTransactions");

            query.GetSellerTransactionsRequest.RequesterCredentials = new RequesterCredentials
            {
                EbayAuthToken = query.EbayAuthToken,
            };

            var xmlSerialized = string.Empty;

            using (var stringWriter = new StringWriter())
            {
                new XmlSerializer(query.GetSellerTransactionsRequest.GetType()).Serialize(stringWriter, query.GetSellerTransactionsRequest);
                xmlSerialized = stringWriter.GetStringBuilder().ToString();
            }

            var response = await httpClient.PostAsync("", new StringContent(xmlSerialized, null, "text/xml"));
            var responseBody = await response.Content.ReadAsStringAsync();

            var xmlSerializer = new XmlSerializer(typeof(GetSellerTransactionsResponse));

            using var stringReader = new StringReader(responseBody);
            return (GetSellerTransactionsResponse)xmlSerializer.Deserialize(stringReader);
        }
    }
}
