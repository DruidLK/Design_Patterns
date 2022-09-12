using Creationnal_Design_Patterns.CreationnalFoundations.Builder.Before.Domain.Entity.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Builder.Before.Domain.Entity.HouseTypes
{
    public sealed class Status : House
    {
        public Status(
            int windows,
            int doors,
            int rooms,
            bool hasGarage,
            bool hasSwimPool,
            bool hasGarden
            ) : base
            (
                windows,
                doors,
                rooms,
                hasGarage,
                hasSwimPool,
                hasStatues: true,
                hasGarden
                )
        { }
    }
}
