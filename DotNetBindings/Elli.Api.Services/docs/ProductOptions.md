# Elli.Api.Services.Model.ProductOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DigiCert** | **bool?** | Determines how to authenticate to CoreLogic Credco. &#39;true - Indicates a DigiCert SSL certificate will be used. false - Indicates the user name and password will be used to authenticate.&#39;&#39; | [optional] 
**RequestType** | **string** | Possible values are &#39;NewRequest&#39; and &#39;ReissueRequest&#39; | [optional] 
**ReportOn** | **string** | Possible values are: Individual - Requests a report on on borrower. Joint - Requests reports on both borrowers. | [optional] 
**ReportType** | **string** |  | [optional] 
**CreditReportIdentifier** | **string** | Identifier assigned by CoreLogic Credco. It is returned in the response and is required to reissue or update a report. | [optional] 
**Note** | **string** | Comment or note to add to the request. | [optional] 
**CreditBureauExperian** | **bool?** | Indicates whether the request is submitted to Experian. This is a &#39;Y&#39; or &#39;N&#39;. | [optional] 
**CreditBureauEquifax** | **bool?** | Indicates whether the request is submitted to Equifax. This is a &#39;Y&#39; or &#39;N&#39;. | [optional] 
**CreditBureauTransUnion** | **bool?** | Indicates whether the request is submitted to TransUnion. This is a &#39;Y&#39; or &#39;N&#39;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

