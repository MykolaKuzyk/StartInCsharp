using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class StructRef_st172
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

       
        public StructRef_st172(int XPos, int YPos)
        {
            x = XPos;
            y = YPos;
            
        }
    }
}
