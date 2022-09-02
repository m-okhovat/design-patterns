using DesignPatterns.Visitors;

namespace DesignPatterns.CompositeSpecifications.BaseSpecifications;
public abstract class Specification<T> : ISpecification<T>, IVisitable<T>
{
    public Specification<T> And(Specification<T> right)
    {
        return new AndSpecification<T>(this, right);
    }

    public Specification<T> Or(Specification<T> right)
    {
        return new OrSpecification<T>(this, right);
    }

    public Specification<T> Not()
    {
        return new NotSpecification<T>(this);
    }

    public abstract bool IsSatisfiedBy(T entity);
    public abstract void AcceptVisitor(ISpecificationVisitor<T> specificationVisitor);

}

