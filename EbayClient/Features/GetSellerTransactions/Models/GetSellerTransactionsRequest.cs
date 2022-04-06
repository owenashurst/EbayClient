using System;
using System.Xml.Serialization;

namespace EbayClient.Features.GetSellerTransactions.Models
{
    [Serializable()]
    [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
    [XmlRoot(Namespace = "urn:ebay:apis:eBLBaseComponents", IsNullable = false)]
    public class GetSellerTransactionsRequest
    {
        public string InventoryTrackingMethod { get; set; }

        [XmlElement(ElementName = "RequesterCredentials")]
        public RequesterCredentials RequesterCredentials { get; set; }

        public string ErrorLanguage { get; set; }

        public string WarningLevel { get; set; }

        public bool IncludeCodiceFiscale { get; set; }

        public bool IncludeFinalValueFee { get; set; }

        public bool IncludeContainingOrder { get; set; }

        public DateTime ModTimeFrom { get; set; }

        public DateTime ModTimeTo { get; set; }

        [XmlElement(ElementName = "Pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Pagination
    {
        [XmlElement(ElementName = "EntriesPerPage")]
        public int EntriesPerPage { get; set; }

        [XmlElement(ElementName = "PageNumber")]
        public int PageNumber { get; set; }
    }

    public class RequesterCredentials
    {
        [XmlElement(ElementName = "eBayAuthToken")]
        public string EbayAuthToken { get; set; }
    }
}
