using Shared.Domain.Primitives;

namespace Modules.Identity.Domain.Events
{
    public sealed record UserRegisteredDomainEvent(Guid UserId, string Email, Role role) : DomainEvent;
}
