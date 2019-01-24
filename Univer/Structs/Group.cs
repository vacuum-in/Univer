using System;

namespace Univer
{
    class Group
    {
        public int groupNumber;
        public string specialization;
        public Student[] students;

        public Group()
        {

        }
        public Group (int groupNumber, string specialization, Student[] students)
        {
            this.groupNumber = groupNumber;
            this.specialization = specialization;
            this.students = students;
        }

        public Group(Group source)
            : this(source.groupNumber, source.specialization,source.students)
        {
            //groupNumber = source.groupNumber;
            //specialization = source.specialization;
            //students = source.students;
        }

    }
}
