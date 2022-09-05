using Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Domain.Interfaces;

namespace Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Domain.Base
{
    public abstract class EnemyShip : IEnemyShip
    {
        public string Name { get; private set; }
        public int Damage { get; private set; }

        public EnemyShip(string Name, int Damage)
        {
            this.Name = Name;
            this.Damage = Damage;
        }
    }
}
