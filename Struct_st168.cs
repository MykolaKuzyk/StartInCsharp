using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class Struct_st168 // well to use struct with arithmetics and math examples, you can assign struct to struckt and then you won`t miss your data, but if you will use  method instead of struct you will work with a reference type.  
    {                  // struct  -  tip znaczenia 
                       // new class - ref type

        public struct Point
        {
            // polya struktury
            public int x;
            public int y;
            // Add  1 to (x y)
            public void incriment()
            {
                x++; y--;
            }
            public void decrement()
            {
                x--; y--;
            }
            //show this position
            public void Display()
            {
                Console.WriteLine("X = {0}, Y = {1}", x, y);
            }

        }
        public void _newMethodStruct()
        {
            Console.WriteLine("");
            Console.WriteLine(" *** Start Struct method _newMethodStruct *** ");
            Point p1;
            p1.x = 10;
            p1.y = 20;
            p1.Display();
            Point p2 = p1;
            p1.decrement();
            p1.incriment();
            p1.incriment();
            p1.incriment();
            p1.Display();
            p2.Display();
            Console.ReadLine();
            
            Console.WriteLine(" *** END Struct method _newMethodStruct *** ");
            Console.WriteLine("");
        }

    }
}
