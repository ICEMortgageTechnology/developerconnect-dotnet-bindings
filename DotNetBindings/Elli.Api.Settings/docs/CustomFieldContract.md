# Elli.Api.Settings.Model.CustomFieldContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Loan custom field name. | [optional] 
**Description** | **string** | Description for loan custom field. | [optional] 
**Format** | **string** | Field format, for example - STRING, INTEGER, DROPDOWNLIST, AUDIT etc. This is NONE by default. | [optional] 
**MaxLength** | **int?** | Length allowed for field value when field format is STRING. | [optional] 
**Calculation** | **string** | This is the code for calculation from which the value of this field is derived. | [optional] 
**Audit** | [**CustomFieldContractAudit**](CustomFieldContractAudit.md) |  | [optional] 
**Options** | **List&lt;string&gt;** | This is the list of dropdown values when field format is DROPDOWNLIST or DROPDOWN. | [optional] 
**ModelPath** | **string** | Model path for loan custom field. | [optional] 
**IsCalculatedField** | **bool?** | Indicates whether the field has a calculation associated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

