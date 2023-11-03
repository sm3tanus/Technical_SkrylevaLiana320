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
    /// Логика взаимодействия для ListForGuestPage.xaml
    /// </summary>
    public partial class ListForGuestPage : Page
    {
        public static List<Specialization> specializations { get; set; }
        public ListForGuestPage()
        {
            InitializeComponent();
            specializations = Connection.учебная.Specialization.ToList();
            this.DataContext = this;
        }
        private void GoBackbt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }

}
