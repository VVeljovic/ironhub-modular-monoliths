using Shared.Domain.Primitives;

namespace Modules.Identity.Domain
{
    public static class UserErrors
    {
        public static class Email
        {
            public static readonly Error Empty =
                    new("Email.Empty", "Email cannot be null or empty.");
            
            public static readonly Error InvalidFormat =
                new("Email.InvalidFormat", "Email format is invalid.");

            public static readonly Error TooLong = new("Email.TooLong", $"Email cannot be longer than 255 characters.");
        }
    }
}
