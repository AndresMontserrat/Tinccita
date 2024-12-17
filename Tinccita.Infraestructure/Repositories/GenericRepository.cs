using Tinccita.Domain.Interfaces;

namespace Tinccita.Infraestructure.Repositories
{
    public class GenericRepository<TEntity> : IGeneric<TEntity> where TEntity : class
    {
        //TODO: CREATE REPOSITORY BY DOMAIN CLASS

        Task<int> IGeneric<TEntity>.AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<int> IGeneric<TEntity>.DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<TEntity>> IGeneric<TEntity>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IGeneric<TEntity>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<int> IGeneric<TEntity>.UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
