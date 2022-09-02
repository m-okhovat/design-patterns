using DesignPatterns.Visitors;

namespace DesignPatterns.CompositeSpecifications.BaseSpecifications;

public class OrSpecification<T> : Specification<T>
{
    private readonly Specification<T> _left;
    private readonly Specification<T> _right;

    public OrSpecification(Specification<T> left, Specification<T> right)
    {
        _left = left;
        _right = right;
    }

    public override bool IsSatisfiedBy(T input)
    {
        return _left.IsSatisfiedBy(input) || _right.IsSatisfiedBy(input);
    }

    public override void AcceptVisitor(ISpecificationVisitor<T> specificationVisitor)
    {
        _left.AcceptVisitor(specificationVisitor);
        specificationVisitor.Visit(this);
        _right.AcceptVisitor(specificationVisitor);
    }
}