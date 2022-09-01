namespace DesignPatterns.Visitors;

public interface IVisitable
{
    public void AcceptVisitor(IVisitor visitor);
}