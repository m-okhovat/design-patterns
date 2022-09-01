namespace DesignPatterns.CompositeSpecification;

public class OrSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _left;
    private readonly ISpecification<T> _right;

    public OrSpecification(ISpecification<T> left, ISpecification<T> right)
    {
        _left = left;
        _right = right;
    }

    public bool IsSatisfy(T input)
    {
        return _left.IsSatisfy(input) || _right.IsSatisfy(input);
    }
}