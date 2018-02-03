# Elli.Api.Contacts.Model.BorrowerContactContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployerName** | **string** | The contact&#39;s company name. | [optional] 
**Birthdate** | **DateTime?** | The contact&#39;s date of birth. For example, 1978-02-15. | [optional] 
**BorrowerType** | **string** | Type of contact - Prospect, Client or Lead. | [optional] 
**PrimaryEmail** | **string** | The contact&#39;s primary email address. | [optional] 
**PrimaryPhone** | **string** | The contact&#39;s primary phone number. | [optional] 
**Referral** | **string** | The name of a person or company, if any, who referred the borrower to you. | [optional] 
**FirstName** | **string** | The contact&#39;s first name. | [optional] 
**LastName** | **string** | The contact&#39;s last name. | [optional] 
**OwnerId** | **string** | User ID of the user who submitted the API request. | [optional] 
**AccessLevel** | **int?** | Possible values are: 0 – Private, 1- Public. | [optional] 
**CurrentMailingAddress** | [**BorrowerContactContractCurrentMailingAddress**](BorrowerContactContractCurrentMailingAddress.md) |  | [optional] 
**BizAddress** | [**BorrowerContactContractBizAddress**](BorrowerContactContractBizAddress.md) |  | [optional] 
**BusinessWebUrl** | **string** | Website URL of contact&#39;s work. | [optional] 
**JobTitle** | **string** | The contact&#39;s job title. | [optional] 
**WorkPhone** | **string** | The contact&#39;s work phone number. | [optional] 
**HomePhone** | **string** | The contact&#39;s home phone number. | [optional] 
**MobilePhone** | **string** | The contact&#39;s cell phone number. | [optional] 
**FaxNumber** | **string** | The contact&#39;s fax number. | [optional] 
**PersonalEmail** | **string** | The contact&#39;s personal email address. | [optional] 
**BusinessEmail** | **string** | The contact&#39;s work email address. | [optional] 
**Salutation** | **string** | Ms., Miss, Mrs., Mr., Dr., etc. | [optional] 
**Id** | **string** | The contactId (or id) is the unique identifier of the borrower contact. It is returned in the response header when the contact is created. | [optional] 
**GroupIDs** | **List&lt;int?&gt;** | Group ids, unique identifier or id of the groups to which this contact is assigned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

