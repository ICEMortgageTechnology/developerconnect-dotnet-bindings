# Elli.Api.Loans.Api.LoanBatchApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchUpdateRequestStatus**](LoanBatchApi.md#batchupdaterequeststatus) | **GET** /encompass/v1/loanBatch/updateRequests/{requestId} | 
[**BatchUpdateRequests**](LoanBatchApi.md#batchupdaterequests) | **POST** /encompass/v1/loanBatch/updateRequests | 


<a name="batchupdaterequeststatus"></a>
# **BatchUpdateRequestStatus**
> void BatchUpdateRequestStatus (string requestId)



### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class BatchUpdateRequestStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanBatchApi();
            var requestId = requestId_example;  // string | Request ID

            try
            {
                apiInstance.BatchUpdateRequestStatus(requestId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanBatchApi.BatchUpdateRequestStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**| Request ID | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchupdaterequests"></a>
# **BatchUpdateRequests**
> void BatchUpdateRequests (LoanBatchUpdateRequestContract loanBatchUpdateContract = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class BatchUpdateRequestsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanBatchApi();
            var loanBatchUpdateContract = new LoanBatchUpdateRequestContract(); // LoanBatchUpdateRequestContract |  (optional) 

            try
            {
                apiInstance.BatchUpdateRequests(loanBatchUpdateContract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanBatchApi.BatchUpdateRequests: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanBatchUpdateContract** | [**LoanBatchUpdateRequestContract**](LoanBatchUpdateRequestContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

