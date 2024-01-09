using EduCenter.Desktop.Entities.Teachers;
using EduCenter.Desktop.Enums;

namespace EduCenter.Desktop.Entities.Groups;

public class GroupTeacher : Auditable
{
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public float SalaryPerMonth { get; set; }
    public string Description { get; set; }

    public TeacherStatus Status { get; set; }
    public string Role { get; set; }
}
