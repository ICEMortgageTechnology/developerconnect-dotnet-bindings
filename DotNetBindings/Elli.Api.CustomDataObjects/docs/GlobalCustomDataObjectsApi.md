# Elli.Api.CustomDataObjects.Api.GlobalCustomDataObjectsApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppendGlobalCustomDataObject**](GlobalCustomDataObjectsApi.md#appendglobalcustomdataobject) | **PATCH** /encompass/v1/company/customObjects/{objectName} | Append to global custom data object
[**CreateGlobalCustomDataObject**](GlobalCustomDataObjectsApi.md#createglobalcustomdataobject) | **PUT** /encompass/v1/company/customObjects/{objectName} | Create a global custom data object
[**DeleteGlobalCustomDataObject**](GlobalCustomDataObjectsApi.md#deleteglobalcustomdataobject) | **DELETE** /encompass/v1/company/customObjects/{objectName} | Removes a global custom data objec
[**GetGlobalCustomDataObject**](GlobalCustomDataObjectsApi.md#getglobalcustomdataobject) | **GET** /encompass/v1/company/customObjects/{objectName} | Retrieve a global custom data object
[**GetGlobalCustomDataObjects**](GlobalCustomDataObjectsApi.md#getglobalcustomdataobjects) | **GET** /encompass/v1/company/customObjects | Retrieve all custom data objects for any instance


<a name="appendglobalcustomdataobject"></a>
# **AppendGlobalCustomDataObject**
> Object AppendGlobalCustomDataObject (string objectName, GlobalCustomDataObjectContract globalCustomDataObjectContract = null, string view = null)

Append to global custom data object

Append contents to any specific custom data object for any specific instance

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class AppendGlobalCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlobalCustomDataObjectsApi();
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource
            var globalCustomDataObjectContract = new GlobalCustomDataObjectContract(); // GlobalCustomDataObjectContract |  (optional) 
            var view = view_example;  // string | Possible values are: entity - Returns all properties of the resource. id - Returns the ID assigned to the resource. (optional) 

            try
            {
                // Append to global custom data object
                Object result = apiInstance.AppendGlobalCustomDataObject(objectName, globalCustomDataObjectContract, view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalCustomDataObjectsApi.AppendGlobalCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 
 **globalCustomDataObjectContract** | [**GlobalCustomDataObjectContract**](GlobalCustomDataObjectContract.md)|  | [optional] 
 **view** | **string**| Possible values are: entity - Returns all properties of the resource. id - Returns the ID assigned to the resource. | [optional] 

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createglobalcustomdataobject"></a>
# **CreateGlobalCustomDataObject**
> Object CreateGlobalCustomDataObject (string objectName, GlobalCustomDataObjectContract globalCustomDataObjectContract = null, string view = null)

Create a global custom data object

Create/Update specific custom data object for any specific instance

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class CreateGlobalCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlobalCustomDataObjectsApi();
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource
            var globalCustomDataObjectContract = new GlobalCustomDataObjectContract(); // GlobalCustomDataObjectContract |  (optional) 
            var view = view_example;  // string | Possible values are: entity - Returns all properties of the resource. id - Returns the ID assigned to the resource. (optional) 

            try
            {
                // Create a global custom data object
                Object result = apiInstance.CreateGlobalCustomDataObject(objectName, globalCustomDataObjectContract, view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalCustomDataObjectsApi.CreateGlobalCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 
 **globalCustomDataObjectContract** | [**GlobalCustomDataObjectContract**](GlobalCustomDataObjectContract.md)|  | [optional] 
 **view** | **string**| Possible values are: entity - Returns all properties of the resource. id - Returns the ID assigned to the resource. | [optional] 

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteglobalcustomdataobject"></a>
# **DeleteGlobalCustomDataObject**
> void DeleteGlobalCustomDataObject (string objectName)

Removes a global custom data objec

Removes specific custom data object for any specific instance

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class DeleteGlobalCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlobalCustomDataObjectsApi();
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource

            try
            {
                // Removes a global custom data objec
                apiInstance.DeleteGlobalCustomDataObject(objectName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalCustomDataObjectsApi.DeleteGlobalCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getglobalcustomdataobject"></a>
# **GetGlobalCustomDataObject**
> GlobalCustomDataObjectContract GetGlobalCustomDataObject (string objectName)

Retrieve a global custom data object

Retrieves a specific custom data object for any specific instance

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class GetGlobalCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlobalCustomDataObjectsApi();
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource

            try
            {
                // Retrieve a global custom data object
                GlobalCustomDataObjectContract result = apiInstance.GetGlobalCustomDataObject(objectName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalCustomDataObjectsApi.GetGlobalCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 

### Return type

[**GlobalCustomDataObjectContract**](GlobalCustomDataObjectContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getglobalcustomdataobjects"></a>
# **GetGlobalCustomDataObjects**
> List<string> GetGlobalCustomDataObjects ()

Retrieve all custom data objects for any instance

Retrieves a list of custom data objects for any specific instance

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class GetGlobalCustomDataObjectsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlobalCustomDataObjectsApi();

            try
            {
                // Retrieve all custom data objects for any instance
                List&lt;string&gt; result = apiInstance.GetGlobalCustomDataObjects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalCustomDataObjectsApi.GetGlobalCustomDataObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

