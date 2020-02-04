using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class Cheked
    {
        public  void ProcessBytes()

        {
            try   // in Order to use checked we need to place code into Try {} 
            {
                byte b1 = 100;
                byte b2 = 250;
                byte sum = checked((byte)Add(b1, b2));
            }

            catch (OverflowException ex)  // and catch environment 
            {
                Console.WriteLine(ex.Message);
            }


        }



        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
