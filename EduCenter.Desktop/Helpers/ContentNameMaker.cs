using System.IO;

namespace EduCenter.Desktop.Helpers;

public class ContentNameMaker
{
    public static string GetImageName(string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);

        return "IMG" + Guid.NewGuid().ToString() + fileInfo.Extension;
    }
}
