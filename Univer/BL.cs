namespace Univer
{
    using System;
    using System.Linq;

    class BL
    {
        private Dekanat dekanat;
        public BL(Dekanat dekanat)
        {
            this.dekanat = dekanat;
        }

        public Group GetGroupByIndex(int groupIndex, ref Group[] groups)
        {
            return groups[groupIndex];
        }




      
    }
}