using EduCenter.Desktop.Entities.Courses;

namespace EduCenter.Desktop.Entities.Teachers;

public class Teacher : Human
{
    public long CourseId { get; set; }
    public Course Course { get; set; }
    public string TeacherDegree { get; set; }
}
