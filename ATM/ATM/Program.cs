using System;
using ATM;
using Program = ATM.Program;

namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Blue Flame Bank");
            UserInterface();
        }
        
        public static decimal balance = 0m;

        public static decimal ViewBalance()
        {
            return balance;
        }

        public static decimal Withdraw(decimal balance)
        {
            
            if (balance - balance  < 0) 
            {
                return balance;
            }
            else
            {
                return balance -= balance;
            }   
        }
         
        public static decimal Deposit(decimal balance)
        {
            // if amount < 0
            //else balance += amount

            if (balance <= 0)
            {
                return balance;
            }
            else
            {
                return balance += balance;
            }
        }

        public static void UserInterface()
        {
            Console.WriteLine("Blue Flame");
            string choice = " ";

            while (choice != "Exit")
            {

                //Console.WriteLine(ViewBalance());
                //Console.WriteLine(Deposit());
                //Console.WriteLine(ViewBalance());
                //Console.WriteLine(Withdraw());
                //Console.WriteLine(ViewBalance());

                //Console.WriteLine("What can we assist you with today?");
                //Console.WriteLine("1. Check Balance, 2. Withdraw Funds, 3. Deposit Funds");

                switch (choice)
                {
                    case "1":
                        decimal balance = ViewBalance();
                        Console.WriteLine("New Balance");
                        break;
                    
                    case "2":
                        Console.WriteLine("Amount To Withdraw");
                        string withdrawAmountInput = Console.ReadLine();
                        decimal withdrawAmount;
                        
                        if (decimal.TryParse(withdrawAmountInput, out withdrawAmount))
                        {
                            if (withdrawAmount > ViewBalance())
                            {
                                Console.WriteLine("You're Broke");
                                break;
                            }
                            decimal updatedBalance = Withdraw(withdrawAmount);
                            if (updatedBalance != -1)
                                Console.WriteLine("Withdrawn" + withdrawAmount + "Updated Balance" + updatedBalance);
                            else 
                                Console.WriteLine("You're Broke");
                        }
                        else
                        {
                            Console.WriteLine("Amount Not Valid");
                        }
                        break;
                    
                    case "3":
                        Console.WriteLine("Deposit Amount");
                        string depositAmountInput = Console.ReadLine();
                        decimal depositAmount;
                        
                        if (decimal.TryParse(depositAmountInput, out depositAmount))
                        {
                            decimal updatedBalance = Deposit(depositAmount);
                            if (updatedBalance != -1)
                                Console.WriteLine("Deposited" + depositAmount + "Updated Balance" + updatedBalance);
                            else
                                Console.WriteLine("Amonut Not Valid");
                        }
                        else
                        {
                            Console.WriteLine("Amount Not Valid");
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Exiting Application");
                        break;
                    default:
                        Console.WriteLine("Choice Not Valid");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}