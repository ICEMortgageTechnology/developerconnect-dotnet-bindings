# Elli.Api.Loans.Api.EntityRefContractApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLoanTemplatesSetFolders**](EntityRefContractApi.md#getloantemplatessetfolders) | **GET** /v1/settings/templates/loanTemplateSet/folders/{folderPath} | Returns all folders.


<a name="getloantemplatessetfolders"></a>
# **GetLoanTemplatesSetFolders**
> List<EntityRefContract> GetLoanTemplatesSetFolders (string folderPath)

Returns all folders.

Returns all folders available under the folderPath.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetLoanTemplatesSetFoldersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EntityRefContractApi();
            var folderPath = folderPath_example;  // string | path to fetch the folders. Default parent path starts with public or personal.

            try
            {
                // Returns all folders.
                List&lt;EntityRefContract&gt; result = apiInstance.GetLoanTemplatesSetFolders(folderPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntityRefContractApi.GetLoanTemplatesSetFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderPath** | **string**| path to fetch the folders. Default parent path starts with public or personal. | 

### Return type

[**List<EntityRefContract>**](EntityRefContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

