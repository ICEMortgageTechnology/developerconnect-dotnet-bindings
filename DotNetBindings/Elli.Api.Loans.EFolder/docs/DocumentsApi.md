# Elli.Api.Loans.EFolder.Api.DocumentsApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDocument**](DocumentsApi.md#createdocument) | **POST** /encompass/v1/loans/{loanId}/documents/ | 
[**GetDocument**](DocumentsApi.md#getdocument) | **GET** /encompass/v1/loans/{loanId}/documents/{documentId} | 
[**GetDocuments**](DocumentsApi.md#getdocuments) | **GET** /encompass/v1/loans/{loanId}/documents | 
[**RetrieveDocAttachments**](DocumentsApi.md#retrievedocattachments) | **GET** /encompass/v1/loans/{loanId}/documents/{documentId}/attachments | 
[**UpdateDocAttachments**](DocumentsApi.md#updatedocattachments) | **PATCH** /encompass/v1/loans/{loanId}/documents/{documentId}/attachments | 
[**UpdateDocument**](DocumentsApi.md#updatedocument) | **PATCH** /encompass/v1/loans/{loanId}/documents/{documentId} | 


<a name="createdocument"></a>
# **CreateDocument**
> void CreateDocument (string loanId, string view = null, EFolderDocumentContract input = null)



Create a new document

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class CreateDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentsApi();
            var loanId = loanId_example;  // string | Loan GUID
            var view = view_example;  // string |  (optional) 
            var input = new EFolderDocumentContract(); // EFolderDocumentContract |  (optional) 

            try
            {
                apiInstance.CreateDocument(loanId, view, input);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.CreateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Loan GUID | 
 **view** | **string**|  | [optional] 
 **input** | [**EFolderDocumentContract**](EFolderDocumentContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> void GetDocument (string documentId, string loanId)



Retrieves a document by its ID

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class GetDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document GUID
            var loanId = loanId_example;  // string | Loan GUID

            try
            {
                apiInstance.GetDocument(documentId, loanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string**| Document GUID | 
 **loanId** | **string**| Loan GUID | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocuments"></a>
# **GetDocuments**
> void GetDocuments (string loanId)



Retrieves all documents for a loan

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class GetDocumentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentsApi();
            var loanId = loanId_example;  // string | Loan GUID

            try
            {
                apiInstance.GetDocuments(loanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Loan GUID | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievedocattachments"></a>
# **RetrieveDocAttachments**
> void RetrieveDocAttachments (string documentId, string loanId)



Retrieves all attachments of a loan within a specific document

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class RetrieveDocAttachmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document GUID
            var loanId = loanId_example;  // string | Loan GUID

            try
            {
                apiInstance.RetrieveDocAttachments(documentId, loanId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.RetrieveDocAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string**| Document GUID | 
 **loanId** | **string**| Loan GUID | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocattachments"></a>
# **UpdateDocAttachments**
> void UpdateDocAttachments (string documentId, string loanId, List<EFolderAttachmentContract> input = null)



Update an attachment of a loan within a document

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class UpdateDocAttachmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document GUID
            var loanId = loanId_example;  // string | Loan GUID
            var input = new List<EFolderAttachmentContract>(); // List<EFolderAttachmentContract> |  (optional) 

            try
            {
                apiInstance.UpdateDocAttachments(documentId, loanId, input);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.UpdateDocAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string**| Document GUID | 
 **loanId** | **string**| Loan GUID | 
 **input** | [**List&lt;EFolderAttachmentContract&gt;**](EFolderAttachmentContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocument"></a>
# **UpdateDocument**
> void UpdateDocument (string documentId, string loanId, string view = null, EFolderDocumentContract input = null)



Update a document by its ID

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class UpdateDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentsApi();
            var documentId = documentId_example;  // string | Document GUID
            var loanId = loanId_example;  // string | Loan GUID
            var view = view_example;  // string |  (optional) 
            var input = new EFolderDocumentContract(); // EFolderDocumentContract |  (optional) 

            try
            {
                apiInstance.UpdateDocument(documentId, loanId, view, input);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.UpdateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string**| Document GUID | 
 **loanId** | **string**| Loan GUID | 
 **view** | **string**|  | [optional] 
 **input** | [**EFolderDocumentContract**](EFolderDocumentContract.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

