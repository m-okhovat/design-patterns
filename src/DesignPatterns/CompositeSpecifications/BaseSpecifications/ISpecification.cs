namespace DesignPatterns.CompositeSpecifications.BaseSpecifications;

public  interface ISpecification<T>
{
    bool IsSatisfiedBy(T input);
}