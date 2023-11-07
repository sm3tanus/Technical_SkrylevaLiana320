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
    /// Логика взаимодействия для InfoOfEmployeePage.xaml
    /// </summary>
    public partial class InfoOfEmployeePage : Page
    {
        public static List<Role> role { get; set; }
        public InfoOfEmployeePage()
        {
            InitializeComponent();
            LastNameTb.Text = ListOfEmployeesPage.currentEmployee.fio;
            SalaryTb.Text = ListOfEmployeesPage.currentEmployee.salary.ToString();
            RoleNameTb.Text = ListOfEmployeesPage.currentEmployee.Role.name;
            role = Connection.учебная.Role.ToList();
            if (ListOfEmployeesPage.currentEmployee.chef == ListOfEmployeesPage.currentEmployee.id)
            {
                ChefTb.IsChecked = true;
            }
            this.DataContext = this;
        }
        private void GoBackbt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListOfEmployeesPage());
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            ListOfEmployeesPage.currentEmployee.fio = LastNameTb.Text.Trim();
            ListOfEmployeesPage.currentEmployee.salary = int.Parse(SalaryTb.Text.Trim());
            if (ChefTb.IsChecked == true)
            {
                ListOfEmployeesPage.currentEmployee.chef = ListOfEmployeesPage.currentEmployee.id;
            }
            else
            {
                ListOfEmployeesPage.currentEmployee.chef = null;
            }
            Connection.учебная.SaveChanges();
            NavigationService.Navigate(new ListOfEmployeesPage());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListOfEmployeesPage.currentEmployee.Role = EmpCb.SelectedItem as Role;
        }

        private void DelBt_Click(object sender, RoutedEventArgs e)
        {
            Connection.учебная.Employee.Remove(ListOfEmployeesPage.currentEmployee);
            Connection.учебная.SaveChanges();
            NavigationService.Navigate(new ListOfEmployeesPage());
        }
    }
}
