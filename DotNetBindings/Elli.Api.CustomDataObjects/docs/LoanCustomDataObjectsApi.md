# Elli.Api.CustomDataObjects.Api.LoanCustomDataObjectsApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppendLoanCustomDataObject**](LoanCustomDataObjectsApi.md#appendloancustomdataobject) | **PATCH** /encompass/v1/loans/{loanId}/customObjects/{objectName} | Append custom data object for a loan
[**CreateLoanCustomDataObject**](LoanCustomDataObjectsApi.md#createloancustomdataobject) | **PUT** /encompass/v1/loans/{loanId}/customObjects/{objectName} | Create a loan custom data object
[**DeleteLoanCustomDataObject**](LoanCustomDataObjectsApi.md#deleteloancustomdataobject) | **DELETE** /encompass/v1/loans/{loanId}/customObjects/{objectName} | Removes custom data object for a loan
[**GetLoanCustomDataObject**](LoanCustomDataObjectsApi.md#getloancustomdataobject) | **GET** /encompass/v1/loans/{loanId}/customObjects/{objectName} | Retrieve a loan custom data object
[**GetLoanCustomDataObjects**](LoanCustomDataObjectsApi.md#getloancustomdataobjects) | **GET** /encompass/v1/loans/{loanId}/customObjects | Retrieve all loan custom data objects


<a name="appendloancustomdataobject"></a>
# **AppendLoanCustomDataObject**
> LoanCustomDataObjectContract AppendLoanCustomDataObject (string loanId, string objectName, LoanCustomDataObjectContract customDataObjectContract = null)

Append custom data object for a loan

Append contents to any specific custom data object for a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class AppendLoanCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanCustomDataObjectsApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to a loan
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource
            var customDataObjectContract = new LoanCustomDataObjectContract(); // LoanCustomDataObjectContract |  (optional) 

            try
            {
                // Append custom data object for a loan
                LoanCustomDataObjectContract result = apiInstance.AppendLoanCustomDataObject(loanId, objectName, customDataObjectContract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanCustomDataObjectsApi.AppendLoanCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to a loan | 
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 
 **customDataObjectContract** | [**LoanCustomDataObjectContract**](LoanCustomDataObjectContract.md)|  | [optional] 

### Return type

[**LoanCustomDataObjectContract**](LoanCustomDataObjectContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createloancustomdataobject"></a>
# **CreateLoanCustomDataObject**
> LoanCustomDataObjectContract CreateLoanCustomDataObject (string loanId, string objectName, LoanCustomDataObjectContract customDataObjectContract = null)

Create a loan custom data object

Create/Update specific custom data object for a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class CreateLoanCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanCustomDataObjectsApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to a loan
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource
            var customDataObjectContract = new LoanCustomDataObjectContract(); // LoanCustomDataObjectContract |  (optional) 

            try
            {
                // Create a loan custom data object
                LoanCustomDataObjectContract result = apiInstance.CreateLoanCustomDataObject(loanId, objectName, customDataObjectContract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanCustomDataObjectsApi.CreateLoanCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to a loan | 
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 
 **customDataObjectContract** | [**LoanCustomDataObjectContract**](LoanCustomDataObjectContract.md)|  | [optional] 

### Return type

[**LoanCustomDataObjectContract**](LoanCustomDataObjectContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteloancustomdataobject"></a>
# **DeleteLoanCustomDataObject**
> void DeleteLoanCustomDataObject (string loanId, string objectName)

Removes custom data object for a loan

Removes specific custom data object for a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class DeleteLoanCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanCustomDataObjectsApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to a loan
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource

            try
            {
                // Removes custom data object for a loan
                apiInstance.DeleteLoanCustomDataObject(loanId, objectName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanCustomDataObjectsApi.DeleteLoanCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to a loan | 
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloancustomdataobject"></a>
# **GetLoanCustomDataObject**
> LoanCustomDataObjectContract GetLoanCustomDataObject (string loanId, string objectName)

Retrieve a loan custom data object

Retrieves a specific custom data object for any existing loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class GetLoanCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanCustomDataObjectsApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to a loan
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource

            try
            {
                // Retrieve a loan custom data object
                LoanCustomDataObjectContract result = apiInstance.GetLoanCustomDataObject(loanId, objectName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanCustomDataObjectsApi.GetLoanCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to a loan | 
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 

### Return type

[**LoanCustomDataObjectContract**](LoanCustomDataObjectContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloancustomdataobjects"></a>
# **GetLoanCustomDataObjects**
> List<string> GetLoanCustomDataObjects (string loanId)

Retrieve all loan custom data objects

Retrieves a list of custom data objects for any specific loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class GetLoanCustomDataObjectsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanCustomDataObjectsApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to a loan

            try
            {
                // Retrieve all loan custom data objects
                List&lt;string&gt; result = apiInstance.GetLoanCustomDataObjects(loanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanCustomDataObjectsApi.GetLoanCustomDataObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to a loan | 

### Return type

**List<string>**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

