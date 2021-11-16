using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoPattern_Arquitecture
{
   public class Student
    {
        private string name;
        private int rollNo;

        public string Name { get => name; set => name = value; }
        public int RollNo { get => rollNo; set => rollNo = value; }

        public Student(string _name, int _rollNo)
        {
            this.Name = _name;
            this.RollNo = _rollNo;
        }
    }
}
