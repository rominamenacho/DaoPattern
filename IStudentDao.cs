using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoPattern_Arquitecture
{
   public interface IStudentDao
    {
         List<Student> GetAllStudents();
        Student GetStudent(int rollNo);
        void UpdateStudent(Student s);
        void DeleteStudent(Student s);
        void AddStudent(Student s);

    }
}
