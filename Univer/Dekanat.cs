using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Univer
{
    class Dekanat
    {
        private int _groupCounter = 0;
        private Group[] groupsMass = new Group[Creation.AMOUNT_USERS_IN_GROUP];

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
            groupsMass[++_groupCounter] = group;
        }

        public Group AddNewGroup(string spec, int numb)
        {
            return groupsMass[_groupCounter++] = new Group(numb, spec);
        }

        public Group CreateNewGroupFromExisting(int groupNumber)
        {
            int index = SelectGroupIndex(groupNumber);
            if (index != -1)
            {
                Group groupToMove = groupsMass[index]; 
                Group againGroup = new Group(groupToMove);

                for (int i = 0; i < groupToMove.students.GetLength(0); i++)
                {
                    againGroup[i] = groupToMove[i];
                    for (int j = 0; j < Creation.AMOUNT_GRADES_PER_STUDENT; j++)
                    {
                        againGroup[i][j] = groupToMove[i][j]; //If you don't want to move grades frop previous course you should put 0 instead of "group.students[i].grades[j]"
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
            Group nextGroup = new Group();
            nextGroup = CreateNewGroupFromExisting(currentGroupNumber);
            if (nextGroup != null)
            {
                nextGroup.GroupNumber = newGroupNum;
                AddExistingGroup(nextGroup);
            }
        }
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
    }
}