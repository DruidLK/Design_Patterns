using Creationnal_Design_Patterns.CreationnalFoundations.Builder.After.Domain.Abstractions.IHouses;
using Creationnal_Design_Patterns.CreationnalFoundations.Builder.After.Domain.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Builder.After.Services
{
    public sealed class HouseCreator
    {
        private readonly IHouse houseBuilder;

        public HouseCreator(IHouse houseType) =>
            this.houseBuilder = houseType;
        public House ConstructHouse()
        {
            this.houseBuilder.BuildDoors();
            this.houseBuilder.BuildGarden();
            this.houseBuilder.BuildRooms();
            this.houseBuilder.BuildStatus();
            this.houseBuilder.BuildWindows();
            return this.houseBuilder.GetHouse();
        }
    }
}
