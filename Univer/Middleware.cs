using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    class Middleware
    {
        private ShowUI showUI;
        public Middleware(ShowUI showUI)
        {
            this.showUI = showUI;
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
                        showUI.ShAddingStudent();
                        break;
                    case ConsoleKey.D2:
                        showUI.ShAddingGroup();
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
                        showUI.ShSearchStudent();
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
