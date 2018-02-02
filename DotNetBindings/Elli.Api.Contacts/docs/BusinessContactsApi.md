# Elli.Api.Contacts.Api.BusinessContactsApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBusinessContact**](BusinessContactsApi.md#createbusinesscontact) | **POST** /encompass/v1/businesscontacts/ | Create Business Contact
[**CreateBusinessContactNote**](BusinessContactsApi.md#createbusinesscontactnote) | **POST** /encompass/v1/businesscontacts/{contactId}/notes | Create Business Contact Note
[**DeleteBusinessContact**](BusinessContactsApi.md#deletebusinesscontact) | **DELETE** /encompass/v1/businesscontacts/{contactId} | Delete Business Contact
[**DeleteBusinessContactNote**](BusinessContactsApi.md#deletebusinesscontactnote) | **DELETE** /encompass/v1/businesscontacts/{contactId}/notes/{noteId} | Delete Business Contact Note
[**GetBusinessContact**](BusinessContactsApi.md#getbusinesscontact) | **GET** /encompass/v1/businesscontacts/{contactId} | Retrieve Business Contact
[**GetBusinessContactNote**](BusinessContactsApi.md#getbusinesscontactnote) | **GET** /encompass/v1/businesscontacts/{contactId}/notes/{noteId} | Retrieve Business Contact Note
[**UpdateBusinessContact**](BusinessContactsApi.md#updatebusinesscontact) | **PATCH** /encompass/v1/businesscontacts/{contactId} | Update Business Contact
[**UpdateBusinessContactNote**](BusinessContactsApi.md#updatebusinesscontactnote) | **PATCH** /encompass/v1/businesscontacts/{contactId}/notes/{noteId} | Update Business Contact Note


<a name="createbusinesscontact"></a>
# **CreateBusinessContact**
> void CreateBusinessContact (BusinessContactContract contact)

Create Business Contact

Create a new business contact. To create a contact, the firstName OR lastName is required AND one of the following parameters: personalEmail, currentMailingAddress.street1, homePhone, mobilePhone, workPhone.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class CreateBusinessContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessContactsApi();
            var contact = new BusinessContactContract(); // BusinessContactContract | Business contact entity

            try
            {
                // Create Business Contact
                apiInstance.CreateBusinessContact(contact);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessContactsApi.CreateBusinessContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contact** | [**BusinessContactContract**](BusinessContactContract.md)| Business contact entity | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbusinesscontactnote"></a>
# **CreateBusinessContactNote**
> void CreateBusinessContactNote (string contactId, ContactNoteContract note)

Create Business Contact Note

Adds a note to the specified business contact. Returns the note ID in the response header.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class CreateBusinessContactNoteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.
            var note = new ContactNoteContract(); // ContactNoteContract | Contact note entity.

            try
            {
                // Create Business Contact Note
                apiInstance.CreateBusinessContactNote(contactId, note);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessContactsApi.CreateBusinessContactNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| The unique identifier that is returned in the response when the contact is created. | 
 **note** | [**ContactNoteContract**](ContactNoteContract.md)| Contact note entity. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebusinesscontact"></a>
# **DeleteBusinessContact**
> void DeleteBusinessContact (string contactId)

Delete Business Contact

Permanently deletes the specified business contact.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class DeleteBusinessContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.

            try
            {
                // Delete Business Contact
                apiInstance.DeleteBusinessContact(contactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessContactsApi.DeleteBusinessContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| The unique identifier that is returned in the response when the contact is created. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebusinesscontactnote"></a>
# **DeleteBusinessContactNote**
> void DeleteBusinessContactNote (string contactId, string noteId)

Delete Business Contact Note

Permanently deletes the specified note from the specified business contact.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class DeleteBusinessContactNoteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.
            var noteId = noteId_example;  // string | Unique identifier of the note assigned to the note when it was created.

            try
            {
                // Delete Business Contact Note
                apiInstance.DeleteBusinessContactNote(contactId, noteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessContactsApi.DeleteBusinessContactNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| The unique identifier that is returned in the response when the contact is created. | 
 **noteId** | **string**| Unique identifier of the note assigned to the note when it was created. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbusinesscontact"></a>
# **GetBusinessContact**
> BusinessContactContract GetBusinessContact (string contactId)

Retrieve Business Contact

Retrieves contact information for the specified contact ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class GetBusinessContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.

            try
            {
                // Retrieve Business Contact
                BusinessContactContract result = apiInstance.GetBusinessContact(contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessContactsApi.GetBusinessContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| The unique identifier that is returned in the response when the contact is created. | 

### Return type

[**BusinessContactContract**](BusinessContactContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbusinesscontactnote"></a>
# **GetBusinessContactNote**
> ContactNoteContract GetBusinessContactNote (string contactId, string noteId)

Retrieve Business Contact Note

Retrieves the specified note for the specified business contact.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class GetBusinessContactNoteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.
            var noteId = noteId_example;  // string | Unique identifier of the note assigned to the note when it was created.

            try
            {
                // Retrieve Business Contact Note
                ContactNoteContract result = apiInstance.GetBusinessContactNote(contactId, noteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessContactsApi.GetBusinessContactNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| The unique identifier that is returned in the response when the contact is created. | 
 **noteId** | **string**| Unique identifier of the note assigned to the note when it was created. | 

### Return type

[**ContactNoteContract**](ContactNoteContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebusinesscontact"></a>
# **UpdateBusinessContact**
> BusinessContactContract UpdateBusinessContact (string contactId, BusinessContactContract contact)

Update Business Contact

Updates contact information for the specified contact ID. To update a contact, the firstName OR lastName is required AND one of the following parameters: personalEmail, currentMailingAddress.street1, homePhone, mobilePhone, workPhone.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class UpdateBusinessContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.
            var contact = new BusinessContactContract(); // BusinessContactContract | Business contact entity

            try
            {
                // Update Business Contact
                BusinessContactContract result = apiInstance.UpdateBusinessContact(contactId, contact);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessContactsApi.UpdateBusinessContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| The unique identifier that is returned in the response when the contact is created. | 
 **contact** | [**BusinessContactContract**](BusinessContactContract.md)| Business contact entity | 

### Return type

[**BusinessContactContract**](BusinessContactContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebusinesscontactnote"></a>
# **UpdateBusinessContactNote**
> ContactNoteContract UpdateBusinessContactNote (string contactId, string noteId, ContactNoteContract note)

Update Business Contact Note

Updates the specified note with the values provided.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class UpdateBusinessContactNoteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BusinessContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.
            var noteId = noteId_example;  // string | Unique identifier of the note assigned to the note when it was created.
            var note = new ContactNoteContract(); // ContactNoteContract | Contact note entity.

            try
            {
                // Update Business Contact Note
                ContactNoteContract result = apiInstance.UpdateBusinessContactNote(contactId, noteId, note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BusinessContactsApi.UpdateBusinessContactNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| The unique identifier that is returned in the response when the contact is created. | 
 **noteId** | **string**| Unique identifier of the note assigned to the note when it was created. | 
 **note** | [**ContactNoteContract**](ContactNoteContract.md)| Contact note entity. | 

### Return type

[**ContactNoteContract**](ContactNoteContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

