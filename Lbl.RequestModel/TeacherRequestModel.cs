using System;
using System.Linq.Expressions;
using Lbl.Model;

namespace Lbl.RequestModel
{
    public class TeacherRequestModel : BaseRequestModel<Teacher>
    {
        
        public override Expression<Func<Teacher, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x =>
                    x.Name.Contains(Keyword);
            }
            return ExpressionObject;
        }
        //public string Keyword { set; get; }
    }
}