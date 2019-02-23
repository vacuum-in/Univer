using System;

namespace Univer
{

    class Program
    {
        public const int AMOUNT_USERS_IN_GROUP = 5;
        public const int AMOUNT_GRADES_PER_STUDENT = 6;
        //  private static int _groupCounter;
        //  public static Group[] groups;
        //  public static Dekanat dek = Dekanat.GetDekanat(); //ToDo: How? What is another way?


        //public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Dekanat dekanat = Dekanat.GetDekanat();
            ShowUI showUI = new ShowUI(dekanat);

            ////Container cont = new Container { groups = new Group[20] };
            ////groups = cont.groups; 
            ////   groups = new Group[20];


            dekanat.AddNewGroup("CompEngineering", 1001);
            dekanat.AddNewGroup("SoftEngineering", 2002);


            ////Creation.AddGroup(ref groups,1001, "CompEngineering");
            ////Creation.AddGroup(ref groups,2002, "SoftEngineering");
            ////int groupNumber = UIMain.GetGroupNumber();
            ////Group mygroup = GroupGetter(groupNumber);
            FillData fillData = new FillData(dekanat);

            fillData.FillGroups();
            //fillData.FillGrades(ref dekanat.groupsMass);
  
            

            dekanat.MoveToNextLevel(2002, 4004);
            UIMain.ShowGroups(dekanat);
            UIMain.ShowGrades(ref dekanat.groupsMass);
            Console.ReadKey();
            showUI.ShowUIMain();

            UIMain.ShowGroups( dekanat);
            UIMain.ShowGrades(ref dekanat.groupsMass);
            //BL.GetAvgGrade(ref mygroup);
            //BL.GetAvgAge(ref mygroup);

            Console.ReadKey();

        }
    }

    }

