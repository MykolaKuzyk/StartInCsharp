using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp // named variavbles means that we can type like this "variable:value" in method, instead of using another variable
{
    class NamedParams_st_153
    {
        public void _DisplayMessage(ConsoleColor textcolor, ConsoleColor backgroundColor, string message)
        {
            Console.WriteLine("");
            Console.WriteLine(" **** Start function NamedParams_st_153 method _DisplayMessage ****");
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;
            // set new colors 
            Console.ForegroundColor = textcolor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            Console.ReadLine();
            // set old colors back
            Console.ResetColor();
            Console.WriteLine(" **** End function NamedParams_st_153 method _DisplayMessage **** ");
            Console.WriteLine("");
        }
        public void _St153_For_Test(int i, int a, bool what)
        {
            string yesNo = "";
            Console.WriteLine("");
            Console.WriteLine(" **** Start function NamedParams_st_153 method _St153_For_Test **** ");
            Console.WriteLine("Let`s do light show ? type YES? or NO?");
            yesNo = Console.ReadLine();
            if (yesNo == "YES" ||yesNo=="yes" || yesNo=="Yes" )
            {
                what = true;
                    if (what == true) {
                    ConsoleColor[] color1 = { ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Magenta,
                ConsoleColor.DarkYellow,
                ConsoleColor.DarkBlue,
                ConsoleColor.DarkCyan,
                ConsoleColor.Cyan };
                    ConsoleColor colorr;
                    while (i >= 0)
                    {
                        colorr = color1[i];
                        Console.BackgroundColor = colorr;
                        Console.WriteLine("*              *");
                        i--;
                    }
                }
                else
                {
                    what = false;
                }
            }
            else
            {
                Console.WriteLine("Ok have a nice day ");
            }
            Console.ResetColor();
            Console.WriteLine(" **** End function NamedParams_st_153 method _St153_For_Test **** ");
            Console.WriteLine("");
        }
    }

}
