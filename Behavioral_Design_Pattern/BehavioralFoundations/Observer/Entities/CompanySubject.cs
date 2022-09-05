using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Behavioral_Design_Pattern.BehavioralFoundations.Observer.Entities
{
    public sealed class CompanySubject
    {
        private List<Candidates> candidates;
        private ObservableCollection<Opportunity> opportunities;

        public CompanySubject()
        {
            this.candidates = new List<Candidates>();
            this.opportunities = new ObservableCollection<Opportunity>();

            this.opportunities.CollectionChanged += CollectionChangedEvent;
        }

        public void CollectionChangedEvent(object sender, NotifyCollectionChangedEventArgs eventArgs)
        {
            if (eventArgs.Action == NotifyCollectionChangedAction.Add)
                this.candidates.ForEach(candidate => candidate.Notify("SE"));
        }

        public void SetOpportunitys(Opportunity opportunity) =>
            this.opportunities.Add(opportunity);

        public void SetCandidate(Candidates candidate) =>
            this.candidates.Add(candidate);
    }
}
