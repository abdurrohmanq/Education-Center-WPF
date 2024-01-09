using EduCenter.Desktop.Components.Courses;
using EduCenter.Desktop.DbContexts;
using EduCenter.Desktop.Entities;
using EduCenter.Desktop.Entities.Courses;
using EduCenter.Desktop.Helpers;
using EduCenter.Desktop.Interfaces.IRepositories;
using EduCenter.Desktop.Repositories;
using EduCenter.Desktop.Windows.Courses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EduCenter.Desktop.Pages
{
    /// <summary>
    /// Interaction logic for CoursesPage.xaml
    /// </summary>
    public partial class CoursesPage : Page
    {
        private readonly AppDbContext dbContext;
        private readonly IRepository<Course> courseRepository;
        public CoursesPage()
        {
            InitializeComponent();
            this.dbContext = new AppDbContext();
            this.courseRepository = new Repository<Course>(dbContext);
        }

        private async void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CourseCreateWindow courseCreate = new CourseCreateWindow();
            courseCreate.ShowDialog();

            await RefreshAsync();
        }

        private async Task RefreshAsync()
        {
            wrpCourses.Children.Clear();
            PaginationParams paginationParams = new PaginationParams()
            {
                PageIndex = 1,
                PageSize = 20,
            };

            var courses = await courseRepository.SelectAll().ToPaginate(paginationParams).ToListAsync();
            foreach (var course in courses)
            {
                CourseViewUserControl courseViewUserControl = new CourseViewUserControl();
                courseViewUserControl.SetData(course);
                wrpCourses.Children.Add(courseViewUserControl);
            }
        }
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            await RefreshAsync();
        }
    }
}
