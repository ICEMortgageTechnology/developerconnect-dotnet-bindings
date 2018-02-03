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
 *  1. CREATE LOAN PIPELINE
 *  2. PAGINATION THROUGH PIEPLINE
 *  3. CREATE CUSTOM DATA OBJECT (CDO)
 *  4. RETRIEVE CUSTOM DATA OBJECT (CDO)
 *  5. DELETE CUSTOM DATA OBJECT (CDO)
 *  
 *  NOTE: All custom data objects are currently illustrated for loan. They follow similar pattern for User CDO and Global CDO as well.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Configuration;
using Elli.Api.Base;
using Elli.Api.CustomDataObjects.Api;
using Elli.Api.CustomDataObjects.Model;
using Elli.Api.Loans.Pipeline.Api;
using Elli.Api.Loans.Pipeline.Model;
using Newtonsoft.Json.Linq;

namespace Ellie.Api.Examples.Loans
{
    public static class UseCase2
    {
        //Static access token is just for the example. This could be instantiated for each user individually in the same way.
        private static AccessToken _accessToken;


        private static string _cursor;
        private static int _count;

        public static void Execute()
        {
            Authenticate();
            do
            {
                Console.Clear();
                Console.WriteLine("Please make a selection:");
                Console.WriteLine(" 1: Create Loan Pipeline (Cursor)");
                Console.WriteLine(" 2: Pagination");
                Console.WriteLine(" 3: Create Custom Data Object (CDO)");
                Console.WriteLine(" 4: Append Custom Data Object");
                Console.WriteLine(" 5: Get List of Custom Data Objects");
                Console.WriteLine(" 6: Get Specific Custom Data Object");
                Console.WriteLine(" 7: Delete Custom Data Object");
                Console.WriteLine("99: Exit");
                Console.Write("Enter your choice: ");
                int choice;
                if (Int32.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Clear();
                    try
                    {
                        switch (choice)
                        {
                            case 1:
                                CreateCursor();
                                break;
                            case 2:
                                Paginate();
                                break;
                            case 3:
                                CreateCDO();
                                break;
                            case 4:
                                AppendCDO();
                                break;
                            case 5:
                                GetListOfCDOs();
                                break;
                            case 6:
                                GetCDO();
                                break;
                            case 7:
                                DeleteCDO();
                                break;
                            case 99:
                                return;
                        }
                        Console.WriteLine("Operation completed successfully. Press enter to try another operation");
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }
                }
            } while (true);
        }

        /// <summary>
        /// Example: Obtain access token
        /// </summary>
        private static void Authenticate()
        {
            ApiConfiguration config = (ApiConfiguration)ConfigurationManager.GetSection("ElliApiConfig");
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
        }

