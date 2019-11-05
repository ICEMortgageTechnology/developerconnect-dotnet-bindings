# Elli.Api.Loans.EFolder.Api.AttachmentsApi

All URIs are relative to *https://api.elliemae.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadAttachment**](AttachmentsApi.md#downloadattachment) | **POST** /encompass/v1/loans/{loanId}/attachments/{attachmentId}/url | 
[**DownloadAttachmentPage**](AttachmentsApi.md#downloadattachmentpage) | **POST** /encompass/v1/loans/{loanId}/attachments/{attachmentId}/pages/{pageId}/url | 
[**DownloadAttachmentThumbnail**](AttachmentsApi.md#downloadattachmentthumbnail) | **POST** /encompass/v1/loans/{loanId}/attachments/{attachmentId}/pages/{pageId}/thumbnail/url | 
[**GetAttachment**](AttachmentsApi.md#getattachment) | **GET** /encompass/v1/loans/{loanId}/attachments/{attachmentId} | 
[**GetAttachments**](AttachmentsApi.md#getattachments) | **GET** /encompass/v1/loans/{loanId}/attachments | 
[**UpdateAttachment**](AttachmentsApi.md#updateattachment) | **PATCH** /encompass/v1/loans/{loanId}/attachments/{attachmentId} | 
[**UploadAttachment**](AttachmentsApi.md#uploadattachment) | **POST** /encompass/v1/loans/{loanId}/attachments/url | 


<a name="downloadattachment"></a>
# **DownloadAttachment**
> EFolderMediaUrlContract DownloadAttachment (string attachmentId, string loanId)



Retrieves the attachment URL for a file in the eFolder. The attachment URL is the full URL where the attachment is located in the eFolder. Getting the attachment URL is the first step in retrieving an attachment from the eFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class DownloadAttachmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi();
            var attachmentId = attachmentId_example;  // string | Attachment GUID
            var loanId = loanId_example;  // string | Loan GUID

            try
            {
                EFolderMediaUrlContract result = apiInstance.DownloadAttachment(attachmentId, loanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.DownloadAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **string**| Attachment GUID | 
 **loanId** | **string**| Loan GUID | 

### Return type

[**EFolderMediaUrlContract**](EFolderMediaUrlContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadattachmentpage"></a>
# **DownloadAttachmentPage**
> EFolderMediaUrlContract DownloadAttachmentPage (string attachmentId, string pageId, string loanId)



Retrieves a URL to get a specific page within an attachment

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class DownloadAttachmentPageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi();
            var attachmentId = attachmentId_example;  // string | Attachment Id
            var pageId = pageId_example;  // string | Page id within the attachment
            var loanId = loanId_example;  // string | Loan GUID

            try
            {
                EFolderMediaUrlContract result = apiInstance.DownloadAttachmentPage(attachmentId, pageId, loanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.DownloadAttachmentPage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **string**| Attachment Id | 
 **pageId** | **string**| Page id within the attachment | 
 **loanId** | **string**| Loan GUID | 

### Return type

[**EFolderMediaUrlContract**](EFolderMediaUrlContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadattachmentthumbnail"></a>
# **DownloadAttachmentThumbnail**
> EFolderMediaUrlContract DownloadAttachmentThumbnail (string attachmentId, string pageId, string loanId)



Retrieves an URL to get the thumbnails for a specified page within an attachment

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class DownloadAttachmentThumbnailExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi();
            var attachmentId = attachmentId_example;  // string | Attachment GUID
            var pageId = pageId_example;  // string | Page Id within the attachment
            var loanId = loanId_example;  // string | Loan GUID

            try
            {
                EFolderMediaUrlContract result = apiInstance.DownloadAttachmentThumbnail(attachmentId, pageId, loanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.DownloadAttachmentThumbnail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **string**| Attachment GUID | 
 **pageId** | **string**| Page Id within the attachment | 
 **loanId** | **string**| Loan GUID | 

### Return type

[**EFolderMediaUrlContract**](EFolderMediaUrlContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachment"></a>
# **GetAttachment**
> EFolderAttachmentContract GetAttachment (string attachmentId, string loanId, bool? includeImageUrls = null, string generateUrl = null)



Retrieves properties for a specified file attachment.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class GetAttachmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi();
            var attachmentId = attachmentId_example;  // string | Attachment ID
            var loanId = loanId_example;  // string | Loan GUID
            var includeImageUrls = true;  // bool? | Include image URLs in response in case attachment type is Image. (optional) 
            var generateUrl = generateUrl_example;  // string | Boolean to specify if media url needs to be generated. (optional) 

            try
            {
                EFolderAttachmentContract result = apiInstance.GetAttachment(attachmentId, loanId, includeImageUrls, generateUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.GetAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **string**| Attachment ID | 
 **loanId** | **string**| Loan GUID | 
 **includeImageUrls** | **bool?**| Include image URLs in response in case attachment type is Image. | [optional] 
 **generateUrl** | **string**| Boolean to specify if media url needs to be generated. | [optional] 

### Return type

[**EFolderAttachmentContract**](EFolderAttachmentContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachments"></a>
# **GetAttachments**
> List<EFolderAttachmentContract> GetAttachments (string loanId)



Retrieves a list of files attached to a specified loan. The response includes all properties for all assigned and unassigned file attachments.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class GetAttachmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi();
            var loanId = loanId_example;  // string | Loan GUID

            try
            {
                List&lt;EFolderAttachmentContract&gt; result = apiInstance.GetAttachments(loanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.GetAttachments: " + e.Message );
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

[**List<EFolderAttachmentContract>**](EFolderAttachmentContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateattachment"></a>
# **UpdateAttachment**
> Object UpdateAttachment (string attachmentId, string loanId, string view = null, EFolderAttachmentContract input = null)



Updates properties for a specified file attachment.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class UpdateAttachmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi();
            var attachmentId = attachmentId_example;  // string | Attachment GUID
            var loanId = loanId_example;  // string | Loan GUID
            var view = view_example;  // string |  (optional) 
            var input = new EFolderAttachmentContract(); // EFolderAttachmentContract |  (optional) 

            try
            {
                Object result = apiInstance.UpdateAttachment(attachmentId, loanId, view, input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.UpdateAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentId** | **string**| Attachment GUID | 
 **loanId** | **string**| Loan GUID | 
 **view** | **string**|  | [optional] 
 **input** | [**EFolderAttachmentContract**](EFolderAttachmentContract.md)|  | [optional] 

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadattachment"></a>
# **UploadAttachment**
> EFolderMediaUrlContract UploadAttachment (string loanId, string view = null, EFolderMediaUrlContract input = null)



Retrieves the URL for uploading an attachment. This URL is time sensitive. It must be invoked as a PUT with the attachment converted to a byteStream within the request body. The attachment ID is returned in location attribute of the PUT call's response header.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Client;
using Elli.Api.Loans.EFolder.Model;

namespace Example
{
    public class UploadAttachmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi();
            var loanId = loanId_example;  // string | Loan GUID
            var view = view_example;  // string | Acceptable value is ID/Entity. Specifying this value will retrieve the ID in the subsequent URL PUT call (optional) 
            var input = new EFolderMediaUrlContract(); // EFolderMediaUrlContract |  (optional) 

            try
            {
                EFolderMediaUrlContract result = apiInstance.UploadAttachment(loanId, view, input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttachmentsApi.UploadAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loanId** | **string**| Loan GUID | 
 **view** | **string**| Acceptable value is ID/Entity. Specifying this value will retrieve the ID in the subsequent URL PUT call | [optional] 
 **input** | [**EFolderMediaUrlContract**](EFolderMediaUrlContract.md)|  | [optional] 

### Return type

[**EFolderMediaUrlContract**](EFolderMediaUrlContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

