using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class NullOpp
    {
        public int? numericValue = null; 
        public bool? boolValue = true;

        public int? GetValueFromDataBase()
        { 
            return numericValue; 
        }

        public bool? GetFromDatabase()
        {
            return boolValue;
        }


        public void _myMain()
        {
            Console.WriteLine("");
            Console.WriteLine(" **** START NullOpp method _myMain **** ");
            NullOpp dr = new NullOpp { };
            int? i = dr.GetValueFromDataBase();
            if (i.HasValue)
            {
                Console.WriteLine("Value of 'i' is {0}", i.Value);

            }
            else
            {
                Console.WriteLine("Value of i is undefined");
            }

            bool? b = dr.GetFromDatabase();
            if (b != null)
            {
                Console.WriteLine("The value for b is {0}", b.Value);
            }
            else
            {
                Console.WriteLine("There is no value for b");

            }

            Console.ReadLine();

            
            Console.WriteLine(" **** END NullOpp method _myMain **** ");
            Console.WriteLine("");
        }
    }
}
