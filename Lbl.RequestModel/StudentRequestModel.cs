using System;
using System.Linq.Expressions;
using Lbl.Model.Student;

namespace Lbl.RequestModel
{
    public class StudentRequestModel : BaseRequestModel<Student>
    {
        public string Name { get; set; }
        public string Phone { get; set; }


        public override Expression<Func<Student, bool>> GetExpression()
        {

            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x =>
                    x.Name.Contains(Keyword) || x.Phone.Contains(Keyword) || x.Email.Contains(Keyword);
            }
            if (!string.IsNullOrWhiteSpace(Name))
            {
                this.ExpressionObject = ExpressionObject.And(s => s.Name.Contains(Name));
            }
            if (!string.IsNullOrWhiteSpace(Phone))
            {
                this.ExpressionObject = ExpressionObject.And(s => s.Phone.Contains(Phone));
            }
            Expression<Func<Student, bool>> baseExpression = this.GenerateBaseExpression();
            this.ExpressionObject = ExpressionObject.And(baseExpression);
            return ExpressionObject;

        }

    }
}
