using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Lbl.Model;

namespace Lbl.RequestModel
{
    public class ContentRequestModel:BaseRequestModel<Content>
    {
        public override Expression<Func<Content, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x =>
                    x.Title.Contains(Keyword)|| x.Tags.Contains(Keyword)||x.CourseId.Equals(Keyword);
            }
            this.ExpressionObject = ExpressionObject.And(this.GenerateBaseExpression());
            return ExpressionObject;
        }

        public override IQueryable<Content> IncludeParents(IQueryable<Content> queryable)
        {
            return queryable.Include(x=>x.Course);
        }
    }
}
