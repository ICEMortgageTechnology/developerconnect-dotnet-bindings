# Elli.Api.Loans.Api.DisclosureTracking2015Api

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllLoanDisclosureTracking2015Logs**](DisclosureTracking2015Api.md#getallloandisclosuretracking2015logs) | **GET** /encompass/v1/loans/{loanId}/disclosureTracking2015 | Get All Disclosure Tracking2015 Logs.
[**GetLoanDisclosureTracking2015Log**](DisclosureTracking2015Api.md#getloandisclosuretracking2015log) | **GET** /encompass/v1/loans/{loanId}/disclosureTracking2015/{logId} | Get Loan Disclosure Tracking2015 Log.
[**GetLoanDisclosureTracking2015Snapshot**](DisclosureTracking2015Api.md#getloandisclosuretracking2015snapshot) | **GET** /encompass/v1/loans/{loanId}/disclosureTracking2015/{logId}/snapshot | Get Loan Disclosure Tracking2015 Snapshot.


<a name="getallloandisclosuretracking2015logs"></a>
# **GetAllLoanDisclosureTracking2015Logs**
> List<DisclosureTracking2015Contract> GetAllLoanDisclosureTracking2015Logs (string loanId)

Get All Disclosure Tracking2015 Logs.

Retrieves all disclosure tracking record for a specified loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetAllLoanDisclosureTracking2015LogsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisclosureTracking2015Api();
            var loanId = loanId_example;  // string | Unique identifier of Loan.

            try
            {
                // Get All Disclosure Tracking2015 Logs.
                List&lt;DisclosureTracking2015Contract&gt; result = apiInstance.GetAllLoanDisclosureTracking2015Logs(loanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisclosureTracking2015Api.GetAllLoanDisclosureTracking2015Logs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Unique identifier of Loan. | 

### Return type

[**List<DisclosureTracking2015Contract>**](DisclosureTracking2015Contract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloandisclosuretracking2015log"></a>
# **GetLoanDisclosureTracking2015Log**
> DisclosureTracking2015Contract GetLoanDisclosureTracking2015Log (string loanId, string logId)

Get Loan Disclosure Tracking2015 Log.

Retrieves a specific disclosure tracking record for a specified loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetLoanDisclosureTracking2015LogExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisclosureTracking2015Api();
            var loanId = loanId_example;  // string | Unique identifier of Loan.
            var logId = logId_example;  // string | Unique identifier of DisclosureTracking2015 record.

            try
            {
                // Get Loan Disclosure Tracking2015 Log.
                DisclosureTracking2015Contract result = apiInstance.GetLoanDisclosureTracking2015Log(loanId, logId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisclosureTracking2015Api.GetLoanDisclosureTracking2015Log: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Unique identifier of Loan. | 
 **logId** | **string**| Unique identifier of DisclosureTracking2015 record. | 

### Return type

[**DisclosureTracking2015Contract**](DisclosureTracking2015Contract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloandisclosuretracking2015snapshot"></a>
# **GetLoanDisclosureTracking2015Snapshot**
> Dictionary<string, string> GetLoanDisclosureTracking2015Snapshot (string loanId, string logId, string type = null)

Get Loan Disclosure Tracking2015 Snapshot.

Retrieves snapshot for a specific disclosure tracking record for a specified loan.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetLoanDisclosureTracking2015SnapshotExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisclosureTracking2015Api();
            var loanId = loanId_example;  // string | Unique identifier of Loan.
            var logId = logId_example;  // string | Unique identifier of DisclosureTracking2015 record.
            var type = type_example;  // string | Filter for snapshot type. Possible values - LE, CD, SSPL, SafeHarbor, Itemization. If not passed, no filter is applied. (optional) 

            try
            {
                // Get Loan Disclosure Tracking2015 Snapshot.
                Dictionary&lt;string, string&gt; result = apiInstance.GetLoanDisclosureTracking2015Snapshot(loanId, logId, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisclosureTracking2015Api.GetLoanDisclosureTracking2015Snapshot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Unique identifier of Loan. | 
 **logId** | **string**| Unique identifier of DisclosureTracking2015 record. | 
 **type** | **string**| Filter for snapshot type. Possible values - LE, CD, SSPL, SafeHarbor, Itemization. If not passed, no filter is applied. | [optional] 

### Return type

**Dictionary<string, string>**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

