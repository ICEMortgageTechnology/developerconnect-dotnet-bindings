# Elli.Api.Loans.Pipeline.Api.LoanPipelineApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFieldDefinitions**](LoanPipelineApi.md#getfielddefinitions) | **GET** /encompass/v1/loanPipeline/fieldDefinitions | 
[**PipelineRequest**](LoanPipelineApi.md#pipelinerequest) | **POST** /encompass/v1/loanPipeline/ | 


<a name="getfielddefinitions"></a>
# **GetFieldDefinitions**
> PipelineFieldDefsContract GetFieldDefinitions ()



### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Pipeline.Api;
using Elli.Api.Loans.Pipeline.Client;
using Elli.Api.Loans.Pipeline.Model;

namespace Example
{
    public class GetFieldDefinitionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanPipelineApi();

            try
            {
                PipelineFieldDefsContract result = apiInstance.GetFieldDefinitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanPipelineApi.GetFieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PipelineFieldDefsContract**](PipelineFieldDefsContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pipelinerequest"></a>
# **PipelineRequest**
> List<LoanPipelineItemContract> PipelineRequest (string limit = null, string cursorType = null, string cursor = null, string start = null, LoanPipelineViewContract contract = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Pipeline.Api;
using Elli.Api.Loans.Pipeline.Client;
using Elli.Api.Loans.Pipeline.Model;

namespace Example
{
    public class PipelineRequestExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanPipelineApi();
            var limit = limit_example;  // string |  (optional) 
            var cursorType = cursorType_example;  // string |  (optional) 
            var cursor = cursor_example;  // string |  (optional) 
            var start = start_example;  // string |  (optional) 
            var contract = new LoanPipelineViewContract(); // LoanPipelineViewContract |  (optional) 

            try
            {
                List&lt;LoanPipelineItemContract&gt; result = apiInstance.PipelineRequest(limit, cursorType, cursor, start, contract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanPipelineApi.PipelineRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **string**|  | [optional] 
 **cursorType** | **string**|  | [optional] 
 **cursor** | **string**|  | [optional] 
 **start** | **string**|  | [optional] 
 **contract** | [**LoanPipelineViewContract**](LoanPipelineViewContract.md)|  | [optional] 

### Return type

[**List<LoanPipelineItemContract>**](LoanPipelineItemContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

