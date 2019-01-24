using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests
{
    class Program
    {
        const int firstLeft = 0;
        const int top = 7;
        const int secondLeft = 6;

        static void Main(string[] args)
        {

            ShowMain();
            Processing();
         
        }
        static void ShowMain()
        {
            // Console.WriteLine("");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("################################### Main menu ###################################");
            Console.WriteLine("     1) Adding                                                           ");
            Console.WriteLine("     2) Deleting                                                          ");
            Console.WriteLine("     3) Updating                                                          ");
            Console.WriteLine("     4) Find                                                              ");
            Console.WriteLine("     5) Analyze                                                           ");
        }
        public static void ShowAdding()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("################################### Adding ###################################");
            Console.WriteLine("1) Add student                    ");
            Console.WriteLine("2) Add group                     ");
            Console.WriteLine("3) Add grade                          ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("0) Main menu                                                                        ");
            ShAddingStudent();
        }
        public static void ShowDeleting()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("################################### Delete ###################################");
            Console.WriteLine("1) Delete student");
            Console.WriteLine("2) Delete group");
            Console.WriteLine("3) Delete grade");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("0) Main menu                                                                    ");
        }
        public static void ShowUpdating()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("################################### Upadte ###################################");
            Console.WriteLine("1) Upadte student info               ");
            Console.WriteLine("2) Update group info                ");
            Console.WriteLine("3) Update grade                      ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("0) Main menu                                                                    ");
        }
        public static void ShowFind()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("################################### Find ###################################");
            Console.WriteLine("1) Find student                          ");
            Console.WriteLine("2) Find group                                  ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("0) Main menu                                                                        ");
        }
        public static void ShowAnalyze()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("################################### Average ###################################");
            Console.WriteLine("1) Average Grades              ");
            Console.WriteLine("2) Average Age                 ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("0) Main menu                                                                 ");
        }
        public static void ShAddingStudent()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("################################### Add Student ###################################");
            Console.Write("Enter first name: ");
            string stName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string StLstName = Console.ReadLine();
            Console.Write("Enter group: ");
            int groupNumber;
            bool exit = true;
            do
            {
                string inputString = Console.ReadLine();
                if (int.TryParse(inputString, out groupNumber))
                {
                    exit = false;
                }
                string grNumber = Console.ReadLine();
            } while (exit);

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
                        ShowMain();
                        break;
                    case ConsoleKey.D1:
                        ShowAdding();
                        Console.SetCursorPosition(secondLeft, top);
                        //  Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        ShowDeleting();
                        Console.SetCursorPosition(secondLeft, top);
                        // Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        ShowUpdating();
                        Console.SetCursorPosition(secondLeft, top);
                        //  Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        ShowFind();
                        Console.SetCursorPosition(secondLeft, top);
                        //  Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        ShowAnalyze();
                        Console.SetCursorPosition(secondLeft, top);
                        //  Console.ReadKey();
                        break;

                    case ConsoleKey.NumPad0:
                        ShowMain();
                        break;
                    case ConsoleKey.NumPad1:
                        ShowAdding();
                        break;
                    case ConsoleKey.NumPad2:
                        ShowDeleting();
                        break;
                    case ConsoleKey.NumPad3:
                        ShowUpdating();
                        break;
                    case ConsoleKey.NumPad4:
                        ShowFind();
                        break;
                    case ConsoleKey.NumPad5:
                        ShowAnalyze();
                        break;

                    default:
                        break;
                }
            } while (exit);
        }

    }
}
