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
    /// Логика взаимодействия для ListOfEmployeesPage.xaml
    /// </summary>
    public partial class ListOfEmployeesPage : Page
    {
        public static Employee currentEmployee;
        public static List<Employee> employee { get; set; }
        public ListOfEmployeesPage()
        {
            InitializeComponent();
            EmployeeTb.Text = AuthorizationPage.currentUser.fio;
            employee = Connection.учебная.Employee.ToList();
            this.DataContext = this;
        }
        private void GoBackbt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }

        private void AddEmpBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEmployeePage());
        }

        private void EmplLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentEmployee = EmplLv.SelectedItem as Employee; 
            NavigationService.Navigate(new InfoOfEmployeePage());
        }
        
    }
}
