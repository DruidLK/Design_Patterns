using Structural_Design_Patterns.StructuralFoundations.Proxy.Base;
using Structural_Design_Patterns.StructuralFoundations.Proxy.Domain.Ships.ShipsTypes;

namespace Structural_Design_Patterns.StructuralFoundations.Proxy.Domain.Ships
{
    public sealed class ShipService
    {
        public string EnemyShip(ShipsType shipsType) =>
                ReflectionFactory
                    .Get<IEnemyShip>
                        (shipType => shipType.IsApplicable(shipsType)).Name;
    }
}
