# Elli.Api.Loans.Model.AusTrackingLogContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique Id of AusTrackingLog. | [optional] 
**Application** | [**EntityRefContract**](EntityRefContract.md) | Underlying application entity. | [optional] 
**UwRiskAssessType** | **string** | UnderwritingRiskAssessType, possible values - Manual Underwriting, DU, LP, LQA, Other. | [optional] 
**UwOtherRiskAssessType** | **string** | Required when UnderwritingRiskAssessType is Other. | [optional] 
**SubmissionDate** | **DateTime?** | Submission Date Time. | [optional] 
**FirstSubmissionDate** | **DateTime?** | First Submission Date Time. | [optional] 
**SubmissionNumber** | **string** | Submission Number. | [optional] 
**Recommendation** | **string** | Aus Recommendation. | [optional] 
**DuCaseIdOrLPAUSKey** | **string** | DU CaseId Or LP AUS Key. | [optional] 
**SubmittedBy** | **string** | Submitted By. | [optional] 
**Version** | **string** | Aus Version Number. | [optional] 
**DocClass** | **string** | Doc Class (Freddie). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

