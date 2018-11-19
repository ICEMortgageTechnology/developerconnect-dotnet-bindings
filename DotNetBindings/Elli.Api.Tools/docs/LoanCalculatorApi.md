# Elli.Api.Tools.Api.LoanCalculatorApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CalculateLoan**](LoanCalculatorApi.md#calculateloan) | **POST** /encompass/v1/calculators/loan | Get the effect of calculations applied on a loan


<a name="calculateloan"></a>
# **CalculateLoan**
> LoanContract CalculateLoan (LoanCalculationRequest loanCalculationRequest, string calcAllOnly = null)

Get the effect of calculations applied on a loan

Returns the effect of calculations applied on a loan without saving the calculations

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Tools.Api;
using Elli.Api.Tools.Client;
using Elli.Api.Tools.Model;

namespace Example
{
    public class CalculateLoanExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoanCalculatorApi();
            var loanCalculationRequest = new LoanCalculationRequest(); // LoanCalculationRequest | 
            var calcAllOnly = calcAllOnly_example;  // string | Indicates calculations will be executed for all fields (optional) 

            try
            {
                // Get the effect of calculations applied on a loan
                LoanContract result = apiInstance.CalculateLoan(loanCalculationRequest, calcAllOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoanCalculatorApi.CalculateLoan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanCalculationRequest** | [**LoanCalculationRequest**](LoanCalculationRequest.md)|  | 
 **calcAllOnly** | **string**| Indicates calculations will be executed for all fields | [optional] 

### Return type

[**LoanContract**](LoanContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

