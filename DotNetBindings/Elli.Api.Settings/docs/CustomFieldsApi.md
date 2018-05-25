# Elli.Api.Settings.Api.CustomFieldsApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLoanCustomField**](CustomFieldsApi.md#getloancustomfield) | **GET** /encompass/v1/settings/loan/customFields/{customFieldId} | Get specific loan custom field
[**GetLoanCustomFields**](CustomFieldsApi.md#getloancustomfields) | **GET** /encompass/v1/settings/loan/customFields | Get all loan custom fields


<a name="getloancustomfield"></a>
# **GetLoanCustomField**
> CustomFieldContract GetLoanCustomField (string customFieldId)

Get specific loan custom field

Retreives a specific loan custom field under loan setup settings based on custom field name passed.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetLoanCustomFieldExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomFieldsApi();
            var customFieldId = customFieldId_example;  // string | Loan custom field name

            try
            {
                // Get specific loan custom field
                CustomFieldContract result = apiInstance.GetLoanCustomField(customFieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.GetLoanCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldId** | **string**| Loan custom field name | 

### Return type

[**CustomFieldContract**](CustomFieldContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloancustomfields"></a>
# **GetLoanCustomFields**
> List<CustomFieldContract> GetLoanCustomFields ()

Get all loan custom fields

Retrieves all loan custom fields under loan setup settings.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetLoanCustomFieldsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomFieldsApi();

            try
            {
                // Get all loan custom fields
                List&lt;CustomFieldContract&gt; result = apiInstance.GetLoanCustomFields();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomFieldsApi.GetLoanCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CustomFieldContract>**](CustomFieldContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

