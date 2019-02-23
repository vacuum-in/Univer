using System;

namespace Univer
{
    class Group
    {
        private int _groupNumber;
        private string _specialization;
        public Student[] students;

        /// <summary>
        /// New group constructor
        /// </summary>
        /// <param name="groupNumber">Number for group</param>
        /// <param name="specialization">Speciality of group</param>
        public Group(int groupNumber, string specialization)
        {
            this._groupNumber = groupNumber;
            this._specialization = specialization;
            this.students = new Student[Program.AMOUNT_USERS_IN_GROUP];
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="source"></param>
        public Group(Group source) 
        {
            _groupNumber = source.GroupNumber;
            _specialization = source.Specialization;
            students = source.students;
        }

        public void AddNewStudent(int id, string fName, string lName, DateTime birthDay)
        {
            Student student = new Student( id,  fName,  lName,  birthDay);
            for (int i = 0; i < Program.AMOUNT_USERS_IN_GROUP; i++)
            {
                if (students[i] == null)
                {
                    students[i] = student;
                    break;
                }
            }
        }
        public Student CreateNewStudent(int id, string fName, string lName, DateTime birthDay)
        {
            Student student = new Student(id, fName, lName, birthDay);
            return student;
        }
        public Double GetAvgAge()
        {
            double temp = 0;
            for (int i = 0; i < this.students.GetLength(0); i++)
            {
                temp += (DateTime.Now.Year - this[i].BirthDay.Year);
            }
            Console.WriteLine(temp / this.students.GetLength(0));
            return (temp / this.students.GetLength(0));
        }
        public double GetAvgGrade()
        {
            double temp = 0;
            for (int i = 0; i < students.GetLength(0); i++)
            {
                double[] doublearray = new double[Program.AMOUNT_GRADES_PER_STUDENT];
                doublearray = Array.ConvertAll
                temp += students[i].grades.;
            }
            Console.WriteLine(temp / group.students.GetLength(0));
            return (temp / group.students.GetLength(0));
        }
        #region Prop and Indexer
        /// <summary>
        /// Student indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Student this[int index]
        {
            get
            {
                return students[index];
            }
            set
            {
                students[index] = value;
            }
        }
        public int GroupNumber
        {
            get
            {
                return _groupNumber;
            }
            set
            {
                _groupNumber = value;
            }
        }
        public string Specialization
        {
            get
            {
                return  _specialization;
            }
            set
            {
                _specialization = value;
            }
        }
        #endregion
    }
}
