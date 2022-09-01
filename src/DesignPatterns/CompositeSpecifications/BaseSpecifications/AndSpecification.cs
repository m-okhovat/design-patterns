namespace DesignPatterns.CompositeSpecifications.BaseSpecifications;

public class AndSpecification<T> : Specification<T>
{
    private readonly ISpecification<T> _left;
    private readonly ISpecification<T> _right;

    public AndSpecification(ISpecification<T> right, ISpecification<T> left)
    {
        _right = right;
        _left = left;
    }

    public override bool IsSatisfiedBy(T input)
    {
        return _right.IsSatisfiedBy(input) && _left.IsSatisfiedBy(input);
    }
}