using Creationnal_Design_Patterns.CreationnalFoundations.Builder.Before.Domain.Entity.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Builder.Before.Domain.Entity.HouseTypes
{
    public sealed class SwimmingPool : House
    {
        public SwimmingPool(
            int windows,
            int doors,
            int rooms,
            bool hasGarage,
            bool hasStatues,
            bool hasGarden
            ) : base
            (
            windows,
            doors,
            rooms,
            hasGarage,
            hasSwimPool: true,
            hasStatues,
            hasGarden
            )
        { }
    }
}
