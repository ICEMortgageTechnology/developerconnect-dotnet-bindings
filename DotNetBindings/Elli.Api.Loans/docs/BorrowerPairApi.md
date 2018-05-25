# Elli.Api.Loans.Api.BorrowerPairApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateApplication**](BorrowerPairApi.md#createapplication) | **POST** /encompass/v1/loans/{loanId}/applications | Create a borrower pair.
[**DeleteApplication**](BorrowerPairApi.md#deleteapplication) | **DELETE** /encompass/v1/loans/{loanId}/applications/{applicationId} | Delete borrower pair.
[**GetApplication**](BorrowerPairApi.md#getapplication) | **GET** /encompass/v1/loans/{loanId}/applications/{applicationId} | Get borrower pair.
[**GetApplications**](BorrowerPairApi.md#getapplications) | **GET** /encompass/v1/loans/{loanId}/applications | Get Borrower Pairs.
[**SwapMoveApplications**](BorrowerPairApi.md#swapmoveapplications) | **PATCH** /encompass/v1/loans/{loanId}/applications | Swap / Move Borrower - CoBorrower
[**UpdateApplication**](BorrowerPairApi.md#updateapplication) | **PATCH** /encompass/v1/loans/{loanId}/applications/{applicationId} | Update borrower pair.


<a name="createapplication"></a>
# **CreateApplication**
> void CreateApplication (string loanId, ApplicationContract requestPayload = null)

Create a borrower pair.

Creates a new borrower pair for an existing loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class CreateApplicationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerPairApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to the loan.
            var requestPayload = new ApplicationContract(); // ApplicationContract |  (optional) 

            try
            {
                // Create a borrower pair.
                apiInstance.CreateApplication(loanId, requestPayload);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerPairApi.CreateApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to the loan. | 
 **requestPayload** | [**ApplicationContract**](ApplicationContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteapplication"></a>
# **DeleteApplication**
> void DeleteApplication (string loanId, string applicationId)

Delete borrower pair.

Permanently deletes a borrower pair from a specified loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class DeleteApplicationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerPairApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to the loan.
            var applicationId = applicationId_example;  // string | The unique identifier assigned to the application.

            try
            {
                // Delete borrower pair.
                apiInstance.DeleteApplication(loanId, applicationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerPairApi.DeleteApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to the loan. | 
 **applicationId** | **string**| The unique identifier assigned to the application. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplication"></a>
# **GetApplication**
> ApplicationContract GetApplication (string loanId, string applicationId)

Get borrower pair.

Retrieves a specified borrower pair for a specified loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetApplicationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerPairApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to the loan.
            var applicationId = applicationId_example;  // string | The unique identifier assigned to the application.

            try
            {
                // Get borrower pair.
                ApplicationContract result = apiInstance.GetApplication(loanId, applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerPairApi.GetApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to the loan. | 
 **applicationId** | **string**| The unique identifier assigned to the application. | 

### Return type

[**ApplicationContract**](ApplicationContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplications"></a>
# **GetApplications**
> List<ApplicationContract> GetApplications (string loanId, string applicationIndex = null, string applicationType = null)

Get Borrower Pairs.

Retrieves all borrower pairs for a specified loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetApplicationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerPairApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to the loan.
            var applicationIndex = applicationIndex_example;  // string | Index of the specific application type. (optional) 
            var applicationType = applicationType_example;  // string | Borrower, CoBorrower or Both. (optional) 

            try
            {
                // Get Borrower Pairs.
                List&lt;ApplicationContract&gt; result = apiInstance.GetApplications(loanId, applicationIndex, applicationType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerPairApi.GetApplications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to the loan. | 
 **applicationIndex** | **string**| Index of the specific application type. | [optional] 
 **applicationType** | **string**| Borrower, CoBorrower or Both. | [optional] 

### Return type

[**List<ApplicationContract>**](ApplicationContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="swapmoveapplications"></a>
# **SwapMoveApplications**
> void SwapMoveApplications (string loanId, List<ApplicationContract> applicationContracts = null)

Swap / Move Borrower - CoBorrower

To Swap / Move Borrower - CoBorrower across applications of a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class SwapMoveApplicationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerPairApi();
            var loanId = loanId_example;  // string | Unique Identifier of a loan
            var applicationContracts = new List<ApplicationContract>(); // List<ApplicationContract> |  (optional) 

            try
            {
                // Swap / Move Borrower - CoBorrower
                apiInstance.SwapMoveApplications(loanId, applicationContracts);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerPairApi.SwapMoveApplications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Unique Identifier of a loan | 
 **applicationContracts** | [**List&lt;ApplicationContract&gt;**](ApplicationContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateapplication"></a>
# **UpdateApplication**
> void UpdateApplication (string loanId, string applicationId, ApplicationContract applicationContract = null)

Update borrower pair.

Updates an existing borrower pair for a specified loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class UpdateApplicationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerPairApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to the loan.
            var applicationId = applicationId_example;  // string | The unique identifier assigned to the application.
            var applicationContract = new ApplicationContract(); // ApplicationContract |  (optional) 

            try
            {
                // Update borrower pair.
                apiInstance.UpdateApplication(loanId, applicationId, applicationContract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerPairApi.UpdateApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to the loan. | 
 **applicationId** | **string**| The unique identifier assigned to the application. | 
 **applicationContract** | [**ApplicationContract**](ApplicationContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

