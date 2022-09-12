using Creationnal_Design_Patterns.CreationnalFoundations.Builder.After.Domain.Abstractions.IHouses;
using Creationnal_Design_Patterns.CreationnalFoundations.Builder.After.Domain.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Builder.After.Domain.Entities.HouseTypes
{
    public sealed class Status : IHouse
    {
        private const int defaultNumbers = 4;
        private const bool defaultBoolean = true;

        House house = new House();

        public void BuildWindows() =>
            house.Windows = defaultNumbers;
        public void BuildDoors() =>
            house.Doors = defaultNumbers;
        public void BuildRooms() =>
            house.rooms = defaultNumbers;
        public void BuildGarden() =>
            house.HasGarden = false;
        public void BuildStatus() =>
            house.HasStatues = defaultBoolean;
        public House GetHouse() =>
            house;
    }
}
