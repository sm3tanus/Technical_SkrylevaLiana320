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
    /// Логика взаимодействия для ListExamForTeacher.xaml
    /// </summary>
    public partial class ListExamForTeacher : Page
    {
        public static Exam currentExam;
        public static List<Employee> employee { get; set; }
        public static List<Exam> examsSort { get; set; }
        public ListExamForTeacher()
        {
            InitializeComponent();
            EmployeeTb.Text = AuthorizationPage.currentUser.fio;
            examsSort = new List<Exam>();
            List<Exam> exams = Connection.учебная.Exam.Where(i => i.teacher_id == AuthorizationPage.currentUser.id).ToList();
            foreach (Exam i in exams)
            {
                if(examsSort.FirstOrDefault(x => x.date == i.date && x.Discipline == i.Discipline) == null)
                {
                    examsSort.Add(i);
                }
            }
            this.DataContext = this;
        }

        private void GoBackbt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }

        private void ExamLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentExam = ExamLv.SelectedItem as Exam;
            NavigationService.Navigate(new ListOfStudentPage());
        }
    }
}
