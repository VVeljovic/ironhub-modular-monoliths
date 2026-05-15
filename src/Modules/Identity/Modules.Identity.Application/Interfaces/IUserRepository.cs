using Modules.Identity.Domain;
using Shared.Application;

namespace Modules.Identity.Application.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
