using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    class Student
    {
        public int id;
        public string firstName;
        public string lastName;
        public int[] grades;
        public DateTime birthDay;

        public Student(int id, string fName, string lName, int[] grades, DateTime birthDay)
        {
            this.birthDay = birthDay;
            this.firstName = fName;
            this.id = id;
            this.lastName = lName;
            this.grades = grades;
        }

    }
}
