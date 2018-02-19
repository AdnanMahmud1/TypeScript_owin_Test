using System.Collections.Generic;
using System.Linq;
using Lbl.Model.Student;

namespace Lbl.Repository
{
    public interface IGenericRepository<T> where T : Entity
    {
        bool Add(T entity);
        IQueryable<T> Get();
        T GetDetail(string id);
        bool Edit(T entity);
        bool Exists(string id);
        IEnumerable<T> Add(IEnumerable<T> entites);
        bool Delete(string id);
    }
}