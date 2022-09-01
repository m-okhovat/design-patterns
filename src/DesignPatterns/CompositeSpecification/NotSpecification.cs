namespace DesignPatterns.CompositeSpecification;

public class NotSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _specification;

    public NotSpecification(ISpecification<T> specification)
    {
        _specification = specification;
    }

    public bool IsSatisfy(T input)
    {
        return !_specification.IsSatisfy(input);
    }
}