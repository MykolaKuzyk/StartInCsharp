using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class varproje
    {
        public void _newVar1()
        {
            int[] numbers = { 10, 29, 32, 1, 3, 4, 123 };
            // linq question

            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset : ");
            foreach (var i in subset)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine();
            Console.WriteLine("subset is a : {0}", subset.GetType());
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);

        }


        
    }
}
