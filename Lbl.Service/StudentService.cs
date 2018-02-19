using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using Lbl.Model.Student;
using Lbl.Repository;
using Lbl.RequestModel;
using Lbl.ViewModel;

namespace Lbl.Service
{
    public class StudentService:BaseService<Student,StudentRequestModel,StudentViewModel>
    {
        //private GenericRepository<Student> repository;
        // private MongoBaseRepository<Student> _mongoBaseRepository;
        //public StudentService()
        //{
        //    repository = new GenericRepository<Student>();
        //    //_mongoBaseRepository=new MongoBaseRepository<Student>();
        //}

      

        //public List<StudentViewModel> Search(StudentRequestModel request)
        //{
        //    var students = base.SearchQueryable(request);
        //    var list = students.ToList().ConvertAll(x => new StudentViewModel(x));
        //    return list;
        //}

        //public StudentDetailViewModel Detail(string id)
        //{
        //    Student x = repository.GetDetail(id);
        //    if (x == null)
        //    {
        //        throw new ObjectNotFoundException();
        //    }
        //    StudentDetailViewModel vm = new StudentDetailViewModel(x);
        //    return vm;
        //}
    }
}
