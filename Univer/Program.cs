using System;

namespace Univer
{
    
    class Program
    {
        private static int _groupCounter;
        public static Group[] groups;

        public static Random rnd = new Random();

        static void Main(string[] args)
        {
           

            //Container cont = new Container { groups = new Group[20] };
            //groups = cont.groups; 
            groups = new Group[20];

            Creation.AddGroup(ref groups,1001, "CompEngineering");
            Creation.AddGroup(ref groups,2002, "SoftEngineering");
            //int groupNumber = UIMain.GetGroupNumber();
            //Group mygroup = GroupGetter(groupNumber);

            FillData.FillGroups(ref groups);
            FillData.FillGrades(ref groups);
            FillData.FillBirthdays(ref groups);
            UIMain.ShowGroups(ref groups);
            UIMain.ShowGrades(ref groups);
            Console.ReadKey();
            ShowUI.ShowUIMain();
            //      BL.MoveToNextLevel(ref mygroup, mygroup.groupNumber + 1000 , ref groups);

            UIMain.ShowGroups(ref groups);
            UIMain.ShowGrades(ref groups);
            //BL.GetAvgGrade(ref mygroup);
            //BL.GetAvgAge(ref mygroup);

            Console.ReadKey();
            
        }
        public static Group GroupGetter(int groupNumber)
        {
            int groupIndex = BL.SelectGroupIndex(groupNumber);
            Group mygroup = BL.GetGroupByIndex(groupIndex, ref groups);
            return mygroup;
        }
        //public static Group[] GroupsMassGetter()
        //{
        //    Container cont = new Container();
        //    cont.groups = new Group[20];
        //    Group[] groups = cont.groups;
        //    return groups;
        //}
        public static int GroupCounter
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
    }

    }

