using System;

namespace Univer
{

    class Program
    {
        //  private static int _groupCounter;
        //  public static Group[] groups;
        //  public static Dekanat dek = Dekanat.GetDekanat(); //ToDo: How? What is another way?


        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Dekanat container = Dekanat.GetDekanat();
            ShowUI showUI = new ShowUI(container);

            ////Container cont = new Container { groups = new Group[20] };
            ////groups = cont.groups; 
            ////   groups = new Group[20];


            //dekanat.AddNewGroup("CompEngineering", 1001);
            //dekanat.AddNewGroup("SoftEngineering", 2002);


            ////Creation.AddGroup(ref groups,1001, "CompEngineering");
            ////Creation.AddGroup(ref groups,2002, "SoftEngineering");
            ////int groupNumber = UIMain.GetGroupNumber();
            ////Group mygroup = GroupGetter(groupNumber);


            //FillData.FillGroups(ref dekanat.groupsMass);
            //FillData.FillGrades(ref dekanat.groupsMass);
            //FillData.FillBirthdays(ref dekanat.groupsMass);
            //UIMain.ShowGroups(ref dekanat.groupsMass);
            //UIMain.ShowGrades(ref dekanat.groupsMass);
            //Console.ReadKey();
            //ShowUI.ShowUIMain();
            ////      BL.MoveToNextLevel(ref mygroup, mygroup.groupNumber + 1000 , ref groups);

            //UIMain.ShowGroups(ref dekanat.groupsMass);
            //UIMain.ShowGrades(ref dekanat.groupsMass);
            ////BL.GetAvgGrade(ref mygroup);
            ////BL.GetAvgAge(ref mygroup);

            //Console.ReadKey();

        }
        //public void test()
        //{
        //    Initializer.Init();
        //}
        //public static Group GroupGetter(int groupNumber)
        //{

        //    int groupIndex = BL.SelectGroupIndex(groupNumber);
        //    Group mygroup = BL.GetGroupByIndex(groupIndex, ref init);
        //    return mygroup;
        //}

        //public static Group[] GroupsMassGetter()
        //{
        //    Container cont = new Container();
        //    cont.groups = new Group[20];
        //    Group[] groups = cont.groups;
        //    return groups;
        //}
        //public static int GroupCounter
        //{
        //    get
        //    {
        //        return _groupCounter;
        //    }
        //    set
        //    {
        //        _groupCounter = value;
        //    }
        //}
    }

    }

