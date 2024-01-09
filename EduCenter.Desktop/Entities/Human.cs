using System.ComponentModel.DataAnnotations;

namespace EduCenter.Desktop.Entities;

public class Human : Auditable
{
    [MaxLength(50)]
    public string FirstName { get; set; }
    [MaxLength(50)]
    public string LastName { get; set; }
    [MaxLength(15)]
    public string PhoneNumber { get; set; }
    [MaxLength(15)]
    public string ParentsPhoneNumber { get; set; }
    public DateOnly BirthDate { get; set; }
    public string Email { get; set; }
    public bool IsMale { get; set; }
    [MaxLength(9)]
    public string PassportSeriaNumber { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
}
