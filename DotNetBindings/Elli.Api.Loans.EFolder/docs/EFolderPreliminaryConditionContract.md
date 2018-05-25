# Elli.Api.Loans.EFolder.Model.EFolderPreliminaryConditionContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | unique identifier of a condition | [optional] 
**UWAccess** | **bool?** | uWAccess | [optional] 
**PriorTo** | **string** | priorTo | [optional] 
**Category** | **string** | category | [optional] 
**IsFulfilled** | **bool?** | isFulfilled | [optional] 
**FulfilledDate** | **DateTime?** | fulfilledDate | [optional] 
**FulfilledBy** | [**EntityRefContract**](EntityRefContract.md) | fulfilledBy | [optional] 
**TemplateId** | **string** | templateId | [optional] 
**ConditionType** | **string** | Type of a condition(Underwriting|Postclosing|Preliminary|Purchase) | [optional] 
**IsRemoved** | **bool?** | Flag to indicate whether condition is removed or not | [optional] 
**Title** | **string** | title | [optional] 
**Description** | **string** | description | [optional] 
**Application** | [**EntityRefContract**](EntityRefContract.md) | application | [optional] 
**Source** | **string** | Source of condition(Escrow|Investor|Recorder&#39;s Office|Borrowers|FHA|VA|MI Company|Other|Manual|Condition Set|Automated Conditions) | [optional] 
**ExpectedDate** | **DateTime?** | expectedDate | [optional] 
**Status** | **string** | status | [optional] 
**StatusDate** | **DateTime?** | statusDate | [optional] 
**DaysToReceive** | **int?** | daysToReceive | [optional] 
**RequestedFrom** | **string** | requestedFrom | [optional] 
**CreatedDate** | **DateTime?** | createdDate | [optional] 
**CreatedBy** | [**EntityRefContract**](EntityRefContract.md) | createdBy | [optional] 
**IsRequested** | **bool?** | isRequested | [optional] 
**RequestedDate** | **DateTime?** | requestedDate | [optional] 
**RequestedBy** | [**EntityRefContract**](EntityRefContract.md) | requestedBy | [optional] 
**IsRerequested** | **bool?** | isRerequested | [optional] 
**RerequestedDate** | **DateTime?** | rerequestedDate | [optional] 
**RerequestedBy** | [**EntityRefContract**](EntityRefContract.md) | rerequestedBy | [optional] 
**IsReceived** | **bool?** | isReceived | [optional] 
**ReceivedDate** | **DateTime?** | receivedDate | [optional] 
**ReceivedBy** | [**EntityRefContract**](EntityRefContract.md) | receivedBy | [optional] 
**IsAddedToConditionSet** | **bool?** | isAddedToConditionSet | [optional] 
**Comments** | [**List&lt;EFolderCommentContract&gt;**](EFolderCommentContract.md) |  | [optional] 
**Documents** | [**List&lt;EntityRefContract&gt;**](EntityRefContract.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

