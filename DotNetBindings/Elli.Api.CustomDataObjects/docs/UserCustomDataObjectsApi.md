# Elli.Api.CustomDataObjects.Api.UserCustomDataObjectsApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppendUserCustomDataObject**](UserCustomDataObjectsApi.md#appendusercustomdataobject) | **PATCH** /encompass/v1/users/{userId}/customObjects/{objectName} | Append custom data object for a user
[**CreateUserCustomDataObject**](UserCustomDataObjectsApi.md#createusercustomdataobject) | **PUT** /encompass/v1/users/{userId}/customObjects/{objectName} | Create a user custom data object
[**DeleteUserCustomDataObject**](UserCustomDataObjectsApi.md#deleteusercustomdataobject) | **DELETE** /encompass/v1/users/{userId}/customObjects/{objectName} | Removes custom data object for a user
[**GetUserCustomDataObject**](UserCustomDataObjectsApi.md#getusercustomdataobject) | **GET** /encompass/v1/users/{userId}/customObjects/{objectName} | Retrieve a user custom data object
[**GetUserCustomDataObjects**](UserCustomDataObjectsApi.md#getusercustomdataobjects) | **GET** /encompass/v1/users/{userId}/customObjects | Retrieve all user custom data objects


<a name="appendusercustomdataobject"></a>
# **AppendUserCustomDataObject**
> UserCustomDataObjectContract AppendUserCustomDataObject (string userId, string objectName, UserCustomDataObjectContract customDataObjectContract = null)

Append custom data object for a user

Append contents to any specific custom data object for a user

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class AppendUserCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserCustomDataObjectsApi();
            var userId = userId_example;  // string | The unique identifier assigned to a user
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource
            var customDataObjectContract = new UserCustomDataObjectContract(); // UserCustomDataObjectContract |  (optional) 

            try
            {
                // Append custom data object for a user
                UserCustomDataObjectContract result = apiInstance.AppendUserCustomDataObject(userId, objectName, customDataObjectContract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserCustomDataObjectsApi.AppendUserCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The unique identifier assigned to a user | 
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 
 **customDataObjectContract** | [**UserCustomDataObjectContract**](UserCustomDataObjectContract.md)|  | [optional] 

### Return type

[**UserCustomDataObjectContract**](UserCustomDataObjectContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createusercustomdataobject"></a>
# **CreateUserCustomDataObject**
> UserCustomDataObjectContract CreateUserCustomDataObject (string userId, string objectName, UserCustomDataObjectContract customDataObjectContract = null)

Create a user custom data object

Create/Update specific custom data object for a user

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class CreateUserCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserCustomDataObjectsApi();
            var userId = userId_example;  // string | The unique identifier assigned to a user
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource
            var customDataObjectContract = new UserCustomDataObjectContract(); // UserCustomDataObjectContract |  (optional) 

            try
            {
                // Create a user custom data object
                UserCustomDataObjectContract result = apiInstance.CreateUserCustomDataObject(userId, objectName, customDataObjectContract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserCustomDataObjectsApi.CreateUserCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The unique identifier assigned to a user | 
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 
 **customDataObjectContract** | [**UserCustomDataObjectContract**](UserCustomDataObjectContract.md)|  | [optional] 

### Return type

[**UserCustomDataObjectContract**](UserCustomDataObjectContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteusercustomdataobject"></a>
# **DeleteUserCustomDataObject**
> void DeleteUserCustomDataObject (string userId, string objectName)

Removes custom data object for a user

Removes specific custom data object for a user

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class DeleteUserCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserCustomDataObjectsApi();
            var userId = userId_example;  // string | The unique identifier assigned to a user
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource

            try
            {
                // Removes custom data object for a user
                apiInstance.DeleteUserCustomDataObject(userId, objectName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserCustomDataObjectsApi.DeleteUserCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The unique identifier assigned to a user | 
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusercustomdataobject"></a>
# **GetUserCustomDataObject**
> UserCustomDataObjectContract GetUserCustomDataObject (string userId, string objectName)

Retrieve a user custom data object

Retrieves a specific custom data object for any existing user

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class GetUserCustomDataObjectExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserCustomDataObjectsApi();
            var userId = userId_example;  // string | The unique identifier assigned to a user
            var objectName = objectName_example;  // string | The unique identifier assigned to a CDO under specific resource

            try
            {
                // Retrieve a user custom data object
                UserCustomDataObjectContract result = apiInstance.GetUserCustomDataObject(userId, objectName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserCustomDataObjectsApi.GetUserCustomDataObject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The unique identifier assigned to a user | 
 **objectName** | **string**| The unique identifier assigned to a CDO under specific resource | 

### Return type

[**UserCustomDataObjectContract**](UserCustomDataObjectContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusercustomdataobjects"></a>
# **GetUserCustomDataObjects**
> List<string> GetUserCustomDataObjects (string userId)

Retrieve all user custom data objects

Retrieves a list of custom data objects for any specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Client;
using Elli.Api.CustomDataObjects.Model;

namespace Example
{
    public class GetUserCustomDataObjectsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserCustomDataObjectsApi();
            var userId = userId_example;  // string | The unique identifier assigned to a user

            try
            {
                // Retrieve all user custom data objects
                List&lt;string&gt; result = apiInstance.GetUserCustomDataObjects(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserCustomDataObjectsApi.GetUserCustomDataObjects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The unique identifier assigned to a user | 

### Return type

**List<string>**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

