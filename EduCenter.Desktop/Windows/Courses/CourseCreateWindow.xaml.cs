using EduCenter.Desktop.Constants;
using EduCenter.Desktop.DbContexts;
using EduCenter.Desktop.Entities.Courses;
using EduCenter.Desktop.Helpers;
using EduCenter.Desktop.Interfaces.IRepositories;
using EduCenter.Desktop.Repositories;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EduCenter.Desktop.Windows.Courses;

/// <summary>
/// Interaction logic for CourseCreateWindow.xaml
/// </summary>
public partial class CourseCreateWindow : Window
{
    private readonly AppDbContext dbContext;
    private readonly IRepository<Course> courseRepository;
    public CourseCreateWindow()
    {
        InitializeComponent();
        this.dbContext = new AppDbContext();
        this.courseRepository = new Repository<Course>(dbContext);
    }

    private void btnImageSelector_Click(object sender, RoutedEventArgs e)
    {
        var openFileDialog = GetImageDialog();
        if (openFileDialog.ShowDialog() == true)
        {
            string imgPath = openFileDialog.FileName;
            ImBImage.ImageSource = new BitmapImage(new Uri(imgPath, UriKind.Relative));
        }
    }

    private OpenFileDialog GetImageDialog()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|GIF Files (*.gif)|*.gif";
        return openFileDialog;
    }
    private void btnThumbSelector_Click(object sender, RoutedEventArgs e)
    {
        var openFileDialog = GetImageDialog();
        if (openFileDialog.ShowDialog() == true)
        {
            string imgPath = openFileDialog.FileName;
            ImbThumb.ImageSource = new BitmapImage(new Uri(imgPath, UriKind.Relative));
        }
    }

    private void btnVideoSelector_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Mp4 Files (*.mp4)|*.mp4|AVI Files (*.avi)|*.avi|MKV Files (*.mkv)|*.mkv";
        if (openFileDialog.ShowDialog() == true)
        {
            string videoPath = openFileDialog.FileName;
            MdCourseVideo.Source = new Uri(videoPath);
        }
    }

    private async void btnSave_Click(object sender, RoutedEventArgs e)
    {
        Course course = new Course();
        course.Name = tbName.Text;
        
        string imgPath = ImBImage.ImageSource.ToString();
        if(!String.IsNullOrEmpty(imgPath))
             course.ImagePath = await CopyImageAsync(imgPath,
                 ContentConstant.IMAGE_CONTENTS_PATH);
        
        course.Description = new TextRange(rbDescription.Document.ContentStart, rbDescription.Document.ContentEnd).Text;
        
        string thumbPath = ImbThumb.ImageSource.ToString();
        if(!String.IsNullOrEmpty (thumbPath))
             course.IntroVideoThumb = await CopyImageAsync(thumbPath,
                 ContentConstant.THUMB_CONTENTS_PATH);

        await courseRepository.CreateAsync(course);
        await courseRepository.SaveChanges();
        MessageBox.Show("Muvaffaqiyatli saqlandi!");
        this.Close();
    }

    private async Task<string> CopyImageAsync(string imgPath, string destinationDirectory)
    {
        if(!Directory.Exists(destinationDirectory))
           Directory.CreateDirectory(destinationDirectory);

        var imageName = ContentNameMaker.GetImageName(imgPath);

        string path = System.IO.Path.Combine(destinationDirectory, imageName);
        byte[] image = await File.ReadAllBytesAsync(imgPath);
        await File.WriteAllBytesAsync (path, image);
        return path;
    }
}
