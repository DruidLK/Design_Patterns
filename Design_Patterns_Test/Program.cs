using Creationnal_Design_Patterns.CreationnalFoundations.Builder.After.Domain.Entities.HouseTypes;
using Creationnal_Design_Patterns.CreationnalFoundations.Builder.After.Services;

namespace Design_Patterns_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var house = new HouseCreator(new Garden()).ConstructHouse();

            System.Console.WriteLine(house.HasGarden);
        }
    }
}
