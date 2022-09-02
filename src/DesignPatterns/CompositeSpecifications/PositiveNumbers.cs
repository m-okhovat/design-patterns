using DesignPatterns.CompositeSpecifications.BaseSpecifications;
using DesignPatterns.Visitors;

namespace DesignPatterns.CompositeSpecifications;

public class PositiveNumbers: Specification<int>
{
    public override bool IsSatisfiedBy(int entity)
    {
        return entity > 0;
    }

    public override void AcceptVisitor(ISpecificationVisitor<int> specificationVisitor)
    {
        specificationVisitor.Visit(this);
    }
}