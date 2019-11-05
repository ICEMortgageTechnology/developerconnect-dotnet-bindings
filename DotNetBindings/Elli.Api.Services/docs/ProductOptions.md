# Elli.Api.Services.Model.ProductOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestType** | **string** | The type of Underwriting request you would like to place with Fannie Mae. This can be a new request, or the reissue of an existing request (re-perform the Underwriting service for a request that already exists). For the latter, you need to pass an identifier for the existing request on Fannie Mae&#39;s platform. Possible values are - &lt;br&gt;&lt;/br&gt; 1. newOrder - place a new underwriting service request for the referenced loan. &lt;br&gt;&lt;/br&gt; 2. reissue - reissue an underwriting service request for the referenced loan. | [optional] 
**ProductDescription** | **string** | If Standard LCOR is passed as the value, the loan will be considered a standard limited cash out refinance. Otherwise, the loan is analyzed for DU ReFi Plus qualification - this qualification allows for high loan-to-value ratios (outside of standard underwriting guidelines) when the loan can be verified as owned by Fannie Mae. | [optional] 
**AusReportIdentifier** | **string** | This is an identifier for an existing request on Fannie Mae&#39;s platform - this is a required field if you are requesting a reissue of an existing underwriting request. If &#39;newRequest&#39; is passed in the requestType, this field will be ignored. | [optional] 
**CreditProviderCode** | **string** | This is an identifier for the Credit service provider with whom you placed your credit service request for the loan in reference. This is required as Fannie Mae needs to access your credit report information to process your underwriting service request. | [optional] 
**OrderCreditDetails** | [**ProductOptionsOrderCreditDetails**](ProductOptionsOrderCreditDetails.md) |  | [optional] 
**DigiCert** | **bool?** | Determines how to authenticate to CoreLogic Credco. &#39;true - Indicates a DigiCert SSL certificate will be used. false - Indicates the user name and password will be used to authenticate.&#39;&#39; | [optional] 
**ReportOn** | **string** | Possible values are: Individual - Requests a report on on borrower. Joint - Requests reports on both borrowers. | [optional] 
**ReportType** | **string** | Whether to order an individual or merged credit report | [optional] 
**CreditReportIdentifier** | **string** | Identifier assigned by CoreLogic Credco. It is returned in the response and is required to reissue or update a report | [optional] 
**Note** | **string** | Comment or note to add to the request | [optional] 
**CreditBureauExperian** | **bool?** | Indicates whether the request is submitted to Experian. This is a &#39;Y&#39; or &#39;N&#39; | [optional] 
**CreditBureauEquifax** | **bool?** | Indicates whether the request is submitted to Equifax. This is a &#39;Y&#39; or &#39;N&#39; | [optional] 
**CreditBureauTransUnion** | **bool?** | Indicates whether the request is submitted to TransUnion. This is a &#39;Y&#39; or &#39;N&#39; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

