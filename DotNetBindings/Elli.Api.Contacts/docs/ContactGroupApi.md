# Elli.Api.Contacts.Api.ContactGroupApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateContactGroup**](ContactGroupApi.md#createcontactgroup) | **POST** /encompass/v1/contactGroups | Create New Contact Group
[**DeleteContactGroup**](ContactGroupApi.md#deletecontactgroup) | **DELETE** /encompass/v1/contactGroups/{groupId} | Delete contact Group
[**GetContactGroup**](ContactGroupApi.md#getcontactgroup) | **GET** /encompass/v1/contactGroups/{groupId} | Get contact Group by Id
[**GetContactGroups**](ContactGroupApi.md#getcontactgroups) | **GET** /encompass/v1/contactGroups/ | Get All contact Groups
[**GetContactsOfGroup**](ContactGroupApi.md#getcontactsofgroup) | **GET** /encompass/v1/contactGroups/{groupId}/contacts | Get All contacts associated with a group
[**UpdateContactGroup**](ContactGroupApi.md#updatecontactgroup) | **PATCH** /encompass/v1/contactGroups/{groupId} | Update Contact Group
[**UpdateContactsOfGroup**](ContactGroupApi.md#updatecontactsofgroup) | **PATCH** /encompass/v1/contactGroups/{groupId}/contacts | Update Contacts within a Group


<a name="createcontactgroup"></a>
# **CreateContactGroup**
> Object CreateContactGroup (ContactGroupContract contactGroupContract = null, string view = null)

Create New Contact Group

Creates a new Contact Group to be associated with contacts

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class CreateContactGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactGroupApi();
            var contactGroupContract = new ContactGroupContract(); // ContactGroupContract |  (optional) 
            var view = view_example;  // string | Possible values are: entity - Returns all properties of the resource. id - Returns the ID assigned to the resource. (optional) 

            try
            {
                // Create New Contact Group
                Object result = apiInstance.CreateContactGroup(contactGroupContract, view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactGroupApi.CreateContactGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactGroupContract** | [**ContactGroupContract**](ContactGroupContract.md)|  | [optional] 
 **view** | **string**| Possible values are: entity - Returns all properties of the resource. id - Returns the ID assigned to the resource. | [optional] 

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontactgroup"></a>
# **DeleteContactGroup**
> void DeleteContactGroup (string groupId)

Delete contact Group

Removes contact Group of specified groupId

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class DeleteContactGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactGroupApi();
            var groupId = groupId_example;  // string | Unique Identifier of a group

            try
            {
                // Delete contact Group
                apiInstance.DeleteContactGroup(groupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactGroupApi.DeleteContactGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| Unique Identifier of a group | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactgroup"></a>
# **GetContactGroup**
> ContactGroupContract GetContactGroup (string groupId)

Get contact Group by Id

Returns Contact Group details for a given groupId

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class GetContactGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactGroupApi();
            var groupId = groupId_example;  // string | Unique Identifier of a group

            try
            {
                // Get contact Group by Id
                ContactGroupContract result = apiInstance.GetContactGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactGroupApi.GetContactGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| Unique Identifier of a group | 

### Return type

[**ContactGroupContract**](ContactGroupContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactgroups"></a>
# **GetContactGroups**
> List<ContactGroupContract> GetContactGroups (string contactType, string groupType = null)

Get All contact Groups

Returns All contact Groups for a given contact type({Borrower | Business })

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class GetContactGroupsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactGroupApi();
            var contactType = contactType_example;  // string | Type of a contact e.g Borrower|Business
            var groupType = groupType_example;  // string | Type of a group e.g Private|Public (optional) 

            try
            {
                // Get All contact Groups
                List&lt;ContactGroupContract&gt; result = apiInstance.GetContactGroups(contactType, groupType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactGroupApi.GetContactGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactType** | **string**| Type of a contact e.g Borrower|Business | 
 **groupType** | **string**| Type of a group e.g Private|Public | [optional] 

### Return type

[**List<ContactGroupContract>**](ContactGroupContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactsofgroup"></a>
# **GetContactsOfGroup**
> List<EntityRefContract> GetContactsOfGroup (string groupId, string start = null, string limit = null)

Get All contacts associated with a group

Returns All contacts associated with a group specified by group id

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class GetContactsOfGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactGroupApi();
            var groupId = groupId_example;  // string | Unique Identifier of a Group
            var start = start_example;  // string | Start index or record number to retrieve a set of contacts. This is defaulted to 1. (optional) 
            var limit = limit_example;  // string | This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional) 

            try
            {
                // Get All contacts associated with a group
                List&lt;EntityRefContract&gt; result = apiInstance.GetContactsOfGroup(groupId, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactGroupApi.GetContactsOfGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| Unique Identifier of a Group | 
 **start** | **string**| Start index or record number to retrieve a set of contacts. This is defaulted to 1. | [optional] 
 **limit** | **string**| This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. | [optional] 

### Return type

[**List<EntityRefContract>**](EntityRefContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontactgroup"></a>
# **UpdateContactGroup**
> Object UpdateContactGroup (string groupId, ContactGroupContract contactGroupContract = null, string view = null)

Update Contact Group

Updates Contact Group details

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class UpdateContactGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactGroupApi();
            var groupId = groupId_example;  // string | Unique Identifier of a Group
            var contactGroupContract = new ContactGroupContract(); // ContactGroupContract |  (optional) 
            var view = view_example;  // string | Possible values are: entity - Returns all properties of the resource. id - Returns the ID assigned to the resource. (optional) 

            try
            {
                // Update Contact Group
                Object result = apiInstance.UpdateContactGroup(groupId, contactGroupContract, view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactGroupApi.UpdateContactGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| Unique Identifier of a Group | 
 **contactGroupContract** | [**ContactGroupContract**](ContactGroupContract.md)|  | [optional] 
 **view** | **string**| Possible values are: entity - Returns all properties of the resource. id - Returns the ID assigned to the resource. | [optional] 

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontactsofgroup"></a>
# **UpdateContactsOfGroup**
> void UpdateContactsOfGroup (string groupId, string action, List<EntityRefContract> entityRefContract = null)

Update Contacts within a Group

Add/Remove Contacts within a Group specified by groupId

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class UpdateContactsOfGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactGroupApi();
            var groupId = groupId_example;  // string | Unique Identifier of a Group
            var action = action_example;  // string | Specifies action to be performed on contacts (add/remove)
            var entityRefContract = new List<EntityRefContract>(); // List<EntityRefContract> |  (optional) 

            try
            {
                // Update Contacts within a Group
                apiInstance.UpdateContactsOfGroup(groupId, action, entityRefContract);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactGroupApi.UpdateContactsOfGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| Unique Identifier of a Group | 
 **action** | **string**| Specifies action to be performed on contacts (add/remove) | 
 **entityRefContract** | [**List&lt;EntityRefContract&gt;**](EntityRefContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

