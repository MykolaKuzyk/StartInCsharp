using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class Types_With_Ref_Teypes_st173
    {
        public void _newTypeWithRefTest()
        {
            Console.WriteLine();
            Console.WriteLine(" **** START work with _newTypeWithRefTest **** ");
            Console.WriteLine("Create  R1");
            Rectangle r1 = new Rectangle("First react", 10,10,50,50);
            Console.WriteLine("Assign new R2 to R1");
            Rectangle r2 = r1;
            Console.WriteLine("R1 was changed");
            r1.rectInfo.infoString = "Changed value of r1";
            r1.rectLeft = 66666;
            Console.WriteLine("Values After change");
            r1.Display();
            r2.Display();

            Console.WriteLine(" **** END work with _newTypeWithRefTest **** ");
            Console.WriteLine();



        }

        public string infoString;
        public Types_With_Ref_Teypes_st173(string info)
        {
            infoString = info;
        }
    }
    struct Rectangle
    {
        public Types_With_Ref_Teypes_st173 rectInfo;
        public int rectTop, rectLeft, rectBottom, rectRight;
        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new Types_With_Ref_Teypes_st173(info);
            rectTop = top;
            rectRight = right;
            rectBottom = bottom;
            rectLeft = left;
        }

        public void Display()
        {
            Console.WriteLine("String = {0}, TOP = {1}, Bottom = {2}," + "Left = {3} , Right = {4}", 
                rectInfo.infoString, 
                rectTop, 
                rectBottom, 
                rectLeft, 
                rectRight);
        }
    }


   
}
