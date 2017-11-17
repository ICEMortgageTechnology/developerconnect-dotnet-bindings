# Elli.Api.Services.Api.ServiceApi

All URIs are relative to *http://api.ellielabs.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrderStatus**](ServiceApi.md#getorderstatus) | **GET** /services/v1/partners/{partnerId}/transactions/{transactionId} | Get a credit transaction&#39;s status.
[**OrderService**](ServiceApi.md#orderservice) | **POST** /services/v1/partners/{partnerId}/transactions | Order Service.


<a name="getorderstatus"></a>
# **GetOrderStatus**
> Response GetOrderStatus (int? partnerId, string transactionId)

Get a credit transaction's status.

Retrieves details on a service order transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Services.Api;
using Elli.Api.Services.Client;
using Elli.Api.Services.Model;

namespace Example
{
    public class GetOrderStatusExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceApi();
            var partnerId = 56;  // int? | Ellie Mae's Partner ID for the service provider. Partner IDs are listed on the Credit Partners and Samples page.
            var transactionId = transactionId_example;  // string | The unique identifier of the transaction provided in the response header when the order was submitted.

            try
            {
                // Get a credit transaction's status.
                Response result = apiInstance.GetOrderStatus(partnerId, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.GetOrderStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **partnerId** | **int?**| Ellie Mae&#39;s Partner ID for the service provider. Partner IDs are listed on the Credit Partners and Samples page. | 
 **transactionId** | **string**| The unique identifier of the transaction provided in the response header when the order was submitted. | 

### Return type

[**Response**](Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderservice"></a>
# **OrderService**
> Response OrderService (int? partnerId, OrderServiceRequest product)

Order Service.

Submits an order for a service and creates a transaction object. The response header includes the transactionId that is used to retrieve the results from the service provider.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Services.Api;
using Elli.Api.Services.Client;
using Elli.Api.Services.Model;

namespace Example
{
    public class OrderServiceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceApi();
            var partnerId = 56;  // int? | Ellie Mae's Partner ID for the service provider. Partner IDs are listed on the Credit Partners and Samples page.
            var product = new OrderServiceRequest(); // OrderServiceRequest | The product data elements. Product attributes are listed on the Credit Partners and Samples page.

            try
            {
                // Order Service.
                Response result = apiInstance.OrderService(partnerId, product);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceApi.OrderService: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **partnerId** | **int?**| Ellie Mae&#39;s Partner ID for the service provider. Partner IDs are listed on the Credit Partners and Samples page. | 
 **product** | [**OrderServiceRequest**](OrderServiceRequest.md)| The product data elements. Product attributes are listed on the Credit Partners and Samples page. | 

### Return type

[**Response**](Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

