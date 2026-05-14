namespace Shared.Domain.Primitives
{
    public record Error(string Title, string Message)
    {
        public static Error NotFound(string entity) => new($"{entity}.NotFound", $"{entity} was not found.");

        public static Error Validation(string field, string message) => new($"{field}.Validation", message);
    }
}
