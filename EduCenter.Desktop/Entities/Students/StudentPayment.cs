using EduCenter.Desktop.Entities.Groups;
using EduCenter.Desktop.Enums;

namespace EduCenter.Desktop.Entities.Students;

public class StudentPayment : Auditable
{
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public long StudentId { get; set; }
    public Student Student { get; set; }
    public float Amount { get; set; }
    //paymentType

    public PaymentType Type { get; set; }
    public string Description { get; set; }
}
