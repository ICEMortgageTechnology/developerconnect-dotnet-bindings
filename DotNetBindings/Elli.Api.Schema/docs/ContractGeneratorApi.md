# Elli.Api.Schema.Api.ContractGeneratorApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateLoanContract**](ContractGeneratorApi.md#generateloancontract) | **POST** /encompass/v1/schema/loan/contractGenerator | Generate Loan Contract.


<a name="generateloancontract"></a>
# **GenerateLoanContract**
> LoanContract GenerateLoanContract (Object request, string ignoreInvalidFields = null)

Generate Loan Contract.

Generate loan contract for specific loan fields which can be used to Create/Update Loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Schema.Api;
using Elli.Api.Schema.Client;
using Elli.Api.Schema.Model;

namespace Example
{
    public class GenerateLoanContractExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractGeneratorApi();
            var request = ;  // Object | Key value pair of loan field name and value.
            var ignoreInvalidFields = ignoreInvalidFields_example;  // string | Flag to ignore invalid loan fields. False by default. (optional) 

            try
            {
                // Generate Loan Contract.
                LoanContract result = apiInstance.GenerateLoanContract(request, ignoreInvalidFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractGeneratorApi.GenerateLoanContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | **Object**| Key value pair of loan field name and value. | 
 **ignoreInvalidFields** | **string**| Flag to ignore invalid loan fields. False by default. | [optional] 

### Return type

[**LoanContract**](LoanContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

