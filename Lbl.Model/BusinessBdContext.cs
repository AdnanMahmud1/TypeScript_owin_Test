using System.Data.Entity;
using Lbl.Model.Student;

namespace Lbl.Model
{
    public class BusinessBdContext:DbContext
    {
        public BusinessBdContext():base("BusinessBdContext")
        {
            Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }
        public static BusinessBdContext Create()
        {
            return new BusinessBdContext();
        }
        public DbSet<Student.Student> Students { set; get; }
        public DbSet<Teacher> Teachers { set; get; }
        public DbSet<Course> Courses { set; get; }

        public DbSet<Enrollment> Enrollments { set; get; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<StudentContent> StudentContents { get; set; }
    }
}
