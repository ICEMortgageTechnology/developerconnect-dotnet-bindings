# Elli.Api.Contacts.Api.BorrowerContactsApi

All URIs are relative to *https://api.elliemae.com/encompass*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBorrowerContact**](BorrowerContactsApi.md#createborrowercontact) | **POST** /encompass/v1/borrowercontacts/ | Create Borrower Contact
[**CreateBorrowerContactNote**](BorrowerContactsApi.md#createborrowercontactnote) | **POST** /encompass/v1/borrowercontacts/{contactId}/notes | Create Borrower Contact Note
[**DeleteBorrowerContact**](BorrowerContactsApi.md#deleteborrowercontact) | **DELETE** /encompass/v1/borrowercontacts/{contactId} | Delete Borrower Contact
[**DeleteBorrowerContactNote**](BorrowerContactsApi.md#deleteborrowercontactnote) | **DELETE** /encompass/v1/borrowercontacts/{contactId}/notes/{noteId} | Delete Borrower Contact Note
[**GetBorrowerContact**](BorrowerContactsApi.md#getborrowercontact) | **GET** /encompass/v1/borrowercontacts/{contactId} | Retrieve Borrower Contact
[**GetBorrowerContactNote**](BorrowerContactsApi.md#getborrowercontactnote) | **GET** /encompass/v1/borrowercontacts/{contactId}/notes/{noteId} | Retrieve Borrower Contact Note
[**GetBorrowerContactNotes**](BorrowerContactsApi.md#getborrowercontactnotes) | **GET** /encompass/v1/borrowercontacts/{contactId}/notes | Retrieve Borrower Contact Notes
[**UpdateBorrowerContact**](BorrowerContactsApi.md#updateborrowercontact) | **PATCH** /encompass/v1/borrowercontacts/{contactId} | Update Borrower Contact
[**UpdateBorrowerContactNote**](BorrowerContactsApi.md#updateborrowercontactnote) | **PATCH** /encompass/v1/borrowercontacts/{contactId}/notes/{noteId} | Update Borrower Contact Note


<a name="createborrowercontact"></a>
# **CreateBorrowerContact**
> void CreateBorrowerContact (BorrowerContactContract contact)

Create Borrower Contact

Create a new borrower contact. To create a contact, the firstName OR lastName is required AND one of the following parameters: personalEmail, currentMailingAddress.street1, homePhone, mobilePhone, workPhone.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class CreateBorrowerContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerContactsApi();
            var contact = new BorrowerContactContract(); // BorrowerContactContract | Borrower contact entity

            try
            {
                // Create Borrower Contact
                apiInstance.CreateBorrowerContact(contact);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerContactsApi.CreateBorrowerContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contact** | [**BorrowerContactContract**](BorrowerContactContract.md)| Borrower contact entity | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createborrowercontactnote"></a>
# **CreateBorrowerContactNote**
> void CreateBorrowerContactNote (string contactId, ContactNoteContract note)

Create Borrower Contact Note

Adds a note to the specified contact. Returns the note ID in the response header.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class CreateBorrowerContactNoteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.
            var note = new ContactNoteContract(); // ContactNoteContract | Contact note entity.

            try
            {
                // Create Borrower Contact Note
                apiInstance.CreateBorrowerContactNote(contactId, note);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerContactsApi.CreateBorrowerContactNote: " + e.Message );
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

<a name="deleteborrowercontact"></a>
# **DeleteBorrowerContact**
> void DeleteBorrowerContact (string contactId)

Delete Borrower Contact

Permanently deletes the specified contact.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class DeleteBorrowerContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.

            try
            {
                // Delete Borrower Contact
                apiInstance.DeleteBorrowerContact(contactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerContactsApi.DeleteBorrowerContact: " + e.Message );
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

<a name="deleteborrowercontactnote"></a>
# **DeleteBorrowerContactNote**
> void DeleteBorrowerContactNote (string contactId, string noteId)

Delete Borrower Contact Note

Permanently deletes the specified note from the specified contact.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class DeleteBorrowerContactNoteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.
            var noteId = noteId_example;  // string | Unique identifier of the note assigned to the note when it was created.

            try
            {
                // Delete Borrower Contact Note
                apiInstance.DeleteBorrowerContactNote(contactId, noteId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerContactsApi.DeleteBorrowerContactNote: " + e.Message );
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

<a name="getborrowercontact"></a>
# **GetBorrowerContact**
> BorrowerContactContract GetBorrowerContact (string contactId)

Retrieve Borrower Contact

Retrieves contact information for the specified contact ID

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class GetBorrowerContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.

            try
            {
                // Retrieve Borrower Contact
                BorrowerContactContract result = apiInstance.GetBorrowerContact(contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerContactsApi.GetBorrowerContact: " + e.Message );
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

[**BorrowerContactContract**](BorrowerContactContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getborrowercontactnote"></a>
# **GetBorrowerContactNote**
> ContactNoteContract GetBorrowerContactNote (string contactId, string noteId)

Retrieve Borrower Contact Note

Retrieves the specified note for the specified contact.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class GetBorrowerContactNoteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.
            var noteId = noteId_example;  // string | Unique identifier of the note assigned to the note when it was created.

            try
            {
                // Retrieve Borrower Contact Note
                ContactNoteContract result = apiInstance.GetBorrowerContactNote(contactId, noteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerContactsApi.GetBorrowerContactNote: " + e.Message );
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

<a name="getborrowercontactnotes"></a>
# **GetBorrowerContactNotes**
> List<ContactNoteContract> GetBorrowerContactNotes (string contactId)

Retrieve Borrower Contact Notes

Retrieve all notes from the specified contact.

### Example
```csharp
using System;
using System.Diagnostics;
using Elli.Api.Contacts.Api;
using Elli.Api.Contacts.Client;
using Elli.Api.Contacts.Model;

namespace Example
{
    public class GetBorrowerContactNotesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.

            try
            {
                // Retrieve Borrower Contact Notes
                List&lt;ContactNoteContract&gt; result = apiInstance.GetBorrowerContactNotes(contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerContactsApi.GetBorrowerContactNotes: " + e.Message );
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

[**List<ContactNoteContract>**](ContactNoteContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateborrowercontact"></a>
# **UpdateBorrowerContact**
> BorrowerContactContract UpdateBorrowerContact (string contactId, BorrowerContactContract contact)

Update Borrower Contact

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
    public class UpdateBorrowerContactExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.
            var contact = new BorrowerContactContract(); // BorrowerContactContract | Borrower contact entity

            try
            {
                // Update Borrower Contact
                BorrowerContactContract result = apiInstance.UpdateBorrowerContact(contactId, contact);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerContactsApi.UpdateBorrowerContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| The unique identifier that is returned in the response when the contact is created. | 
 **contact** | [**BorrowerContactContract**](BorrowerContactContract.md)| Borrower contact entity | 

### Return type

[**BorrowerContactContract**](BorrowerContactContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateborrowercontactnote"></a>
# **UpdateBorrowerContactNote**
> ContactNoteContract UpdateBorrowerContactNote (string contactId, string noteId, ContactNoteContract contactNoteContract)

Update Borrower Contact Note

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
    public class UpdateBorrowerContactNoteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BorrowerContactsApi();
            var contactId = contactId_example;  // string | The unique identifier that is returned in the response when the contact is created.
            var noteId = noteId_example;  // string | Unique identifier of the note assigned to the note when it was created.
            var contactNoteContract = new ContactNoteContract(); // ContactNoteContract | Contact note entity.

            try
            {
                // Update Borrower Contact Note
                ContactNoteContract result = apiInstance.UpdateBorrowerContactNote(contactId, noteId, contactNoteContract);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BorrowerContactsApi.UpdateBorrowerContactNote: " + e.Message );
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
 **contactNoteContract** | [**ContactNoteContract**](ContactNoteContract.md)| Contact note entity. | 

### Return type

[**ContactNoteContract**](ContactNoteContract.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

