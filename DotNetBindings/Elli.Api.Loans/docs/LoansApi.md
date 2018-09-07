# Elli.Api.Loans.Api.LoansApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLoan**](LoansApi.md#createloan) | **POST** /encompass/v1/loans | Creates a new loan.
[**DeleteLoan**](LoansApi.md#deleteloan) | **DELETE** /encompass/v1/loans/{loanId} | 
[**GetLoan**](LoansApi.md#getloan) | **GET** /encompass/v1/loans/{loanId} | 
[**GetLoanMetaData**](LoansApi.md#getloanmetadata) | **GET** /encompass/v1/loans/{loanId}/metadata | Get Loan Metadata.
[**UpdateLoan**](LoansApi.md#updateloan) | **PATCH** /encompass/v1/loans/{loanId} | Updates an existing loan.


<a name="createloan"></a>
# **CreateLoan**
> Object CreateLoan (string loanFolder = null, string templatePath = null, string persistent = null, string view = null, LoanContract loanContract = null)

Creates a new loan.

This endpoint creates a loan with options to create in specific folder, if user has permissions and also apply template to the loan. Loan can be viewed in Transient mode as well before creation.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class CreateLoanExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoansApi();
            var loanFolder = loanFolder_example;  // string | Name of the Loan Folder where this loan will be created. Default - User's default folder (optional) 
            var templatePath = templatePath_example;  // string | Loan template that will be used during this Loan creation (optional) 
            var persistent = persistent_example;  // string | Provides an option to create loan in Transient or Permanent mode (optional) 
            var view = view_example;  // string | Possible values are: entity - Returns all properties for the loan. id - Returns the ID assigned to the loan. (optional) 
            var loanContract = new LoanContract(); // LoanContract |  (optional) 

            try
            {
                // Creates a new loan.
                Object result = apiInstance.CreateLoan(loanFolder, templatePath, persistent, view, loanContract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoansApi.CreateLoan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanFolder** | **string**| Name of the Loan Folder where this loan will be created. Default - User&#39;s default folder | [optional] 
 **templatePath** | **string**| Loan template that will be used during this Loan creation | [optional] 
 **persistent** | **string**| Provides an option to create loan in Transient or Permanent mode | [optional] 
 **view** | **string**| Possible values are: entity - Returns all properties for the loan. id - Returns the ID assigned to the loan. | [optional] 
 **loanContract** | [**LoanContract**](LoanContract.md)|  | [optional] 

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteloan"></a>
# **DeleteLoan**
> void DeleteLoan (string loanId)



### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class DeleteLoanExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoansApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to the loan.

            try
            {
                apiInstance.DeleteLoan(loanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoansApi.DeleteLoan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to the loan. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloan"></a>
# **GetLoan**
> LoanContract GetLoan (string loanId, string entities = null, string format = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetLoanExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoansApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to the loan.
            var entities = entities_example;  // string | Comma-separated list of loan entities to retrieve from the loan. Use GET /loans/supportedEntities to view all supported entities. (optional) 
            var format = format_example;  // string |  (optional) 

            try
            {
                LoanContract result = apiInstance.GetLoan(loanId, entities, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoansApi.GetLoan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to the loan. | 
 **entities** | **string**| Comma-separated list of loan entities to retrieve from the loan. Use GET /loans/supportedEntities to view all supported entities. | [optional] 
 **format** | **string**|  | [optional] 

### Return type

[**LoanContract**](LoanContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloanmetadata"></a>
# **GetLoanMetaData**
> LoanMetadataContract GetLoanMetaData (string loanId)

Get Loan Metadata.

Retrieves the metadata for a specified loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetLoanMetaDataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoansApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to the loan.

            try
            {
                // Get Loan Metadata.
                LoanMetadataContract result = apiInstance.GetLoanMetaData(loanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoansApi.GetLoanMetaData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to the loan. | 

### Return type

[**LoanMetadataContract**](LoanMetadataContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateloan"></a>
# **UpdateLoan**
> Object UpdateLoan (string loanId, string templatePath = null, string persistent = null, string appendData = null, LoanContract loanContract = null, string view = null)

Updates an existing loan.

This endpoint updates an existing loan with options to apply template and append data feature. Loan can be viewed in Transient mode as well.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class UpdateLoanExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoansApi();
            var loanId = loanId_example;  // string | The unique identifier assigned to the loan.
            var templatePath = templatePath_example;  // string | Loan template that will be used during this Loan creation (optional) 
            var persistent = persistent_example;  // string | Provides an option to create loan in Transient or Permanent mode (optional) 
            var appendData = appendData_example;  // string | If true, only non-blank field values in the template are written to the loan. If false, all field values in the template (including blanks) are written to the loan. (optional) 
            var loanContract = new LoanContract(); // LoanContract |  (optional) 
            var view = view_example;  // string | Possible values are: entity - Returns all properties for the loan. id - Returns the ID assigned to the loan. (optional) 

            try
            {
                // Updates an existing loan.
                Object result = apiInstance.UpdateLoan(loanId, templatePath, persistent, appendData, loanContract, view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoansApi.UpdateLoan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| The unique identifier assigned to the loan. | 
 **templatePath** | **string**| Loan template that will be used during this Loan creation | [optional] 
 **persistent** | **string**| Provides an option to create loan in Transient or Permanent mode | [optional] 
 **appendData** | **string**| If true, only non-blank field values in the template are written to the loan. If false, all field values in the template (including blanks) are written to the loan. | [optional] 
 **loanContract** | [**LoanContract**](LoanContract.md)|  | [optional] 
 **view** | **string**| Possible values are: entity - Returns all properties for the loan. id - Returns the ID assigned to the loan. | [optional] 

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

