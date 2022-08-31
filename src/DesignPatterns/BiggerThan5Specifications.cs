namespace DesignPatterns;

public class BiggerThan5Specifications  : ISpecification<int>
{
    public bool IsSatisfy(int input)
    {
        return input > 5;
    }
}