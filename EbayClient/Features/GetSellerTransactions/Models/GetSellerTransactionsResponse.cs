using System.Xml.Serialization;

namespace EbayClient.Features.GetSellerTransactions.Models
{
    [Serializable()]
    [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
    [XmlRoot(Namespace = "urn:ebay:apis:eBLBaseComponents", IsNullable = false)]
    public class GetSellerTransactionsResponse : BaseResponse
    {
        [XmlElement(ElementName = "PaginationResult")]
        public PaginationResult PaginationResult { get; set; }

        public bool HasMoreTransactions { get; set; }

        public int TransactionsPerPage { get; set; }

        public int PageNumber{ get; set; }

        public int ReturnedTransactionCountActual { get; set; }

        [XmlElement(ElementName = "Seller")]
        public Seller Seller { get; set; }

        [XmlArray("TransactionArray")]
        [XmlArrayItem("Transaction")]
        public List<Transaction> TransactionArray { get; set; }

        public bool PayPalPreferred { get; set; }
    }

    public class Transaction
    {
        [XmlElement(ElementName = "AmountPaid")]
        public Amount AmountPaid { get; set; }

        [XmlElement(ElementName = "Buyer")]
        public Buyer Buyer { get; set; }

        [XmlElement(ElementName = "ShippingDetails")]
        public ShippingDetails ShippingDetails { get; set; }

        [XmlElement(ElementName = "ConvertedAmountPaid")]
        public Amount ConvertedAmountPaid { get; set; }

        [XmlElement(ElementName = "ConvertedTransactionPrice")]
        public Amount ConvertedTransactionPrice { get; set; }

        public DateTime CreatedDate { get; set; }

        public string DepositType { get; set; }

        [XmlElement(ElementName = "Item")]
        public Item Item { get; set; }

        public int QuantityPurchased { get; set; }

        [XmlElement(ElementName = "Status")]
        public Status Status { get; set; }

        [XmlElement(ElementName = "TransactionID")]
        public string TransactionID { get; set; }

        [XmlElement(ElementName = "TransactionPrice")]
        public Amount TransactionPrice { get; set; }

        public bool BestOfferSale { get; set; }

        [XmlElement(ElementName = "eBayCollectAndRemitTax")]
        public bool EbayCollectAndRemitTax { get; set; }

        [XmlElement(ElementName = "ShippingServiceSelected")]
        public ShippingServiceSelected ShippingServiceSelected { get; set; }

        public DateTime PaidTime { get; set; }

        public DateTime ShippedTime { get; set; }

        [XmlElement(ElementName = "ContainingOrder")]
        public ContainingOrder ContainingOrder { get; set; }

        [XmlElement(ElementName = "FinalValueFee")]
        public Amount FinalValueFee { get; set; }

        public string TransactionSiteID { get; set; }

        public string Platform { get; set; }

        [XmlElement(ElementName = "BuyerGuaranteePrice")]
        public Amount BuyerGuaranteePrice { get; set; }

        [XmlElement(ElementName = "Variation")]
        public Variation Variation { get; set; }

        [XmlElement(ElementName = "ActualShippingCost")]
        public Amount ActualShippingCost { get; set; }

        public string OrderLineItemID { get; set; }

        public bool IsMultiLegShipping { get; set; }

        public bool IntangibleItem { get; set; }

        public string ExtendedOrderID { get; set; }

        [XmlElement(ElementName = "eBayPlusTransaction")]
        public bool EbayPlusTransaction { get; set; }

        public bool GuaranteedShipping { get; set; }

        public bool GuaranteedDelivery { get; set; }

        // Program
    }

    public class Variation
    {
        public string SKU { get; set; }

        [XmlArray("VariationSpecifics")]
        [XmlArrayItem("NameValueList")]
        public List<NameValueList> VariationSpecifics { get; set; }

        public string VariationTitle { get; set; }

        public string VariationViewItemURL { get; set; }
    }

    public class NameValueList
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }

    public class ContainingOrder
    {
        public string OrderID { get; set; }

        public string OrderStatus { get; set; }

        public string CancelStatus { get; set; }

        public string ExtendedOrderID { get; set; }

        public bool ContainseBayPlusTransaction { get; set; }

        public int OrderLineItemCount { get; set; }
    }

    public class ShippingServiceSelected
    {
        public string ShippingService { get; set; }

        [XmlElement(ElementName = "ShippingServiceCost")]
        public Amount ShippingServiceCost { get; set; }

        [XmlElement(ElementName = "ShippingPackageInfo")]
        public ShippingPackageInfo ShippingPackageInfo { get; set; }
    }

    public class ShippingPackageInfo
    {
        public DateTime ActualDeliveryTime { get; set; }

        public DateTime EstimatedDeliveryTimeMin { get; set; }

        public DateTime EstimatedDeliveryTimeMax { get; set; }

        public DateTime HandleByTime { get; set; }

        public DateTime MinNativeEstimatedDeliveryTime { get; set; }

        public DateTime MaxNativeEstimatedDeliveryTime { get; set; }
    }

    public class ShippingDetails
    {
        public bool ChangePaymentInstructions { get; set; }

        public bool PaymentEdited { get; set; }

