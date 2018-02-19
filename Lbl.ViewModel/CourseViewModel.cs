using System;
using Lbl.Model;

namespace Lbl.ViewModel
{
    public class CourseViewModel : BaseViewModel<Course>
    {
        public CourseViewModel(Course course) : base(course)
        {
            Title = course.Tags;
            Price = course.Price;
            Tags = course.Tags;
            TotalStudentEnrolled = course.TotalStudentEnrolled;
            PublishDate = course.PublishDate;
            TotalLecturesCount = course.TotalLecturesCount;
            SubTitle = course.SubTitle;
            CourseSummary = this.CourseSummary;
            CourseShortDescription = course.CourseShortDescription;
            Language = course.Language;
            Achive = course.Language;
            Requirements = course.Requirements;
            FullDescription = course.FullDescription;

            if (course.Teacher != null)
            {
                this.Teacher = new TeacherViewModel(course.Teacher);
            }
        }

        public string Title { get; set; }
        public double Price { set; get; }
        public string Tags { set; get; }
        public int TotalStudentEnrolled { get; set; }
        public DateTime PublishDate { set; get; }
        public int TotalLecturesCount { get; set; }

        public string SubTitle { get; set; }
        public string CourseSummary { get; set; }
        public string CourseShortDescription { get; set; }
        public string Language { get; set; }
        public string Achive { get; set; }
        public string Requirements { set; get; }
        public string FullDescription { get; set; }
        public TeacherViewModel Teacher { set; get; }

    }
}
