# Elli.Api.OAuth.Api.RevocationApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RevokeToken**](RevocationApi.md#revoketoken) | **POST** /oauth2/v1/token/revocation | 


<a name="revoketoken"></a>
# **RevokeToken**
> Object RevokeToken (string token)



### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.OAuth.Api;
using Elli.Api.OAuth.Client;
using Elli.Api.OAuth.Model;

namespace Example
{
    public class RevokeTokenExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: ClientCredential
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RevocationApi();
            var token = token_example;  // string | A valid OAuth token

            try
            {
                Object result = apiInstance.RevokeToken(token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RevocationApi.RevokeToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| A valid OAuth token | 

### Return type

**Object**

### Authorization

[ClientCredential](../README.md#ClientCredential)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

