using DesignPatterns.CompositeSpecifications.BaseSpecifications;

namespace DesignPatterns.CompositeSpecifications;

public class LessThan  : Specification<int>
{
    private readonly int _number;

    public LessThan(int number)
    {
        this._number = number;
    }

    public override bool IsSatisfiedBy(int input)
    {
        return input < _number;
    }
}