using MediatR;

namespace Shared.Domain.Primitives
{
    public interface IDomainEvent : INotification
    {
        Guid EventId { get; }
    
        DateTime OccuredOn { get; }
    }
}
