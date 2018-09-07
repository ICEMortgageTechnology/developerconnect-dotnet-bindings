/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/*
 * THIS EXAMPLE ELLUSTRATES THE WORKFLOW WITH FOLLOWING STEPS:
 *  1. GET ACCESS TOKEN
 *  2. ACCESS LOAN PIPELINE
 *  3. RETRIVING A LOAN
 *  4. LOCKING A LOAN
 *  5. UPDATING A LOAN
 *  6. ORDERING A SERVICE
 *  7. CHECKING SERVICE STATUS
 *  8. CREATING A DOCUMENT
 *  9. CREATING/ADDING ATTACHMENT
 * 10. UNLOCK LOAN
 * 11. DELETE LOAN
 * 12. GET LOAN MILESTONES
 * 13. GET SPECIFIC LOAN MILESTONE
 * 14. GET ALL ASSOCIATES OF A LOAN
 * 15. ASSIGNING LOAN ASSOCIATE TO A MILESTONE
 * 16. UNASSIGNING LOAN ASSOCIATE FROM A MILESTONE
 * 17. COMPLETING A MILESTONE
 * 18. GET ALL UNDERWRITING CONDITIONS
 * 19. GET SPECIFIC UNDERWRITING CONDITION
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using Elli.Api.Base;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.EFolder.Api;
using Elli.Api.Loans.EFolder.Model;
using Elli.Api.Loans.Model;
using Elli.Api.Loans.Pipeline.Api;
using Elli.Api.Loans.Pipeline.Model;
using Elli.Api.Services.Api;
using Elli.Api.Services.Model;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Security;
using Newtonsoft.Json;
using Elli.Api.Schema.Api;

namespace Ellie.Api.Examples.Loans
{
    public static class UseCase1
    {
        private static AccessToken _accessToken;
        private static string _loanId, _lockId, _transactionId, _documentId;

        public static void Execute()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("It is suggested that the menu items are executed sequentially. This will help in storing the Loan guid behind the scenes. You can also jump into any menu item and enter a loan guid manually to execute them.\r\n");
                Console.WriteLine("Please make a selection:");
                Console.WriteLine(" 1: Get Access Token");
                Console.WriteLine(" 2: Access \"My Pipeline\" Folder");
                Console.WriteLine(" 3: Retrieve a Loan");
                Console.WriteLine(" 4: Lock the Loan");
                Console.WriteLine(" 5: Update A Loan");
                Console.WriteLine(" 6: Order Service");
                Console.WriteLine(" 7: Check Service Status");
                Console.WriteLine(" 8: Create Document");
                Console.WriteLine(" 9: Create/Add Attachment");
                Console.WriteLine("10: Unlock Loan");
                Console.WriteLine("11: Delete Loan");
                Console.WriteLine("12: Get Loan Milestones");
                Console.WriteLine("13: Get Specific Loan Milestone");
                Console.WriteLine("14: Get All Loan Associates");
                Console.WriteLine("15: Assign Loan Associate To A Milestone");
                Console.WriteLine("16: Unassign Loan Associate From A Milestone");
                Console.WriteLine("17: Complete A Milestone");
                Console.WriteLine("18: Get All Underwriting Conditions");
                Console.WriteLine("19: Get Specific Underwriting Condition");
                Console.WriteLine("98: Choose another Loan ID");
                Console.WriteLine("99: Exit");
                Console.Write("Enter your choice: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Clear();
                    try
                    {
                        switch (choice)
                        {
                            case 1:
                                Authenticate();
                                break;
                            case 2:
                                AccessPipeline();
                                break;
                            case 3:
                                GetLoan();
                                break;
                            case 4:
                                LoanLock();
                                break;
                            case 5:
                                UpdateLoan();
                                break;
                            case 6:
                                OrderService();
                                break;
                            case 7:
                                CheckServiceStatus();
                                break;
                            case 8:
                                CreateDocument();
                                break;
                            case 9:
                                CreateAttachment();
                                break;
                            case 10:
                                DeleteLock();
                                break;
                            case 11:
                                DeleteLoan();
                                break;
                            case 12:
                                GetLoanMilestones();
                                break;
                            case 13:
                                GetLoanMilestone();
                                break;
                            case 14:
                                GetAllLoanAssociates();
                                break;
                            case 15:
                                AssignLoanAssociate();
                                break;
                            case 16:
                                UnassignLoanAssociate();
                                break;
                            case 17:
                                CompleteMilestone();
                                break;
                            case 18:
                                GetUnderwritingConditions();
                                break;
                            case 19:
                                GetUnderwritingCondition();
                                break;
                            case 98:
                                _loanId = null;
                                _accessToken = null;
                                _lockId = null;
                                _transactionId = null;
                                _documentId = null;
                                Console.Write("Enter Loan Id: ");
                                _loanId = Console.ReadLine();
                                break;
                            case 99:
                                _loanId = null;
                                _accessToken = null;
                                _lockId = null;
                                _transactionId = null;
                                return;
                        }
                        Console.WriteLine("Operation completed successfully. Press enter to try another operation");
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        Console.ReadLine();
                    }
                }
            } while (true);
        }


        /// <summary>
        /// Example: Obtain access token
        /// </summary>
        public static void Authenticate()
        {
            ApiConfiguration config = (ApiConfiguration)ConfigurationManager.GetSection("ElliApiConfig");
            
            //Passwords and other sensitive information should be handled by consumer application suitably            
            string instanceId = config.InstanceId, userName = config.Username, password = config.Password;

            Console.Clear();
            if (string.IsNullOrEmpty(instanceId))
            {
                Console.Write("Instance Id     : ");
                instanceId = Console.ReadLine();
            }
            if (string.IsNullOrEmpty(userName))
            {
                Console.Write("Username        : ");
                userName = Console.ReadLine();
            }            
            if (string.IsNullOrEmpty(password))
            {
                Console.Write("Password        : ");
                password = Console.ReadLine();
            }

            var credentials = new UserCredential
            {
                IdentityType = IdentityType.Lender,
                InstanceId = instanceId,
                Password = password,
                UserName = userName
            };

            _accessToken = AccessToken.GetAccessToken(credentials);
            Console.WriteLine($"Your Access Token is: {_accessToken.Token}");
        }

        /// <summary>
        /// Example: Creating a cursor to generate a pipeline view
        /// This example gets top 100 loans based on last modified in its descending order.
        /// </summary>
        private static void AccessPipeline()
        {
            if (_accessToken == null)
                Authenticate();
            var loanPipelineApiClient = ApiClientProvider.GetApiClient<LoanPipelineApi>(_accessToken);

            var cursorRequest = new LoanPipelineViewContract
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

            var loans = loanPipelineApiClient.PipelineRequest("100", "randomAccess", null, "0", cursorRequest, "true");
            Console.WriteLine("Total Loans: {0}", loans.Count);
            foreach (var loanInfo in loans)
            {
                //Since swagger does not support Dictionary directly, we need to cast manually here.
                var fieldinfo = ((JObject)loanInfo.Fields).ToDictionary<string>();
                Console.WriteLine("{0} | {1}", loanInfo.LoanGuid, fieldinfo["Loan.LastModified"]);
            }
        }

        /// <summary>
        /// Example: Retrieve Loan
        /// </summary>
        private static void GetLoan()
        {
            if (_accessToken == null)
                Authenticate();
            //Initializing the API Client*/
            var loanApiClient = ApiClientProvider.GetApiClient<LoansApi>(_accessToken);


            //Example: retriving the loan
            var loan = loanApiClient.GetLoan(LoanId);

            //Printing the response with couple of fields
            Console.WriteLine("Loan Number        : {0}", loan.LoanNumber);
            Console.WriteLine("Borrower First Name: {0}", loan.Applications[0].Borrower.FirstName);
        }

        /// <summary>
        /// Example: Obtaining a lock and getting lock information
        /// </summary>
        private static void LoanLock()
        {
            if (_accessToken == null)
                Authenticate();
            ResourceLocksApi lockApiClient = ApiClientProvider.GetApiClient<ResourceLocksApi>(_accessToken);

            Console.Write("Enter the LoanId: ");
            var loanId = Console.ReadLine();
            //This contract will get us lock on a loan and this will be a forced lock.
            var request = new ResourceLockContract
            {
                Resource = new ResourceLockContractResource
                {
                    EntityType = "loan",
                    EntityId = loanId
                },
                LockType = "shared"
            };
            var createResponse = lockApiClient.CreateResourceLockWithHttpInfo("false", "id", request);
            //Example of pasrsing the URL
            _lockId = createResponse.Headers["Location"].Split('/')[3];
            var getResponse = lockApiClient.GetResourceLockByLockId(_lockId, "loan", loanId);
            Console.WriteLine("Lock ID: {0}", getResponse.Id);
        }

        /// <summary>
        /// Example: Update Loan. For Example will be updating Loan Amount
        /// </summary>
        private static void UpdateLoan()
        {
            if (_accessToken == null)
                Authenticate();
            //Initializing the API Client*/
            var loanApiClient = ApiClientProvider.GetApiClient<LoansApi>(_accessToken);

            //Creating new loan contract for update. We are updating the loan amount.
            var correctVal = false;
            double loanAmt = 0;
            Console.Write("Enter Loan Amount: ");
            while (!correctVal)
            {
                correctVal = double.TryParse(Console.ReadLine(), out loanAmt);
                if (!correctVal)
                    Console.Write("Please enter a valid number: ");
            }
            var loan = new LoanContract
            {
                BorrowerRequestedLoanAmount = loanAmt
            };

            var response = loanApiClient.UpdateLoan(LoanId, null, null, null, loan, "entity");

            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            };
            LoanContract updatedLoan = JsonConvert.DeserializeObject<LoanContract>(response.ToString(), serializerSettings);
        }

        /// <summary>
        /// Example: Ordering a service. Example of ordring credit from Credco.
        /// </summary>
        private static void OrderService()
        {
            if (_accessToken == null)
                Authenticate();
            var serviceApiClient = ApiClientProvider.GetApiClient<ServiceApi>(_accessToken);
            Console.Write("Enter Credco User Name  : ");
            var userName = Console.ReadLine();
            Console.Write("Enter Credco Password   : ");
            string password = Console.ReadLine();
            Console.Write("Enter Borrower Id       : ");
            var borrowerId = Console.ReadLine();

            //Ordering credit from credco
            var request = new OrderServiceRequest
            {
                Product = new Product
                {
                    Credentials = new ProductCredentials
                    {
                        UserName = userName,
                        Password = password
                    },
                    EntityRef = new ProductEntityRef
                    {
                        EntityId = $"{LoanId}#{borrowerId}",
                        EntityType = "urn:elli:encompass:loan:borrower"
                    },
                    Name = "CREDITIQ",
                    Options = new ProductOptions
                    {
                        DigiCert = true,
                        CreditBureauEquifax = true,
                        CreditBureauExperian = true,
                        CreditBureauTransUnion = true,
                        CreditReportIdentifier = "",
                        Note = "",
                        ReportOn = "Joint",
                        ReportType = "Merge",
                        RequestType = "NewOrder"
                    },
                    Preferences = new ProductPreferences
                    {
                        ExcludeZeroforImportLiabilities = true,
                        ImportLiabilities = true
                    }
                }
            };

            //Partner ID for credco is 307378
            var resp = serviceApiClient.OrderServiceWithHttpInfo(307378, request);
            //Example Getting ID from location header
            _transactionId = resp.Headers["Location"].Split('/')[6];
            Console.WriteLine($"Transaction ID: {_transactionId}");
        }

        /// <summary>
        /// Example: Checking the status of service we just ordered
        /// </summary>
        private static void CheckServiceStatus()
        {
            if (_accessToken == null)
                Authenticate();
            var serviceApiClient = ApiClientProvider.GetApiClient<ServiceApi>(_accessToken);
            var response = serviceApiClient.GetOrderStatus(307378, _transactionId);
            Console.WriteLine($"The Transaction Status is: {response?.Status}");
        }

        /// <summary>
        /// Example: Creating a document
        /// </summary>
        private static void CreateDocument()
        {
            if (_accessToken == null)
                Authenticate();
            Console.Write("Enter Doc Title : ");
            var title = Console.ReadLine();
            var docsApiClient = ApiClientProvider.GetApiClient<DocumentsApi>(_accessToken);
            var request = new EFolderDocumentContract
            {
                Title = title,
                Description = "Description of the document",
                RequestedFrom = "User",
                ApplicationId = "All",
                EmnSignature = "Signature",
                DateRequested = DateTime.Now.AddDays(-5),
                DateExpected = DateTime.Now.AddDays(5),
                DateReceived = DateTime.Now.AddDays(-1),
                DateReviewed = DateTime.Now,
                DateReadyForUw = DateTime.Now.AddDays(-2),
                DateReadyToShip = DateTime.Now.AddDays(-2),
                Comments = new List<EFolderDocumentContractComments>()
            };
            var response = docsApiClient.CreateDocumentWithHttpInfo(LoanId, "id", request);
            var loc = response.Headers["Location"];
            DocumentId = loc.Split('/')[5];
            Console.WriteLine("This document can be accessed at: {0}", loc);
            Console.WriteLine($"Document Reference Id is: {loc.Split('/')[5]}");
        }

        /// <summary>
        /// Example: Create Attachment
        /// Create attachment is a 2 step process
        /// 1. Get URL where the document should be put
        /// 2. Upload actual file
        /// </summary>
        private static void CreateAttachment()
        {
            if (_accessToken == null)
                Authenticate();
            //Step 1: Get the url for document to be uploaded
            var attachmentsApiClient = ApiClientProvider.GetApiClient<AttachmentsApi>(_accessToken);
            Console.WriteLine("Step 1: Creating Attachment Metadata");
            Console.Write("Please enter File Name with Extension: ");
            var fileName = Console.ReadLine();

            var request = new EFolderMediaUrlContract
            {
                FileWithExtension = fileName,
                CreateReason = 1,
                Title = fileName,
                DocumentRefId = DocumentId
            };
            //We need to provide id parameter in order to get the attachment id at the end of second call.
            var response = attachmentsApiClient.UploadAttachment(LoanId, "id", request);
            var urlToUpload = response.MediaUrl;
            Console.WriteLine("Attachment Metadata Created Successfully");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Step 2: Uploading File for attachment");
            bool fileReadAttemptFailed;
            string path;
            byte[] content = { };
            //Reading the file path and making sure the file exists and readable
            do
            {
                fileReadAttemptFailed = false;
                Console.WriteLine("Please enter the file path to upload the attachment: ");
                path = Console.ReadLine() + "";
                path = path.Replace("..", ""); //Fix for Path Traversal security threat
                try
                {
                    content = File.ReadAllBytes(path);
                }
                catch
                {
                    fileReadAttemptFailed = true;
                }
            } while (fileReadAttemptFailed);
            //Step 2: Upload the file
            //we are using rest client from rest sharp here to use the URL
            var client = new RestClient(urlToUpload);
            var attachRequest = new RestRequest(Method.PUT);
            //TODO: Remove this header in next release
            attachRequest.AddHeader("cache-control", "no-cache");
            attachRequest.AddParameter("undefined", content, ParameterType.RequestBody);
            var putResponse = client.Execute(attachRequest);
            //Code to handle the response from file put goes here. For now we are just printing the row response
            Console.WriteLine(putResponse.Content);
        }

        /// <summary>
        /// Example: Unlock Loan
        /// </summary>
        private static void DeleteLock()
        {
            if (_accessToken == null)
                Authenticate();
            ResourceLocksApi lockApiClient = ApiClientProvider.GetApiClient<ResourceLocksApi>(_accessToken);
            lockApiClient.Unlock(_lockId, "loan", LoanId, "true");
        }

        /// <summary>
        /// Example: Delete Loan. 
        /// </summary>
        private static void DeleteLoan()
        {
            if (_accessToken == null)
                Authenticate();
            //Initializing the API Client*/
            var loanApiClient = ApiClientProvider.GetApiClient<LoansApi>(_accessToken);

            //Calling Delete loan
            loanApiClient.DeleteLoan(LoanId);
            Console.WriteLine("Loan Deleted");
        }

        private static string LoanId
        {
            get
            {
                if (string.IsNullOrEmpty(_loanId))
                {
                    Guid guid = Guid.Empty;
                    var correctVal = false;
                    Console.WriteLine("Enter Loan Id: ");
                    while (!correctVal)
                    {
                        correctVal = Guid.TryParse(Console.ReadLine(), out guid);
                        if (!correctVal)
                            Console.Write("Please enter a valid loan id: ");
                    }
                    _loanId = guid.ToString();
                }
                return _loanId;
            }
        }

        private static string DocumentId
        {
            get
            {
                
                if (string.IsNullOrEmpty(_documentId))
                {
                    Guid guid = Guid.Empty;
                    var correctVal = false;
                    Console.WriteLine("Enter Document Id: ");
                    while (!correctVal)
                    {
                        correctVal = Guid.TryParse(Console.ReadLine(), out guid);
                        if (!correctVal)
                            Console.Write("Please enter a valid document id: ");
                    }
                    _documentId = guid.ToString();
                }
                return _documentId;
            }
            set
            {
                _documentId = value;
            }
        }

        /// <summary>
        /// Example: Get Loan Milestones
        /// </summary>
        private static void GetLoanMilestones()
        {
            if (_accessToken == null)
                Authenticate();

            //Initializing the API Client
            MilestonesApi milestoneApiClient = ApiClientProvider.GetApiClient<MilestonesApi>(_accessToken);

            //Retrieving loan milestones
            var milestones = milestoneApiClient.GetMilestones(LoanId);

            for (int i = 0; i < milestones.Count; i++)
            {
                //Printing the response with couple of fields
                Console.WriteLine("{0})Milestone Id   : {1}", (i + 1).ToString("00"), milestones[i].Id);
                Console.WriteLine("   Milestone Name : {0}", milestones[i].MilestoneName);
                Console.WriteLine("   Start Date     : {0}", milestones[i].StartDate);
            }
        }

        /// <summary>
        /// Example: Get specific loan milestone
        /// </summary>
        private static void GetLoanMilestone()
        {
            if (_accessToken == null)
                Authenticate();

            Console.WriteLine("Enter Milestone Id: ");
            string milestoneId = Console.ReadLine();

            //Initializing the API Client
            MilestonesApi milestoneApiClient = ApiClientProvider.GetApiClient<MilestonesApi>(_accessToken);

            //Retrieving loan milestones
            var milestone = milestoneApiClient.GetMilestone(milestoneId, LoanId);

            //Printing the response with couple of fields
            Console.WriteLine("Milestone Id     : {0}", milestone.Id);
            Console.WriteLine("Milestone Name   : {0}", milestone.MilestoneName);
            Console.WriteLine("Start Date       : {0}", milestone.StartDate);
            Console.WriteLine("Loan Team Member : {0}", milestone.LoanAssociate.Name);
        }

        /// <summary>
        /// Example: Get all associates for a loan
        /// </summary>
        private static void GetAllLoanAssociates()
        {
            if (_accessToken == null)
                Authenticate();

            //Initializing the API Client
            LoanAssociatesApi loanAssociateApiClient = ApiClientProvider.GetApiClient<LoanAssociatesApi>(_accessToken);

            //Retrieving all loan associates
            var associates = loanAssociateApiClient.GetAssociates(LoanId);

            //Printing the response with couple of fields
            for (int i = 0; i < associates.Count; i++)
            {
                Console.WriteLine("{0})User Id  : {1}", (i + 1).ToString("00"), associates[i].Id);
                Console.WriteLine("   Name     : {0}", associates[i].Name);
                Console.WriteLine("   Role     : {0}", associates[i].RoleName);
                Console.WriteLine("   Type     : {0}", associates[i].LoanAssociateType);
            }
        }

        /// <summary>
        /// Example: Assign associate to a milestone
        /// </summary>
        private static void AssignLoanAssociate()
        {
            if (_accessToken == null)
                Authenticate();

            string loanId = LoanId;

            Console.Write("Enter Milestone Id      : ");
            string milestoneId = Console.ReadLine();

            Console.Write("Enter Loan Associate Id : ");
            string associateId = Console.ReadLine();

            Console.Write("Enter Associate Type    : ");
            string associateType = Console.ReadLine();

            //Initializing the API Client
            LoanAssociatesApi loanAssociateApiClient = ApiClientProvider.GetApiClient<LoanAssociatesApi>(_accessToken);

            //Initializing the contract
            LoanTeamMemberContract loanAssociate = new LoanTeamMemberContract { Id = associateId, LoanAssociateType = associateType };

            //Calling AssignLoanTeamMember
            loanAssociateApiClient.AssignLoanTeamMember(milestoneId, LoanId, loanAssociate);
            Console.WriteLine("");
            Console.WriteLine("Associate assigned");
        }

        /// <summary>
        /// Example: Unassign a loan associate
        /// </summary>
        private static void UnassignLoanAssociate()
        {
            if (_accessToken == null)
                Authenticate();

            string loanId = LoanId;

            Console.Write("Enter Milestone Id : ");
            string milestoneId = Console.ReadLine();

            //Initializing the API Client
            LoanAssociatesApi loanAssociateApiClient = ApiClientProvider.GetApiClient<LoanAssociatesApi>(_accessToken);

            //Calling UnassignLoanAssociate
            loanAssociateApiClient.UnassignLoanTeamMember(milestoneId, loanId);

        }

        /// <summary>
        /// Example: Finish a loan milestone
        /// </summary>
        private static void CompleteMilestone()
        {
            if (_accessToken == null)
                Authenticate();

            string loanId = LoanId;

            Console.Write("Enter Milestone Id : ");
            string milestoneId = Console.ReadLine();

            //Initializing the API Client
            MilestonesApi milestoneApiClient = ApiClientProvider.GetApiClient<MilestonesApi>(_accessToken);

            //Calling UpdateMilestone operation which completes the milestone when action is passed as finish
            milestoneApiClient.UpdateMilestone(milestoneId, LoanId, action: "finish", milestoneLogContract: new MilestoneContract());
        }

        /// <summary>
        /// Example: Get all Underwriting conditions for a loan
        /// </summary>
        private static void GetUnderwritingCondition()
        {
            if (_accessToken == null)
                Authenticate();
            var conditionsApiClient = ApiClientProvider.GetApiClient<ConditionsApi>(_accessToken);

            Console.Write("Enter Condition Id: ");
            string conditionId = Console.ReadLine();

            var condition = conditionsApiClient.GetEFolderUnderwritingConditionById(conditionId, LoanId);

            Console.WriteLine("Id             - {0}", condition.Id);
            Console.WriteLine("ConditionType  - {0}", condition.ConditionType);
            Console.WriteLine("Title          - {0}", condition.Title);
            Console.WriteLine("Description    - {0}", condition.Description);
            Console.WriteLine("Status         - {0}", condition.Status);
            Console.WriteLine("Source         - {0}", condition.Source);
            Console.WriteLine("StatusDate     - {0}", condition.StatusDate);
            Console.WriteLine("Comments Count - {0}", condition.Comments.Count);
            Console.WriteLine("Docs Count     - {0}", condition.Documents.Count);
        }

        /// <summary>
        /// Example: Get a specific Underwriting condition for a loan
        /// </summary>
        private static void GetUnderwritingConditions()
        {
            int count = 1;
            if (_accessToken == null)
                Authenticate();
            var conditionsApiClient = ApiClientProvider.GetApiClient<ConditionsApi>(_accessToken);

            var response = conditionsApiClient.GetEFolderUnderwritingConditions(LoanId);

            Console.WriteLine("Total count of conditions - {0}", response.Count);
            foreach (var condition in response)
            {
                //Printing only first five records
                if (count > 5)
                    break;
                Console.WriteLine("Condition {0} - ", count);
                Console.WriteLine("Id            - {0}", condition.Id);
                Console.WriteLine("ConditionType - {0}", condition.ConditionType);
                Console.WriteLine("Title         - {0}", condition.Title);
                Console.WriteLine("Description   - {0}", condition.Description);
                Console.WriteLine("Status        - {0}", condition.Status);
                Console.WriteLine();
                count++;
            }
        }
    }
}
