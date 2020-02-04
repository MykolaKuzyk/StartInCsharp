using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class TypeConversions
    {
        public void _newTypeConvers()
        {
            Console.WriteLine(" *** Start Work with type Conversions method _newTypeConver *** ");
            short numb1 = 9, numb2 = 10;
            Console.WriteLine("{0} + {1}  = {2}", numb1 , numb2, Add(numb1,numb2));
            Console.WriteLine(" *** END Work with type Conversions  method _newTypeConver *** ");
            Console.WriteLine("");
            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        public void _explicitvalue()
        {
            short numb3 = 30000, numb4 = 30000;
            Console.WriteLine(" *** Start Work with type Conversions method _explicitvalue *** ");
            // explicit 
            short answer = (short)Add(numb3, numb4);
            Console.WriteLine("{0} + {1} = {2}", numb3, numb4, answer);
            NarrowingAttempt();
            Console.WriteLine(" *** END Work with type Conversions method _explicitvalue *** ");
            Console.WriteLine();
            Console.ReadLine();
        }
        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            /// int to byte 
            /// 
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }
    }
}
