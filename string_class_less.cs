using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class string_class_less
    {
        // lets learn some strings operation

        public void _newStrig()
        {
            string newOne = " First String ";
            string newTwo = " Two String";
            string newTree = " Two many words for comparing";
            string isNewTree = " ";

            if (newTree.Contains("many fuck"))
            {
                isNewTree = "many";

            }
            else
            {
                isNewTree = "there is no many there ";
            }

            Console.WriteLine(@"D/adada/asasa/asas "" ! #$%^"); // doslownaja stroka
            Console.WriteLine("The Length of the newOne is: {0}", newOne.Length);
            Console.WriteLine("Insert newOne to newTwo is: {0}", newTwo.Insert(11, newOne));
            Console.WriteLine("Lets PadLeft  newTree : {0}", newTree.PadLeft(10));
            Console.WriteLine("Is newTreee contains what are we looking for ? : {0} so it contain  {1}", newTree.Contains("many foll"), isNewTree);



        }



        public void _newSecondStrig()
        {
            string forTest = "We will add this to ";
            string forTest1 = " that ";
            string concat_1 = String.Concat(forTest, forTest1);
            Console.WriteLine("{0}", concat_1);



        }



    }
}
