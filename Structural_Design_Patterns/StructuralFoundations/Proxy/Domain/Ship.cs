using Structural_Design_Patterns.StructuralFoundations.Proxy.Domain.Ships;
using Structural_Design_Patterns.StructuralFoundations.Proxy.Domain.Ships.ShipsTypes;

namespace Structural_Design_Patterns.StructuralFoundations.Proxy.Domain
{
    public sealed class Ship
    {
        public string Name { get; private set; }

        public Ship(string Name) =>
            this.Name = Name;

        public void ShipName(ShipsType shipsType) =>
            this.Name = new ShipService().EnemyShip(shipsType);
    }
}
