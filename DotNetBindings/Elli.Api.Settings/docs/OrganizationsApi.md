# Elli.Api.Settings.Api.OrganizationsApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrganization**](OrganizationsApi.md#getorganization) | **GET** /encompass/v1/organizations/{orgId} | Get organization detail
[**GetOrganizationChildren**](OrganizationsApi.md#getorganizationchildren) | **GET** /encompass/v1/organizations/{orgId}/children | Returnes entity reference for child organizations and users
[**GetOrganizations**](OrganizationsApi.md#getorganizations) | **GET** /encompass/v1/organizations/ | Get list of organizations
[**GetRootOrganization**](OrganizationsApi.md#getrootorganization) | **GET** /encompass/v1/organizations/root | Get root organization detail


<a name="getorganization"></a>
# **GetOrganization**
> OrganizationInfoContract GetOrganization (string orgId, string view = null)

Get organization detail

Returns the organization details. It supports three types of view. By default 'Summary' will be returns. in 'Summary' view, response will have basic organization details along with parent organization reference. when view is 'Entity', response will have complete organization details. When view is 'Hierarchy', organization children like like child organizations and associated users will be included in response. Case is ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetOrganizationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi();
            var orgId = orgId_example;  // string | Organization id for which details are requested.
            var view = view_example;  // string | Indicates the level of details required in response. Acceptable values are summary, entity or hierarchy. summary by default. (optional) 

            try
            {
                // Get organization detail
                OrganizationInfoContract result = apiInstance.GetOrganization(orgId, view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgId** | **string**| Organization id for which details are requested. | 
 **view** | **string**| Indicates the level of details required in response. Acceptable values are summary, entity or hierarchy. summary by default. | [optional] 

### Return type

[**OrganizationInfoContract**](OrganizationInfoContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationchildren"></a>
# **GetOrganizationChildren**
> List<EntityRefContract> GetOrganizationChildren (string orgId, string recursive = null, string type = null, string start = null, string limit = null)

Returnes entity reference for child organizations and users

Returns the entity references of child organizations and users. it supports the pagination using query parameters start and limit. Case is ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetOrganizationChildrenExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi();
            var orgId = orgId_example;  // string | Organization id for which details are requested.
            var recursive = recursive_example;  // string | Accepted values - True or False, false by default. If this is passed as true, response includes all the below child organizations and their users till end of tree. If not, only immediate child organization and users of organization for which details are requested, will be included in response. (optional) 
            var type = type_example;  // string | Accepted values - Organization or User. By default, both organizations and users will included in response. User can request only organizations using type = organization and users using type = user. (optional) 
            var start = start_example;  // string | Starting record number in pagination. (optional) 
            var limit = limit_example;  // string | Number of records in result. (optional) 

            try
            {
                // Returnes entity reference for child organizations and users
                List&lt;EntityRefContract&gt; result = apiInstance.GetOrganizationChildren(orgId, recursive, type, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationChildren: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgId** | **string**| Organization id for which details are requested. | 
 **recursive** | **string**| Accepted values - True or False, false by default. If this is passed as true, response includes all the below child organizations and their users till end of tree. If not, only immediate child organization and users of organization for which details are requested, will be included in response. | [optional] 
 **type** | **string**| Accepted values - Organization or User. By default, both organizations and users will included in response. User can request only organizations using type &#x3D; organization and users using type &#x3D; user. | [optional] 
 **start** | **string**| Starting record number in pagination. | [optional] 
 **limit** | **string**| Number of records in result. | [optional] 

### Return type

[**List<EntityRefContract>**](EntityRefContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizations"></a>
# **GetOrganizations**
> List<OrganizationInfoContract> GetOrganizations (string view = null, string parentId = null, string start = null, string limit = null)

Get list of organizations

Returns information for all organizations. it supports the pagination using query parameters start and limit. ParentId can be used to filter the result. It supports three types of view. By default 'Summary' will be returns. in 'Summary' view, response will have basic organization details along with parent organization reference. when view is 'Entity', response will have complete organization details. When view is 'Hierarchy', organization children like like child organizations and associated users will be included in response. Case is ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetOrganizationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi();
            var view = view_example;  // string | By default summary view will be returned. It also supports 'Entity' and 'Hierarchy'. 'Summary' view returns basic information along with parent organization reference. 'Entity' view will return complete details of organization. 'Hierarchy' view will return the id, description and children of organization including users. (optional) 
            var parentId = parentId_example;  // string | Result will be filtered based on parent id. It will return organizations with matching parent id. (optional) 
            var start = start_example;  // string | Starting record number in pagination. Default is 1 (optional) 
            var limit = limit_example;  // string | Number of records in result. (optional) 

            try
            {
                // Get list of organizations
                List&lt;OrganizationInfoContract&gt; result = apiInstance.GetOrganizations(view, parentId, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **view** | **string**| By default summary view will be returned. It also supports &#39;Entity&#39; and &#39;Hierarchy&#39;. &#39;Summary&#39; view returns basic information along with parent organization reference. &#39;Entity&#39; view will return complete details of organization. &#39;Hierarchy&#39; view will return the id, description and children of organization including users. | [optional] 
 **parentId** | **string**| Result will be filtered based on parent id. It will return organizations with matching parent id. | [optional] 
 **start** | **string**| Starting record number in pagination. Default is 1 | [optional] 
 **limit** | **string**| Number of records in result. | [optional] 

### Return type

[**List<OrganizationInfoContract>**](OrganizationInfoContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrootorganization"></a>
# **GetRootOrganization**
> OrganizationInfoContract GetRootOrganization (string view = null)

Get root organization detail

Returns the root organization details. It supports three types of view. By default 'Summary' will be returns. in 'Summary' view, response will have basic organization details along with parent organization reference. when view is 'Entity', response will have complete organization details. When view is 'Hierarchy', organization children like like child organizations and associated users will be included in response. Case is ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Example
{
    public class GetRootOrganizationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi();
            var view = view_example;  // string | Indicates the level of details required in response. Acceptable values are summary, entity or hierarchy. summary by default. (optional) 

            try
            {
                // Get root organization detail
                OrganizationInfoContract result = apiInstance.GetRootOrganization(view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetRootOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **view** | **string**| Indicates the level of details required in response. Acceptable values are summary, entity or hierarchy. summary by default. | [optional] 

### Return type

[**OrganizationInfoContract**](OrganizationInfoContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

