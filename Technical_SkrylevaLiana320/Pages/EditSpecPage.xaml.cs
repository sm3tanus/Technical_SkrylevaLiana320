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
    /// Логика взаимодействия для EditSpecPage.xaml
    /// </summary>
    public partial class EditSpecPage : Page
    {
        public EditSpecPage()
        {
            InitializeComponent();
            CodeSpecTb.Text = ListOfSpecializationPage.currentSpec.snumber;
            NameSpecTb.Text = ListOfSpecializationPage.currentSpec.sname;
            AmountTb.Text = ListOfSpecializationPage.currentSpec.amount.ToString();
            this.DataContext = this;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            ListOfSpecializationPage.currentSpec.snumber = CodeSpecTb.Text;
            ListOfSpecializationPage.currentSpec.sname = NameSpecTb.Text;
            ListOfSpecializationPage.currentSpec.amount = int.Parse(AmountTb.Text);
            ListOfSpecializationPage.currentSpec.kafedra_code = ListOfDepartmentPage.currentDepartment.code;
            Connection.учебная.SaveChanges();
            NavigationService.Navigate(new ListOfSpecializationPage());
        }
    }
}
