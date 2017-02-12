namespace Jan16th2017.Visitor
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(Element.Element element, Transaction.Transaction deposit);
    }
}
