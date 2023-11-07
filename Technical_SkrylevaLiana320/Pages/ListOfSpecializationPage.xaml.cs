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
    /// Логика взаимодействия для ListOfSpecializationPage.xaml
    /// </summary>
    public partial class ListOfSpecializationPage : Page
    {
        public static Specialization currentSpec;
        public static List<Specialization> spec { get; set; }
        public ListOfSpecializationPage()
        {
            InitializeComponent();
            Department currentDepartment = ListOfDepartmentPage.currentDepartment;
            spec = Connection.учебная.Specialization.Where(i => i.kafedra_code == currentDepartment.code).ToList();
            this.DataContext = this;
        }

        private void GoBackbt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListOfDepartmentPage());
        }

        private void addBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddSpecInDepartPage());
        }

        private void delBt_Click(object sender, RoutedEventArgs e)
        {
            Connection.учебная.Department.Remove(ListOfDepartmentPage.currentDepartment);
            Connection.учебная.SaveChanges();
            NavigationService.Navigate(new ListOfSpecializationPage());
        }

        private void DepLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentSpec = DepLv.SelectedItem as Specialization;
        }

        private void editBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditSpecPage());
        }
    }
}
