using Lbl.Model;
using Lbl.Model.Student;

namespace Lbl.ViewModel
{
    public class ContentViewModel : BaseViewModel<Content>
    {
        public ContentViewModel(Content content) : base(content)
        {
            Serial = content.Serial;
            Title = content.Title;
            Description = content.Description;
            Url = content.Url;
            TotalSeconds = content.TotalSeconds;
            Tags = content.Tags;
            Category = content.Category;
            if (content.Course != null)
            {
                this.Course=new CourseViewModel(content.Course);
            }
        }
        
        public int Serial { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int TotalSeconds { set; get; }
        public string Tags { get; set; }
        public int Category { get; set; }
        public CourseViewModel Course { set; get; }

    }
}
