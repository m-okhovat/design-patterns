using DesignPatterns.CompositeSpecifications.BaseSpecifications;

namespace DesignPatterns.CompositeSpecifications;

public class BiggerThan  : Specification<int>
{
    private readonly int _number;

    public BiggerThan(int number)
    {
        _number = number;
    }

    public override bool IsSatisfiedBy(int input)
    {
        return input > _number;
    }
}