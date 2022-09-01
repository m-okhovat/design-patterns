namespace DesignPatterns.Visitors;

public  interface IVisitor
{
    public void Visit(IVisitable entity);
}


public class SqlExpressionGenerator : IVisitor
{
    public void Visit(IVisitable entity)
    {
        //...
    }
}


