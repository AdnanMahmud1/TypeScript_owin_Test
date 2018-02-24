using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Lbl.Model;
using Lbl.Model.Student;

namespace Lbl.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class 
    {
        protected DbContext db;

        public GenericRepository(DbContext dbContext)
        {
            this.db = dbContext;
        }

        public bool Add(T entity)
        {
            DbSet<T> dbSet = this.db.Set<T>();
            dbSet.Add(entity);
            int i = db.SaveChanges();
            return i>0;
        }
        public IQueryable<T> Get()
        {
            return this.db.Set<T>().AsQueryable();
        }
        public T GetDetail(string id)
        {
            return db.Set<T>().Find(id);
        }

        public bool Edit(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            int i = db.SaveChanges();
            return i > 0;
        }

        //public virtual bool Exists(string id)
        //{
        //    return this.db.Set<T>().Any(x=>x.Id==id);
        //}

        public virtual IEnumerable<T> Add(IEnumerable<T> entites)
        {
            var enumarable = entites as IList<T>?? entites.ToList();
            db.Set<T>().AddRange(enumarable);
            return enumarable;
        }

        public bool Delete(string id)
        {
            var entity = GetDetail(id);
            if (entity!=null)
            {
                db.Set<T>().Remove(entity);
                db.SaveChanges();
                int i = db.SaveChanges();
                return i > 0;
            }
            return true;
        }

        //public virtual bool Save()
        //{
        //    var saveChanges = db.SaveChanges();
        //    return saveChanges>0;
        //}
    }
}