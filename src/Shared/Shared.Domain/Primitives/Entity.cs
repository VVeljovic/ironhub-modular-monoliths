namespace Shared.Domain.Primitives
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity(Guid id)
        {
            Id = id;
        }
        
        protected Entity() { }
        
        public Guid Id { get; private init; } 

        public bool Equals(Entity? other)
        {
            if (other is null) return false; 

            if(other.GetType() != GetType()) return false;

            return Id == other.Id;
        }

        public static bool operator ==(Entity? left, Entity? right)
        {
            return left is not null && right is not null && left.Equals(right);
        }

        public static bool operator !=(Entity? left, Entity? right)
        {
            return !(left == right);
        }

        public override bool Equals(object? obj)
        {
            return obj is Entity entity && 
                entity.GetType() == GetType() && 
                entity.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() * 41;
        }
    }
}
