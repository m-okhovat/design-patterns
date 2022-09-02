namespace DesignPatterns.Visitors;

public interface IVisitable<T>
{
    public void AcceptVisitor(ISpecificationVisitor<T> specificationVisitor);
}