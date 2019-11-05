# Elli.Api.OAuth.Api.TokenApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateToken**](TokenApi.md#generatetoken) | **POST** /oauth2/v1/token | 


<a name="generatetoken"></a>
# **GenerateToken**
> TokenIssuance GenerateToken (string grantType, string username = null, string password = null, string scope = null, string redirectUri = null, string code = null, string session = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.OAuth.Api;
using Elli.Api.OAuth.Client;
using Elli.Api.OAuth.Model;

namespace Example
{
    public class GenerateTokenExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: ClientCredential
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TokenApi();
            var grantType = grantType_example;  // string | password, authorization_code, client_credentials, urn:elli:params:oauth:grant-type:encompass-bearer
            var username = username_example;  // string | For password grant (optional) 
            var password = password_example;  // string | For password grant (optional) 
            var scope = scope_example;  // string | A valid scope (optional) 
            var redirectUri = redirectUri_example;  // string | For auth code grant (optional) 
            var code = code_example;  // string | For auth code grant (optional) 
            var session = session_example;  // string | For grant_type = urn:elli:params:oauth:grant-type:encompass-bearer (optional) 

            try
            {
                TokenIssuance result = apiInstance.GenerateToken(grantType, username, password, scope, redirectUri, code, session);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TokenApi.GenerateToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grantType** | **string**| password, authorization_code, client_credentials, urn:elli:params:oauth:grant-type:encompass-bearer | 
 **username** | **string**| For password grant | [optional] 
 **password** | **string**| For password grant | [optional] 
 **scope** | **string**| A valid scope | [optional] 
 **redirectUri** | **string**| For auth code grant | [optional] 
 **code** | **string**| For auth code grant | [optional] 
 **session** | **string**| For grant_type &#x3D; urn:elli:params:oauth:grant-type:encompass-bearer | [optional] 

### Return type

[**TokenIssuance**](TokenIssuance.md)

### Authorization

[ClientCredential](../README.md#ClientCredential)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

