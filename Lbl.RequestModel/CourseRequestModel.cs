using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Lbl.Model;

namespace Lbl.RequestModel
{
    public class CourseRequestModel:BaseRequestModel<Course>
    {
        public override Expression<Func<Course, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x =>
                    x.Title.Contains(Keyword) || x.Tags.Contains(Keyword) || x.Teacher.Name.Contains(Keyword);
            }
            this.ExpressionObject = ExpressionObject.And(this.GenerateBaseExpression());
            return ExpressionObject;
        }

        public override IQueryable<Course> IncludeParents(IQueryable<Course> queryable)
        {
            return queryable.Include(x => x.Teacher);
        }
    }
}
