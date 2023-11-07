using System;
using System.Collections.Generic;
using System.Data.Common;
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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public static Employee currentUser;
        public static List<Employee> employee {  get; set; }
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void EnterBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = LoginTb.Text.Trim();
                int password = int.Parse(PasswordPb.Password.Trim());
                currentUser = Connection.учебная.Employee.FirstOrDefault(x => x.fio == login && x.id == password);
                if (currentUser.idRole == 1)
                {
                    MessageBox.Show("Добро пожаловать, " + currentUser.fio);
                    NavigationService.Navigate(new ListExamForTeacher());

                }
                else if (currentUser.idRole == 2)
                {
                    MessageBox.Show("Добро пожаловать, " + currentUser.fio);
                    NavigationService.Navigate(new ListOfDepartmentPage());
                }
                else if (currentUser.idRole == 3)
                {
                    MessageBox.Show("Добро пожаловать, " + currentUser.fio);
                    NavigationService.Navigate(new ListOfEmployeesPage());
                }
                else
                {
                    MessageBox.Show("Неверные данные");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            
        }

        private void GuestBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListForGuestPage());
        }
    }
}
