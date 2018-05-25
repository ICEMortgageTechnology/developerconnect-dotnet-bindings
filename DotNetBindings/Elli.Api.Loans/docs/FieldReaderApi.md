# Elli.Api.Loans.Api.FieldReaderApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLoanFieldValuesByFieldIds**](FieldReaderApi.md#getloanfieldvaluesbyfieldids) | **POST** /encompass/v1/loans/{loanId}/fieldReader | Retrieve details for specified Loan Field Ids.


<a name="getloanfieldvaluesbyfieldids"></a>
# **GetLoanFieldValuesByFieldIds**
> List<LoanFieldDataContract> GetLoanFieldValuesByFieldIds (string loanId, string includeMetadata = null, LoanFieldIdsContract fieldIds = null)

Retrieve details for specified Loan Field Ids.

Retrieves value, type, description, etc. for the loan field ids in request against the specified loan Id.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetLoanFieldValuesByFieldIdsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FieldReaderApi();
            var loanId = loanId_example;  // string | Loan Id for which user wants to retrieve the value of certain fields.
            var includeMetadata = includeMetadata_example;  // string | Flag to include field metadata or not, with default value as false. (optional) 
            var fieldIds = new LoanFieldIdsContract(); // LoanFieldIdsContract |  (optional) 

            try
            {
                // Retrieve details for specified Loan Field Ids.
                List&lt;LoanFieldDataContract&gt; result = apiInstance.GetLoanFieldValuesByFieldIds(loanId, includeMetadata, fieldIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldReaderApi.GetLoanFieldValuesByFieldIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Loan Id for which user wants to retrieve the value of certain fields. | 
 **includeMetadata** | **string**| Flag to include field metadata or not, with default value as false. | [optional] 
 **fieldIds** | [**LoanFieldIdsContract**](LoanFieldIdsContract.md)|  | [optional] 

### Return type

[**List<LoanFieldDataContract>**](LoanFieldDataContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

