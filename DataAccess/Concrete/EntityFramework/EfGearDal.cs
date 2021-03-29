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
    public class EfGearDal : IGearDal
    {
        public void Add(Gear entity)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Gear entity)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Gear Get(Expression<Func<Gear, bool>> filter)
        {
            using (CarDBContext context = new CarDBContext())
            {
                return context.Set<Gear>().SingleOrDefault(filter);
            }
        }

        public List<Gear> GetAll(Expression<Func<Gear, bool>> filter = null)
        {
            using (CarDBContext context = new CarDBContext())
            {
                return filter == null ? context.Set<Gear>().ToList() : context.Set<Gear>().Where(filter).ToList();
            }
        }

        public void Update(Gear entity)
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
