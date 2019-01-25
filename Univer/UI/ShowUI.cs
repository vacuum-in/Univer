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
            else
            {
                Console.WriteLine("There is not any group with this number");
                Console.ReadKey();
                ShowUIMain();

            }
            Tools.ClearDisplay();
        }
        public static void ShSearchStudent()
        {
            Console.WriteLine("################################### Search Student ###################################");
            Console.Write("Enter query: ");
            string query = Console.ReadLine();
            Student[] findedStudents = BL.SearchStudent(query);
            UIMain.ShowStudents(ref findedStudents);
        }

        public static void Processing()
        {
            bool exit = true;
            do
            {
                ////Console.SetCursorPosition(firstLeft, top);
                ////Console.WriteLine("Enter: ");
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
                        Middleware.UIToBLInvoker(1);
                        break;

                    case ConsoleKey.D2:
                        UING.ShowMyUI("1) Delete student", "2) Delete group", "3) Delete grade", "Delete");
                        Middleware.UIToBLInvoker(2);
                        break;

                    case ConsoleKey.D3:
                        UING.ShowMyUI("1) Upadte student info", "2) Update group info", "3) Update grade", "Update");
                        Middleware.UIToBLInvoker(3);
                        break;

                    case ConsoleKey.D4:
                        UING.ShowMyUI("1) Find student", "2) Find group", "Find");
                        Middleware.UIToBLInvoker(4);
                        break;

                    case ConsoleKey.D5:
                        UING.ShowMyUI("1) Average Grades", "2) Average Age", "Analyze");
                        Middleware.UIToBLInvoker(5);
                        break;


                    default:
                        break;
                }
            } while (exit);
        }

    }
}
