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
        _queryBuilder.Append(" > ");
    }

    public void Visit(LessThan entity)
    {
        _queryBuilder.Append(" < ");
    }

    public string GetQuery()
    {
        return _queryBuilder.ToString();
    }
}

public class PersianExpressionGenerator<T>: ISpecificationVisitor<T>
{
    private readonly StringBuilder _queryBuilder = new StringBuilder();
    public void Visit(AndSpecification<T> entity)
    {
        _queryBuilder.Append(" و ");
    }

    public void Visit(OrSpecification<T> entity)
    {
        _queryBuilder.Append(" یا ");
    }

    public void Visit(NotSpecification<T> entity)
    {
        _queryBuilder.Append(" نقیض ");
    }

    public void Visit(EvenNumbers entity)
    {
        _queryBuilder.Append(" زوج باشد ");
    }

    public void Visit(PositiveNumbers entity)
    {
        _queryBuilder.Append(" مثبت باشد ");

    }

    public void Visit(NonZeroNumbers entity)
    {
        _queryBuilder.Append(" مخالف صفر ");

    }

    public void Visit(BiggerThan entity)
    {
        _queryBuilder.Append(" بزرگتر از ");

    }

    public void Visit(LessThan entity)
    {
        _queryBuilder.Append(" کوچکتر باشد ");

    }

    public string GenerateExpressions()
    {
        var expressions = _queryBuilder.ToString();
        return expressions;
    }
}