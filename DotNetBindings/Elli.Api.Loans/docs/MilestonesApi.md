# Elli.Api.Loans.Api.MilestonesApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMilestone**](MilestonesApi.md#getmilestone) | **GET** /encompass/v1/loans/{id}/milestones/{logId} | Get specific milestone of a loan
[**GetMilestones**](MilestonesApi.md#getmilestones) | **GET** /encompass/v1/loans/{id}/milestones | Get all milestones for a loan
[**UpdateMilestone**](MilestonesApi.md#updatemilestone) | **PATCH** /encompass/v1/loans/{id}/milestones/{logId} | Update a specific milestone


<a name="getmilestone"></a>
# **GetMilestone**
> MilestoneContract GetMilestone (string logId, string id)

Get specific milestone of a loan

Returns specifc milestone of a loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetMilestoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MilestonesApi();
            var logId = logId_example;  // string | Unique Identifier of log(LogId)
            var id = id_example;  // string | Unique Identifier of loan(LoanId)

            try
            {
                // Get specific milestone of a loan
                MilestoneContract result = apiInstance.GetMilestone(logId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MilestonesApi.GetMilestone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logId** | **string**| Unique Identifier of log(LogId) | 
 **id** | **string**| Unique Identifier of loan(LoanId) | 

### Return type

[**MilestoneContract**](MilestoneContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmilestones"></a>
# **GetMilestones**
> List<MilestoneContract> GetMilestones (string id)

Get all milestones for a loan

Returns all milestones for a loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetMilestonesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MilestonesApi();
            var id = id_example;  // string | Unique Identifier of loan(LoanId)

            try
            {
                // Get all milestones for a loan
                List&lt;MilestoneContract&gt; result = apiInstance.GetMilestones(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MilestonesApi.GetMilestones: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Unique Identifier of loan(LoanId) | 

### Return type

[**List<MilestoneContract>**](MilestoneContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemilestone"></a>
# **UpdateMilestone**
> void UpdateMilestone (string logId, string id, string action = null, MilestoneContract milestoneLogContract = null)

Update a specific milestone

Update the specific milestones for a loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class UpdateMilestoneExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MilestonesApi();
            var logId = logId_example;  // string | Unique Identifier of log(LogId)
            var id = id_example;  // string | Unique Identifier of loan(LoanId)
            var action = action_example;  // string | Optional parameter to perform specific action on a milestone. Action can be 'AcceptFile', 'ReturnFile', 'Unfinish' and 'Finish' (complete) milestone (optional) 
            var milestoneLogContract = new MilestoneContract(); // MilestoneContract |  (optional) 

            try
            {
                // Update a specific milestone
                apiInstance.UpdateMilestone(logId, id, action, milestoneLogContract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MilestonesApi.UpdateMilestone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logId** | **string**| Unique Identifier of log(LogId) | 
 **id** | **string**| Unique Identifier of loan(LoanId) | 
 **action** | **string**| Optional parameter to perform specific action on a milestone. Action can be &#39;AcceptFile&#39;, &#39;ReturnFile&#39;, &#39;Unfinish&#39; and &#39;Finish&#39; (complete) milestone | [optional] 
 **milestoneLogContract** | [**MilestoneContract**](MilestoneContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

