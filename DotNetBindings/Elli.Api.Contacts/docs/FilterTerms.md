# Elli.Api.Contacts.Model.FilterTerms
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanonicalName** | **string** | Canonical field name for borrower contact. | [optional] 
**Value** | **Object** | Matching value for the field provided. Values are represented as alphanumeric values such as My Pipeline. Or numeric, such as integer, date or partial date, floating point, and currency. | [optional] 
**MatchType** | **string** | Type on how value should be equated to field provided. Depending on filter criteria, options can include, greaterThanOrEquals, exact, greaterThan, isNotEmpty, isEmpty, lessThan, lessThanOrEquals, equals, notEquals, startsWith and contains. | [optional] 
**Terms** | [**List&lt;FilterTerms&gt;**](FilterTerms.md) | Terms, when filter needs to be applied on more than one field. Used to create a nested/sub query. | [optional] 
**_Operator** | **string** | Binary operator for filter criteria when filter is applied on more than one fields. Accepted values - And and Or. | [optional] 
**Precision** | **string** | Precision applies to Dates only. Possible values are - exact, day, month, year, recurring | [optional] 
**Include** | **bool?** | When include &#x3D; true (which is the default), results are included if the filter returns results. It applies to strings only. When include &#x3D; false, results are excluded if the filter returns results. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

