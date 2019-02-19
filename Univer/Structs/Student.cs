using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    class Student
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        public int[] grades; //Can hide array?
        private DateTime _birthDay;

        public Student(int id, string fName, string lName, DateTime birthDay)
        {
            this._birthDay = birthDay;
            this._firstName = fName;
            this._id = id;
            this._lastName = lName;
            this.grades = new int[Program.AMOUNT_GRADES_PER_STUDENT];
        }

        public int this[int index]
        {
            get
            {
                return grades[index];
            }
            set
            {
                grades[index] = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public DateTime BirthDay
        {
            get
            {
                return _birthDay;
            }
            set
            {
                _birthDay = value;
            }
        }
    }
}
