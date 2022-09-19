using Structural_Design_Patterns.StructuralFoundations.Proxy.Domain.Ships.ShipsTypes;

namespace Structural_Design_Patterns.StructuralFoundations.Proxy.Domain.Ships
{
    public sealed class UFO : IEnemyShip
    {
        public bool IsApplicable(ShipsType shipsType) =>
            shipsType.Equals(ShipsType.UFO);
        public string Name =>
            nameof(UFO);
    }
}
