using Project.Entities.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Project.Commons.DataAccess
{
    public interface IEntityRepository<TEntity> where TEntity:class,IEntity,new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> expression=null);
    }
}
