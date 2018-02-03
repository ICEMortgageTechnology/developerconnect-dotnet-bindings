# Elli.Api.Contacts.Model.BusinessContactContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryId** | **int?** | The business category ID for the business contact. Possible values are: 0 - Appraiser, 1 - Attorney, 2 - Credit Company, 3 - Doc Signing, 4 - Escrow Company, 5 - Flood Insurance, 6 - Hazard Insurance, 7 - Lender, 8 - Mortgage Insurance, 9 - Real Estate Agent, 10 - Servicing, 11 - Title Insurance, 12 - Underwriter, 13 - Surveyor, 14 - No Category, 15 - Organization, 16 - Verification, 17 - Investor, 18 - Warehouse Bank, 19 - Builder, 20 - Dealer, 21 - TradeAssignee | [optional] 
**CategoryFields** | [**List&lt;BusinessContactContractCategoryFields&gt;**](BusinessContactContractCategoryFields.md) |  | [optional] 
**CompanyName** | **string** | The contact&#39;s company name. | [optional] 
**Fees** | **int?** | Rate or fee charged by the contact’s services. | [optional] 
**PersonalContactLicense** | [**BusinessContactContractPersonalContactLicense**](BusinessContactContractPersonalContactLicense.md) |  | [optional] 
**BusinessContactLicense** | [**BusinessContactContractBusinessContactLicense**](BusinessContactContractBusinessContactLicense.md) |  | [optional] 
**NoSpam** | **bool?** |  | [optional] 
**FirstName** | **string** | The contact&#39;s first name. | [optional] 
**LastName** | **string** | The contact&#39;s last name. | [optional] 
**OwnerId** | **string** |  | [optional] 
**AccessLevel** | **int?** | Possible values are: 0 – Private, 1- Public. | [optional] 
**CurrentMailingAddress** | [**BorrowerContactContractCurrentMailingAddress**](BorrowerContactContractCurrentMailingAddress.md) |  | [optional] 
**BizAddress** | [**BorrowerContactContractBizAddress**](BorrowerContactContractBizAddress.md) |  | [optional] 
**BusinessWebUrl** | **string** | Website URL of contact&#39;s work. | [optional] 
**JobTitle** | **string** | The contact&#39;s job title | [optional] 
**WorkPhone** | **string** | The contact&#39;s work phone number. | [optional] 
**HomePhone** | **string** | The contact&#39;s home phone number. | [optional] 
**MobilePhone** | **string** | The contact&#39;s cell phone number. | [optional] 
**FaxNumber** | **string** | The contact&#39;s fax number. | [optional] 
**PersonalEmail** | **string** | The contact&#39;s personal email address. | [optional] 
**BusinessEmail** | **string** | The contact&#39;s work email address. | [optional] 
**PrimaryEmail** | **string** | The contact&#39;s primary email address. | [optional] 
**PrimaryPhone** | **string** | The contact&#39;s primary phone number. | [optional] 
**Salutation** | **string** | Ms., Miss, Mrs., Mr., Dr., etc. | [optional] 
**Id** | **string** | The contactId (or id) is the unique identifier of the contact. It is returned in the response header when the contact is created. | [optional] 
**GroupIDs** | **List&lt;int?&gt;** | Group ids, unique identifier or id of the groups to which this contact is assigned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

