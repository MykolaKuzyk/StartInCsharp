using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyStartCsharp
{
    class SBuilder
    {
        public void _buildString()
        {
            Console.WriteLine("=> Using the StringBuilder");
            StringBuilder sb = new StringBuilder("**** New builder *****");
            sb.Append("\n");
            sb.AppendLine(" Added new Line ");
            sb.AppendLine(" Addednew second Line " + "85");
            Console.WriteLine("{0}", sb.ToString());
            sb.Replace("85", "Repleced worrd ");
            Console.WriteLine("{0} and lenght is {1}", sb.ToString(), sb.Length);



        }
    }
}
