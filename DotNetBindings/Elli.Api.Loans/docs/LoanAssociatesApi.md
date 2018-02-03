# Elli.Api.Loans.Api.LoanAssociatesApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignLoanTeamMember**](LoanAssociatesApi.md#assignloanteammember) | **PUT** /encompass/v1/loans/{id}/associates/{logId} | Assign loan associate
[**GetAssociate**](LoanAssociatesApi.md#getassociate) | **GET** /encompass/v1/loans/{id}/associates/{logId} | Retrieve a loan associate
[**GetAssociates**](LoanAssociatesApi.md#getassociates) | **GET** /encompass/v1/loans/{id}/associates | Retrieve loan associates
[**UnassignLoanTeamMember**](LoanAssociatesApi.md#unassignloanteammember) | **DELETE** /encompass/v1/loans/{id}/associates/{logId} | Unassign loan associate


<a name="assignloanteammember"></a>
# **AssignLoanTeamMember**
> void AssignLoanTeamMember (string logId, string id, LoanTeamMemberContract loanAssociate = null)

Assign loan associate

Assign a loan associate to a loan based on provided milestone/milestone free role guid and user id.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class AssignLoanTeamMemberExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanAssociatesApi();
            var logId = logId_example;  // string | Milestone/milestone free role id
            var id = id_example;  // string | Loan Id
            var loanAssociate = new LoanTeamMemberContract(); // LoanTeamMemberContract |  (optional) 

            try
            {
                // Assign loan associate
                apiInstance.AssignLoanTeamMember(logId, id, loanAssociate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanAssociatesApi.AssignLoanTeamMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logId** | **string**| Milestone/milestone free role id | 
 **id** | **string**| Loan Id | 
 **loanAssociate** | [**LoanTeamMemberContract**](LoanTeamMemberContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassociate"></a>
# **GetAssociate**
> LoanTeamMemberContract GetAssociate (string logId, string id)

Retrieve a loan associate

Retrieve a loan associate based on milestone/milestone free role guid.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetAssociateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanAssociatesApi();
            var logId = logId_example;  // string | Milestone/milestone free role id
            var id = id_example;  // string | Loan Id

            try
            {
                // Retrieve a loan associate
                LoanTeamMemberContract result = apiInstance.GetAssociate(logId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanAssociatesApi.GetAssociate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logId** | **string**| Milestone/milestone free role id | 
 **id** | **string**| Loan Id | 

### Return type

[**LoanTeamMemberContract**](LoanTeamMemberContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassociates"></a>
# **GetAssociates**
> List<LoanTeamMemberContract> GetAssociates (string id, string userId = null, string roleId = null, string fixedRoleId = null)

Retrieve loan associates

Retrieves a list of loan associates

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetAssociatesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanAssociatesApi();
            var id = id_example;  // string | Loan Id
            var userId = userId_example;  // string | Filter associates list based on user id. (optional) 
            var roleId = roleId_example;  // string | Filter associates list based on role id. (optional) 
            var fixedRoleId = fixedRoleId_example;  // string | Filter associates list based on fixed role id. (optional) 

            try
            {
                // Retrieve loan associates
                List&lt;LoanTeamMemberContract&gt; result = apiInstance.GetAssociates(id, userId, roleId, fixedRoleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanAssociatesApi.GetAssociates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Loan Id | 
 **userId** | **string**| Filter associates list based on user id. | [optional] 
 **roleId** | **string**| Filter associates list based on role id. | [optional] 
 **fixedRoleId** | **string**| Filter associates list based on fixed role id. | [optional] 

### Return type

[**List<LoanTeamMemberContract>**](LoanTeamMemberContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassignloanteammember"></a>
# **UnassignLoanTeamMember**
> void UnassignLoanTeamMember (string logId, string id)

Unassign loan associate

Unassign a loan associate from a loan based on provided milestone/milestone free role guid and user id.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class UnassignLoanTeamMemberExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanAssociatesApi();
            var logId = logId_example;  // string | Milestone/milestone free role id
            var id = id_example;  // string | Loan Id

            try
            {
                // Unassign loan associate
                apiInstance.UnassignLoanTeamMember(logId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanAssociatesApi.UnassignLoanTeamMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logId** | **string**| Milestone/milestone free role id | 
 **id** | **string**| Loan Id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