        /// <summary>
        /// Example: Creating a cursor to generate a pipeline view
        /// </summary>
        private static void CreateCursor()
        {
            var cursorRequest = new LoanPipelineViewContract
            {
                Filter = new LoanPipelineFilterContract
                {
                    Terms = new List<LoanPipelineFilterContractTerms>() {
                        new LoanPipelineFilterContractTerms {
                            CanonicalName = "Loan.LoanFolder",
                            Value = "(Trash)",
                            MatchType = "exact",
                            Include = false
                        },
                        new LoanPipelineFilterContractTerms {
                            CanonicalName = "Loan.LastModified",
                            Value = "02/25/2011",
                            MatchType = "greaterThanOrEquals",
                            Precision = "day"
                        },
                        //Rate Lock # Days
                        new LoanPipelineFilterContractTerms {
                            CanonicalName = "Fields.432",
                            Value = "2",
                            MatchType = "greaterThanOrEquals"
                        },
                        new LoanPipelineFilterContractTerms {
                            CanonicalName = "Loan.CreditScore",
                            Value = "0",
                            MatchType = "notEquals"
                        }
                    },
                    _Operator = "and"
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


            var loanPipelineApiClient = ApiClientProvider.GetApiClient<LoanPipelineApi>(_accessToken);

            //We will need to read headers and hence calling method with http info
            var resp = loanPipelineApiClient.PipelineRequestWithHttpInfo("100", "randomAccess", null, "0", cursorRequest);

            //Reading the cursor ID from headers
            _cursor = resp.Headers["x-cursor"];
            _count = Convert.ToInt32(resp.Headers["x-total-count"]);
        }

        /// <summary>
        /// Example: Loan Cursor pagination
        /// </summary>
        private static void Paginate()
        {
            var loanPipelineApiClient = ApiClientProvider.GetApiClient<LoanPipelineApi>(_accessToken);
            //Making sure we received more than one page in the response
            if (_count > 100)
            {
                var paginationRequest = new LoanPipelineViewContract
                {
                    Fields = new List<string> { "Loan.GUID", "Loan.LastModified" }
                };
                var start = 0;
                var page = 1;
                for (var i = 0; i < 10; i++)
                {
                    //We do not need headers anymore, hence, calling regular method, And will be paginating 10 loans at a time
                    var resp = loanPipelineApiClient.PipelineRequest("10", null, _cursor, start.ToString(), paginationRequest);
                    Console.WriteLine("Page {0} Loan IDs: ", page);
                    foreach (var loanInfo in resp)
                    {
                        var fieldinfo = ((JObject)loanInfo.Fields).ToDictionary<string>();
                        Console.WriteLine("Loan ID: {0}", loanInfo.LoanGuid);
                        Console.WriteLine("Loan Last Modified: {0}", fieldinfo["Loan.LastModified"]);
                    }
                    start += 10;
                    page++;
                }
            }
        }

        /// <summary>
        /// Example: Create Custom Data Object(CDO)
        /// </summary>
        private static void CreateCDO()
        {
            Console.Write("Enter CDO Name  : ");
            var cdoName = Console.ReadLine();

            Console.Write("Enter File Path : ");
            var filePath = Console.ReadLine() ?? "";

            Console.Write("Enter Loan Id   : ");
            var loanId = Console.ReadLine();
            var cdoApiClient = ApiClientProvider.GetApiClient<LoanCustomDataObjectsApi>(_accessToken);
            var request = new LoanCustomDataObjectContract
            {
                Name = cdoName,
                DataObject = File.ReadAllBytes(filePath)
            };
            var response = cdoApiClient.CreateLoanCustomDataObject(loanId, cdoName, request);
            //Code for handling the response
            Console.WriteLine(response?.Name);
        }

        /// <summary>
        /// Example: Update CDO
        /// </summary>
        private static void UpdateCDO()
        {
            Console.Write("Enter CDO Name: ");
            var cdoName = Console.ReadLine();

            Console.Write("Enter Loan Id : ");
            var loanId = Console.ReadLine();
            var cdoApiClient = ApiClientProvider.GetApiClient<LoanCustomDataObjectsApi>(_accessToken);
            //Demonstrating to update value with plain string as well
            var request = new LoanCustomDataObjectContract
            {
                Name = cdoName,
                DataObject = Encoding.ASCII.GetBytes("This is a test value [Updated].")
            };
            var response = cdoApiClient.AppendLoanCustomDataObject(loanId, cdoName, request);
            //Code for handling the response
            Console.WriteLine(response.Name);
        }

        /// <summary>
        /// Example: Append CDO
        /// </summary>
        private static void AppendCDO()
        {
            Console.Write("Enter CDO Name: ");
            var cdoName = Console.ReadLine();

            Console.Write("Enter Loan Id : ");
            var loanId = Console.ReadLine();
            var cdoApiClient = ApiClientProvider.GetApiClient<LoanCustomDataObjectsApi>(_accessToken);
            var request = new LoanCustomDataObjectContract
            {
                Name = cdoName,
                DataObject = Encoding.ASCII.GetBytes("This is a test value [appended].")
            };
            var response = cdoApiClient.AppendLoanCustomDataObject(loanId, cdoName, request);
            //Code for handling the response
            Console.WriteLine(response?.ToJson());
            Console.WriteLine("CDO Appended.");
        }

        /// <summary>
        /// Example: Get specific CDO
        /// </summary>
        private static void GetCDO()
        {
            Console.Write("Enter CDO Name: ");
            var cdoName = Console.ReadLine();

            Console.Write("Enter Loan Id : ");
            var loanId = Console.ReadLine();
            var cdoApiClient = ApiClientProvider.GetApiClient<LoanCustomDataObjectsApi>(_accessToken);
            var response = cdoApiClient.GetLoanCustomDataObject(loanId, cdoName);
            //Code for handling the response
            // Console.WriteLine(response.Name);
            Console.WriteLine();
            Console.WriteLine(response?.ToJson());
            Console.WriteLine();
            Console.WriteLine("CDO retrieved successfully.");
        }

        /// <summary>
        /// Example: Get specific CDO
        /// </summary>
        private static void GetListOfCDOs()
        {
            Console.Write("Enter Loan Id : ");
            var loanId = Console.ReadLine();
            var cdoApiClient = ApiClientProvider.GetApiClient<LoanCustomDataObjectsApi>(_accessToken);
            var response = cdoApiClient.GetLoanCustomDataObjects(loanId);

            //Code for handling the response
            response.ForEach(i => Console.WriteLine("{0}\t", i));
            Console.WriteLine();
            Console.WriteLine("Retrived list of CDOs");
        }

        /// <summary>
        /// Example: Update CDO
        /// </summary>
        private static void DeleteCDO()
        {
            Console.Write("Enter CDO Name: ");
            var cdoName = Console.ReadLine();

            Console.Write("Enter Loan Id : ");
            var loanId = Console.ReadLine();
            var cdoApiClient = ApiClientProvider.GetApiClient<LoanCustomDataObjectsApi>(_accessToken);
            cdoApiClient.DeleteLoanCustomDataObject(loanId, cdoName);
            Console.WriteLine("CDO Deleted");
        }
    }
}
