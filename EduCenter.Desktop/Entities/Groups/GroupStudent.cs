using EduCenter.Desktop.Entities.Students;
using EduCenter.Desktop.Enums;

namespace EduCenter.Desktop.Entities.Groups;

public class GroupStudent : Auditable
{
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public long StudentId { get; set; }
    public Student Student { get; set; }
    public DateOnly PaymentDate { get; set; }
    public string Description { get; set; }
    public float PricePerMonth { get; set; }
    public StudentStatus Status { get; set; }
}
