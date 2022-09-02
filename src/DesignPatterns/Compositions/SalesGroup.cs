namespace DesignPatterns.Compositions;

public class SalesGroup : SalesUnit
{
    private List<SalesUnit> _salesUnits;

    public SalesGroup(List<SalesUnit> salesUnits)
    {
        _salesUnits = salesUnits;
    }

    public SalesGroup(params SalesUnit[] units) : this(units?.ToList())
    {
    }

    public override void PayCommission(int amount)
    {
        var singleCommission = amount / _salesUnits.Count;
        foreach (var salesUnit in _salesUnits)
        {
            salesUnit.PayCommission(singleCommission);
        }
    }
}