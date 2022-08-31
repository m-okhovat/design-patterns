using System.Linq.Expressions;

namespace DesignPatterns;

public  interface ISpecification<in T>
{
    bool IsSatisfy(T input);
}