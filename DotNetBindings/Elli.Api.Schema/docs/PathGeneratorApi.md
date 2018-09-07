# Elli.Api.Schema.Api.PathGeneratorApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWebhookNotificationPath**](PathGeneratorApi.md#getwebhooknotificationpath) | **POST** /encompass/v1/schema/loan/pathGenerator | Get Json path.


<a name="getwebhooknotificationpath"></a>
# **GetWebhookNotificationPath**
> Dictionary<string, string> GetWebhookNotificationPath (PathGeneratorContract request, string ignoreInvalidFields = null, string fieldNamePattern = null)

Get Json path.

Get Json path for loan fields.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Schema.Api;
using Elli.Api.Schema.Client;
using Elli.Api.Schema.Model;

namespace Example
{
    public class GetWebhookNotificationPathExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PathGeneratorApi();
            var request = new PathGeneratorContract(); // PathGeneratorContract | List of loan fields.
            var ignoreInvalidFields = ignoreInvalidFields_example;  // string | Flag to ignore invalid loan fields. False by default. (optional) 
            var fieldNamePattern = fieldNamePattern_example;  // string | Pattern to search matching json paths. (optional) 

            try
            {
                // Get Json path.
                Dictionary&lt;string, string&gt; result = apiInstance.GetWebhookNotificationPath(request, ignoreInvalidFields, fieldNamePattern);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PathGeneratorApi.GetWebhookNotificationPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PathGeneratorContract**](PathGeneratorContract.md)| List of loan fields. | 
 **ignoreInvalidFields** | **string**| Flag to ignore invalid loan fields. False by default. | [optional] 
 **fieldNamePattern** | **string**| Pattern to search matching json paths. | [optional] 

### Return type

**Dictionary<string, string>**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

