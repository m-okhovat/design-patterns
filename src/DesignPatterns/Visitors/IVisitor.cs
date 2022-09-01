namespace DesignPatterns.Visitors;

public  interface IVisitor
{
    public void Visit(IVisitable entity);
}