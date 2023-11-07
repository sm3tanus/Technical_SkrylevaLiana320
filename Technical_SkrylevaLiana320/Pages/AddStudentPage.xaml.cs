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
    /// Логика взаимодействия для AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        public static List<Student> students { get; set; }
        public Exam exam = new Exam();
        public AddStudentPage()
        {
            InitializeComponent();
            students = Connection.учебная.Student.ToList();
            int[] scores = { 1, 2, 3, 4, 5 };
            ScoreCb.ItemsSource = scores;
            this.DataContext = this;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            exam.teacher_id = ListExamForTeacher.currentExam.teacher_id;
            exam.cabinet = ListExamForTeacher.currentExam.cabinet;
            exam.date = ListExamForTeacher.currentExam.date;
            exam.Discipline = ListExamForTeacher.currentExam.Discipline;
            Connection.учебная.Exam.Add(exam);
            Connection.учебная.SaveChanges();
            NavigationService.Navigate(new ListOfStudentPage());
        }
        private void StudentsCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            exam.stud_id = (StudentsCb.SelectedItem as Student).id;
        }

        private void ScoreCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            exam.score = Convert.ToInt32(ScoreCb.SelectedItem);
        }
    }
}
