namespace DesignPatterns.CompositeSpecification;

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _right;
    private readonly ISpecification<T> _left;

    public AndSpecification(ISpecification<T> right, ISpecification<T> left)
    {
        _right = right;
        _left = left;
    }

    public bool IsSatisfy(T input)
    {
        return _right.IsSatisfy(input) && _left.IsSatisfy(input);
    }
}