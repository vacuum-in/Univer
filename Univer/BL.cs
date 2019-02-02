namespace Univer
{
    using System;
    using System.Linq;

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
                if (Program.groups[i] != null)
                {
                    if (Program.groups[i].GroupNumber == num)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static Student[] SearchStudent(string query)
        {
            int cnt = 0;
            Student[] findedStudents = new Student[20];
            if (int.TryParse(query, out int numb))
            {
                for (int i = 0; i <= Program.GroupCounter; i++) //ToDo Check another places with Program.GroupCounter prop ref
                {
                    if (Program.groups[i] != null)
                    {
                        for (int j = 0; j < Creation.AmountOfUsers; j++)
                        {
                            if (Program.groups[i].students[j] != null)
                            {
                                if (Program.groups[i].students[j].Id == numb)
                                {
                                    findedStudents[cnt] = Program.groups[i].students[j];
                                    ++cnt;
                                }
                            }
                        }
                    }                    
                }
            }
            else
            {
                for (int i = 0; i <= Program.GroupCounter; i++) //ToDo Check another places with Program.GroupCounter prop ref
                {
                    if (Program.groups[i] != null)
                    {
                        for (int j = 0; j < Creation.AmountOfUsers; j++)
                        {
                            if (Program.groups[i].students[j] != null)
                            {
                                if (Program.groups[i].students[j].LastName == query || Program.groups[i].students[j].LastName == query)
                                {
                                    findedStudents[cnt] = Program.groups[i].students[j];
                                    ++cnt;
                                }
                            }                          
                        }
                    }                       
                }
            }
            return findedStudents;           
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
                temp += group[i].grades.Average();
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
                temp += (DateTime.Now.Year - group[i].BirthDay.Year);
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
                    if (groups[i].students[j].FirstName == Name || groups[i].students[j].LastName == Name)
                    {
                        temp[temp.GetLength(0)] = groups[i].students[j];
                    }   
                }                
            }
            return temp;
        }
      
    }
}