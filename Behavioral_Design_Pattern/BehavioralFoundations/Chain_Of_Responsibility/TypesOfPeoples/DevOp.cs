using Behavioral_Design_Pattern.BehavioralFoundations.ChainOfResponsibility.Entities;
using Behavioral_Design_Pattern.BehavioralFoundations.ChainOfResponsibility.Interfaces;

namespace Behavioral_Design_Pattern.BehavioralFoundations.ChainOfResponsibility.TypesOfPeoples
{
    public sealed class DevOp : IHandler
    {
        private IHandler nextPersonToHandleWork;

        public void HandOverWhenDone(IHandler handler) =>
            this.nextPersonToHandleWork = handler;

        public void Handle(Requirment requirement)
        {
            requirement.OperationsDone.Add(nameof(DevOp));
            this.nextPersonToHandleWork.Handle(requirement);
        }
    }
}
