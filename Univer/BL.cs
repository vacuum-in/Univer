using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    class BL
    {
        /// <summary>
        /// Search index of group bu group number
        /// </summary>
        /// <param name="num">Number of group</param>
        /// <param name="groups">Array of groups</param>
        /// <returns>Index of gruop we search</returns>
        public static int SelectGroupIndex(int num)
        {
            for (int i = 0; i < Program.groups.Length; i++)
            {
                if (Program.groups[i].groupNumber == num)
                {
                    return i;
                }
            }
            return -1;
        }

        public static Student SearchStudent(string query)
        {
            if (int.TryParse(query, out int numb))
            {
                for (int i = 0; i <= Program.GroupCounter; i++) //ToDo Check another places with Program.GroupCounter prop ref
                {
                    for (int j = 0; j < Creation.AmountOfUsers; j++)
                    {
                        if (Program.groups[i].students[j].id == numb)
                        {
                            return Program.groups[i].students[j];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i <= Program.GroupCounter; i++) //ToDo Check another places with Program.GroupCounter prop ref
                {
                    for (int j = 0; j < Creation.AmountOfUsers; j++)
                    {
                        if (Program.groups[i].students[j].lastName == query || Program.groups[i].students[j].lastName == query)
                        {
                            return Program.groups[i].students[j];
                        }

                    }
                }
            }
            return null;           
        }
        public static Group GetGroupByIndex(int groupIndex, ref Group[] groups)
        {
            return groups[groupIndex];
        }

        public static void MoveToNextLevel(ref Group inGroup, int newGroupNum, ref Group[] groups)
        {
            Group nextGroup = new Group();
            nextGroup = Creation.CreateNewGroupFromExisting(ref inGroup);
            Creation.AddGroup(newGroupNum, ref nextGroup, ref groups);
        }

        public static double GetAvgGrade(ref Group group)
        {
            double temp = 0;
            for (int i = 0; i < group.students.GetLength(0); i++)
            {
                temp += group.students[i].grades.Average();
            }
            Console.WriteLine(temp / group.students.GetLength(0));
            return (temp / group.students.GetLength(0));
        }
        public static Double GetAvgAge(ref Group group)
        {
            double temp = 0;
            //DateTime tmpDate = new DateTime();
            for (int i = 0; i < group.students.GetLength(0); i++)
            {
                temp += (DateTime.Now.Year - group.students[i].birthDay.Year);
            }
            Console.WriteLine(temp / group.students.GetLength(0));
            return (temp / group.students.GetLength(0));
        }
        public static Student[] FindStudent(string Name, ref Group[] groups)
        {
            Student[] temp = new Student[20];
            for (int i = 0; i < Program.GroupCounter; i++)
            {
                for (int j = 0; j < groups[i].students.GetLength(0); j++)
                {
                    if (groups[i].students[j].firstName == Name || groups[i].students[j].lastName == Name)
                    {
                        temp[temp.GetLength(0)] = groups[i].students[j];
                    }   
                }                
            }
            return temp;
        }
      
    }
}