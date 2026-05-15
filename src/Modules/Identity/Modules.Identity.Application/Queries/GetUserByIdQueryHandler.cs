using MediatR;
using Modules.Identity.Domain;
using Modules.Identity.Application.Interfaces;
using Shared.Domain.Primitives;

namespace Modules.Identity.Application.Queries
{
    public sealed class GetUserByIdQueryHandler(IUserRepository userRepository) : IRequestHandler<GetUserByIdQuery, Result<UserResponse>>
    {
        public async Task<Result<UserResponse>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                return Result<UserResponse>.Failure(UserErrors.NotFoundError);
            }

            return Result<UserResponse>.Success(new UserResponse(user.Id, user.FullName, user.Email, user.CreatedAt, user.Role.ToString(), user.IsActive));
        }
    }
}
