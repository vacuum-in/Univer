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
                        _dekanat[i][j] = _dekanat[i].CreateNewStudent(i, "ivan", "Smirnov", Temp);
                        for (int k = 0; k < Program.AMOUNT_GRADES_PER_STUDENT; k++)
                        {
                            _dekanat[i].students[j][k] = random.Next(50, 100);
                        }
                    }                   
                }
            }
        }
    }
}
