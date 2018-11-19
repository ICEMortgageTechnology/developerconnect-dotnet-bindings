# Elli.Api.Loans.Api.ConversationLogApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConversationLog**](ConversationLogApi.md#getconversationlog) | **GET** /encompass/v1/loans/{loanId}/conversationLogs/{logId} | Get specific Conversation log
[**GetConversationLogs**](ConversationLogApi.md#getconversationlogs) | **GET** /encompass/v1/loans/{loanId}/conversationLogs | Get list of Conversation logs


<a name="getconversationlog"></a>
# **GetConversationLog**
> ConversationContract GetConversationLog (string loanId, string logId)

Get specific Conversation log

Retrieves specific Conversation log for a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetConversationLogExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationLogApi();
            var loanId = loanId_example;  // string | Unique Identifier of Loan(LoanId)
            var logId = logId_example;  // string | Unique Identifier of conversation log.

            try
            {
                // Get specific Conversation log
                ConversationContract result = apiInstance.GetConversationLog(loanId, logId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationLogApi.GetConversationLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Unique Identifier of Loan(LoanId) | 
 **logId** | **string**| Unique Identifier of conversation log. | 

### Return type

[**ConversationContract**](ConversationContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconversationlogs"></a>
# **GetConversationLogs**
> List<ConversationContract> GetConversationLogs (string loanId)

Get list of Conversation logs

Retrieves a list of Conversation logs for a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetConversationLogsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConversationLogApi();
            var loanId = loanId_example;  // string | Unique Identifier of Loan(LoanId)

            try
            {
                // Get list of Conversation logs
                List&lt;ConversationContract&gt; result = apiInstance.GetConversationLogs(loanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationLogApi.GetConversationLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Unique Identifier of Loan(LoanId) | 

### Return type

[**List<ConversationContract>**](ConversationContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

