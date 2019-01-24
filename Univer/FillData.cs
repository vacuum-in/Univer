using System;

namespace Univer
{
    class FillData
    {
        public static void FillGroups(ref Group[] groups)
        {
            for (int i = 0; i < groups.GetLength(0); i++)
            {
                if (groups[i] != null)
                {
                    Creation.AddStudent(i, "ivan", "Smirnov", ref groups[i]);
                }
            }
        }
        public static void FillBirthdays(ref Group[] groups)
        {
            for (int i = 0; i < groups.GetLength(0); i++)
            {
                if (groups[i] != null)
                {
                    for (int j = 0; j < Creation.AMOUNT_USERS_IN_GROUP; j++)
                    {
                        if  (groups[i].students[j] != null)
                        {
                            DateTime Temp = (DateTime.Now.AddYears(Program.rnd.Next(-25, -18)));
                            Temp = Temp.AddDays(Program.rnd.Next(-365, 0));
                            groups[i].students[j].birthDay = Temp;
                        }
                    }
                }
            }
        }
        public static void FillGrades(ref Group[] groups)
        {
            for (int i = 0; i < groups.GetLength(0); i++)
            {
                if (groups[i] != null)
                {
                    for (int j = 0; j < Creation.AMOUNT_USERS_IN_GROUP; j++)
                    {
                        if (groups[i].students[j] != null)
                        {
                            groups[i].students[j].grades = new int[Creation.AMOUNT_GRADES_PER_STUDENT];
                            for (int k = 0; k < Creation.AMOUNT_GRADES_PER_STUDENT; k++)
                            {
                                groups[i].students[j].grades[k] = Program.rnd.Next(50, 100);
                            }
                        }

                    }
                }
            }
        }
    }
}
