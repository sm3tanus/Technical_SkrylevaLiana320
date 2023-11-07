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
    /// Логика взаимодействия для AddSpecInDepartPage.xaml
    /// </summary>
    public partial class AddSpecInDepartPage : Page
    {
        public Specialization spec = new Specialization();
        public AddSpecInDepartPage()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Department currentDepartment = ListOfDepartmentPage.currentDepartment;
            spec.snumber = CodeSpecTb.Text;
            spec.kafedra_code = currentDepartment.code;
            spec.sname = NameSpecTb.Text;
            spec.amount = int.Parse(AmountTb.Text);
            Connection.учебная.Specialization.Add(spec);
            Connection.учебная.SaveChanges();
            NavigationService.Navigate(new ListOfSpecializationPage());
        }
    }
}