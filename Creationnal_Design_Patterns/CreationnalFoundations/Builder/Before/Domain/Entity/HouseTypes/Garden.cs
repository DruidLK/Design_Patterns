using Creationnal_Design_Patterns.CreationnalFoundations.Builder.Before.Domain.Entity.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Builder.Before.Domain.Entity.HouseTypes
{
    public sealed class Garden : House
    {
        public Garden(
            int windows,
            int doors,
            int rooms,
            bool hasGarage,
            bool hasSwimPool,
            bool hasStatues
            )
            : base
            (
                windows,
                doors,
                rooms,
                hasGarage,
                hasSwimPool,
                hasStatues, hasGarden: true
            )
        { }
    }
}
