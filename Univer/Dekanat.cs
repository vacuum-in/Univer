using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Univer
{
    class Dekanat
    {
        private int _groupCounter = 0;
        public Group[] groupsMass = new Group[Program.AMOUNT_USERS_IN_GROUP];

        private static Dekanat instance;
        private Dekanat()
        {

        }
        public static Dekanat GetDekanat()
        {
            if (instance == null)
            {
                instance = new Dekanat();               
            }
            return instance;
        }

        public int GroupCounter
        {
            get
            {
                return _groupCounter;
            }
            set
            {
                _groupCounter = value;
            }
        }
        public Group this[int index]
        {
            get
            {
                return groupsMass[index];
            }
            //set
            //{
            //    groupsMass[index] = value;
            //}
        }
        public void AddExistingGroup(Group group)
        {
            groupsMass[_groupCounter++] = group;
        }

        public Group AddNewGroup(string spec, int numb)
        {
            return groupsMass[_groupCounter++] = new Group(numb, spec);
        }
        /// <summary>
        /// Function creates full copy of group that it receives, including copy of array.
        /// </summary>
        /// <param name="groupNumber"></param>
        /// <returns></returns>
        public Group CreateNewGroupFromExisting(int groupNumber)
        {
            Group groupToMove = GetGroupByNumber(groupNumber);
            if (groupToMove != null)
            {

                Group againGroup = new Group(groupToMove);

                for (int i = 0; i < groupToMove.students.GetLength(0); i++)
                {
                    againGroup[i] = groupToMove[i];
                    for (int j = 0; j < Program.AMOUNT_GRADES_PER_STUDENT; j++)
                    {
                        if (groupToMove[i] != null)
                        {
                            againGroup[i][j] = groupToMove[i][j]; //If you don't want to move grades from previous course you should put 0 instead of "group.students[i].grades[j]"
                        }                      
                    }
                }
                return againGroup;
            }
            else
            {
                return null;
            }
        }

        public void MoveToNextLevel(int currentGroupNumber, int newGroupNum)
        {
            Group nextGroup = CreateNewGroupFromExisting(currentGroupNumber);
            if (nextGroup != null)
            {
                nextGroup.GroupNumber = newGroupNum;
                AddExistingGroup(nextGroup);
            }
        }
        /// <summary>
        /// Function retuns index of group by it's number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private int SelectGroupIndex(int num)
        {
            for (int i = 0; i < groupsMass.Length; i++)
            {
                if (groupsMass[i] != null)
                {
                    if (groupsMass[i].GroupNumber == num)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        /// <summary>
        /// Function returns group object by it's number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public Group GetGroupByNumber(int number)
        {
            int index = SelectGroupIndex(number);
            if (index != -1)
            {
                return groupsMass[index];
            }
            else
            {
                return null;
            }
        }
        public Student[] SearchStudent(string query)
        {
            int cnt = 0;
            Student[] findedStudents = new Student[20];
            if (int.TryParse(query, out int numb))
            {
                for (int i = 0; i <= _groupCounter; i++) //ToDo Check another places with Program.GroupCounter prop ref
                {

                    if (groupsMass[i] != null)
                    {
                        for (int j = 0; j < Program.AMOUNT_USERS_IN_GROUP; j++)
                        {
                            if (groupsMass[i].students[j] != null)
                            {
                                if (groupsMass[i].students[j].Id == numb)
                                {
                                    findedStudents[cnt] = groupsMass[i].students[j];
                                    ++cnt;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i <= _groupCounter; i++) //ToDo Check another places with Program.GroupCounter prop ref
                {
                    if (groupsMass[i] != null)
                    {
                        for (int j = 0; j < Program.AMOUNT_USERS_IN_GROUP; j++)
                        {
                            if (groupsMass[i].students[j] != null)
                            {
                                if (groupsMass[i].students[j].LastName == query || groupsMass[i].students[j].LastName == query)
                                {
                                    findedStudents[cnt] = groupsMass[i].students[j];
                                    ++cnt;
                                }
                            }
                        }
                    }
                }
            }
            return findedStudents;
        }
    }
}