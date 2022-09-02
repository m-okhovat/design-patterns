using DesignPatterns.Visitors;

namespace DesignPatterns.CompositeSpecifications.BaseSpecifications;

public class AndSpecification<T> : Specification<T>
{
    private readonly Specification<T> _left;
    private readonly Specification<T> _right;

    public AndSpecification(Specification<T> right, Specification<T> left)
    {
        _right = right;
        _left = left;
    }

    public override bool IsSatisfiedBy(T input)
    {
        return _right.IsSatisfiedBy(input) && _left.IsSatisfiedBy(input);
    }

    public override void AcceptVisitor(ISpecificationVisitor<T> specificationVisitor)
    {
        _left.AcceptVisitor(specificationVisitor);
        specificationVisitor.Visit(this);
        _right.AcceptVisitor(specificationVisitor);
    }
    
}