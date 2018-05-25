# Elli.Api.Loans.EFolder.Api.ConditionsApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEFolderPostclosingConditionById**](ConditionsApi.md#getefolderpostclosingconditionbyid) | **GET** /encompass/v1/loans/{loanId}/conditions/postclosing/{conditionId} | Gets post closing condition detail for a ConditionId
[**GetEFolderPostclosingConditions**](ConditionsApi.md#getefolderpostclosingconditions) | **GET** /encompass/v1/loans/{loanId}/conditions/postclosing | Get EFolder Postclosing Conditions for a loan
[**GetEFolderPreliminaryConditionById**](ConditionsApi.md#getefolderpreliminaryconditionbyid) | **GET** /encompass/v1/loans/{loanId}/conditions/preliminary/{conditionId} | Gets preliminary condition detail for a ConditionId
[**GetEFolderPreliminaryConditions**](ConditionsApi.md#getefolderpreliminaryconditions) | **GET** /encompass/v1/loans/{loanId}/conditions/preliminary | Gets list of preliminary conditions
[**GetEFolderUnderwritingConditionById**](ConditionsApi.md#getefolderunderwritingconditionbyid) | **GET** /encompass/v1/loans/{loanId}/conditions/underwriting/{conditionId} | Gets underwriting condition detail for a ConditionId
[**GetEFolderUnderwritingConditions**](ConditionsApi.md#getefolderunderwritingconditions) | **GET** /encompass/v1/loans/{loanId}/conditions/underwriting | Gets list of underwriting conditions


<a name="getefolderpostclosingconditionbyid"></a>
# **GetEFolderPostclosingConditionById**
> EFolderPostClosingConditionContract GetEFolderPostclosingConditionById (string conditionId, string loanId, string includeRemoved = null)

Gets post closing condition detail for a ConditionId

Returns post closing condition detail for a ConditionId of a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class GetEFolderPostclosingConditionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConditionsApi();
            var conditionId = conditionId_example;  // string | Guid - Unique Identifier of a condition
            var loanId = loanId_example;  // string | Guid - Loan id to which condition belogs to
            var includeRemoved = includeRemoved_example;  // string | Flag indicating if the deleted condition has to be included (optional) 

            try
            {
                // Gets post closing condition detail for a ConditionId
                EFolderPostClosingConditionContract result = apiInstance.GetEFolderPostclosingConditionById(conditionId, loanId, includeRemoved);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConditionsApi.GetEFolderPostclosingConditionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conditionId** | **string**| Guid - Unique Identifier of a condition | 
 **loanId** | **string**| Guid - Loan id to which condition belogs to | 
 **includeRemoved** | **string**| Flag indicating if the deleted condition has to be included | [optional] 

### Return type

[**EFolderPostClosingConditionContract**](EFolderPostClosingConditionContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getefolderpostclosingconditions"></a>
# **GetEFolderPostclosingConditions**
> List<EFolderPostClosingConditionContract> GetEFolderPostclosingConditions (string loanId, string sort = null, string filter = null, string start = null, string limit = null, string includeRemoved = null)

Get EFolder Postclosing Conditions for a loan

Returns all EFolder Postclosing Conditions for a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class GetEFolderPostclosingConditionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConditionsApi();
            var loanId = loanId_example;  // string | Guid - Loan id to which condition belongs to
            var sort = sort_example;  // string | Comma separated list of sort parameters. Each sort parameter can be prefixed with +/- to indicate sort direction as ascending or descending. Default is ascending. If no parameter is specified, the returned collection will be sorted on Title in asceding direction. (optional) 
            var filter = filter_example;  // string | Comma spearated list of filter parameters. Filter is specified in format operand:operator:value.eg. title:=:MyCondition. Valid operators are 1. '=' or '==', '!=', '>', '>=', '<', '<=', 'like' for Contains, 'sw' for StartsWith, 'ew' for Endswith</param> (optional) 
            var start = start_example;  // string | Start index or record number to retrieve a set of conditions. This is defaulted to 1. (optional) 
            var limit = limit_example;  // string | Total number of records to be returned on a page. (optional) 
            var includeRemoved = includeRemoved_example;  // string | Flag indicating if deleted conditions have to included. (optional) 

            try
            {
                // Get EFolder Postclosing Conditions for a loan
                List&lt;EFolderPostClosingConditionContract&gt; result = apiInstance.GetEFolderPostclosingConditions(loanId, sort, filter, start, limit, includeRemoved);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConditionsApi.GetEFolderPostclosingConditions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Guid - Loan id to which condition belongs to | 
 **sort** | **string**| Comma separated list of sort parameters. Each sort parameter can be prefixed with +/- to indicate sort direction as ascending or descending. Default is ascending. If no parameter is specified, the returned collection will be sorted on Title in asceding direction. | [optional] 
 **filter** | **string**| Comma spearated list of filter parameters. Filter is specified in format operand:operator:value.eg. title:&#x3D;:MyCondition. Valid operators are 1. &#39;&#x3D;&#39; or &#39;&#x3D;&#x3D;&#39;, &#39;!&#x3D;&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39;, &#39;like&#39; for Contains, &#39;sw&#39; for StartsWith, &#39;ew&#39; for Endswith&lt;/param&gt; | [optional] 
 **start** | **string**| Start index or record number to retrieve a set of conditions. This is defaulted to 1. | [optional] 
 **limit** | **string**| Total number of records to be returned on a page. | [optional] 
 **includeRemoved** | **string**| Flag indicating if deleted conditions have to included. | [optional] 

### Return type

[**List<EFolderPostClosingConditionContract>**](EFolderPostClosingConditionContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getefolderpreliminaryconditionbyid"></a>
# **GetEFolderPreliminaryConditionById**
> EFolderPreliminaryConditionContract GetEFolderPreliminaryConditionById (string conditionId, string loanId, string includeRemoved = null)

Gets preliminary condition detail for a ConditionId

Returns preliminary condition detail for a ConditionId

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class GetEFolderPreliminaryConditionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConditionsApi();
            var conditionId = conditionId_example;  // string | Guid - Unique Identifier of a condition
            var loanId = loanId_example;  // string | Guid - Loan id to which condition belogs to
            var includeRemoved = includeRemoved_example;  // string | Flag indicating if the deleted condition has to included (optional) 

            try
            {
                // Gets preliminary condition detail for a ConditionId
                EFolderPreliminaryConditionContract result = apiInstance.GetEFolderPreliminaryConditionById(conditionId, loanId, includeRemoved);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConditionsApi.GetEFolderPreliminaryConditionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conditionId** | **string**| Guid - Unique Identifier of a condition | 
 **loanId** | **string**| Guid - Loan id to which condition belogs to | 
 **includeRemoved** | **string**| Flag indicating if the deleted condition has to included | [optional] 

### Return type

[**EFolderPreliminaryConditionContract**](EFolderPreliminaryConditionContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getefolderpreliminaryconditions"></a>
# **GetEFolderPreliminaryConditions**
> List<EFolderPreliminaryConditionContract> GetEFolderPreliminaryConditions (string loanId, string sort = null, string filter = null, string start = null, string limit = null, string includeRemoved = null)

Gets list of preliminary conditions

Returns list of preliminary conditions for a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class GetEFolderPreliminaryConditionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConditionsApi();
            var loanId = loanId_example;  // string | Guid - Loan id to which condition belongs to
            var sort = sort_example;  // string | Comma separated list of sort parameters. Each sort parameter can be prefixed with +/- to indicate sort direction as ascending or descending. Default is ascending. If no parameter is specified, the returned collection will be sorted on Title in asceding direction. (optional) 
            var filter = filter_example;  // string | Comma spearated list of filter parameters. Filter is specified in format operand:operator:value.eg. title:=:MyCondition. Valid operators are 1. '=' or '==', '!=', '>', '>=', '<', '<=', 'like' for Contains, 'sw' for StartsWith, 'ew' for Endswith</param> (optional) 
            var start = start_example;  // string | Start index or record number to retrieve a set of conditions. This is defaulted to 1. (optional) 
            var limit = limit_example;  // string | Total number of records to be returned on a page. (optional) 
            var includeRemoved = includeRemoved_example;  // string | Flag indicating if deleted conditions have to included. (optional) 

            try
            {
                // Gets list of preliminary conditions
                List&lt;EFolderPreliminaryConditionContract&gt; result = apiInstance.GetEFolderPreliminaryConditions(loanId, sort, filter, start, limit, includeRemoved);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConditionsApi.GetEFolderPreliminaryConditions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Guid - Loan id to which condition belongs to | 
 **sort** | **string**| Comma separated list of sort parameters. Each sort parameter can be prefixed with +/- to indicate sort direction as ascending or descending. Default is ascending. If no parameter is specified, the returned collection will be sorted on Title in asceding direction. | [optional] 
 **filter** | **string**| Comma spearated list of filter parameters. Filter is specified in format operand:operator:value.eg. title:&#x3D;:MyCondition. Valid operators are 1. &#39;&#x3D;&#39; or &#39;&#x3D;&#x3D;&#39;, &#39;!&#x3D;&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39;, &#39;like&#39; for Contains, &#39;sw&#39; for StartsWith, &#39;ew&#39; for Endswith&lt;/param&gt; | [optional] 
 **start** | **string**| Start index or record number to retrieve a set of conditions. This is defaulted to 1. | [optional] 
 **limit** | **string**| Total number of records to be returned on a page. | [optional] 
 **includeRemoved** | **string**| Flag indicating if deleted conditions have to included. | [optional] 

### Return type

[**List<EFolderPreliminaryConditionContract>**](EFolderPreliminaryConditionContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getefolderunderwritingconditionbyid"></a>
# **GetEFolderUnderwritingConditionById**
> EFolderUnderwritingConditionContract GetEFolderUnderwritingConditionById (string conditionId, string loanId, string includeRemoved = null)

Gets underwriting condition detail for a ConditionId

Returns underwriting condition detail for a ConditionId of a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class GetEFolderUnderwritingConditionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConditionsApi();
            var conditionId = conditionId_example;  // string | Guid - Unique Identifier of a condition
            var loanId = loanId_example;  // string | Guid - Loan id to which condition belogs to
            var includeRemoved = includeRemoved_example;  // string | Flag indicating if the deleted condition has to included (optional) 

            try
            {
                // Gets underwriting condition detail for a ConditionId
                EFolderUnderwritingConditionContract result = apiInstance.GetEFolderUnderwritingConditionById(conditionId, loanId, includeRemoved);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConditionsApi.GetEFolderUnderwritingConditionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conditionId** | **string**| Guid - Unique Identifier of a condition | 
 **loanId** | **string**| Guid - Loan id to which condition belogs to | 
 **includeRemoved** | **string**| Flag indicating if the deleted condition has to included | [optional] 

### Return type

[**EFolderUnderwritingConditionContract**](EFolderUnderwritingConditionContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getefolderunderwritingconditions"></a>
# **GetEFolderUnderwritingConditions**
> List<EFolderUnderwritingConditionContract> GetEFolderUnderwritingConditions (string loanId, string sort = null, string filter = null, string start = null, string limit = null, string includeRemoved = null)

Gets list of underwriting conditions

Returns all underwriting conditions for a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class GetEFolderUnderwritingConditionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConditionsApi();
            var loanId = loanId_example;  // string | Guid - Loan id to which condition belongs to
            var sort = sort_example;  // string | Comma separated list of sort parameters. Each sort parameter can be prefixed with +/- to indicate sort direction as ascending or descending. Default is ascending. If no parameter is specified, the returned collection will be sorted on Title in asceding direction. (optional) 
            var filter = filter_example;  // string | Comma spearated list of filter parameters. Filter is specified in format operand:operator:value.eg. title:=:MyCondition. Valid operators are 1. '=' or '==', '!=', '>', '>=', '<', '<=', 'like' for Contains, 'sw' for StartsWith, 'ew' for Endswith</param> (optional) 
            var start = start_example;  // string | Start index or record number to retrieve a set of conditions. This is defaulted to 1. (optional) 
            var limit = limit_example;  // string | Total number of records to be returned on a page. (optional) 
            var includeRemoved = includeRemoved_example;  // string | Flag indicating if deleted conditions have to included. (optional) 

            try
            {
                // Gets list of underwriting conditions
                List&lt;EFolderUnderwritingConditionContract&gt; result = apiInstance.GetEFolderUnderwritingConditions(loanId, sort, filter, start, limit, includeRemoved);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConditionsApi.GetEFolderUnderwritingConditions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Guid - Loan id to which condition belongs to | 
 **sort** | **string**| Comma separated list of sort parameters. Each sort parameter can be prefixed with +/- to indicate sort direction as ascending or descending. Default is ascending. If no parameter is specified, the returned collection will be sorted on Title in asceding direction. | [optional] 
 **filter** | **string**| Comma spearated list of filter parameters. Filter is specified in format operand:operator:value.eg. title:&#x3D;:MyCondition. Valid operators are 1. &#39;&#x3D;&#39; or &#39;&#x3D;&#x3D;&#39;, &#39;!&#x3D;&#39;, &#39;&gt;&#39;, &#39;&gt;&#x3D;&#39;, &#39;&lt;&#39;, &#39;&lt;&#x3D;&#39;, &#39;like&#39; for Contains, &#39;sw&#39; for StartsWith, &#39;ew&#39; for Endswith&lt;/param&gt; | [optional] 
 **start** | **string**| Start index or record number to retrieve a set of conditions. This is defaulted to 1. | [optional] 
 **limit** | **string**| Total number of records to be returned on a page. | [optional] 
 **includeRemoved** | **string**| Flag indicating if deleted conditions have to included. | [optional] 

### Return type

[**List<EFolderUnderwritingConditionContract>**](EFolderUnderwritingConditionContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

