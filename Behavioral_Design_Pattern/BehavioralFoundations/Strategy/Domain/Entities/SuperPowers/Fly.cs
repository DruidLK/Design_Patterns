using Behavioral_Design_Pattern.BehavioralFoundations.Strategy.Domain.Interfaces;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Strategy.Domain.Entities.SuperPowers
{
    public sealed class Fly : ISuperPower
    {
        public string Power() =>
            nameof(Fly);
    }
}
