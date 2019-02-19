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
        private Dekanat dekanat;
        //private Middleware middleware;
        

        //public ShowUI(Middleware middleware)
        //{
        //    this.middleware = middleware;
        //}
        public ShowUI(Dekanat dekanat)
        {
            this.dekanat = dekanat;
        }

    public void ShowUIMain()
        {
        Tools.ClearDisplay();
        UING.ShowMyUI("1) Adding", "2) Deleting", "3) Updating", "4) Find", "5) Analyze", "Main Menu");
            this.Processing();

        }

        public void ShAddingGroup()
        {
            Tools.ClearDisplay();
            Console.WriteLine("################################### Add Group ###################################");
            Console.Write("Enter specialization: ");
            string specialization = Console.ReadLine();
            Console.Write("Enter group number: ");
            int groupNumber = Tools.ConverToInt();
            dekanat.AddNewGroup(specialization, groupNumber);
            
        }  
        public void ShAddingStudent()
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
            Group ourGroup = dekanat.GetGroupByNumber(groupNumber);
            if (ourGroup != null)
            {
                ourGroup.AddNewStudent(studentNumber, stName, stLstName, DateTime.MinValue);
            }
            else
            {
                Console.WriteLine("There is not any group with this number");
                Console.ReadKey();
                ShowUIMain();

            }
            Tools.ClearDisplay();
        }
        public void ShSearchStudent()
        {
            Console.WriteLine("################################### Search Student ###################################");
            Console.Write("Enter query: ");
            string query = Console.ReadLine();
            Student[] findedStudents = dekanat.SearchStudent(query);
            UIMain.ShowStudents(ref findedStudents);
        }

        public void Processing()
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
                        UIToBLInvoker(1);
                        break;

                    case ConsoleKey.D2:
                        UING.ShowMyUI("1) Delete student", "2) Delete group", "3) Delete grade", "Delete");
                        UIToBLInvoker(2);
                        break;

                    case ConsoleKey.D3:
                        UING.ShowMyUI("1) Upadte student info", "2) Update group info", "3) Update grade", "Update");
                        UIToBLInvoker(3);
                        break;

                    case ConsoleKey.D4:
                        UING.ShowMyUI("1) Find student", "2) Find group", "Find");
                        UIToBLInvoker(4);
                        break;

                    case ConsoleKey.D5:
                        UING.ShowMyUI("1) Average Grades", "2) Average Age", "Analyze");
                        UIToBLInvoker(5);
                        break;


                    default:
                        break;
                }
            } while (exit);
        }
        public void UIToBLInvoker(int context)
        {

            ConsoleKey consoleKey = Console.ReadKey().Key;
            //Tools.ClearDisplay();
            if (context == 1)
            {
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        ShAddingStudent();
                        break;
                    case ConsoleKey.D2:
                        ShAddingGroup();
                        break;

                    default:
                        break;
                }
            }
            if (context == 2)
            {
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        // ShowUI.ShAddingStudent();
                        break;
                    case ConsoleKey.D2:
                        break;

                    default:
                        break;
                }
            }
            if (context == 3)
            {
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;

                    default:
                        break;
                }
            }
            if (context == 4)
            {
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        ShSearchStudent();
                        break;
                    case ConsoleKey.D2:
                        break;

                    default:
                        break;
                }
            }
        }

    }
}
