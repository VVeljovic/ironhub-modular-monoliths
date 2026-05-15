using MediatR;
using Shared.Domain.Primitives;

namespace Modules.Identity.Application.Queries
{
    public sealed record GetUserByIdQuery(Guid UserId) : IRequest<Result<UserResponse>>;
}
