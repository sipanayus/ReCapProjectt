using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T GetById(Expression<Func<T,bool>>filter=null);
        List<T> GetAll(Expression<Func<T,bool>>filter=null);

        //List<Car> GetById(int Id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
