using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace SocialNetwork.Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>

        where TEntity : class
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using var context= new TContext();
            var addEntity = context.Entry(entity);
            addEntity.State=EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var context=new TContext();
            var removeEntity=context.Remove(entity);
            removeEntity.State=EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using var context=new TContext();
            return context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}