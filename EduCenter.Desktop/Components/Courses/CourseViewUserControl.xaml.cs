using EduCenter.Desktop.Entities.Courses;
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

namespace EduCenter.Desktop.Components.Courses
{
    /// <summary>
    /// Interaction logic for CourseViewUserControl.xaml
    /// </summary>
    public partial class CourseViewUserControl : UserControl
    {
        public long Id { get; private set; }    
        public CourseViewUserControl()
        {
            InitializeComponent();
        }

        public void SetData(Course course) 
        {
            Id = course.Id;
            imgB.ImageSource = new BitmapImage(new System.Uri(course.ImagePath, UriKind.Relative));
            lbName.Content = course.Name;
            tbDescription.Text = course.Description;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(Id.ToString());
        }
    }
}
