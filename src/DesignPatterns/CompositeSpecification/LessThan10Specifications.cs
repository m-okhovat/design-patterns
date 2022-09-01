namespace DesignPatterns.CompositeSpecification;

public class LessThan10Specifications  : ISpecification<int>
{
    public bool IsSatisfy(int input)
    {
        return input < 10;
    }
}