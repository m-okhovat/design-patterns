using DesignPatterns.CompositeSpecifications.BaseSpecifications;

namespace DesignPatterns.CompositeSpecifications;

public class BiggerThan5Specifications  : Specification<int>
{
    public override bool IsSatisfiedBy(int input)
    {
        return input > 5;
    }
}