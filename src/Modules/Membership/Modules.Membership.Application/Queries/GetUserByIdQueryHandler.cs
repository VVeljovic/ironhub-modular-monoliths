using MediatR;
using Modules.Identity.Domain;
using Modules.Membership.Application.Interfaces;
using Shared.Domain.Primitives;

namespace Modules.Membership.Application.Queries
{
    public sealed class GetUserByIdQueryHandler(IUserRepository userRepository) : IRequestHandler<GetUserByIdQuery, Result<UserResponse>>
    {
        public async Task<Result<UserResponse>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetByIdAsync(request.UserId);

            if (user is null)
            {
                return Result<UserResponse>.Failure(UserErrors.NotFoundError);
            }

            return Result<UserResponse>.Success(new UserResponse(user.Id, user.FullName, user.Email, user.CreatedAt, user.Role.ToString(), user.IsActive));
        }
    }
}
