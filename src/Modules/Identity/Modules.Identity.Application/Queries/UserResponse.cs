using Modules.Identity.Domain;

namespace Modules.Identity.Application.Queries
{
    public sealed record UserResponse(Guid Id,
        FullName FullName,
        Email Email,
        DateTime CreatedAt,
        string Role,
        bool IsActive);
}
