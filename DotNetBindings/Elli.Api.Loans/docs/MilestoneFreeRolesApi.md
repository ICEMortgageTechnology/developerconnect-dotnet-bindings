# Elli.Api.Loans.Api.MilestoneFreeRolesApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMilestoneFreeRole**](MilestoneFreeRolesApi.md#getmilestonefreerole) | **GET** /encompass/v1/loans/{id}/milestoneFreeRoles/{logId} | Retrieve specific milestonefreerole log
[**GetMilestoneFreeRoles**](MilestoneFreeRolesApi.md#getmilestonefreeroles) | **GET** /encompass/v1/loans/{id}/milestoneFreeRoles | Retrieve milestonefreelogs
[**UpdateMilestoneFreeRole**](MilestoneFreeRolesApi.md#updatemilestonefreerole) | **PATCH** /encompass/v1/loans/{id}/milestoneFreeRoles/{logId} | Update specific milestoneFreeRole to loan


<a name="getmilestonefreerole"></a>
# **GetMilestoneFreeRole**
> MilestoneFreeRoleContract GetMilestoneFreeRole (string logId, string id)

Retrieve specific milestonefreerole log

Retrieves a specific milestonefreerolelog of given logId for a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetMilestoneFreeRoleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MilestoneFreeRolesApi();
            var logId = logId_example;  // string | Unique Identifier of log(LogId)
            var id = id_example;  // string | Unique Identifier of loan(LoanId)

            try
            {
                // Retrieve specific milestonefreerole log
                MilestoneFreeRoleContract result = apiInstance.GetMilestoneFreeRole(logId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MilestoneFreeRolesApi.GetMilestoneFreeRole: " + e.Message );
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

[**MilestoneFreeRoleContract**](MilestoneFreeRoleContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmilestonefreeroles"></a>
# **GetMilestoneFreeRoles**
> MilestoneFreeRoleContract GetMilestoneFreeRoles (string id)

Retrieve milestonefreelogs

Retrieves a list of milestonefreelogs for a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetMilestoneFreeRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MilestoneFreeRolesApi();
            var id = id_example;  // string | Unique Identifier of Loan(LoanId)

            try
            {
                // Retrieve milestonefreelogs
                MilestoneFreeRoleContract result = apiInstance.GetMilestoneFreeRoles(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MilestoneFreeRolesApi.GetMilestoneFreeRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Unique Identifier of Loan(LoanId) | 

### Return type

[**MilestoneFreeRoleContract**](MilestoneFreeRoleContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemilestonefreerole"></a>
# **UpdateMilestoneFreeRole**
> void UpdateMilestoneFreeRole (string logId, string id, MilestoneFreeRoleContract milestoneFreeRole = null)

Update specific milestoneFreeRole to loan

Update specific milestoneFreeRole to loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class UpdateMilestoneFreeRoleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MilestoneFreeRolesApi();
            var logId = logId_example;  // string | Unique Identifier of log(LogId)
            var id = id_example;  // string | Unique Identifier of loan(LoanId)
            var milestoneFreeRole = new MilestoneFreeRoleContract(); // MilestoneFreeRoleContract |  (optional) 

            try
            {
                // Update specific milestoneFreeRole to loan
                apiInstance.UpdateMilestoneFreeRole(logId, id, milestoneFreeRole);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MilestoneFreeRolesApi.UpdateMilestoneFreeRole: " + e.Message );
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
 **milestoneFreeRole** | [**MilestoneFreeRoleContract**](MilestoneFreeRoleContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

