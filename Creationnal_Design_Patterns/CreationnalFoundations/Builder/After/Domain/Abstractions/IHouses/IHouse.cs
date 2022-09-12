using Creationnal_Design_Patterns.CreationnalFoundations.Builder.After.Domain.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Builder.After.Domain.Abstractions.IHouses
{
    public interface IHouse
    {
        void BuildDoors();
        void BuildRooms();
        void BuildGarden();
        void BuildStatus();
        void BuildWindows();
        House GetHouse();
    }
}
