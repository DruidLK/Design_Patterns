using Structural_Design_Patterns.StructuralFoundations.Proxy.Domain.Ships.ShipsTypes;

namespace Structural_Design_Patterns.StructuralFoundations.Proxy.Domain.Ships
{
    public sealed class Rocket : IEnemyShip
    {
        public bool IsApplicable(ShipsType shipsType) =>
            shipsType.Equals(ShipsType.Rocket);
        public string Name =>
            nameof(Rocket);
    }
}
