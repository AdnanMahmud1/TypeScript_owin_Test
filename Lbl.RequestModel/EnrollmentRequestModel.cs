using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Lbl.Model;

namespace Lbl.RequestModel
{
    public class EnrollmentRequestModel:BaseRequestModel<Enrollment>
    {
        public override Expression<Func<Enrollment, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x =>
                    x.Student.Name.Contains(Keyword) || x.Course.Title.Contains(Keyword);
            }
            this.ExpressionObject = ExpressionObject.And(this.GenerateBaseExpression());
            return ExpressionObject;
        }

        public override IQueryable<Enrollment> IncludeParents(IQueryable<Enrollment> queryable)
        {
            return queryable.Include(x=>x.Student).Include(x=>x.Course);
        }
    }
}
