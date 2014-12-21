using Abp.Domain.Entities;
using Abp.EntityFramework.Repositories;

namespace AspNetBoilerplateSample.EntityFramework.Repositories
{
    public abstract class AspNetBoilerplateSampleRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AspNetBoilerplateSampleDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class AspNetBoilerplateSampleRepositoryBase<TEntity> : AspNetBoilerplateSampleRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
