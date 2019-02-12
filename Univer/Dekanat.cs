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

        public Dekanat(Group group)
        {

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
            groupsMass[++_groupCounter] = group;
        }

        public Group AddNewGroup(string spec, int numb)
        {
            return groupsMass[_groupCounter++] = new Group(numb, spec);
        }
    }
}