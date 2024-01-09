using EduCenter.Desktop.Entities.Lessons;
using EduCenter.Desktop.Entities.Students;

namespace EduCenter.Desktop.Entities.Attandances;

public class Attandance : Auditable
{
    public long LessonId { get; set; }
    public Lesson Lesson { get; set; }
    public long StudentId { get; set; }
    public Student Student { get; set; }
    public bool IsAttended { get; set; }
    public string Description { get; set; }
}
