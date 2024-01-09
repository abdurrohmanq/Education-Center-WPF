using System.ComponentModel.DataAnnotations;

namespace EduCenter.Desktop.Entities.Courses;

public class Course : Auditable
{
    [MaxLength(50)]
    public string Name { get; set; }
    public string ImagePath { get; set; }
    public string Description { get; set; }
    public string IntroVideoPath { get; set; }
    public string IntroVideoThumb { get; set; }
}
