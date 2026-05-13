namespace Shared.Domain.Primitives
{
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        protected abstract IEnumerable<object> GetAtomicValues();

        public bool Equals(ValueObject? other)
        {
            return other is not null &&
                GetType() == other.GetType() &&
                GetAtomicValues().SequenceEqual(other.GetAtomicValues());
        }

        public override bool Equals(object? obj)
        {
            return obj is ValueObject valueObject && 
                valueObject.GetType() == GetType() &&
                valueObject.GetAtomicValues().SequenceEqual(GetAtomicValues());
        }

        public override int GetHashCode()
        {
            return GetAtomicValues()
                .Aggregate(default(int), HashCode.Combine);
        }

        public static bool operator ==(ValueObject? left, ValueObject? right)
        {
            return left is not null && right is not null && left.Equals(right);
        }

        public static bool operator !=(ValueObject? left, ValueObject? right)
        {
            return !(left == right);
        }

    }
}
