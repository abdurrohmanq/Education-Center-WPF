using EduCenter.Desktop.Entities.Rooms;

namespace EduCenter.Desktop.Entities.Groups;

public class GroupDetail : Auditable
{
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public long RoomId { get; set; }
    public Room Room { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public string Description { get; set; }
}
