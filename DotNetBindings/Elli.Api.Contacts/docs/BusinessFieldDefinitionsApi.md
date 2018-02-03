# Elli.Api.Contacts.Api.BusinessFieldDefinitionsApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBusinessContactFieldDefinitions**](BusinessFieldDefinitionsApi.md#getbusinesscontactfielddefinitions) | **GET** /encompass/v1/settings/businessContacts/fieldDefinitions | Retrieve canonical names


<a name="getbusinesscontactfielddefinitions"></a>
# **GetBusinessContactFieldDefinitions**
> List<BusinessFieldDefinitionContract> GetBusinessContactFieldDefinitions ()

Retrieve canonical names

Retrieves a list of Canonical names of BusinessContacts

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class GetBusinessContactFieldDefinitionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessFieldDefinitionsApi();

            try
            {
                // Retrieve canonical names
                List&lt;BusinessFieldDefinitionContract&gt; result = apiInstance.GetBusinessContactFieldDefinitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessFieldDefinitionsApi.GetBusinessContactFieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BusinessFieldDefinitionContract>**](BusinessFieldDefinitionContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

