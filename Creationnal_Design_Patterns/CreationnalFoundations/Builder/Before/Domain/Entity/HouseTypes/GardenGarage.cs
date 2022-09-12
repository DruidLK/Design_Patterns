using Creationnal_Design_Patterns.CreationnalFoundations.Builder.Before.Domain.Entity.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Builder.Before.Domain.Entity.HouseTypes
{
    public sealed class GardenGarage : House
    {
        public GardenGarage(
            int windows,
            int doors,
            int rooms,
            bool hasStatues,
            bool hasGarden
            ) : base
            (
            windows,
            doors,
            rooms,
            hasGarage: true,
            hasSwimPool: true,
            hasStatues,
            hasGarden
            )
        { }
    }
}
