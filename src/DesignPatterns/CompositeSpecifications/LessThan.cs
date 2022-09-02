using DesignPatterns.CompositeSpecifications.BaseSpecifications;
using DesignPatterns.Visitors;

namespace DesignPatterns.CompositeSpecifications;

public class LessThan  : Specification<int>
{
    private readonly int _number;

    public LessThan(int number)
    {
        this._number = number;
    }

    public override bool IsSatisfiedBy(int input)
    {
        return input < _number;
    }

    public override void AcceptVisitor(ISpecificationVisitor<int> specificationVisitor)
    {
        specificationVisitor.Visit(this);
    }
}