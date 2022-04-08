# Ebay Client
[![master](https://github.com/owenashurst/EbayClient/actions/workflows/build-and-publish.yml/badge.svg)](https://github.com/owenashurst/EbayClient/actions) [![NuGet version (EbayClient)](https://img.shields.io/nuget/v/EbayClient)](https://www.nuget.org/packages/EbayClient/)

This is an unofficial SDK to help people target more modern versions of .NET whilst also providing the same kind of functionality as the official (and might I add, old) SDK's provided by eBay that target .NET Framework.

This SDK allows for cross platform applications to be written such as those that can be deployed to the cloud for SaaS.

Contributions are welcome.

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

## API's Implemented

- [ ] Trading API
  - [ ] AddDispute
  - [ ] AddDisputeResponse
  - [ ] AddFixedPriceItem
  - [ ] AddItem
  - [ ] AddItems
  - [ ] AddMemberMessageAAQToPartner
  - [ ] AddMemberMessageRTQ
  - [ ] AddMemberMessagesAAQToBidder
  - [ ] AddOrder
  - [ ] AddSecondChanceItem
  - [ ] AddToItemDescription
  - [ ] AddToWatchList
  - [ ] AddTransactionConfirmationItem
  - [ ] CompleteSale
  - [ ] ConfirmIdentity
  - [ ] DeleteMyMessages
  - [ ] DisableUnpaidItemAssistance
  - [ ] EndFixedPriceItem
  - [ ] EndItem
  - [ ] EndItems
  - [ ] ExtendSiteHostedPictures
  - [ ] FetchToken
  - [ ] GetAccount
  - [ ] GetAdFormatLeads
  - [ ] GetAllBidders
  - [ ] GetApiAccessRules
  - [ ] GetBestOffers
  - [ ] GetBidderList
  - [ ] GetCategories
  - [ ] GetCategoryFeatures
  - [ ] GetCategoryMappings
  - [ ] GetCategorySpecifics
  - [ ] GetChallengeToken
  - [ ] GetCharities
  - [ ] GetClientAlertsAuthToken
  - [ ] GetContextualKeywords
  - [ ] GetDescriptionTemplates
  - [ ] GetDispute
  - [ ] GeteBayDetails
  - [ ] GeteBayOfficialTime
  - [ ] GetFeedback
  - [ ] GetItem
  - [ ] GetItemsAwaitingFeedback
  - [ ] GetItemShipping
  - [ ] GetItemTransactions
  - [ ] GetMemberMessages
  - [ ] GetMessagePreferences
  - [ ] GetMyeBayBuying
  - [ ] GetMyeBayReminders
  - [ ] GetMyeBaySelling
  - [ ] GetMyMessages
  - [ ] GetNotificationPreferences
  - [ ] GetNotificationsUsage
  - [ ] GetOrders
  - [ ] GetOrderTransactions
  - [ ] GetSellerDashboard
  - [ ] GetSellerEvents
  - [ ] GetSellerList
  - [x] GetSellerTransactions
  - [ ] GetSessionID
  - [ ] GetShippingDiscountProfiles
  - [ ] GetStore
  - [ ] GetStoreCategoryUpdateStatus
  - [ ] GetStoreCustomPage
  - [ ] GetStoreOptions
  - [ ] GetStorePreferences
  - [ ] GetSuggestedCategories
  - [ ] GetTaxTable
  - [ ] GetTokenStatus
  - [ ] GetUser
  - [ ] GetUserContactDetails
  - [ ] GetUserDisputes
  - [ ] GetUserPreferences
  - [ ] GetVeROReasonCodeDetails
  - [ ] GetVeROReportStatus
  - [ ] LeaveFeedback
  - [ ] PlaceOffer
  - [ ] RelistFixedPriceItem
  - [ ] RelistItem
  - [ ] RemoveFromWatchList
  - [ ] RespondToBestOffer
  - [ ] RespondToFeedback
  - [ ] ReviseFixedPriceItem
  - [ ] ReviseInventoryStatus
  - [ ] ReviseItem
  - [ ] ReviseMyMessages
  - [ ] ReviseMyMessagesFolders
  - [ ] RevokeToken
  - [ ] SellerReverseDispute
  - [ ] SendInvoice
  - [ ] SetMessagePreferences
  - [ ] SetNotificationPreferences
  - [ ] SetShippingDiscountProfiles
  - [ ] SetStore
  - [ ] SetStoreCategories
  - [ ] SetStoreCustomPage
  - [ ] SetStorePreferences
  - [ ] SetTaxTable
  - [ ] SetUserNotes
  - [ ] SetUserPreferences
  - [ ] UploadSiteHostedPictures
  - [ ] ValidateChallengeInput
  - [ ] ValidateTestUserRegistration
  - [ ] VerifyAddFixedPriceItem
  - [ ] VerifyAddItem
  - [ ] VerifyAddSecondChanceItem
  - [ ] VerifyRelistItem
  - [ ] VeROReportItems
