using Modules.Identity.Domain;
using Shared.Application;

namespace Modules.Membership.Application.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
