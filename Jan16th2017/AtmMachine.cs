using Jan16th2017.ConcreteElement;
using System;

namespace Jan16th2017
{
    /// <summary>
    /// This program implemets VISITOR AND STATE PATTERN.
    /// </summary>
    public class AtmMachine
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                string[] inputStrings = input.Split(',');
                string accountType = inputStrings[0].Trim();
                string accountState = inputStrings[1].Trim();
                long initialBalance = Convert.ToInt64(inputStrings[2].Trim());

                Account account = new Account(accountType, accountState, initialBalance);

                int len = inputStrings.Length, i = 3;
                while (i < len)
                {
                    if (inputStrings[i].ToLower().Contains("deposit"))
                    {
                        string[] depositStrs = inputStrings[i].Trim().Split();
                        account.Deposit(Convert.ToInt64(depositStrs[0]));
                    }
                    else if (inputStrings[i].ToLower().Contains("withdraw"))
                    {
                        string[] withDrawStrs = inputStrings[i].Trim().Split();
                        account.WithDraw(Convert.ToInt64(withDrawStrs[0]));
                    }
                    else if (inputStrings[i].ToLower().Contains("balanceenquiry"))
                    {
                        account.BalanceEnquiry();
                    }
                    else
                    {
                        //Account Type Changed
                        account.AccountType = inputStrings[i].Trim();
                    }
                    i++;
                }

                Console.WriteLine(account.CashBackAmount);
                Console.WriteLine(account.BalanceAmount);
            }
            Console.ReadKey();
        }
    }
}
