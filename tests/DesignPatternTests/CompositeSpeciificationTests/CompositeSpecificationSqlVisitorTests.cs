using DesignPatterns.CompositeSpecifications;
using DesignPatterns.Visitors;

namespace SpecificationRTests.CompositeSpecificationTests;

public class CompositeSpecificationSqlVisitorTests
{
    [Fact]
    public void Generate_sql_query()
    {
        var specification = new EvenNumbers().And(new PositiveNumbers());
        var sqlExpressionGenerator = new SqlExpressionGenerator<int>();
        
        specification.AcceptVisitor(sqlExpressionGenerator);
        var isSatisfiedBy = specification.IsSatisfiedBy(2);

        var query = sqlExpressionGenerator.GetQuery();
        Assert.True(isSatisfiedBy);
        
    }

    [Fact]
    public void Generate_persian_expressions()
    {
        var specification = new EvenNumbers().And(new PositiveNumbers());
        var persianExpressionGenerator = new PersianExpressionGenerator<int>();
        
        specification.AcceptVisitor(persianExpressionGenerator);
        var isSatisfiedBy = specification.IsSatisfiedBy(10);

        var query = persianExpressionGenerator.GenerateExpressions();
        Assert.True(isSatisfiedBy);

    }
}