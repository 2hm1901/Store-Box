using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_2._0
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string City { get; set; }

        public Student()
        {

        }
        //public static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        //{
        //    foreach (Student student in students)
        //    {
        //        if (student.FirstName == firstName && student.LastName == lastName) return true;
        //    }
        //    return false;
        //}
        //public static Student GetStudent(List<Student> students, string firstName, string lastName)
        //{
        //    Student exitStudent = null;
        //    foreach (Student student in students)
        //    {
        //        if (student.FirstName == firstName && student.LastName == lastName)
        //        {
        //            exitStudent = student;
        //        }
        //    }
        //    return exitStudent;
        //}
        
    }
}
