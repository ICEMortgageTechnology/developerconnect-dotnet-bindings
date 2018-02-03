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
 * This program illustrates various operations on loan at various stages of loan life cycle.
 * This example is designed as an interactive console application. User can select corresponding number to perform specific 
 * operation. 
 */ 

using System;

namespace Ellie.Api.Examples.Loans
{
    class Program
    {


        static void Main()
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.ServicePointManager.SecurityProtocol | System.Net.SecurityProtocolType.Tls12;
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("ENCOMPASS DEVELOPER CONNECT");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("This sample application provides a way to perform operations on a loan.");
                Console.WriteLine("Please make a selection:");
                Console.WriteLine(" 1: Use Case 1: Loan Operations");
                Console.WriteLine(" 2: Use Case 2: Pipeline and Custom Data Objects");
                Console.WriteLine(" 3: Use Case 3: Batch Processing");
                Console.WriteLine(" 4: Use Case 4: Working With Templates");
                Console.WriteLine("99: Exit");
                Console.Write("Enter your choice: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            UseCase1.Execute();
                            break;
                        case 2:
                            UseCase2.Execute();
                            break;
                        case 3:
                            UseCase3.Execute();
                            break;
                        case 4:
                            UseCase4.Execute();
                            break;
                        case 99:
                            return;
                    }
                }
            } while (true);
        }
    }
}