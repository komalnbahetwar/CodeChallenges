using Jan16th2017.ConcreteElement;
using System;

namespace Jan16th2017.State
{
    public abstract class AccountState
    {
        protected Account account;

        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public abstract AccountState Deposit(Action deposit);
        public abstract AccountState WithDraw(Action withDraw);
        public abstract AccountState BalanceEnquiry(Action balanceEnquiry);

        public abstract decimal CalculateInterest(decimal interest);
    }
}
