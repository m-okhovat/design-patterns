using DesignPatterns.CompositeSpecifications;
using DesignPatterns.CompositeSpecifications.BaseSpecifications;

namespace DesignPatterns.Visitors;

public  interface ISpecificationVisitor<T>
{
    public void Visit(AndSpecification<T> entity);
    public void Visit(OrSpecification<T> entity);
    public void Visit(NotSpecification<T> entity);
    public void Visit(EvenNumbers entity);

    void Visit(PositiveNumbers entity);
    void Visit(NonZeroNumbers entity);
    void Visit(BiggerThan entity);
    void Visit(LessThan entity);
}