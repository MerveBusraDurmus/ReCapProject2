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
    public class EfFuelDal : IFuelDal
    {
        public void Add(Fuel entity)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Fuel entity)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
         
        }

        public Fuel Get(Expression<Func<Fuel, bool>> filter)
        {
            using (CarDBContext context = new CarDBContext())
            {
                return context.Set<Fuel>().SingleOrDefault(filter);
            }
        }

        public List<Fuel> GetAll(Expression<Func<Fuel, bool>> filter = null)
        {
            using (CarDBContext context = new CarDBContext())
            {
                return filter == null ? context.Set<Fuel>().ToList() : context.Set<Fuel>().Where(filter).ToList();
            }
        }

        public void Update(Fuel entity)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
