using Shared.Domain.Primitives;

namespace Modules.Identity.Domain
{
    public sealed class Email : ValueObject
    {
        public string Value { get; private set; }


        public const int MaxLength = 255; 

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }

        protected Email(string value)
        {
            Value = value;
        }   

        public static Result<Email> Create(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return Result<Email>.Failure(UserErrors.Email.Empty);
            }

            if (value.Length > MaxLength)
            {
                return Result<Email>.Failure(UserErrors.Email.TooLong);
            }

            if (!value.Contains('@'))
            {
                return Result<Email>.Failure(UserErrors.Email.InvalidFormat);
            }

            return Result<Email>.Success(new Email(value));
        }
    }
}
