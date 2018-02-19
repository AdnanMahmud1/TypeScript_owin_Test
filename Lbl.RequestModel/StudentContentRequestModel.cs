using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Lbl.Model;

namespace Lbl.RequestModel
{
    public class StudentContentRequestModel:BaseRequestModel<StudentContent>
    {
        public override Expression<Func<StudentContent, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x =>
                    x.Student.Name.Contains(Keyword) || x.Content.Title.Contains(Keyword);
            }
            this.ExpressionObject = ExpressionObject.And(this.GenerateBaseExpression());
            return ExpressionObject;
        }

        public override IQueryable<StudentContent> IncludeParents(IQueryable<StudentContent> queryable)
        {
            return queryable.Include(x=>x.Student).Include(x=>x.Content);
        }
    }
}
