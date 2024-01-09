using System.ComponentModel.DataAnnotations;

namespace EduCenter.Desktop.Entities.Rooms;

public class Room : Auditable
{
    [MaxLength(50)]
    public string Name { get; set; }
    public string Description { get; set; }
    public short MaxCapacity { get; set; }
}
