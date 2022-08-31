using DesignPatterns;
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

}