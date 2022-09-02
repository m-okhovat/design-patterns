namespace DesignPatterns.Compositions;

public class SalesAgent : SalesUnit
{
    public int Credit { get; private set; }

    public override void PayCommission(int amount)
    {
        Credit += amount;
    }
}