namespace Shared.Domain.Primitives
{
    public abstract record DomainEvent(Guid EventId, DateTime OccuredOn) : IDomainEvent
    {
        public DomainEvent() : this(Guid.NewGuid(), DateTime.UtcNow) { } 
    }
}