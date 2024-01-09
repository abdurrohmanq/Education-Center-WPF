using EduCenter.Desktop.Entities.Groups;
using EduCenter.Desktop.Entities.Rooms;

namespace EduCenter.Desktop.Entities.Lessons;

public class Lesson : Auditable
{
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public long RoomId { get; set; }
    public Room Room { get; set; }
    public string Description { get; set; }
    public DateOnly DestinitionDate { get; set; }
    public bool IsSuccessFully { get; set; }
}
