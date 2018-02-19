using System;
using Lbl.Model.Student;

namespace Lbl.ViewModel
{
    public class BaseViewModel<T> where T:Entity
    {
        public BaseViewModel(Entity entity)
        {
            Id = entity.Id;
            Modified = entity.Modified;
            ModifiedBy = entity.ModifiedBy;
            Created = entity.Created;
            CreatedBy = entity.CreatedBy;
        }
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}