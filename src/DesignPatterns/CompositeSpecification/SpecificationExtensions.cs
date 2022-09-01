namespace DesignPatterns.CompositeSpecification;

public static class SpecificationExtensions
{
    public static ISpecification<T> And<T>(this ISpecification<T> spec, ISpecification<T> otherSpec)
    {
        return new AndSpecification<T>(spec, otherSpec);
    }
    
    public static ISpecification<T> Or<T>(this ISpecification<T> spec, ISpecification<T> otherSpec)
    {
        return new OrSpecification<T>(spec, otherSpec);
    }
    
    public static ISpecification<T> Not<T>(this ISpecification<T> spec)
    {
        return new NotSpecification<T>(spec);
    }
}