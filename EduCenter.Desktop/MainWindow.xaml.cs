using EduCenter.Desktop.Pages;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EduCenter.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void brDragable_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void rbCourses_Click(object sender, RoutedEventArgs e)
        {
            CoursesPage coursesPage = new CoursesPage();
            PageNavigator.Content = coursesPage;
        }

        private void rbGroups_Click(object sender, RoutedEventArgs e)
        {
            GroupsPage groupsPage = new GroupsPage();
            PageNavigator.Content = groupsPage;
        }

        private void rbTeachers_Click(object sender, RoutedEventArgs e)
        {
            TeachersPage teachersPage = new TeachersPage();
            PageNavigator.Content = teachersPage;
        }

        private void rbStudents_Click(object sender, RoutedEventArgs e)
        {
            StudentsPage studentsPage = new StudentsPage();
            PageNavigator.Content = studentsPage;
        }

        private void rbEmployees_Click(object sender, RoutedEventArgs e)
        {
            EmployeesPage employeesPage = new EmployeesPage();
            PageNavigator.Content = employeesPage;
        }

        private void rbPayments_Click(object sender, RoutedEventArgs e)
        {
            PaymentsPage paymentsPage = new PaymentsPage();
            PageNavigator.Content = paymentsPage;
        }

        private void rbSalaries_Click(object sender, RoutedEventArgs e)
        {
            SalariesPage salariesPage = new SalariesPage();
            PageNavigator.Content = salariesPage;
        }

        private void rbInformation_Click(object sender, RoutedEventArgs e)
        {
            InformationsPage informationsPage = new InformationsPage();
            PageNavigator.Content = informationsPage;
        }

        private void rbAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutPage aboutPage = new AboutPage();
            PageNavigator.Content = aboutPage;
        }

        private void rbDashboard_Click(object sender, RoutedEventArgs e)
        {
            DashboardPage dashboardPage = new DashboardPage();
            PageNavigator.Content = dashboardPage;
        }
    }
}