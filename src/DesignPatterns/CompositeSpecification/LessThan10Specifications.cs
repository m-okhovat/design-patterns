namespace DesignPatterns.CompositeSpecification;

public class LessThan10Specifications  : Specification<int>
{
    public override bool IsSatisfiedBy(int input)
    {
        return input < 10;
    }
}