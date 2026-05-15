namespace Shared.Domain.Primitives
{
    public abstract class AggregateRoot : Entity
    {
        protected AggregateRoot(Guid id) : base(id) { }

        private readonly List<IDomainEvent> _domainEvents = [];

        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
     
        public void ClearDomainEvents() => _domainEvents.Clear();

        public void AddDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent); 
    }
}
