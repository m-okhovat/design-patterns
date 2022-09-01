using DesignPatterns.CompositeSpecifications.BaseSpecifications;

namespace DesignPatterns.CompositeSpecifications;

public class PositiveNumbers: Specification<int>
{
    public override bool IsSatisfiedBy(int entity)
    {
        return entity > 0;
    }
}