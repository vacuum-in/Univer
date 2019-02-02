using System;

namespace Univer
{
    class Group
    {
        private int _groupNumber;
        private string _specialization;
        public Student[] students;

        public Group()
        {

        }
        public Group (int groupNumber, string specialization, Student[] students)
        {
            this._groupNumber = groupNumber;
            this._specialization = specialization;
            this.students = students;
        }

        public Group(Group source)
            : this(source._groupNumber, source._specialization,source.students)
        {
            //groupNumber = source.groupNumber;
            //specialization = source.specialization;
            //students = source.students;
        }
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
    }
}
