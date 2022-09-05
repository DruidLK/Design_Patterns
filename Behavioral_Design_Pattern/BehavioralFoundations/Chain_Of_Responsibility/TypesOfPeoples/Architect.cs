using Behavioral_Design_Pattern.BehavioralFoundations.ChainOfResponsibility.Entities;
using Behavioral_Design_Pattern.BehavioralFoundations.ChainOfResponsibility.Interfaces;

namespace Behavioral_Design_Pattern.BehavioralFoundations.ChainOfResponsibility.TypesOfPeoples
{
    public sealed class Architect : IHandler
    {
        private IHandler nextPersonToHandleWork;

        public void HandOverWhenDone(IHandler handler) =>
            this.nextPersonToHandleWork = handler;

        public void Handle(Requirment requirement)
        {
            requirement.OperationsDone.Add(nameof(Architect));
            this.nextPersonToHandleWork.Handle(requirement);
        }
    }
}
