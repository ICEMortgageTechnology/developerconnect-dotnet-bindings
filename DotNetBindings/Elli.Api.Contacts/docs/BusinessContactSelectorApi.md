# Elli.Api.Contacts.Api.BusinessContactSelectorApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QueryBusinessContacts**](BusinessContactSelectorApi.md#querybusinesscontacts) | **POST** /encompass/v1/businessContactSelector/ | Retrieve Business Contacts


<a name="querybusinesscontacts"></a>
# **QueryBusinessContacts**
> List<BusinessContactSelectorContract> QueryBusinessContacts (string start = null, string limit = null, string cursorType = null, string cursor = null, BusinessContactQueryContract request = null)

Retrieve Business Contacts

Retrieve and paginate through business contacts

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class QueryBusinessContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessContactSelectorApi();
            var start = start_example;  // string | Start index or record number to retrieve a set of borrower contacts. This is defaulted to 1. (optional) 
            var limit = limit_example;  // string | This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. (optional) 
            var cursorType = cursorType_example;  // string | This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. (optional) 
            var cursor = cursor_example;  // string | Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. (optional) 
            var request = new BusinessContactQueryContract(); // BusinessContactQueryContract | Business contact query object (optional) 

            try
            {
                // Retrieve Business Contacts
                List&lt;BusinessContactSelectorContract&gt; result = apiInstance.QueryBusinessContacts(start, limit, cursorType, cursor, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessContactSelectorApi.QueryBusinessContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **string**| Start index or record number to retrieve a set of borrower contacts. This is defaulted to 1. | [optional] 
 **limit** | **string**| This is the maximum number of records user wants to fetch. Response size is limited to 6 MB hence this is recalculated if response size exceeds 6 MB. Default value is 1000 and max value for this parameter is limited to 10000 in any case. | [optional] 
 **cursorType** | **string**| This should be passed when user wants to create a new cursor. Only RandomAccess cursor type is supported. | [optional] 
 **cursor** | **string**| Id of the cursor from which data needs to be retrieved. This is responded in location header while creating a new cursor. | [optional] 
 **request** | [**BusinessContactQueryContract**](BusinessContactQueryContract.md)| Business contact query object | [optional] 

### Return type

[**List<BusinessContactSelectorContract>**](BusinessContactSelectorContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

