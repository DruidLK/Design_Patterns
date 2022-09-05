using Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Domain.Base;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Domain.Entities
{
    public sealed class UFO : EnemyShip
    {
        public UFO()
            : base(Name: nameof(UFO), Damage: 15)
        { }
    }
}
