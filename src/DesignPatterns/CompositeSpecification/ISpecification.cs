namespace DesignPatterns.CompositeSpecification;

public  interface ISpecification<T>
{
    bool IsSatisfiedBy(T input);
}