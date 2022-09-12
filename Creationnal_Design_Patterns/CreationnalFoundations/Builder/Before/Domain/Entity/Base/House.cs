namespace Creationnal_Design_Patterns.CreationnalFoundations.Builder.Before.Domain.Entity.Base
{
    public abstract class House
    {
        public int Windows { get; private set; }
        public int Doors { get; private set; }
        public int rooms { get; private set; }
        public bool HasGarage { get; private set; }
        public bool HasSwimPool { get; private set; }
        public bool HasStatues { get; private set; }
        public bool HasGarden { get; private set; }

        public House(
         int windows,
         int doors,
         int rooms,
         bool hasGarage,
         bool hasSwimPool,
         bool hasStatues,
         bool hasGarden)
        {
            Windows = windows;
            Doors = doors;
            this.rooms = rooms;
            HasGarage = hasGarage;
            HasSwimPool = hasSwimPool;
            HasStatues = hasStatues;
            HasGarden = hasGarden;
        }
    }
}
