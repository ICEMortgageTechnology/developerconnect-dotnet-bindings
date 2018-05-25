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
 *  1. CREATE A LOAN BASED ON TEMPLATE
 */


using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security;
using Elli.Api.Base;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Model;

namespace Ellie.Api.Examples.Loans
{
    public static class UseCase4
    {
        //Static access token is just for the example. This could be instantiated for each user individually in the same way.
        private static AccessToken _accessToken;

        public static void Execute()
        {
            Authenticate();
            do
            {
                Console.Clear();
                Console.WriteLine("Please make a selection:");
                Console.WriteLine(" 1: Create a Loan using Template");
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
                                CreateLoan();
                                break;
                            case 99:
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
        }

        /// <summary>
        /// Example: Create Loan
        /// Template path can be found in Encompass smart client
        /// </summary>
        private static void CreateLoan()
        {
            var correctVal = false;
            Console.Write("Loan Template Path : ");
            var templatePath = Console.ReadLine();
            double loanAmt = 0;
            Console.Write("Enter Loan Amount  : ");
            while (!correctVal)
            {
                correctVal = double.TryParse(Console.ReadLine(), out loanAmt);
                if (!correctVal)
                    Console.Write("Please enter a valid number: ");
            }
            //Creating the request object with some sample data
            var loan = new LoanContract
            {
                BorrowerRequestedLoanAmount = loanAmt,
                Applications = new List<LoanContractApplications>()
            };

            var application = new LoanContractApplications
            {
                Borrower = new LoanContractBorrower
                {
                    FirstName = "John",
                    LastName = "Doe"
                }
            };
            loan.Applications.Add(application);
            //Initializing the API Client*/
            var loanApiClient = ApiClientProvider.GetApiClient<LoansApi>(_accessToken);
            //Example: Reading the loan id for the created loan using Location header
            var resp = loanApiClient.CreateLoanWithHttpInfo("My Pipeline", templatePath, null, "id", loan);
            Console.WriteLine("Loan Created. New loan id is: {0}", resp.Headers["Location"]);
        }
    }
}