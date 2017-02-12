using Jan16th2017.Visitor;

namespace Jan16th2017.Element
{
    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor, Transaction.Transaction transaction);
    }
}
