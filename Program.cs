using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoPattern_Arquitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentDao studentDao = new StudentDaoImpl();

            foreach (Student x in studentDao.GetAllStudents()) {
                Console.WriteLine( "$Student: id {0} name: {1}", x.RollNo, x.Name);
            }

            //update
            Student st1 = studentDao.GetStudent(1);
            st1.Name = "michael";
            studentDao.UpdateStudent(st1);

           Console.WriteLine( "metodo get: " + studentDao.GetStudent(2).Name);

            Console.ReadKey();
        }
    }
}
