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

        public static class FullName
        {
            public static readonly Error Empty = new("FullName.Empty", "First or last cannot be null or empty.");

            public static readonly Error InvalidFormat = new("FullName.InvalidFormat", "First or last name are in invalid format.");

            public static readonly Error TooLong = new("FullName.TooLong", "First or last name is longer than 255 characters.");
        }

        public static readonly Error NotFoundError = new("NotFound", "User was not found");
    }
}
