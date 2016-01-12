using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace NtxBlog.EntityFramework.Repositories
{
    public abstract class NtxBlogRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<NtxBlogDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected NtxBlogRepositoryBase(IDbContextProvider<NtxBlogDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class NtxBlogRepositoryBase<TEntity> : NtxBlogRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected NtxBlogRepositoryBase(IDbContextProvider<NtxBlogDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
