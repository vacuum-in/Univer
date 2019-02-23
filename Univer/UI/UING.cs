using System;

namespace Univer.UI
{
    class UING
    {
        const int firstLeft = 0;
        const int top = 7;
        const int secondLeft = 6;

        public static void ShowMyUI(string first, string second, string third, string fourth, string fifth, string menu)
        {
            Console.Clear();
            Console.WriteLine("################################### {0} ###################################", menu);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);
            Console.WriteLine(fifth);
        }
        public static void ShowMyUI(string first, string second, string third, string fourth, string menu)
        {
            Console.Clear();
            Console.WriteLine("################################### {0} ###################################", menu);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);
        }
        public static void ShowMyUI(string first, string second, string third, string menu)
        {
            Console.Clear();
            Console.WriteLine("################################### {0} ###################################", menu);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
        public static void ShowMyUI(string first, string second, string menu)
        {
            Console.Clear();
            Console.WriteLine("################################### {0} ###################################", menu);
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
        public static void DrowEnter()
        {
            Console.SetCursorPosition(firstLeft, top);
            Console.WriteLine("Enter: ");
            Console.SetCursorPosition(secondLeft, top);
        }
    }
}
