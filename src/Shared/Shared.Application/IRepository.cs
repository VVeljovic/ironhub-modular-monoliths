using Shared.Domain.Primitives;

namespace Shared.Application
{
    public interface IRepository<T> where T : AggregateRoot
    {
        Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        void Add(T entity);
       
        void Update(T entity);
        
        void Remove(T entity);
    }
}
