using Microsoft.EntityFrameworkCore;
using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Project.Commons.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var context=new TContext())
            {
                return expression != null ? context.Set<TEntity>().Where(expression).ToList<TEntity>() : context.Set<TEntity>().ToList<TEntity>();
            }
        }
    }
}
