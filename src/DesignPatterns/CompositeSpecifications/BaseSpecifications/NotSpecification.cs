using DesignPatterns.Visitors;

namespace DesignPatterns.CompositeSpecifications.BaseSpecifications;

public class NotSpecification<T> : Specification<T>
{
    private readonly Specification<T> _specification;

    public NotSpecification(Specification<T> specification)
    {
        _specification = specification;
    }

    public override bool IsSatisfiedBy(T input)
    {
        return !_specification.IsSatisfiedBy(input);
    }

    public override void AcceptVisitor(ISpecificationVisitor<T> specificationVisitor)
    {
        specificationVisitor.Visit(this);
        _specification.AcceptVisitor(specificationVisitor);
    }
}