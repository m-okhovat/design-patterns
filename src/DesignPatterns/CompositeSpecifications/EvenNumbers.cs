using DesignPatterns.CompositeSpecifications.BaseSpecifications;

namespace DesignPatterns.CompositeSpecifications;

public class EvenNumbers: Specification<int>
{
    public override bool IsSatisfiedBy(int entity)
    {
        return entity % 2 == 0;
    }
}