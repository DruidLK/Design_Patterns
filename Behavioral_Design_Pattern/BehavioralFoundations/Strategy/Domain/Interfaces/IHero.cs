namespace Behavioral_Design_Pattern.BehavioralFoundations.Strategy.Domain.Interfaces
{
    public interface IHero
    {
        string DoHeroStuff();

        void ChangeSuperPower(ISuperPower superPower);
    }
}
