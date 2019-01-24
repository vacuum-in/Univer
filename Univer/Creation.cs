using System;
namespace Univer
{
    class Creation
    {
        public const int AMOUNT_USERS_IN_GROUP = 5;
        public const int AMOUNT_GRADES_PER_STUDENT = 6;

        public static void AddNewStudent(int id, string fName, string lName, ref Group group)
        {
            if (group.students == null)
            {
                group.students = new Student[AMOUNT_USERS_IN_GROUP];
            }
            for (int i = 0; i < AMOUNT_USERS_IN_GROUP; i++)
            {
                if (group.students[i] == null) // How can I check if object is initialized?
                {
                    Student newStudent = new Student(id, fName + i, lName + i, new int[AMOUNT_GRADES_PER_STUDENT], new DateTime());
                    group.students[i] = newStudent;
                }
            }
        }

        public static void AddStudent(int id, string fName, string lName, ref Group group)
        {
            if (group.students == null)
            {
                group.students = new Student[AMOUNT_USERS_IN_GROUP];
            }

            for (int i = 0; i < AMOUNT_USERS_IN_GROUP -1; i++)
            {
               // if (group.students[i].firstName == null && group.students[i].lastName == null) // How can I check if object is initialized?
                {
                    Student newStudent = new Student( id , fName + i, lName + i,  new int[AMOUNT_GRADES_PER_STUDENT], new DateTime() );
                    group.students[i] = newStudent;
                }
            }
        }

        public static void AddNewGroup( int groupNum, string spec)
        {
            Student[] studs = new Student[AMOUNT_USERS_IN_GROUP];
            Program.groups[Program.GroupCounter] = new Group(groupNum, spec, studs);
            ++Program.GroupCounter;

        }

        /// <summary>
        /// This func creates new group and adds it to grop array "groups"   
        /// </summary>
        /// <param name="groups">This is array with our groups</param>
        /// <param name="groupNum">This is a unique group identifier </param>
        /// <param name="spec">String that explain group specification</param>
        /// <param name="groupCounter">Counter for amount of gruops</param>
        public static void AddGroup(ref Group[] groups, int groupNum, string spec)
        {
            Student[] studs = new Student[AMOUNT_USERS_IN_GROUP];
            Group temp = new Group() { groupNumber = groupNum, specialization = spec, students = studs };
            groups[Program.GroupCounter] = temp;
            ++Program.GroupCounter;
        }

        /// <summary>
        /// This func adds existing group to array "groups"
        /// </summary>
        /// <param name="newGroupNum">new number of group</param>
        /// <param name="groupCounter">Counter for amount of gruops</param>
        /// <param name="inGroup">input group object</param>
        public static void AddGroup( ref Group inGroup, ref Group[] groups)
        {
            groups[Program.GroupCounter] = inGroup;
            ++Program.GroupCounter;
        }

        /// <summary>
        /// This func adds existing group to array "groups", but change its' group number
        /// </summary>
        /// <param name="newGroupNum">new number of group</param>
        /// <param name="groupCounter">Counter for amount of gruops</param>
        /// <param name="inGroup">input group object</param>
        public static void AddGroup(int newGroupNum, ref Group inGroup, ref Group[] groups)
        {
            inGroup.groupNumber = newGroupNum;
            groups[Program.GroupCounter] = inGroup;
            ++Program.GroupCounter;
        }
        public static Group CreateNewGroupFromExisting(ref Group groupToMove)
        {
            Group againGroup = new Group(groupToMove);

//            againGroup.students = new Student[AMOUNT_USERS_IN_GROUP];

            for (int i = 0; i < groupToMove.students.GetLength(0); i++)
            {
                againGroup.students[i] = groupToMove.students[i];
                for (int j = 0; j < AMOUNT_GRADES_PER_STUDENT; j++)
                {
                    againGroup.students[i].grades[j] = groupToMove.students[i].grades[j]; //If you don't want to move grades frop previous course you should put 0 instead of "group.students[i].grades[j]"
                }
            }
            return againGroup;
        }
        public static int AmountOfUsers {
            get
            {
                return AMOUNT_USERS_IN_GROUP;
            }
        }
    }
}
