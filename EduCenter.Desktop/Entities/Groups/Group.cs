using EduCenter.Desktop.Entities.Courses;
using EduCenter.Desktop.Enums;

namespace EduCenter.Desktop.Entities.Groups;

public class Group : Auditable
{
    public long CourseId { get; set; }
    public Course Course { get; set; }
    public short GroupNumber { get; set; }
    //Type
    public string Type { get; set; }
    public short MaxCapacity { get; set; }
    public short MinCapacity { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    //status
    public GroupStatus Status { get; set; }
    public string Description { get; set; }
    public float PricePerMonth { get; set; }
    public bool IsOnline { get; set; }
}
