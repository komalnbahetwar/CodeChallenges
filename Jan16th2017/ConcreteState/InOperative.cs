using Jan16th2017.ConcreteElement;
using Jan16th2017.State;
using System;

namespace Jan16th2017.ConcreteState
{
    /// <summary>
    /// A ConcreteState Class
    /// <remarks>
    /// InOperative indicates that account is in In-Operative state
    /// </remarks>
    /// </summary>
    public class InOperative : AccountState
    {
        public InOperative(Account account)
        {
            this.account = account;
        }

        public override AccountState Deposit(Action deposit)
        {
            account.AccountState = new Active(this);
            return account.AccountState;
        }

        public override AccountState WithDraw(Action withDraw)
        {
            account.AccountState = new Active(this);
            return account.AccountState;
        }

        public override AccountState BalanceEnquiry(Action balanceEnquiry)
        {
            balanceEnquiry();
            return this;
        }

        public override decimal CalculateInterest(decimal interestPercent)
        {
            return 0;
        }
    }
}
