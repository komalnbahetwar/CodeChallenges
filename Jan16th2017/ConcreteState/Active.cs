using Jan16th2017.ConcreteElement;
using Jan16th2017.State;
using System;

namespace Jan16th2017.ConcreteState
{
    /// <summary>
    /// A ConcreteState Class
    /// <remarks>
    /// Active indicates that account is in working state
    /// </remarks>
    /// </summary>
    public class Active : AccountState
    {
        public Active(AccountState accountState) :
            this(accountState.Account)
        {
        }

        public Active(Account account)
        {
            this.account = account;
        }

        public override AccountState Deposit(Action deposit)
        {
            deposit();
            return this;
        }

        public override AccountState WithDraw(Action withDraw)
        {
            withDraw();
            return this;
        }

        public override AccountState BalanceEnquiry(Action balanceEnquiry)
        {
            balanceEnquiry();
            return this;
        }

        public override decimal CalculateInterest(decimal interestPercent)
        {
            return (interestPercent * this.account.BalanceAmount) / 100;
        }
    }
}
