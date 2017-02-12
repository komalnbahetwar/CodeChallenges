using Jan16th2017.ConcreteState;
using Jan16th2017.ConcreteTransaction;
using Jan16th2017.ConcreteVisitor;
using Jan16th2017.State;
using Jan16th2017.Visitor;

namespace Jan16th2017.ConcreteElement
{
    public class Account : Element.Element
    {
        public Account(string accountType, string accountState, long balance)
        {
            this.AccountType = accountType;
            this.AccountState = GetAccountState(accountState);
            this.BalanceAmount = balance;
        }

        public string AccountType { get; set; }

        public IVisitor AccountTypeVisitor { get; set; }

        public AccountState AccountState { get; set; }

        public decimal BalanceAmount { get; set; }

        public decimal CashBackAmount { get; set; }

        public decimal InterestAmount { get; set; }

        public override void Accept(IVisitor visitor, Transaction.Transaction transaction)
        {
            visitor.Visit(this, transaction);
        }

        public void Deposit(decimal amount)
        {
            this.AccountTypeVisitor = GetAccountTypeVisitor(AccountType);
            this.AccountState = this.AccountState.Deposit(() =>
            {
                this.Accept(AccountTypeVisitor, new Deposit(amount));
            });
        }

        public void WithDraw(decimal amount)
        {
            this.AccountTypeVisitor = GetAccountTypeVisitor(AccountType);
            this.AccountState = this.AccountState.WithDraw(() =>
            {
                this.Accept(AccountTypeVisitor, new Withdraw(amount));
            });
        }

        public void BalanceEnquiry()
        {
            this.AccountTypeVisitor = GetAccountTypeVisitor(AccountType);
            this.AccountState = this.AccountState.BalanceEnquiry(() =>
            {
                this.Accept(AccountTypeVisitor, new BalanceEnquiry());
            });
        }

        /// <summary>
        /// Get Account Type based on string
        /// </summary>
        /// <param name="accountType"></param>
        /// <returns></returns>
        private IVisitor GetAccountTypeVisitor(string accountType)
        {
            switch (accountType.ToLower())
            {
                case "gold":
                    return new GoldAccountVisitor();
                case "diamond":
                    return new DiamondAccountVisitor();
                default:
                    return new PlatinumAccountVisitor();
            }
        }

        /// <summary>
        /// Get Account State based on string
        /// </summary>
        /// <param name="accountState"></param>
        /// <returns></returns>
        private AccountState GetAccountState(string accountState)
        {
            switch (accountState.ToLower())
            {
                case "active":
                    return new Active(this);
                case "closed":
                    return new Closed(this);
                default:
                    return new InOperative(this);
            }
        }
    }
}
