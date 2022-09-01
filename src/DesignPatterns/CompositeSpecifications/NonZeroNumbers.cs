using DesignPatterns.CompositeSpecifications.BaseSpecifications;
using DesignPatterns.Visitors;

namespace DesignPatterns.CompositeSpecifications;

public class NonZeroNumbers: Specification<int>, IVisitable   
{
    public override bool IsSatisfiedBy(int entity)
    {
        return entity != 0;
    }

    public void AcceptVisitor(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}