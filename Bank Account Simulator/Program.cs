using System;

namespace BankSystem
{
    class BankAccount
    {
        public string AccountHolder;
        private float _balance = 0;
        public string userOption;

        public void Deposit()
        {
            Console.WriteLine("Enter how much you want to deposit:");
            try
            {
                userOption = Console.ReadLine();
                _balance += float.Parse(userOption);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input, please enter a valid number");
                Deposit();
            }
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter how much you want to deposit:");
            userOption = Console.ReadLine();
            _balance -= float.Parse(userOption);
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: £{_balance}");
        }

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            while (true)
            {
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                account.userOption = Console.ReadLine();
                if (account.userOption == "1")
                {
                    account.Deposit();
                }
                else if (account.userOption == "2")
                {
                    account.Withdraw();
                }
                else if (account.userOption == "3")
                {
                    account.CheckBalance();
                }
                else if (account.userOption == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again");
                }
            }
        }
    }
}