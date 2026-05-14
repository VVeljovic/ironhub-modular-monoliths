using Shared.Domain.Primitives;

namespace Modules.Identity.Domain
{
    public sealed class User : AggregateRoot
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Email { get; private set; }

        public string  Password { get; private set; }

        public bool IsActive { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public Role Role { get; private set; }
    }
}
