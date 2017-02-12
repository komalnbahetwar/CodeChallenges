namespace Jan16th2017.ConcreteTransaction
{
    public class Withdraw : Transaction.Transaction
    {
        private readonly decimal _amount;

        public Withdraw(decimal amount)
        {
            this._amount = amount;
        }
        public override decimal GetBalanceAmount(decimal cashBackAmount, decimal minimumBalance, decimal penalty)
        {
            BalanceAmount -= _amount;
            if (BalanceAmount < minimumBalance)
            {
                BalanceAmount = BalanceAmount - penalty;
            }
            return BalanceAmount;
        }

        public override decimal GetCashBackAmount(decimal cashBackPercent)
        {
            return 0;
        }
    }
}
