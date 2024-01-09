using EduCenter.Desktop.Entities.Positions;

namespace EduCenter.Desktop.Entities.Employees;

public class Employee : Human
{
    public long PositionId { get; set; }
    public Position Position { get; set; }
    public float SalaryPerMonth { get; set; }
}
