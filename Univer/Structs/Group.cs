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

        /// <summary>
        /// New group constructor
        /// </summary>
        /// <param name="groupNumber">Number for group</param>
        /// <param name="specialization">Speciality of group</param>
        public Group (int groupNumber, string specialization)
        {
            this._groupNumber = groupNumber;
            this._specialization = specialization;
            this.students = new Student[Creation.AMOUNT_USERS_IN_GROUP];
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
