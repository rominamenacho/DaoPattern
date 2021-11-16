using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoPattern_Arquitecture
{
    class StudentDaoImpl : IStudentDao
    {
        private List<Student> studentsList;//working as a db

        public StudentDaoImpl()
        {
            studentsList = new List<Student>();
            Student student1 = new Student("Pepe", 1);
            Student student2 = new Student("Juan", 2);
            studentsList.Add(student1);
            studentsList.Add(student2);

        }

        public void AddStudent(Student s)
        {
            studentsList.Add(s);
            Console.WriteLine("$Se agrego el estudiante {0}", s.Name);
        }

        public void DeleteStudent(Student s)
        {
            studentsList.Remove(s);
            Console.WriteLine("$Se elimino el estudiante {0}", s.Name);
        }

        public List<Student> GetAllStudents()
        {
            Console.WriteLine("La lista de estudiantes es: ");
            return studentsList;
        }

        public Student GetStudent(int rollNo)
        {
           return studentsList.Find(x=> x.RollNo==rollNo);
        }

        public void UpdateStudent(Student s)
        {
           
            GetStudent(s.RollNo).Name = s.Name;
            Console.WriteLine("$Se modifico el estudiante {0}", s.RollNo);
        }
    }
}
