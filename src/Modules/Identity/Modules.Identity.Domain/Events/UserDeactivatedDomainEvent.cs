using Shared.Domain.Primitives;

namespace Modules.Identity.Domain.Events
{
    public sealed record UserDeactivatedDomainEvent(Guid Id) : DomainEvent;
}
