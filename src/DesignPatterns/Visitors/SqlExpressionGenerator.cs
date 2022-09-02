using System.Text;
using DesignPatterns.CompositeSpecifications;
using DesignPatterns.CompositeSpecifications.BaseSpecifications;

namespace DesignPatterns.Visitors;

public class SqlExpressionGenerator<T> : ISpecificationVisitor<T>
{
    private readonly StringBuilder _queryBuilder = new StringBuilder();  
    
    public void Visit(AndSpecification<T> entity)
    {
        _queryBuilder.Append(' ')
            .Append("AND")
            .Append(' ');
    }

    public void Visit(OrSpecification<T> entity)
    {
        _queryBuilder.Append(' ')
            .Append("OR")
            .Append(' ');
    }

    public void Visit(NotSpecification<T> entity)
    {
        _queryBuilder.Append(' ')
            .Append("!");
    }

    public void Visit(EvenNumbers entity)
    {
        _queryBuilder.Append(" % 2 == 0 ");
    }

    public void Visit(PositiveNumbers entity)
    {
        _queryBuilder.Append(" > 0 ");
    }

    public void Visit(NonZeroNumbers entity)
    {
        _queryBuilder.Append(" != 0 ");
    }

    public void Visit(BiggerThan entity)
    {
        throw new NotImplementedException();
    }

    public void Visit(LessThan entity)
    {
        throw new NotImplementedException();
    }

    public string GetQuery()
    {
        return _queryBuilder.ToString();
    }
}