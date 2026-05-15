using Modules.Identity.Domain.Events;
using Shared.Domain.Primitives;

namespace Modules.Identity.Domain
{
    public sealed class User : AggregateRoot
    {
        public FullName FullName { get; private set; }

        public Email Email { get; private set; }

        public string PasswordHash { get; private set; }

        public bool IsActive { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public Role Role { get; private set; }

        private User(
           Guid id,
           FullName fullName,
           Email email,
           string passwordHash,
           Role role) : base(id)
        {
            FullName = fullName;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
            IsActive = true;
            CreatedAt = DateTime.UtcNow;
        }

        public static Result<User> Create(FullName fullName, Email email, string passwordHash, Role role)
        {
            var user = new User(Guid.NewGuid(), fullName, email, passwordHash, role);

            user.AddDomainEvent(new UserRegisteredDomainEvent(user.Id, user.Email.Value, user.Role));

            return user;
        }

        public void Deactivate()
        {
            if (!IsActive) return;

            IsActive = false;

            AddDomainEvent(new UserDeactivatedDomainEvent(Id));
        }
    }
}
