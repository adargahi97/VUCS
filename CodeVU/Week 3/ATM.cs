using System;
using System.Collections.Generic;
using System.Text;

namespace Week_3
{
    internal class ATM
    {
        static void ATM_main(string[] args)
        {
            int accNum = 12345;
            int pin = 12345;

            int userAcc = 0, userPin = 0, userSelection = 0;
            double toDeposit = 0, toWithdrawal = 0, balance = 0;


            while (userAcc != accNum)
            {
                Console.WriteLine("Please enter your account number: ");
                userAcc = int.Parse(Console.ReadLine());
            }
            while (userPin != pin)
            {
                Console.WriteLine("Please enter your pin number: ");
                userPin = int.Parse(Console.ReadLine());
            }


            while (userSelection != 4)
            {
                Console.WriteLine("\n------------------ Menu ------------------");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Please enter a number to select an action:\n1. Deposit\n2. Withdrawal\n3. Display Account Balance\n4. Exit");
                userSelection = int.Parse(Console.ReadLine());

                if (userSelection == 1)
                {
                    Console.WriteLine("Please enter the amount to deposit: ");
                    toDeposit = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n${0} has been depositied into account number {1}", toDeposit, userAcc);
                    balance += toDeposit;
                    Console.WriteLine("\nCurrent balance for account: {0} is ${1}", userAcc, balance);
                    Console.WriteLine(" ");


                }
                else if (userSelection == 2)
                {
                    Console.WriteLine("Please enter the amount to Withdrawal");
                    toWithdrawal = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n${0} has been withdrawn from account number {1}", toWithdrawal, userAcc);
                    balance -= toWithdrawal;
                    Console.WriteLine("\nCurrent balance for account: {0} is ${1}", userAcc, balance);
                    Console.WriteLine(" ");
                }
                else if (userSelection == 3)
                {
                    Console.WriteLine("\nCurrent balance for account: {0} is ${1}", userAcc, balance);
                    Console.WriteLine(" ");
                }
                else if (userSelection == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid selection");
                }

            }
        }
    }
}
