# Elli.Api.Loans.Api.AusTrackingLogApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAusTrackingLog**](AusTrackingLogApi.md#createaustrackinglog) | **POST** /encompass/v1/loans/{loanId}/ausTrackingLogs | Create AUS Tracking Log
[**GetAusTrackingLog**](AusTrackingLogApi.md#getaustrackinglog) | **GET** /encompass/v1/loans/{loanId}/ausTrackingLogs/{logId} | Retrieve AUS Tracking Log
[**GetAusTrackingLogSnapshot**](AusTrackingLogApi.md#getaustrackinglogsnapshot) | **GET** /encompass/v1/loans/{loanId}/ausTrackingLogs/{logId}/snapshot | Retrieve AUS Tracking Log Snapshot
[**GetAusTrackingLogs**](AusTrackingLogApi.md#getaustrackinglogs) | **GET** /encompass/v1/loans/{loanId}/ausTrackingLogs | Retrieve AUS Tracking Logs
[**UpdateAusTrackingLog**](AusTrackingLogApi.md#updateaustrackinglog) | **PATCH** /encompass/v1/loans/{loanId}/ausTrackingLogs/{logId} | Update AUS Tracking Log


<a name="createaustrackinglog"></a>
# **CreateAusTrackingLog**
> Object CreateAusTrackingLog (string loanId, AusTrackingLogContract ausTrackingLog, string view = null)

Create AUS Tracking Log

Create AUS Tracking Log record for a Loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class CreateAusTrackingLogExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AusTrackingLogApi();
            var loanId = loanId_example;  // string | Unique Identifier of a loan
            var ausTrackingLog = new AusTrackingLogContract(); // AusTrackingLogContract | AusTrackingLog
            var view = view_example;  // string | Possible values are: entity - Returns all properties for the loan. id - Returns the ID assigned to the loan. (optional) 

            try
            {
                // Create AUS Tracking Log
                Object result = apiInstance.CreateAusTrackingLog(loanId, ausTrackingLog, view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AusTrackingLogApi.CreateAusTrackingLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Unique Identifier of a loan | 
 **ausTrackingLog** | [**AusTrackingLogContract**](AusTrackingLogContract.md)| AusTrackingLog | 
 **view** | **string**| Possible values are: entity - Returns all properties for the loan. id - Returns the ID assigned to the loan. | [optional] 

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaustrackinglog"></a>
# **GetAusTrackingLog**
> AusTrackingLogContract GetAusTrackingLog (string loanId, string logId)

Retrieve AUS Tracking Log

Retrieve a specific AUS Tracking Log for a Loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetAusTrackingLogExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AusTrackingLogApi();
            var loanId = loanId_example;  // string | Unique Identifier of a loan
            var logId = logId_example;  // string | Unique Identifier of Aus Tracking Log

            try
            {
                // Retrieve AUS Tracking Log
                AusTrackingLogContract result = apiInstance.GetAusTrackingLog(loanId, logId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AusTrackingLogApi.GetAusTrackingLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Unique Identifier of a loan | 
 **logId** | **string**| Unique Identifier of Aus Tracking Log | 

### Return type

[**AusTrackingLogContract**](AusTrackingLogContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaustrackinglogsnapshot"></a>
# **GetAusTrackingLogSnapshot**
> Dictionary<string, string> GetAusTrackingLogSnapshot (string loanId, string logId)

Retrieve AUS Tracking Log Snapshot

Retrieve AUS Tracking Log Snapshot for an AUS tracking log within a Loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetAusTrackingLogSnapshotExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AusTrackingLogApi();
            var loanId = loanId_example;  // string | Unique Identifier of a loan
            var logId = logId_example;  // string | Unique Identifier of Aus Tracking Log

            try
            {
                // Retrieve AUS Tracking Log Snapshot
                Dictionary&lt;string, string&gt; result = apiInstance.GetAusTrackingLogSnapshot(loanId, logId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AusTrackingLogApi.GetAusTrackingLogSnapshot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Unique Identifier of a loan | 
 **logId** | **string**| Unique Identifier of Aus Tracking Log | 

### Return type

**Dictionary<string, string>**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaustrackinglogs"></a>
# **GetAusTrackingLogs**
> List<AusTrackingLogContract> GetAusTrackingLogs (string loanId)

Retrieve AUS Tracking Logs

Retrieve all AUS Tracking Logs for a Loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class GetAusTrackingLogsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AusTrackingLogApi();
            var loanId = loanId_example;  // string | Unique Identifier of a loan

            try
            {
                // Retrieve AUS Tracking Logs
                List&lt;AusTrackingLogContract&gt; result = apiInstance.GetAusTrackingLogs(loanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AusTrackingLogApi.GetAusTrackingLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Unique Identifier of a loan | 

### Return type

[**List<AusTrackingLogContract>**](AusTrackingLogContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaustrackinglog"></a>
# **UpdateAusTrackingLog**
> Object UpdateAusTrackingLog (string loanId, string logId, AusTrackingLogContract ausTrackingLog, string view = null)

Update AUS Tracking Log

Update a specific AUS Tracking Log for a Loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;

namespace Example
{
    public class UpdateAusTrackingLogExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AusTrackingLogApi();
            var loanId = loanId_example;  // string | Unique Identifier of a loan
            var logId = logId_example;  // string | Unique Identifier of Aus Tracking Log
            var ausTrackingLog = new AusTrackingLogContract(); // AusTrackingLogContract | AusTrackingLog
            var view = view_example;  // string | Possible values are: entity - Returns all properties for the loan. id - Returns the ID assigned to the loan. (optional) 

            try
            {
                // Update AUS Tracking Log
                Object result = apiInstance.UpdateAusTrackingLog(loanId, logId, ausTrackingLog, view);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AusTrackingLogApi.UpdateAusTrackingLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Unique Identifier of a loan | 
 **logId** | **string**| Unique Identifier of Aus Tracking Log | 
 **ausTrackingLog** | [**AusTrackingLogContract**](AusTrackingLogContract.md)| AusTrackingLog | 
 **view** | **string**| Possible values are: entity - Returns all properties for the loan. id - Returns the ID assigned to the loan. | [optional] 

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

