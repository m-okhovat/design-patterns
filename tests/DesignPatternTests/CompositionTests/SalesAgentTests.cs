using DesignPatterns.Compositions;

namespace SpecificationRTests.CompositionTests;

public class SalesAgentTests
{
    [Fact]
    public void Pay_salesGroup_commissions()
    {
        var sadeq = new SalesAgent();
        var reza = new SalesAgent();
        var ahmad = new SalesAgent();
        var salesGroup = new SalesGroup(sadeq, reza, ahmad);
        
        salesGroup.PayCommission(300);
        
        Assert.Equal(100, sadeq.Credit);
        Assert.Equal(100, ahmad.Credit);
        Assert.Equal(100, reza.Credit);
    }
}