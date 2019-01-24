using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.UI;

namespace Univer
{
    class ShowUI
    {
        const int firstLeft = 0;
        const int top = 7;
        const int secondLeft = 6;

        public static void ShowUIMain()
        {
        Tools.ClearDisplay();
        UING.ShowMyUI("1) Adding", "2) Deleting", "3) Updating", "4) Find", "5) Analyze", "Main Menu");
            Processing();

        }

        public static void ShAddingGroup()
        {
            Tools.ClearDisplay();
            Console.WriteLine("################################### Add Group ###################################");
            Console.Write("Enter specialization: ");
            string specialization = Console.ReadLine();
            Console.Write("Enter group number: ");
            int groupNumber = Tools.ConverToInt();
            Creation.AddNewGroup(groupNumber, specialization);
        }  
        public static void ShAddingStudent()
        {
            Tools.ClearDisplay();
            Console.WriteLine("################################### Add Student ###################################");
            Console.Write("Enter first name: ");
            string stName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string stLstName = Console.ReadLine();
            Console.Write("Enter student's number: ");
            int studentNumber = Tools.ConverToInt();
            Console.Write("Enter group number: ");
            int groupNumber = Tools.ConverToInt();
            if ((BL.SelectGroupIndex(groupNumber)) != -1)
            {
            Group ourGroup = Program.GroupGetter(groupNumber);
                Creation.AddNewStudent(studentNumber, stName, stLstName, ref ourGroup);
            }       
            Tools.ClearDisplay();
        }

        public static void Processing()
        {
            bool exit = true;
            do
            {
                Console.SetCursorPosition(firstLeft, top);
                Console.WriteLine("Enter: ");
                Console.SetCursorPosition(secondLeft, top);
                // Console.ReadKey();
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Escape:
                        exit = false;
                        break;
                    case ConsoleKey.D0:
                        UING.ShowMyUI("1) Adding", "2) Deleting", "3) Updating", "4) Find", "5) Analyze", "Main Menu");
                    break;
                    case ConsoleKey.D1:
                        UING.ShowMyUI("1) Add student", "2) Add group", "3) Add Grade", "Adding");
                    Console.SetCursorPosition(secondLeft, top);
                    Middleware.UIToBLInvoker(1);
                        //  Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                    UING.ShowMyUI("1) Delete student", "2) Delete group", "3) Delete grade", "Delete");
                        Console.SetCursorPosition(secondLeft, top);
                        // Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                    UING.ShowMyUI("1) Upadte student info", "2) Update group info", "3) Update grade", "Update");
                    Console.SetCursorPosition(secondLeft, top);
                        //  Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                    UING.ShowMyUI("1) Find student", "2) Find group", "Find");

                    Console.SetCursorPosition(secondLeft, top);
                        //  Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                    UING.ShowMyUI("1) Average Grades", "2) Average Age", "Analyze");

                    Console.SetCursorPosition(secondLeft, top);
                        //  Console.ReadKey();
                        break;

                    //case ConsoleKey.NumPad0:
                    //    ShowMain();
                    //    break;
                    //case ConsoleKey.NumPad1:
                    //    ShowAdding();
                    //    break;
                    //case ConsoleKey.NumPad2:
                    //    ShowDeleting();
                    //    break;
                    //case ConsoleKey.NumPad3:
                    //    ShowUpdating();
                    //    break;
                    //case ConsoleKey.NumPad4:
                    //    ShowFind();
                    //    break;
                    //case ConsoleKey.NumPad5:
                    //    ShowAnalyze();
                    //    break;

                    default:
                        break;
                }
            } while (exit);
        }

    }
}
