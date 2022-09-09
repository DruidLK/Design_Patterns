using Behavioral_Design_Pattern.BehavioralFoundations.Strategy.Domain.Entities.SuperPowers;
using Behavioral_Design_Pattern.BehavioralFoundations.Strategy.Domain.Interfaces;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Strategy.Domain.Entities
{
    public sealed class Hero : IHero
    {
        private ISuperPower superPower;

        public Hero()
            : this(new Regular())
        { }

        private Hero(ISuperPower superPower) =>
            this.superPower = superPower;

        public void ChangeSuperPower(ISuperPower power) =>
              this.superPower = power;

        public string DoHeroStuff() =>
            this.superPower.Power();
    }
}
