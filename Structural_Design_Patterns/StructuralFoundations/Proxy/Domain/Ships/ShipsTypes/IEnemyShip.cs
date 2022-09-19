namespace Structural_Design_Patterns.StructuralFoundations.Proxy.Domain.Ships.ShipsTypes
{
    public interface IEnemyShip
    {
        bool IsApplicable(ShipsType shipsType);
        string Name { get; }
    }
}
