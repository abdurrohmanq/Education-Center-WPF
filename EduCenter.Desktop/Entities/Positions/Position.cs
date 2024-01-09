using System.ComponentModel.DataAnnotations;

namespace EduCenter.Desktop.Entities.Positions;

public class Position : Auditable
{
    [MaxLength(50)]
    public string Name { get; set; }
    public string Description { get; set; }
}
