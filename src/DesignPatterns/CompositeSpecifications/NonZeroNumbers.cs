using DesignPatterns.CompositeSpecifications.BaseSpecifications;

namespace DesignPatterns.CompositeSpecifications;

public class NonZeroNumbers: Specification<int>
{
    public override bool IsSatisfiedBy(int entity)
    {
        return entity != 0;
    }
}