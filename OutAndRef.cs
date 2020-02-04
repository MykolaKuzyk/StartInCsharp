using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class OutAndRef
    {
        public void _AddOUR(int a, int b , out int ans)  // out - similar to ref, but you must inicialize out vale in method while ref can be initialized before method   
        {
            ans = a + b;

            Console.WriteLine();
            Console.WriteLine(" **** Lesson about Out Ref etc. method _AddOUR  **** ");
            Console.WriteLine("The value for ans Step 1:{0}", ans);
            ans = 78;
            Console.WriteLine("The value for ans Step 2:{0}", ans);
            Console.WriteLine(" **** END of out Ref lesson method _AddOUR**** ");
            Console.WriteLine();
        }
        public void _NewRefExample(ref int a, int a1) // ref - works directly with reference on value therefore 
        {                                             //if you have changed something in method with ref value it will change the rest of code for this variable
            a = 15;
            a1 = 30;

            Console.WriteLine(" **** Lesson about Out Ref etc. method _NewRefExample **** ");
            Console.WriteLine("This is your a value step 1: {0}", a);
            Console.WriteLine("This is a1 step 1: {0}", a1);
            Console.WriteLine("This is your a value step 2: {0}", a);
            Console.WriteLine("This is your a1 value step 2: {0}", a);
            Console.WriteLine(" **** END of out Ref lesson method _NewRefExample **** ");
        }
        public void _ParamsMethod(params double[] values) // params allows us to gather a lot of variables into one scope 
        {
            Console.WriteLine();
            Console.WriteLine(" **** Lesson about Out Ref etc. method _ParamsMethod **** ");
            Console.WriteLine("You sent me {0} double values ", values.Length);
            foreach (double i in values)
            {
                Console.WriteLine("*:{0}", i);
            }


            Console.WriteLine(" **** END of out Ref lesson method _ParamsMethod **** ");
            Console.WriteLine();
        }
    }
}
