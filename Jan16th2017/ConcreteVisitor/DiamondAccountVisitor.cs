using Jan16th2017.Visitor;

namespace Jan16th2017.ConcreteVisitor
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class DiamondAccountVisitor : IVisitor
    {
        private decimal CashBackPercent = 3;
        private decimal InterestPercent = 4;
        private decimal MinimumBalance = 5000;
        private decimal Penalty = 1000;
        public void Visit(Element.Element element, Transaction.Transaction transaction)
        {
            AccountVisitorHelper.DoTransaction(element, transaction, CashBackPercent, InterestPercent, MinimumBalance, Penalty);
        }
    }
}
