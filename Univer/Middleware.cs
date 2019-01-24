using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    class Middleware
    {
        public static void UIToBLInvoker(int context)
        {
            ConsoleKey consoleKey = Console.ReadKey().Key;
            if (context == 1)
            {
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        break;
                    case ConsoleKey.D1:
                        ShowUI.ShAddingStudent();
                        break;
                    case ConsoleKey.D2:
                        ShowUI.ShAddingGroup();
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
                        ShowUI.ShAddingStudent();
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
                        ShowUI.ShAddingStudent();
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
                        ShowUI.ShAddingStudent();
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
