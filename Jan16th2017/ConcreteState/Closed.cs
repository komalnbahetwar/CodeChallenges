using Jan16th2017.ConcreteElement;
using Jan16th2017.State;
using System;

namespace Jan16th2017.ConcreteState
{
    /// <summary>
    /// A ConcreteState Class
    /// <remarks>
    /// Closed indicates that account is in closed state
    /// </remarks>
    /// </summary>
    public class Closed : AccountState
    {
        public Closed(Account account)
        {
            this.account = account;
        }

        public override AccountState Deposit(Action deposit)
        {
            return this;
        }

        public override AccountState WithDraw(Action withDraw)
        {
            return this;
        }

        public override AccountState BalanceEnquiry(Action balanceEnquiry)
        {
            return this;
        }

        public override decimal CalculateInterest(decimal interestPercent)
        {
            return 0;
        }
    }
}
