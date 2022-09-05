using Behavioral_Design_Pattern.BehavioralFoundations.ChainOfResponsibility.Entities;

namespace Behavioral_Design_Pattern.BehavioralFoundations.ChainOfResponsibility.Interfaces
{
    public interface IHandler
    {
        void Handle(Requirment requirement);

        void HandOverWhenDone(IHandler handler);
    }
}
