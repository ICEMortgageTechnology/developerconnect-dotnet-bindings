# Elli.Api.Contacts.Api.BorrowerFieldDefinitionsApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBorrowerContactFieldDefinitions**](BorrowerFieldDefinitionsApi.md#getborrowercontactfielddefinitions) | **GET** /encompass/v1/settings/borrowerContacts/fieldDefinitions | Retrieve canonical names


<a name="getborrowercontactfielddefinitions"></a>
# **GetBorrowerContactFieldDefinitions**
> List<BorrowerFieldDefinitionContract> GetBorrowerContactFieldDefinitions ()

Retrieve canonical names

Retrieves a list of Canonical names of BorrowerContacts

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class GetBorrowerContactFieldDefinitionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerFieldDefinitionsApi();

            try
            {
                // Retrieve canonical names
                List&lt;BorrowerFieldDefinitionContract&gt; result = apiInstance.GetBorrowerContactFieldDefinitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerFieldDefinitionsApi.GetBorrowerContactFieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BorrowerFieldDefinitionContract>**](BorrowerFieldDefinitionContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

