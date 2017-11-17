# Elli.Api.Loans.Api.ResourceLocksApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateResourceLock**](ResourceLocksApi.md#createresourcelock) | **POST** /encompass/v1/resourceLocks | Create a lock
[**GetResourceLock**](ResourceLocksApi.md#getresourcelock) | **GET** /encompass/v1/resourceLocks | Retrieve locks
[**GetResourceLockByLockId**](ResourceLocksApi.md#getresourcelockbylockid) | **GET** /encompass/v1/resourceLocks/{lockId} | Retrieve a lock
[**Unlock**](ResourceLocksApi.md#unlock) | **DELETE** /encompass/v1/resourceLocks/{lockId} | Unlock a resource


<a name="createresourcelock"></a>
# **CreateResourceLock**
> ResourceRef CreateResourceLock (string force = null, string view = null, ResourceLockContract resourceLock = null)

Create a lock

Create a Resource lock

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class CreateResourceLockExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourceLocksApi();
            var force = force_example;  // string | Flag to forcefully lock a loan (optional) 
            var view = view_example;  // string | Flag to forcefully lock a loan (optional) 
            var resourceLock = new ResourceLockContract(); // ResourceLockContract |  (optional) 

            try
            {
                // Create a lock
                ResourceRef result = apiInstance.CreateResourceLock(force, view, resourceLock);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourceLocksApi.CreateResourceLock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **force** | **string**| Flag to forcefully lock a loan | [optional] 
 **view** | **string**| Flag to forcefully lock a loan | [optional] 
 **resourceLock** | [**ResourceLockContract**](ResourceLockContract.md)|  | [optional] 

### Return type

[**ResourceRef**](ResourceRef.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresourcelock"></a>
# **GetResourceLock**
> ResourceLockContract GetResourceLock (string resourceType = null, string resourceId = null)

Retrieve locks

Retrieves a list of Locks

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetResourceLockExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourceLocksApi();
            var resourceType = resourceType_example;  // string | Type of resource (optional) 
            var resourceId = resourceId_example;  // string | Unique Identifier of resource (optional) 

            try
            {
                // Retrieve locks
                ResourceLockContract result = apiInstance.GetResourceLock(resourceType, resourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourceLocksApi.GetResourceLock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resourceType** | **string**| Type of resource | [optional] 
 **resourceId** | **string**| Unique Identifier of resource | [optional] 

### Return type

[**ResourceLockContract**](ResourceLockContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresourcelockbylockid"></a>
# **GetResourceLockByLockId**
> ResourceLockContract GetResourceLockByLockId (string lockId, string resourceType, string resourceId)

Retrieve a lock

Retrieve a lock based on the lock Id for a resource

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetResourceLockByLockIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourceLocksApi();
            var lockId = lockId_example;  // string | The Unique Identifier assigned to a lock
            var resourceType = resourceType_example;  // string | Type of resource
            var resourceId = resourceId_example;  // string | Unique Identifier of resource

            try
            {
                // Retrieve a lock
                ResourceLockContract result = apiInstance.GetResourceLockByLockId(lockId, resourceType, resourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourceLocksApi.GetResourceLockByLockId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lockId** | **string**| The Unique Identifier assigned to a lock | 
 **resourceType** | **string**| Type of resource | 
 **resourceId** | **string**| Unique Identifier of resource | 

### Return type

[**ResourceLockContract**](ResourceLockContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unlock"></a>
# **Unlock**
> void Unlock (string lockId, string resourceType, string resourceId, string force = null)

Unlock a resource

Deletes an existing resourceLock resulting in unlocking the resource

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class UnlockExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourceLocksApi();
            var lockId = lockId_example;  // string | The Unique identifier assigned to a lock
            var resourceType = resourceType_example;  // string | Type of resource
            var resourceId = resourceId_example;  // string | Unique Identifier of resource
            var force = force_example;  // string | Flag to forcefully unlock a loan (optional) 

            try
            {
                // Unlock a resource
                apiInstance.Unlock(lockId, resourceType, resourceId, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourceLocksApi.Unlock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lockId** | **string**| The Unique identifier assigned to a lock | 
 **resourceType** | **string**| Type of resource | 
 **resourceId** | **string**| Unique Identifier of resource | 
 **force** | **string**| Flag to forcefully unlock a loan | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

