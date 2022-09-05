using Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Domain.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Domain.Entities
{
    public sealed class Rocket : EnemyShip
    {
        public Rocket()
            : base(Name: nameof(Rocket), Damage: 25)
        { }
    }
}
