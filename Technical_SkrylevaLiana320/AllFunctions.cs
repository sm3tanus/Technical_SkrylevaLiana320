using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technical_SkrylevaLiana320.DBconnection;
using Technical_SkrylevaLiana320.Pages;

namespace Technical_SkrylevaLiana320
{
    public class AllFunctions
    {

        public static void AddStudentInExam(Exam exam)
        {
            Connection.учебная.Exam.Add(exam);
            Connection.учебная.SaveChanges();
        }
        public static void AddSpecInDepartment(Specialization spec)
        {
            Connection.учебная.Specialization.Add(spec);
            Connection.учебная.SaveChanges();
        }
        public static void AddEmployee(Employee employee)
        {
            Connection.учебная.Employee.Add(employee);
            Connection.учебная.SaveChanges();
        }
        public static void AddDepartment(Department department)
        {
            Connection.учебная.Department.Add(department);
            Connection.учебная.SaveChanges();
        }
        public static void DeleteExam(Exam exam)
        {
            Connection.учебная.Exam.Remove(exam);
            Connection.учебная.SaveChanges();
        }
        public static void DeleteDepartment(Department department)
        {
            Connection.учебная.Department.Remove(department);
            Connection.учебная.SaveChanges();
        }
        public static void DeleteEmployee(Employee employee)
        {
            Connection.учебная.Employee.Remove(employee);
            Connection.учебная.SaveChanges();
        }
        
            
    }
}
