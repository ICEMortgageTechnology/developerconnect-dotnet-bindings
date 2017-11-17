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

using System;
using Elli.Api.Base;

namespace Elli.Api.Examples.Token.ResourceOwner
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Please make a selection:");
                Console.WriteLine("1: Borrower Login");
                Console.WriteLine("2: Admin Login");
                Console.WriteLine("3: Exit");
                Console.Write("Enter your choice: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            BorrowerLogin();
                            break;
                        case 2:
                            LenderLogin();
                            break;
                        case 3:
                            return;
                    }
                }
            } while (true);
        }

        /// <summary>
        /// Example: Lender and Admin Login
        /// </summary>
        private static void LenderLogin()
        {
            //Taking in required values
            Console.Write("Instance ID : ");
            var instanceId = Console.ReadLine();
            Console.Write("User Name   : ");
            var userName = Console.ReadLine();
            Console.Write("Password    : ");
            var password = Console.ReadLine();
            try
            {
                //Calling method to get access token using Resource Owner Flow
                //User name transformation: username format accepted by the API is <username>@encompass:<instanceId>
                var credentials = new UserCredential
                {
                    Password = password,
                    IdentityType = IdentityType.Lender,
                    InstanceId = instanceId,
                    UserName = userName
                };
                var accessToken = AccessToken.GetAccessToken(credentials);
                Console.WriteLine("Your access token is: {0}", accessToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while processing your request: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Press enter to exit");
                Console.Read();
            }
        }

        /// <summary>
        /// Example: Borrower Login
        /// </summary>
        private static void BorrowerLogin()
        {
            //Taking in required values
            Console.Write("Site Id    : ");
            var siteId = Console.ReadLine();
            Console.Write("User Name  : ");
            var userName = Console.ReadLine();
            Console.Write("Password   : ");
            var password = Console.ReadLine();
            try
            {
                //Calling method to get access token using Resource Owner Flow
                var credentials = new UserCredential
                {
                    Password = password,
                    IdentityType = IdentityType.Borrower,
                    SiteId = siteId,
                    UserName = userName
                };
                var accessToken = AccessToken.GetAccessToken(credentials);
                Console.WriteLine("Your access token is: {0}", accessToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while processing your request: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Press enter to exit");
                Console.Read();
            }
        }
    }
}
