using Shared.Domain.Primitives;

namespace Modules.Identity.Domain
{
    public class FullName : ValueObject
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public const int MaxLength = 255;

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return FirstName;

            yield return LastName;
        }

        private FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public static Result<FullName> Create(string? firstName, string? lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                return Result<FullName>.Failure(UserErrors.FullName.Empty);
            }

            if (firstName.Length > MaxLength || lastName.Length > 255)
            {
                return Result<FullName>.Failure(UserErrors.FullName.TooLong);
            }

            if (firstName.Contains("@") || lastName.Contains("@"))
            {
                return Result<FullName>.Failure(UserErrors.FullName.InvalidFormat);
            }

            return Result<FullName>.Success(new FullName(firstName, lastName));
        }

    }
}
