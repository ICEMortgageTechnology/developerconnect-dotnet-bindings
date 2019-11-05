# Elli.Api.OAuth.Api.IntrospectionApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Introspect**](IntrospectionApi.md#introspect) | **POST** /oauth2/v1/token/introspection | 


<a name="introspect"></a>
# **Introspect**
> IntrospectionSuccess Introspect (string token)



### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.OAuth.Api;
using Elli.Api.OAuth.Client;
using Elli.Api.OAuth.Model;

namespace Example
{
    public class IntrospectExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: ClientCredential
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new IntrospectionApi();
            var token = token_example;  // string | 

            try
            {
                IntrospectionSuccess result = apiInstance.Introspect(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntrospectionApi.Introspect: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | 

### Return type

[**IntrospectionSuccess**](IntrospectionSuccess.md)

### Authorization

[ClientCredential](../README.md#ClientCredential)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

