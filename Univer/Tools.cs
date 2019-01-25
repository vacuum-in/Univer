using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    class Tools
    {
      public static int ConverToInt()
        {
            int outPutNum;
            bool exit = true;
            do
            {
                string inputString = Console.ReadLine();
                if (int.TryParse(inputString, out outPutNum))
                {
                    exit = false;
                }
                else
                {
                    Console.WriteLine("Please enter number");
                }
            } while (exit);
            return outPutNum;
        }

        public static void ClearDisplay()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.WriteLine("                                                                                                      ");
            Console.SetCursorPosition(0, 0);

        }
    }
}
