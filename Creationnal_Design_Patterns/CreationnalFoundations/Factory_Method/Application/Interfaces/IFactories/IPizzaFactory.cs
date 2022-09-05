using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Base;
using Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Domain.Entities.Enums;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Factory_Method.Application.Interfaces.IFactories
{
    public interface IPizzaFactory
    {
        Pizza Create(Types type);
    }
}
