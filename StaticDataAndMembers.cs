using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class StaticDataAndMembers
    {
        public double currBalance;
        public static double currInterestRate = 0.4; // static placed in one place in memory and shared beetween all members in class 
        public StaticDataAndMembers(double balance)
        {
            
            currBalance = balance; 
        }

        //Static ctor we use it in order ot change static data 
        static StaticDataAndMembers() // we can implement only one static ctor in class 
        {
            Console.WriteLine("It`s static ctor");
            currInterestRate = 0.7;
        }

       

        public static void SetInterestRate(double newBalance)
        {
            currInterestRate = newBalance;
            Console.WriteLine("New Value  seted: {0} \n\n", currInterestRate);
        }
        public static double GetInterestRate()
        {
            Console.WriteLine("Curr Rate is {0}", currInterestRate);
            return currInterestRate;
        }
    }
}
