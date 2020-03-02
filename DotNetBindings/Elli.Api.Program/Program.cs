using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using Elli.Api.Base;
using Elli.Api.Loans.Pipeline.Api;
using Elli.Api.Loans.Pipeline.Model;
using Elli.Api.Services.Api;

namespace Elli.Api.Program
{
   class Program
   {
      public static ApiConfiguration EncompassApiConfig { get; protected set; }

      public static AccessToken EncompassAccessToken { get; protected set; }

      static void Main(string[] args)
      {
         EncompassApiConfig = (ApiConfiguration) ConfigurationManager.GetSection("ElliApiConfig");

         ValidateConnection();

         // Simplified way to have all of the DLLs build and drop into a single folder.
         ServiceApi serviceApiClient = ApiClientProvider.GetApiClient<ServiceApi>(EncompassAccessToken, EncompassApiConfig);
      }

      public static void ValidateConnection()
      {

         if (EncompassAccessToken == null)
         {
            Connect();
         }

         try
         {
            // Is the token valid? Can I pull back some data from Ellie Mae?
            ValidateActiveToken();
         }
         catch
         {
            try
            {
               EncompassAccessToken = null;

               Connect();
               // If this throws an exception then we have a problem and we cannot continue.
               ValidateActiveToken();
            }
            catch (Exception ex)
            {
               throw new Exception("Unable to connect to Encompass", ex);
            }
         }
      }

      public static void Connect()
      {
         Connect(EncompassApiConfig.Username, EncompassApiConfig.Password, IdentityType.Lender);
      }

      public static void Connect(string userName, string password, IdentityType identityType)
      {
         try
         {
            //Calling method to get access token using Resource Owner Flow
            //User name transformation: username format accepted by the API is <username>@encompass:<instanceId>
            UserCredential credentials = new UserCredential
            {
               Password = password,
               IdentityType = identityType,
               InstanceId = EncompassApiConfig.InstanceId,
               UserName = userName
            };

            EncompassAccessToken = AccessToken.GetAccessToken(credentials, EncompassApiConfig.ApiClientId, EncompassApiConfig.ClientSecret, EncompassApiConfig);
         }
         catch (Exception ex)
         {
            throw new Exception("Unable to connect to Encompass See InnerException", ex);
         }
      }

      private static void ValidateActiveToken()
      {
         //ToDo: Find out if there is a "IsValidToken()" API call provided from Ellie Mae instead of the following logic.

         // access the loan pipeline to pull back a single record as a connectivity check.
         LoanPipelineApi loanPipelineApiClient = ApiClientProvider.GetApiClient<LoanPipelineApi>(EncompassAccessToken, EncompassApiConfig);
         LoanPipelineViewContract cursorRequest = new LoanPipelineViewContract
         {
            Filter = new LoanPipelineFilterContract
            {
               Terms = new List<LoanPipelineFilterContractTerms>()
               {
                  new LoanPipelineFilterContractTerms
                  {
                     CanonicalName = "Loan.LoanFolder",
                     Value = "My Pipeline",
                     MatchType = "exact"
                  }
               }
            },
            Fields = new List<string> { "Loan.GUID", "Loan.LastModified" },
            SortOrder = new List<LoanPipelineViewContractSortOrder>
            {
               new LoanPipelineViewContractSortOrder
               {
                  CanonicalName = "Loan.LastModified",
                  Order = "desc"
               }
            }
         };

         // returning a single loan. This will fail if the token is invalid and we only want to pull back a single record to reduce load on the server.
         loanPipelineApiClient.PipelineRequest("1", "randomAccess", null, "0", cursorRequest, "true");
      }
   }
}
