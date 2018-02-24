using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using System.Linq.Expressions;
using Lbl.Model.Student;
using Lbl.Repository;
using Lbl.RequestModel;
using Lbl.ViewModel;

namespace Lbl.Service
{
    public class BaseService<T,TR,TV> where T:Entity where TR:BaseRequestModel<T> where TV: BaseViewModel<T>
    {
        GenericRepository<T> repository;
        public BaseService(DbContext dbContext)
        {
            repository = new GenericRepository<T>(dbContext);
        }
        public IQueryable<T> SearchQueryable(BaseRequestModel<T> request)
        {
            IQueryable<T> queryable = repository.Get();
            Expression<Func<T, bool>> expression = request.GetExpression();
            queryable = queryable.Where(expression);
            queryable = request.OrderByFunc()(queryable);
            queryable = request.SkipAndTake(queryable);
            queryable = request.IncludeParents(queryable);
            return queryable;
        }

        public bool Add(T model)
        {
            //var repository = new GenericRepository<T>();
            //model.Id = Guid.NewGuid().ToString();
            return repository.Add(model);
        }
        public TV Detail(string id)
        {
            T x = repository.GetDetail(id);
            if (x == null)
            {
                throw new ObjectNotFoundException();
            }
            TV vm = CreateVmInstances(x);
            return vm;
        }
        public List<TV> Search(TR request)
        {
            var queryable = SearchQueryable(request);
            var list = queryable.ToList().ConvertAll(CreateVmInstances);
            return list;
        }

        private static TV CreateVmInstances(T x)
        {
            return (TV) Activator.CreateInstance(typeof(TV),x);
        }
    }
}