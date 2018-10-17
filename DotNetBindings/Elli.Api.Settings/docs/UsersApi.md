# Elli.Api.Settings.Api.UsersApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAssignedPermissionRights**](UsersApi.md#getassignedpermissionrights) | **GET** /encompass/v1/company/users/{userId}/assignedRights | Get Assigned Permission Rights
[**GetEffectivePermissionRights**](UsersApi.md#geteffectivepermissionrights) | **GET** /encompass/v1/company/users/{userId}/effectiveRights | Get Effective Permission Rights
[**GetLicenseInfo**](UsersApi.md#getlicenseinfo) | **GET** /encompass/v1/company/users/{userId}/licenses | Get License details
[**GetUserCompPlans**](UsersApi.md#getusercompplans) | **GET** /encompass/v1/company/users/{userId}/compensation | Get compensation plans
[**GetUserGroups**](UsersApi.md#getusergroups) | **GET** /encompass/v1/company/users/{id}/groups | Get List of user groups
[**GetUserProfile**](UsersApi.md#getuserprofile) | **GET** /encompass/v1/company/users/{id} | Get User profile
[**GetUserProfiles**](UsersApi.md#getuserprofiles) | **GET** /encompass/v1/company/users/ | Get List of users
[**GetUserSelfProfile**](UsersApi.md#getuserselfprofile) | **GET** /encompass/v1/company/users/me | Get User&#39;s self profile


<a name="getassignedpermissionrights"></a>
# **GetAssignedPermissionRights**
> Object GetAssignedPermissionRights (string userId, string category = null)

Get Assigned Permission Rights

Returns assigned permission rights of specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetAssignedPermissionRightsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | Unique Identifier of user
            var category = category_example;  // string | User settings category (optional) 

            try
            {
                // Get Assigned Permission Rights
                Object result = apiInstance.GetAssignedPermissionRights(userId, category);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAssignedPermissionRights: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Unique Identifier of user | 
 **category** | **string**| User settings category | [optional] 

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteffectivepermissionrights"></a>
# **GetEffectivePermissionRights**
> Object GetEffectivePermissionRights (string userId, string category = null)

Get Effective Permission Rights

Returns effective permission rights of specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetEffectivePermissionRightsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | Unique Identifier of user
            var category = category_example;  // string | User settings category (optional) 

            try
            {
                // Get Effective Permission Rights
                Object result = apiInstance.GetEffectivePermissionRights(userId, category);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetEffectivePermissionRights: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Unique Identifier of user | 
 **category** | **string**| User settings category | [optional] 

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlicenseinfo"></a>
# **GetLicenseInfo**
> List<LicenseContract> GetLicenseInfo (string userId, string state = null)

Get License details

Returns License of specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetLicenseInfoExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | Unique Identifier of user
            var state = state_example;  // string | State code (optional) 

            try
            {
                // Get License details
                List&lt;LicenseContract&gt; result = apiInstance.GetLicenseInfo(userId, state);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetLicenseInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Unique Identifier of user | 
 **state** | **string**| State code | [optional] 

### Return type

[**List<LicenseContract>**](LicenseContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusercompplans"></a>
# **GetUserCompPlans**
> CompensationPlanContract GetUserCompPlans (string userId)

Get compensation plans

Returns compensation plans associated to a user

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetUserCompPlansExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | Unique Identifier of user

            try
            {
                // Get compensation plans
                CompensationPlanContract result = apiInstance.GetUserCompPlans(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserCompPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Unique Identifier of user | 

### Return type

[**CompensationPlanContract**](CompensationPlanContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergroups"></a>
# **GetUserGroups**
> List<EntityRefContract> GetUserGroups (string id)

Get List of user groups

Returns List of groups for specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetUserGroupsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | Unique Identifier of user

            try
            {
                // Get List of user groups
                List&lt;EntityRefContract&gt; result = apiInstance.GetUserGroups(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Unique Identifier of user | 

### Return type

[**List<EntityRefContract>**](EntityRefContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserprofile"></a>
# **GetUserProfile**
> UserContract GetUserProfile (string id, string viewEmailSignature = null)

Get User profile

Returns User profile based on user name / id provided

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetUserProfileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = id_example;  // string | Unique Identifier of user
            var viewEmailSignature = viewEmailSignature_example;  // string | Flag indicates email signature should be returned or not (optional) 

            try
            {
                // Get User profile
                UserContract result = apiInstance.GetUserProfile(id, viewEmailSignature);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Unique Identifier of user | 
 **viewEmailSignature** | **string**| Flag indicates email signature should be returned or not | [optional] 

### Return type

[**UserContract**](UserContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserprofiles"></a>
# **GetUserProfiles**
> List<UserContract> GetUserProfiles (string viewEmailSignature = null, string groupId = null, string roleId = null, string personaId = null, string featureId = null, string organizationId = null, string userName = null, string start = null, string limit = null)

Get List of users

Returns All users

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetUserProfilesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var viewEmailSignature = viewEmailSignature_example;  // string | Flag indicates email signature should be returned or not (optional) 
            var groupId = groupId_example;  // string | Unique identifier of User Group (optional) 
            var roleId = roleId_example;  // string | Unique identifier of Role (optional) 
            var personaId = personaId_example;  // string | Unique identifier of User Persona (optional) 
            var featureId = featureId_example;  // string | Unique identifier of feature (optional) 
            var organizationId = organizationId_example;  // string | Unique identifier of an organization (optional) 
            var userName = userName_example;  // string | Name of user (optional) 
            var start = start_example;  // string | Start index or record number to retrieve a set of users. This is defaulted to 1. (optional) 
            var limit = limit_example;  // string | This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional) 

            try
            {
                // Get List of users
                List&lt;UserContract&gt; result = apiInstance.GetUserProfiles(viewEmailSignature, groupId, roleId, personaId, featureId, organizationId, userName, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewEmailSignature** | **string**| Flag indicates email signature should be returned or not | [optional] 
 **groupId** | **string**| Unique identifier of User Group | [optional] 
 **roleId** | **string**| Unique identifier of Role | [optional] 
 **personaId** | **string**| Unique identifier of User Persona | [optional] 
 **featureId** | **string**| Unique identifier of feature | [optional] 
 **organizationId** | **string**| Unique identifier of an organization | [optional] 
 **userName** | **string**| Name of user | [optional] 
 **start** | **string**| Start index or record number to retrieve a set of users. This is defaulted to 1. | [optional] 
 **limit** | **string**| This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. | [optional] 

### Return type

[**List<UserContract>**](UserContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserselfprofile"></a>
# **GetUserSelfProfile**
> UserContract GetUserSelfProfile (string viewEmailSignature = null)

Get User's self profile

Returns profile for the logged in user.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetUserSelfProfileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var viewEmailSignature = viewEmailSignature_example;  // string | Flag indicates email signature should be returned or not (optional) 

            try
            {
                // Get User's self profile
                UserContract result = apiInstance.GetUserSelfProfile(viewEmailSignature);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserSelfProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewEmailSignature** | **string**| Flag indicates email signature should be returned or not | [optional] 

### Return type

[**UserContract**](UserContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

