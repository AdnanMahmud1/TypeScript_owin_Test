using System.Collections.Generic;
using System.Linq;
using Lbl.Model.Student;

namespace Lbl.MongoRepository
{
    public class MongoBaseRepository<T> where T:Entity
    {
        public IQueryable<T> Geta()
        {
            List<T> models = new List<T>();
            return models.AsQueryable();
        }
    }
}
