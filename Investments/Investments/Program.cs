// Investments
// Written by Bryce Graham
// CS 1182
// Calculate the future and present values of investments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investments
{
    class Program
    {
        static void Main(string[] args)
        {
            double futureInvestmentValue;
            double presentInvestmentValue;

            int choice;

            do // Runs program until the user inputs 3
            {
                choice = menu();

                if (choice == 1)
                {
                    futureInvestmentValue = futureInvestment();

                    futureInvestmentValue = Math.Round(futureInvestmentValue, 2);

                    Console.WriteLine("Future Value is " + futureInvestmentValue.ToString("C"));
                }
                else
                {
                    if (choice == 2)
                    {
                        presentInvestmentValue = presentValue();

                        presentInvestmentValue = Math.Round(presentInvestmentValue, 2);

                        Console.WriteLine("Present Value is " + presentInvestmentValue.ToString("C"));
                    }
                }
            }
            while (choice != 3);

        }

        public static int menu() // Allow user to enter a choice from a menu
        {
            string choiceInput;
            int choice;

            Console.WriteLine("1. Future Value");
            Console.WriteLine("2. Present Value");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            do  // choice validation
            {
                choiceInput = Console.ReadLine();

                if(int.TryParse(choiceInput, out choice))
                {
                    if(choice < 1 || choice > 3)
                    {
                        Console.Write("Invalid - try again: ");
                    }
                }
                else
                {
                    Console.Write("Invalid - try again: ");
                }

            }while (choice < 1 || choice > 3);

            return choice;
        }

        public static double futureInvestment() //receive input and calculate the future investment
        {
            double futureInvestmentValue;
            double monthlyRate;
            double periods;
            string rateInput;
            double rate;
            string yearsInput;
            double years;
            string amountInput;
            double amount;

            Console.WriteLine("Future value of investment amount today");
            Console.Write("Enter Rate between 2.75 and 12.25: ");

            do //validation for rate
            {
                rateInput = Console.ReadLine();

                if(double.TryParse(rateInput, out rate))
                {
                    if (rate < 2.75 || rate > 12.25)
                    {
                        Console.Write("Invalid - try again: ");
                    }
                }
                else
                {
                    Console.Write("Invalid - try again: ");
                }
                
            } while (rate < 2.75 || rate > 12.25);

            Console.Write("Enter Years between 5 and 30: ");

            do //validation for years
            {
                yearsInput = Console.ReadLine();

                if (double.TryParse(yearsInput, out years))
                {
                    if (years < 5 || years > 30)
                    {
                        Console.Write("Invalid - try again: ");
                    }
                }
                else
                {
                    Console.Write("Invalid - try again: ");
                }

            } while (years < 5 || years > 30);

            Console.Write("Enter Amount between 10 and 20000: ");

            do //validation for amount
            {
                amountInput = Console.ReadLine();

                if (double.TryParse(amountInput, out amount))
                {
                    if (amount < 10 || amount > 20000)
                    {
                        Console.Write("Invalid - try again: ");
                    }
                }
                else
                {
                    Console.Write("Invalid - try again: ");
                }

            } while (amount < 10 || amount > 20000);

            periods = years * 12; // Calculation of future value
            monthlyRate = 1 + rate / (double) 1200;
            futureInvestmentValue = Math.Pow(monthlyRate, periods);
            futureInvestmentValue = amount * futureInvestmentValue;

            return futureInvestmentValue;
        }

        public static double presentValue() // Receive input and calculate the present value
        {
            Console.Write("Present value of investment for a given future amount");

            double monthlyRate;
            double periods;
            string rateInput;
            double rate;
            string yearsInput;
            double years;
            string amountInput;
            double amount;

            Console.WriteLine("Future value of investment amount today");
            Console.Write("Enter Rate between 2.75 and 12.25: ");

            do //validation for rate
            {
                rateInput = Console.ReadLine();

                if (double.TryParse(rateInput, out rate))
                {
                    if (rate < 2.75 || rate > 12.25)
                    {
                        Console.Write("Invalid - try again: ");
                    }
                }
                else
                {
                    Console.Write("Invalid - try again: ");
                }

            } while (rate < 2.75 || rate > 12.25);

            Console.Write("Enter Years between 5 and 30: ");

            do //validation for years
            {           
                yearsInput = Console.ReadLine();

                if (double.TryParse(yearsInput, out years))
                {
                    if (years < 5 || years > 30)
                    {
                        Console.Write("Invalid - try again: ");
                    }
                }
                else
                {
                    Console.Write("Invalid - try again: ");
                }

            } while (years < 5 || years > 30);

            Console.Write("Enter Amount between 10 and 20000: ");

            do //validation for amount
            {
                amountInput = Console.ReadLine();

                if (double.TryParse(amountInput, out amount))
                {
                    if (amount < 10 || amount > 20000)
                    {
                        Console.Write("Invalid - try again: ");
                    }
                }
                else
                {
                    Console.Write("Invalid - try again: ");
                }

            } while (amount < 10 || amount > 20000);

            monthlyRate = 1 + rate / (double)1200; // Calculation of present value
            periods = years * 12;

            double presentInvestmentValue = amount / Math.Pow(monthlyRate, periods);

            return presentInvestmentValue;
        }
    }
}
