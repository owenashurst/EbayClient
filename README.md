# Ebay Client
[![master](https://github.com/owenashurst/EbayClient/actions/workflows/build-and-publish.yml/badge.svg)](https://github.com/owenashurst/EbayClient/actions) ![Nuget](https://img.shields.io/nuget/v/EbayClient)

This is an unofficial SDK to help people target more modern versions of .NET whilst also providing the same kind of functionality as the official (and might I add, old) SDK's provided by eBay that target .NET Framework.

This SDK allows for cross platform applications to be written such as those that can be deployed to the cloud for SaaS.

Contributations are welcome.

## Coding Pattern
For this project, each endpoint lives under a "feature". A feature is created following the [CQS (Command Query Seperation) pattern](https://thecodereaper.com/2020/05/23/command-query-separation-cqs/).

## Usage
### GetSellerTransactions

```csharp
var ebay = new EbayClient.EbayContext(new EbayCredentials
{
	AuthToken = "",
	SiteId = 3,
	EnvironmentType = EbayCredentials.Environment.Production
});

var sellerTransactions = await ebay.GetSellerTransactionsService.GetSellerTransactions(new Query
{
	GetSellerTransactionsRequest = new EbayClient.Features.GetSellerTransactions.Models.GetSellerTransactionsRequest
	{
		ErrorLanguage = "en_US",
		WarningLevel = "High",
		IncludeFinalValueFee = true,
		IncludeContainingOrder = true,
		ModTimeFrom = DateTime.UtcNow.AddHours(-5),
		ModTimeTo = DateTime.UtcNow,
		Pagination = new EbayClient.Features.GetSellerTransactions.Models.Pagination
		{
			EntriesPerPage = 25,
			PageNumber = 1
		}
	}
});
```