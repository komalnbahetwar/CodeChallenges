using Jan16th2017.Visitor;
namespace Jan16th2017.ConcreteVisitor
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class GoldAccountVisitor : IVisitor
    {
        private decimal CashBackPercent = 1;
        private decimal InterestPercent = 3;
        private decimal MinimumBalance = 0;
        private decimal Penalty = 0;

        public void Visit(Element.Element element, Transaction.Transaction transaction)
        {
            AccountVisitorHelper.DoTransaction(element, transaction, CashBackPercent, InterestPercent, MinimumBalance, Penalty);
        }
    }
}
