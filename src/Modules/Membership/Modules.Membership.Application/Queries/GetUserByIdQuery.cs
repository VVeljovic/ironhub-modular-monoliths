using MediatR;
using Shared.Domain.Primitives;

namespace Modules.Membership.Application.Queries
{
    public sealed record GetUserByIdQuery(Guid UserId) : IRequest<Result<UserResponse>>;
}
