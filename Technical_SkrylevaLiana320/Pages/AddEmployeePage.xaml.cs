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
    /// Логика взаимодействия для AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        public static List<Role> role { get; set; }
        public static List<Employee> employees { get; set; }
        public AddEmployeePage()
        {
            InitializeComponent();
            role = Connection.учебная.Role.ToList();
            employees = Connection.учебная.Employee.ToList();
            this.DataContext = this;
        }
        public Employee employee = new Employee();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            employee.fio  = LastNameTb.Text.Trim();
            employee.salary = int.Parse(SalaryTb.Text.Trim());
            Connection.учебная.Employee.Add(employee);
            Connection.учебная.SaveChanges();
            NavigationService.Navigate(new ListOfEmployeesPage());
        }
        private void GoBackbt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            employee.Role = EmpCb.SelectedItem as Role;
        }

        private void ChefCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
