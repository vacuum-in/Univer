using System;

namespace Univer
{
    class FillData
    {
        Random random = new Random();

        private Dekanat _dekanat;
        public FillData(Dekanat dekanat)
        {
            this._dekanat = dekanat;
        }
        public void FillGroups()
        {
            for (int i = 0; i < _dekanat.groupsMass.GetLength(0); i++)
            {
                if (_dekanat[i] != null)
                {
                    for (int j = 0; j < Program.AMOUNT_USERS_IN_GROUP; j++)
                    {
                        DateTime Temp = (DateTime.Now.AddYears(random.Next(-25, -18)));
                        Temp = Temp.AddDays(random.Next(-365, 0));
                        _dekanat[i][j] = _dekanat[i].AddNewStudent(i, "ivan", "Smirnov", Temp);
                        for (int k = 0; k < Program.AMOUNT_GRADES_PER_STUDENT; k++)
                        {
                            _dekanat[i].students[j][k] = random.Next(50, 100);
                        }
                    }                   
                }
            }
        }
        //public void FillBirthdays(ref Group[] groups)
        //{
        //    for (int i = 0; i < groups.GetLength(0); i++)
        //    {
        //        if (groups[i] != null)
        //        {
        //            for (int j = 0; j < Creation.AMOUNT_USERS_IN_GROUP; j++)
        //            {
        //                if  (groups[i].students[j] != null)
        //                {
        //                    DateTime Temp = (DateTime.Now.AddYears(Program.rnd.Next(-25, -18)));
        //                    Temp = Temp.AddDays(Program.rnd.Next(-365, 0));
        //                    groups[i].students[j].BirthDay = Temp;
        //                }
        //            }
        //        }
        //    }
        //}
        //public void FillGrades(ref Group[] groups)
        //{
        //    for (int i = 0; i < groups.GetLength(0); i++)
        //    {
        //        if (groups[i] != null)
        //        {
        //            for (int j = 0; j < Creation.AMOUNT_USERS_IN_GROUP; j++)
        //            {
        //                if (groups[i].students[j] != null)
        //                {
        //                    groups[i].students[j].grades = new int[Creation.AMOUNT_GRADES_PER_STUDENT];
        //                    for (int k = 0; k < Creation.AMOUNT_GRADES_PER_STUDENT; k++)
        //                    {
        //                        groups[i].students[j][k] = random.Next(50, 100);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
