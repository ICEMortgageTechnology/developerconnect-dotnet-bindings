# Elli.Api.Loans.Model.LoanTeamMemberContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanAssociateType** | **string** | Type of loan associate | [optional] 
**Id** | **string** | Id of an user or group. In case of group, if id is provided then id will be used to associate group else name will be used. It is manadatory field while associating user to milestone or milestone free role. | [optional] 
**Name** | **string** | Name of a user or group. In case of group, if id is not provided in a request then name will be used to associate group. Associate name can not be updated. It will be extracted from user&#39;s profile while associating user to milestone or milestone free role. | [optional] 
**Phone** | **string** | Phone number of user or group | [optional] 
**CellPhone** | **string** | Cellphone of user or group | [optional] 
**Fax** | **string** | Fax number of user or group | [optional] 
**Email** | **string** | EmailId of user or group | [optional] 
**RoleName** | **string** | Name of Role assigned to user or group | [optional] 
**RoleId** | **string** | Id of Role assigned to user or group | [optional] 
**WriteAccess** | **bool?** | Write access indicator of the milestone free role. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

