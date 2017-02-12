using Jan16th2017.ConcreteElement;

namespace Jan16th2017.ConcreteVisitor
{
    public static class AccountVisitorHelper
    {
        public static void DoTransaction(Element.Element element, Transaction.Transaction transaction, decimal cashBackPercent, decimal interestPercent, decimal minimumBalance, decimal penalty)
        {
            Account account = element as Account;
            if (account != null)
            {
                transaction.BalanceAmount = account.BalanceAmount;

                decimal cashBackAmount = transaction.GetCashBackAmount(cashBackPercent);
                account.BalanceAmount = transaction.GetBalanceAmount(cashBackAmount, minimumBalance, penalty);
                account.BalanceAmount += account.AccountState.CalculateInterest(interestPercent);
                account.CashBackAmount += cashBackAmount;
            }
        }
    }
}
