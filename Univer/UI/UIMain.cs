using System;
using System.Text;

namespace Univer
{
    class UIMain
    {
        public static void ShowGroups(ref Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i] != null)
                {
                    Console.WriteLine("{0}   {1}", groups[i].specialization, groups[i].groupNumber);
                }
            }
        }

        public static int GetGroupNumber()
        {
            int val;
            string inpt = Console.ReadLine();
            int.TryParse(inpt, out val);
            return val;
        }
        public static void ShowGrades(ref Group[] groups)
        {
            for (int i = 0; i < groups.GetLength(0); i++)
            {
                if (groups[i] != null)
                {
                    Console.WriteLine("Group {0} Number {1}", groups[i].specialization, groups[i].groupNumber);
                    for (int j = 0; j < groups[i].students.GetLength(0); j++)
                    {
                        if (groups[i].students[j] != null)
                        {
                            Console.WriteLine("  {0} {1} {2}", groups[i].students[j].firstName, groups[i].students[j].lastName, groups[i].students[j].birthDay.ToLongDateString());
                            for (int k = 0; k < Creation.AMOUNT_GRADES_PER_STUDENT; k++)
                            {
                                Console.WriteLine("             {0}", groups[i].students[j].grades[k]);
                            }
                            Console.WriteLine();
                        }
                    }                
                }
            }
        }
        public static void ShowStudents(ref Student[] students)
        {            
            for (int i = 0; i < students.GetLength(0); i++)
            {
                StringBuilder sb = new StringBuilder();
                if (students[i] != null)
                {
                    Console.WriteLine("Student {0} {1}", students[i].firstName, students[i].lastName);
                    Console.WriteLine("ID {0}", students[i].id);
                    for (int j = 0; j < Creation.AMOUNT_GRADES_PER_STUDENT; j++)
                    {
                        if (students[i].grades[j] != 0)
                        {
                            sb.Append(students[i].grades[j]);
                            sb.Append("  ");
                        }
                    }
                    Console.WriteLine(sb);
                    Console.WriteLine(); ;
                }
            }
        }

    }
}