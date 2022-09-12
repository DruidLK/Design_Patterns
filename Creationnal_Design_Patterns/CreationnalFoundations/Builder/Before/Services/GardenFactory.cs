using Creationnal_Design_Patterns.CreationnalFoundations.Builder.Before.Domain.Entity.HouseTypes;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Builder.Before.Services
{
    public static class GardenFactory
    {
        public static Garden Create(
            int windows,
            int doors,
            int rooms,
            bool hasGarage,
            bool hasSwimPool,
            bool hasStatues) =>
             new Garden(windows, doors, rooms, hasGarage, hasSwimPool, hasStatues);
    }
}
