using Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Domain.Entities;
using Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Domain.Enums.TypesOfShips;
using Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Domain.Interfaces;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Application.ShipApplications
{
    public static class EnemyShipFactory
    {
        public static IEnemyShip Create(TypeOfShip typeOfShip) =>
            typeOfShip switch
            {
                TypeOfShip.Rocket => new Rocket(),
                TypeOfShip.UFO => new UFO(),
                _ => throw new ArgumentOutOfRangeException(paramName: $"typeOfShip")
            };
    }
}
