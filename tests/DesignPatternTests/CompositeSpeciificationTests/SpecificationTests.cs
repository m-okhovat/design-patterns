using DesignPatterns;
using DesignPatterns.CompositeSpecification;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace DesignPatternTests;

public class SpecificationTests
{
    [Fact]
    public void And_specification()
    {
        var biggerThan5Specification = new BiggerThan5Specifications();
        var lessThan10Specification = new LessThan10Specifications();
        var andSpecification = new AndSpecification<int>(biggerThan5Specification, lessThan10Specification);

        var isSatisfy = andSpecification.IsSatisfy(6);
        
        Assert.True(isSatisfy);
    }

    [Fact]
    public void Or_specification()
    {
        var biggerThan5Specification = new BiggerThan5Specifications();
        var lessThan10Specification = new LessThan10Specifications();
        var orSpecification = new OrSpecification<int>(biggerThan5Specification, lessThan10Specification);

        var biggerThanFive = orSpecification.IsSatisfy(11);
        
        Assert.True(biggerThanFive);
    }

    [Fact]
    public void Nested_And_Specifications()
    {
        var spec = 
            new BiggerThan5Specifications().And(new LessThan10Specifications());

        var isSatisfy = spec.IsSatisfy(8);
        
        Assert.True(isSatisfy);
    }

    [Fact]
    public void Fluent_or_specifications()
    {
        var spec = new BiggerThan5Specifications()
            .And(new LessThan10Specifications().Not());
        
        Assert.False(spec.IsSatisfy(7));
        Assert.True(spec.IsSatisfy(12));
    }
}