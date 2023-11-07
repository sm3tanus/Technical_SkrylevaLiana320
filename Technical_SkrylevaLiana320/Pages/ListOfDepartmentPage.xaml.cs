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
using Technical_SkrylevaLiana320.DBconnection;

namespace Technical_SkrylevaLiana320.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListOfDepartmentPage.xaml
    /// </summary>
    public partial class ListOfDepartmentPage : Page
    {
        public static Department currentDepartment;
        public static List<Department> departments { get; set; }
        public static List<Faculty> faculties { get; set; }
        public ListOfDepartmentPage()
        {  
            InitializeComponent();
            departments = Connection.учебная.Department.ToList();
            EmployeeTb.Text = AuthorizationPage.currentUser.fio;
            this.DataContext = this;
        }
        private void GoBackbt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }


        private void DepLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentDepartment = DepLv.SelectedItem as Department;
            NavigationService.Navigate(new ListOfSpecializationPage());
        }

        private void addBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddDepartmentPage());
        }
    }
}
