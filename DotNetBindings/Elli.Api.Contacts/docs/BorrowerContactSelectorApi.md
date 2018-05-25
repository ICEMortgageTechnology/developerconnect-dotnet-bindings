# Elli.Api.Contacts.Api.BorrowerContactSelectorApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QueryBorrowerContacts**](BorrowerContactSelectorApi.md#queryborrowercontacts) | **POST** /encompass/v1/borrowerContactSelector/ | Retrieve Borrower Contacts


<a name="queryborrowercontacts"></a>
# **QueryBorrowerContacts**
> List<BorrowerContactSelectorContract> QueryBorrowerContacts (string start = null, string limit = null, string cursorType = null, string cursor = null, BorrowerContactQueryContract request = null)

Retrieve Borrower Contacts

Retrieve and paginate through borrower contacts

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class QueryBorrowerContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerContactSelectorApi();
            var start = start_example;  // string | Start index or record number to retrieve a set of borrower contacts. (optional) 
            var limit = limit_example;  // string | This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional) 
            var cursorType = cursorType_example;  // string | This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. (optional) 
            var cursor = cursor_example;  // string | Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. (optional) 
            var request = new BorrowerContactQueryContract(); // BorrowerContactQueryContract | Borrower contact query object (optional) 

            try
            {
                // Retrieve Borrower Contacts
                List&lt;BorrowerContactSelectorContract&gt; result = apiInstance.QueryBorrowerContacts(start, limit, cursorType, cursor, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerContactSelectorApi.QueryBorrowerContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **string**| Start index or record number to retrieve a set of borrower contacts. | [optional] 
 **limit** | **string**| This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. | [optional] 
 **cursorType** | **string**| This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. | [optional] 
 **cursor** | **string**| Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. | [optional] 
 **request** | [**BorrowerContactQueryContract**](BorrowerContactQueryContract.md)| Borrower contact query object | [optional] 

### Return type

[**List<BorrowerContactSelectorContract>**](BorrowerContactSelectorContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

