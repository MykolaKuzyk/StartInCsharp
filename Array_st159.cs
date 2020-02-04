using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class Array_st159
    {
        public void _newArray()
        {
            Console.WriteLine("");
            Console.WriteLine(" **** START Array_st159 method _newArray **** ");
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969,3,24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                Console.WriteLine("Information about type: {0} \n Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine(" **** END Array_st159 method _newArray **** ");
            Console.WriteLine("");
        }
        public void _newMultiArray()
        {
            Console.WriteLine("");
            Console.WriteLine(" **** START Array_st159 method _newMultiArray **** ");
            int[,] myMatrix;
            myMatrix = new int[6, 6];
            // fill Array
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    myMatrix[i, j] = i * j;
            // Pop up Array
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <6; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine(" **** END Array_st159 method _newMultiArray **** ");
            Console.WriteLine("");
        }
        public void _newJaggedMultiDimensionalArrey()
        {
            Console.WriteLine("");
            Console.WriteLine(" **** START Array_st159 method _newJaggedMultiDimensionalArrey **** ");
            int[][] myJagArray = new int[5][];
            for (int i = 0; i < myJagArray.Length; i++)
            
                myJagArray[i] = new int[i + 7];
            
            for (int i = 0; i < 5; i++)
            
                {
                    for (int j = 0; j < myJagArray[i].Length; j++)
                        Console.Write(myJagArray[i][j] + " ");
                    Console.WriteLine();
                }
            
            Console.WriteLine();                
            Console.WriteLine(" **** END Array_st159 method _newJaggedMultiDimensionalArrey **** ");
            Console.WriteLine("");

        }
    }
}
