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
    /// Логика взаимодействия для AddDepartmentPage.xaml
    /// </summary>
    public partial class AddDepartmentPage : Page
    {
        public Department dep = new Department();
        public static List<Faculty> faculty { get; set; }
        public AddDepartmentPage()
        {
            InitializeComponent();
            faculty = Connection.учебная.Faculty.ToList();
            this.DataContext = this;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            dep.kname = NameTb.Text.Trim();
            dep.code = CodeSpecTb.Text.Trim();
            AllFunctions.AddDepartment(dep);
            NavigationService.Navigate(new ListOfDepartmentPage());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dep.Faculty = EmpCb.SelectedItem as Faculty;
        }
    }
}