        [XmlElement(ElementName = "SalesTax")]
        public SalesTax SalesTax { get; set; }

        public string ShippingType { get; set; }

        public double SellingManagerSalesRecordNumber { get; set; }

        public bool ThirdPartyCheckout { get; set; }

        // TaxTable

        public bool GetItFast { get; set; }

        public string ShippingServiceUsed { get; set; }

        [XmlElement(ElementName = "ShipmentTrackingDetails")]
        public ShipmentTrackingDetails ShipmentTrackingDetails { get; set; }
    }

    public class Status
    {
        [XmlElement(ElementName = "eBayPaymentStatus")]
        public string EbayPaymentStatus { get; set; }

        public string CheckoutStatus { get; set; }

        public DateTime LastTimeModified { get; set; }

        public string PaymentMethodUsed { get; set; }

        public string CompleteStatus { get; set; }

        public bool BuyerSelectedShipping { get; set; }

        public string PaymentHoldStatus { get; set; }

        public bool IntegratedMerchantCreditCardEnabled { get; set; }

        public string InquiryStatus { get; set; }

        public string ReturnStatus { get; set; }

        public string PaymentInstrument { get; set; }
    }

    public class Item
    {
        public bool AutoPay { get; set; }

        public string Currency { get; set; }

        public double ItemID { get; set; }

        public string ListingType { get; set; }

        public bool PrivateListing { get; set; }

        public int Quantity { get; set; }

        [XmlElement(ElementName = "SellingStatus")]
        public SellingStatus SellingStatus { get; set; }

        public bool GetItFast { get; set; }

        public string SKU { get; set; }

        public bool IntegratedMerchantCreditCardEnabled { get; set; }

        public int ConditionID { get; set; }

        public string ConditionDisplayName { get; set; }
    }

    public class SellingStatus
    {
        [XmlElement(ElementName = "CurrentPrice")]
        public Amount CurrentPrice { get; set; }

        public int QuantitySold { get; set; }

        public string ListingStatus { get; set; }

        [XmlElement(ElementName = "FinalValueFee")]
        public Amount FinalValueFee { get; set; }
    }

    public class ShipmentTrackingDetails
    {
        public string ShippingCarrierUsed { get; set; }

        public string ShipmentTrackingNumber { get; set; }
    }

    public class SalesTax
    {
        public decimal SalesTaxPercent { get; set; }

        public bool ShippingIncludedInTax { get; set; }

        [XmlElement(ElementName = "SalesTaxAmount")]
        public Amount SalesTaxAmount { get; set; }
    }

    public class Buyer : EbayInfo
    {
        [XmlElement(ElementName = "BuyerInfo")]
        public BuyerInfo BuyerInfo { get; set; }

        public bool UserAnonymized { get; set; }

        public string StaticAlias { get; set; }

        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }
    }

    public class BuyerInfo
    {
        [XmlElement(ElementName = "ShippingAddress")]
        public ShippingAddress ShippingAddress { get; set; }
    }

    public class ShippingAddress
    {
        public string Name { get; set; }

        public string Street1 { get; set; }

        public string Street2 { get; set; }

        public string CityName { get; set; }

        public string StateOrProvince { get; set; }

        public string Country { get; set; }

        public string CountryName { get; set; }

        public string Phone { get; set; }

        public string PostalCode { get; set; }

        public string AddressID { get; set; }

        public string AddressOwner { get; set; }

        public string AddressUsage { get; set; }
    }

    public class Amount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }

        [XmlText(DataType = "decimal")]
        public decimal Value { get; set; }
    }

    public class Seller : EbayInfo
    {
        [XmlElement(ElementName = "SellerInfo")]
        public SellerInfo SellerInfo { get; set; }

        public bool PayPalPreferred { get; set; }
    }

    public class EbayInfo
    {
        public bool AboutMe { get; set; }

        public string EIASToken { get; set; }

        public string Email { get; set; }

        public double FeedbackScore { get; set; }

        public float PositiveFeedbackPercent { get; set; }

        public bool FeedbackPrivate { get; set; }

        public bool IDVerified { get; set; }

        [XmlElement(ElementName = "eBayGoodStanding")]
        public bool EbayGoodStanding { get; set; }

        public bool NewUser { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Site { get; set; }

        public string Status { get; set; }

        public string UserID { get; set; }

        public bool UserIDChanged { get; set; }

        public DateTime UserIDLastChanged { get; set; }

        public string VATStatus { get; set; }
    }

    public class SellerInfo
    {
        public bool AllowPaymentEdit { get; set; }

        public bool CheckoutEnabled { get; set; }

        public bool CIPBankAccountStored { get; set; }

        public bool GoodStanding { get; set; }

        public bool LiveAuctionAuthorized { get; set; }

        public string MerchandizingPref { get; set; }

        public bool QualifiesForB2BVAT { get; set; }

        public bool StoreOwner { get; set; }

        public string StoreURL { get; set; }

        public bool SafePaymentExempt { get; set; }

        public bool TopRatedSeller { get; set; }
    }

    public class PaginationResult
    {
        public int TotalNumberOfPages { get; set; }

        public int TotalNumberOfEntries { get; set; }
    }
}
