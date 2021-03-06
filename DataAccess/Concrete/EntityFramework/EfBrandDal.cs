using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();

            }
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public Brand GetById(Expression<Func<Brand, bool>> filter)
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public void Update(Brand entity)
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
