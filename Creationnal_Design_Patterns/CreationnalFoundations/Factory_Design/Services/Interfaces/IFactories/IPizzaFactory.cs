using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Domain.Enums;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Design.Services.Interfaces.IFactories
{
    public interface IPizzaFactory
    {
        Pizza Create(Types types);
    }
}
