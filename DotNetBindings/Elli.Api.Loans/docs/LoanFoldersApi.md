# Elli.Api.Loans.Api.LoanFoldersApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MoveLoanFolder**](LoanFoldersApi.md#moveloanfolder) | **PATCH** /encompass/v1/loanfolders/{folderName}/loans | Move loan folder


<a name="moveloanfolder"></a>
# **MoveLoanFolder**
> void MoveLoanFolder (string folderName, LoanFolderContract loanFolder = null)

Move loan folder

Move loan file from one folder to other folder

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class MoveLoanFolderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanFoldersApi();
            var folderName = folderName_example;  // string | Target foldername where loan file need to move
            var loanFolder = new LoanFolderContract(); // LoanFolderContract |  (optional) 

            try
            {
                // Move loan folder
                apiInstance.MoveLoanFolder(folderName, loanFolder);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanFoldersApi.MoveLoanFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderName** | **string**| Target foldername where loan file need to move | 
 **loanFolder** | [**LoanFolderContract**](LoanFolderContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

