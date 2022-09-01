namespace DesignPatterns.CompositeSpecification;

public  interface ISpecification<in T>
{
    bool IsSatisfy(T input);
}