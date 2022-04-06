# Ebay Client

This is an unofficial SDK to help people target more modern versions of .NET whilst also providing the same kind of functionality as the official (and might I add, old) SDK's provided by eBay that target .NET Framework.

This SDK allows for cross platform applications to be written such as those that can be deployed to the cloud for SaaS.

Contributations are welcome.

## Usage
### GetSellerTransactions

```csharp
var ebay = new EbayClient.EbayContext();
    
var sellerTransactions = await ebay.GetSellerTransactionsService.GetSellerTransactions(new Query
{
    ApiUrl = "https://api.ebay.com/ws/api.dll",
    SiteId = 3,
    EbayAuthToken = "",
    GetSellerTransactionsRequest = new EbayClient.Features.GetSellerTransactions.Models.GetSellerTransactionsRequest
    {
        ErrorLanguage = "en_US",
        WarningLevel = "High",
        IncludeFinalValueFee = true,
        IncludeContainingOrder = true,
        ModTimeFrom = DateTime.UtcNow.AddHours(-1),
        ModTimeTo = DateTime.UtcNow,
        Pagination = new EbayClient.Features.GetSellerTransactions.Models.Pagination
        {
            EntriesPerPage = 25,
            PageNumber = 1
        }
    }
});
```