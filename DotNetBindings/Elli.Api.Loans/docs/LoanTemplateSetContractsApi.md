# Elli.Api.Loans.Api.LoanTemplateSetContractsApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLoanTemplatesSetItems**](LoanTemplateSetContractsApi.md#getloantemplatessetitems) | **GET** /v1/settings/templates/loanTemplateSet/items | Returns all templates.


<a name="getloantemplatessetitems"></a>
# **GetLoanTemplatesSetItems**
> List<EntityRefContract> GetLoanTemplatesSetItems (string path)

Returns all templates.

Returns all folders available under the templatePath.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetLoanTemplatesSetItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanTemplateSetContractsApi();
            var path = path_example;  // string | path to fetch the templates

            try
            {
                // Returns all templates.
                List&lt;EntityRefContract&gt; result = apiInstance.GetLoanTemplatesSetItems(path);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanTemplateSetContractsApi.GetLoanTemplatesSetItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| path to fetch the templates | 

### Return type

[**List<EntityRefContract>**](EntityRefContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

