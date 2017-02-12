namespace Jan16th2017.ConcreteTransaction
{
    public class BalanceEnquiry : Transaction.Transaction
    {
        public override decimal GetBalanceAmount(decimal cashBackAmount, decimal minimumBalance, decimal penalty)
        {
            return BalanceAmount;
        }

        public override decimal GetCashBackAmount(decimal cashBackPercent)
        {
            return 0;
        }
    }
}
