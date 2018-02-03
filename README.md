# API to Language Bindings

The purpose of this repository is to 

1. Demonstrate how to generate a common library for a specific language for API Bindings
2. How to call Encompass Developer Connect APIs using these bindings

## .NET Bindings
This repository contains the .NET bindings, also referred to as .NET Client Libraries.

## Getting Started

**Prerequisites:**

    Visual Studio 2015 Or Higher
    Visual Sudio 2015 Or Higher

### Step 1: Install the .NET Language Binding

This step gets all the required packages and dependencies.

Execute the following command from your Visual Studio's Package Manager console to install all the packages at once:

        PM> Install-Package Elli.Api

All DLLs obtained are Strong Named. You can verify this once the DLL is imported into the project, by clicking on the Properties of the DLL and looking for the property "Strong Name". This value should be true.

In addition to the internal dependencies, the following external dependencies are also installed:

    RestSharpSigned version 105.1.0
    OR
    RestSharp version 105.1.0
    
    Newtonsoft.Json version 10.0.3

If you want to install the packages individually, follow the example for Loans package as follows: 

    PM> Install-Package Elli.Api.Loans

All available packages that will be installed are: 

        Elli.Api.CustomDataObjects
        Elli.Api.Loans
        Elli.Api.Loans.EFolder
        Elli.Api.Loans.Pipeline
        Elli.Api.Services
        
    
Note: Each of the above packages references all dependencies including Oauth Client and Base DLL. If you wish to install just the OAuth reference, execute the following command:

    PM> Install-Package Elli.Api.OAuth

### Step 2: Update API Client Configuration
Elli.Api.Base enables easy configuration for project. Depending on the type of the project, in the web.config or app.config file, add following section for configuration:

    <configSections>
        ...
        <section name="ElliApiConfig" type="Elli.Api.Base.ApiConfiguration, Elli.Api.Base"/>
        ...
    </configSections>
    <ElliApiConfig apiHost="https://api.elliemae.com.com" apiClientId="" clientSecret="" idpHost="idp.elliemae.com" redirectUrl=""/>

Where

    apiHost: this is the end point where APIs are located. In most of the cases this value is https://api.elliemae.com and should not require any changes
    apiClientID and clientSecret: This value can be obtained from Encompass Developer Connect portal. If you do not have access to developer portal, please contact your account representative to obtain access.
    idpHost: This is the host name where user can authenticate for auth code flow. In most of the cases this value is idp.elliemae.com and should not require any changes
     redirectUrl: This is the url where user will be redirected in case of authcode flow. For security reasons, this must be an https end point, else the redirect will not work.

### Step 3: Coding 
#### Example: Initializing an Api Client
    var {varName} = ApiClientProvider.GetApiClient<{TypeOf Client}>({Access Token Object});
    {varName}.{apicall}([{parameters}]);
    
The Access token can be obtained by using either of the following examples.

**Using ROPC Flow**:

    var credentials = new UserCredential
        {
            Password = password,
            IdentityType = IdentityType.Borrower,
            SiteId = siteId,
            UserName = userName
        };
    var accessToken = AccessToken.GetAccessToken(credentials);
    
**Using Auth Code Flow**:
In authcode flow, user is authenticated on Ellie Mae Identity provider and a code is given back to redirect url as a query parameter

    var accessToken = AccessToken.GetAccessToken(code);

For any further references for coding, please refer to the sample applications in this repository.

## How this repository is distributed

There are two folders in this repository: 
1. **DotNetBindings** : The .NET bindings are API clients and corresponding models in needed for an API to be called successfully. This folder also contains a common library under the folder named Elli.Api. This folder and corresponding DLL is referenced below in this document. 
2. **Samlple Applications** : This folder contains certain sample applications demonstrating various use cases.

## Elli.Api
There are several pieces in ths API which are used frequently in the context of API Clients.
1. Using Access Token to call a secured API
2. Generating API Client for a specific API

The Elli.Api.Base.dll contains helper classes for such common uses.
### Obtaining Access Token

The Elli.Api.Base Namespace contains **AccessToken** class. This class is designed to reduce the redundancy in the code for Access Token related operations. A user can be authenticated and get an exchange token using either ROPC flow or Auth Code flow. This class supports both approaches, getting access token using ROPC Flow as well as getting exchange token for an auth code obtaind using interactive login through the console UI.

Both the flows are demonstrated in the Samples/OAuth folder.

### Initializing an API Client
While initializing an API client, it requires certain values such as end point and access token as necessary. Throughout the sample apps, this initialization is demonstrated.

## Referring to API Clients:
All the DLLs are part of Nuget and are available as packages with necessary dependencies.


## Modifying and Referring to changed DLLs
If you wish to change the API Client's behavior, DotNetBindings folder has a .Net solution with all dependencies. Referring to this project in target Dll will modify the behavior as required.

## Advantages
1. Since all types required for a successful API execution are strongly typed, developers do not have to take care of serialization and deserialization.
2. All necessary redundant tasks are streamlined to minimize the redundant code in the consuming applications.
3. If referring to nuget package manager, updates are just a few clicks away.

## Sample Application Use Cases
Each sample application and corresponding code has required comments to help developers understand what each step is doing and best practices around them. The sample applications that are made available in this repository cater to OAuth 2.0 and demonstration

1. OAuth: Oauth has two samples, one using ROPC flow and another using Auth code flow. ROPC flow is an interactive command line application. This sample accepts username and password and gets access token against those credentials. 
*It is not recommended to display password in plain text in any application. For the simplicity of demonstration this sample uses plain text password*

Second example is a web application to demonstrate AuthCode flow and exchange auth code for an exchange token

2. Loan Examples:
Loan example is divided into following use cases:
  *  Getting an access token, accessing the loan pipeline, retrieving a loan, locking a loan, updating a loan, ordering a service, checking the service order status, creating a document, creating/adding an attachment, unlocking the loan and deleting the loan. 
  * Creating a loan pipeline with more than 4 filters and paginating through a result set of over 200 loans, creating, retrieving and updating a custom data object. 
  * Updating a batch of loans based on a filter and moving a loan across folders. 
  * Creating loans based on a loan template
