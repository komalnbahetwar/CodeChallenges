namespace Jan16th2017.ConcreteTransaction
{
    public class Deposit : Transaction.Transaction
    {
        private readonly decimal _amount;

        public Deposit(decimal amount)
        {
            this._amount = amount;
        }

        public override decimal GetBalanceAmount(decimal cashBackAmount, decimal minimumBalance, decimal penalty)
        {
            BalanceAmount += _amount;
            BalanceAmount += cashBackAmount;
            if (BalanceAmount < minimumBalance)
            {
                BalanceAmount = BalanceAmount - penalty;
            }
            return BalanceAmount;
        }

        public override decimal GetCashBackAmount(decimal cashBackPercent)
        {
            return (cashBackPercent * _amount) / 100;
        }
    }
}
