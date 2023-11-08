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
    /// Логика взаимодействия для ListOfStudentPage.xaml
    /// </summary>
    public partial class ListOfStudentPage : Page
    {
        public static List<Student> students { get; set; }
        public static List<Exam> exams { get; set; }
        public Exam deleteExam;
        public ListOfStudentPage()
        {
            InitializeComponent();
            EmployeeTb.Text = AuthorizationPage.currentUser.fio;
            exams = Connection.учебная.Exam.Where(i => i.date == ListExamForTeacher.currentExam.date && i.Discipline.code == ListExamForTeacher.currentExam.Discipline.code).ToList();
            nameDiscTb.Text = ListExamForTeacher.currentExam.Discipline.dname;
            dateDiscTb.Text = ListExamForTeacher.currentExam.date.ToString();
            this.DataContext = this;
        }

        private void GoBackbt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListExamForTeacher());
        }

        private void StudentLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deleteExam = StudentLv.SelectedItem as Exam;  
        }

        private void addStbt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddStudentPage());
        }

        private void DelStbt_Click(object sender, RoutedEventArgs e)
        {
            AllFunctions.DeleteExam(deleteExam);
            NavigationService.Navigate(new ListOfStudentPage());
        }
    }
}
