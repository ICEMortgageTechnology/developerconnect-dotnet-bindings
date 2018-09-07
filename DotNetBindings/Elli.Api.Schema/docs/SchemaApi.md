# Elli.Api.Schema.Api.SchemaApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLoanSchema**](SchemaApi.md#getloanschema) | **GET** /encompass/v1/schema/loan | Get Loan Schema.
[**GetLoanSchemaByFieldId**](SchemaApi.md#getloanschemabyfieldid) | **GET** /encompass/v1/schema/loan/{fieldId} | Get Loan Schema By FieldId.


<a name="getloanschema"></a>
# **GetLoanSchema**
> string GetLoanSchema (string entities = null, bool? includeFieldExtensions = null)

Get Loan Schema.

Get full loan schema.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Schema.Api;
using Elli.Api.Schema.Client;
using Elli.Api.Schema.Model;

namespace Example
{
    public class GetLoanSchemaExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemaApi();
            var entities = entities_example;  // string | Loan entities separated by ',' for which schema definition is requested. (optional) 
            var includeFieldExtensions = true;  // bool? | Include Field Extensions. (optional) 

            try
            {
                // Get Loan Schema.
                string result = apiInstance.GetLoanSchema(entities, includeFieldExtensions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchemaApi.GetLoanSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entities** | **string**| Loan entities separated by &#39;,&#39; for which schema definition is requested. | [optional] 
 **includeFieldExtensions** | **bool?**| Include Field Extensions. | [optional] 

### Return type

**string**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloanschemabyfieldid"></a>
# **GetLoanSchemaByFieldId**
> string GetLoanSchemaByFieldId (string fieldId)

Get Loan Schema By FieldId.

Get loan schema for a specific field by its field id.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Schema.Api;
using Elli.Api.Schema.Client;
using Elli.Api.Schema.Model;

namespace Example
{
    public class GetLoanSchemaByFieldIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchemaApi();
            var fieldId = fieldId_example;  // string | Loan field id for which schema is requested.

            try
            {
                // Get Loan Schema By FieldId.
                string result = apiInstance.GetLoanSchemaByFieldId(fieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchemaApi.GetLoanSchemaByFieldId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldId** | **string**| Loan field id for which schema is requested. | 

### Return type

**string**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

