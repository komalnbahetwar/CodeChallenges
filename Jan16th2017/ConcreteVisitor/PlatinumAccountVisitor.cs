using Jan16th2017.Visitor;

namespace Jan16th2017.ConcreteVisitor
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class PlatinumAccountVisitor : IVisitor
    {
        private decimal CashBackPercent = 5;
        private decimal InterestPercent = 6;
        private decimal MinimumBalance = 25000;
        private decimal Penalty = 5000;
        public void Visit(Element.Element element, Transaction.Transaction transaction)
        {
            AccountVisitorHelper.DoTransaction(element, transaction, CashBackPercent, InterestPercent, MinimumBalance, Penalty);
        }
    }
}
